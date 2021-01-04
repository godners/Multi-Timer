Module DataOpr
    Private ReadOnly CacheFile As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\MTcache.xml"
    Friend ReadOnly dtInit As New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0)
    Friend Sub InitData()
        Call InitDttConfig()
        Call InitDttStatus()
    End Sub
    Friend Sub FlushGlobalStatus()
        Dim gConfiged As Boolean = False
        Dim gEnabled As Boolean = False
        Dim gDisabled As Boolean = False
        For Each dr As DataRow In WinMain.DtsMain.Tables("DttStatus").Rows
            Select Case dr.Item("DtcStatus")
                Case Status.Configed
                    gConfiged = True
                    gDisabled = True
                Case Status.Enabled, Status.Alarming, Status.Acted
                    gConfiged = True
                    gEnabled = True
                Case Else
            End Select
        Next
        With WinMain
            .GlobalConfiged = gConfiged And .Inited
            .GlobalDisabled = gDisabled And .Inited
            .GlobalEnabled = gEnabled And .Inited
        End With
    End Sub
    Private Sub InitDttConfig()
        WinMain.DtsMain.Tables("DttConfig").Clear()
        Dim i As Byte
        For i = 0 To 15 Step 1
            WinMain.DtsMain.Tables("DttConfig").Rows.Add(EmptyConfig(i))
        Next
        WinMain.DtsMain.Tables("DttConfig").AcceptChanges()
    End Sub
    Private Function EmptyConfig(inpID As Byte) As DataRow
        Dim dr As DataRow = WinMain.DtsMain.Tables("DttConfig").NewRow
        dr.Item("DtcIDc") = inpID
        dr.Item("DtcValueInteval") = New TimeSpan(0)
        dr.Item("DtcValueTime") = dtInit
        dr.Item("DtcAsInteval") = False
        dr.Item("DtcTag") = inpID.ToString("X").ToCharArray()(0)
        dr.Item("DtcEnable") = False
        dr.Item("DtcConfiged") = False
        Return dr
    End Function
    Private Sub InitDttStatus()
        WinMain.DtsMain.Tables("DttStatus").Clear()
        Dim i As Byte
        Dim DtrNew As DataRow
        For i = 0 To 15 Step 1
            DtrNew = WinMain.DtsMain.Tables("DttStatus").NewRow
            DtrNew.Item("DtcIDs") = i
            DtrNew.Item("DtcStatus") = Status.Empty
            DtrNew.Item("DtcSpan") = New TimeSpan(0)
            WinMain.DtsMain.Tables("DttStatus").Rows.Add(DtrNew)
        Next
        WinMain.DtsMain.Tables("DttStatus").AcceptChanges()
    End Sub
    Friend Sub LoadXML(fn As String)
        Dim dtn, dts As DateTime
        If Not IO.File.Exists(CacheFile) Then IO.File.Delete(CacheFile)
        With WinMain.DtsMain.Tables("DttConfig")
            .WriteXml(CacheFile, XmlWriteMode.IgnoreSchema)
            Try
                .Clear()
                .ReadXml(WinMain.OfdMain.FileName)
                .AcceptChanges()
                For Each dr As DataRow In .Rows
                    dts = dr.Item("DtcValueTime")
                    dtn = dtInit.AddHours(dts.Hour).AddMinutes(dts.Minute).AddSeconds(dts.Second)
                    dr.Item("DtcValueTime") = dtn
                Next
                .AcceptChanges()
                Call FlushDttStatus()
                Call FlushGlobalStatus()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Load Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                .ReadXml(fn)
            End Try
        End With
    End Sub
    Friend Sub SaveXML(fn As String)
        WinMain.DtsMain.Tables("DttConfig").WriteXml(fn, XmlWriteMode.IgnoreSchema)
    End Sub
    Friend Sub FlushDttStatus()
        Dim ts As TimeSpan
        Dim drStatus As DataRow
        For Each dr As DataRow In WinMain.DtsMain.Tables("DttConfig").Rows
            drStatus = WinMain.DtsMain.Tables("DttStatus").Select("DtcIDs=" & dr.Item("DtcIDc").ToString)(0)
            If dr.Item("DtcConfiged") Then
                If dr.Item("DtcEnable") Then
                    ts = GetAlarmSpan(dr.Item("DtcValueTime"))
                    drStatus.Item("DtcSpan") = ts
                    drStatus.Item("DtcStatus") = GetAlarmStatus(ts)
                Else
                    drStatus.Item("DtcStatus") = Status.Configed
                    drStatus.Item("DtcSpan") = New TimeSpan(0)
                End If
            Else
                drStatus.Item("DtcStatus") = Status.Empty
                drStatus.Item("DtcSpan") = New TimeSpan(0)
            End If
        Next
        WinMain.DtsMain.Tables("DttStatus").AcceptChanges()
    End Sub
    Private Function GetAlarmStatus(ts As TimeSpan) As Status
        If ts >= My.Settings.tsAlarming Then Return 3
        If ts >= My.Settings.tsActed Then Return 4
        Return 2
    End Function
    Private Function GetAlarmSpan(dt As DateTime) As TimeSpan
        Dim ts As TimeSpan = dt - WinMain.GlobalNow
        Return If(ts >= New TimeSpan(0), ts, ts.Add(New TimeSpan(1, 0, 0, 0)))
    End Function
    Friend Enum Status
        Empty = 0 'Not Configed
        Configed = 1 'Not Enabled
        Enabled = 2
        Alarming = 3
        Acted = 4
    End Enum
    Friend Sub SetAlarm(inpID As Byte, ai As Boolean, h As Decimal, m As Decimal, s As Decimal)
        Dim dr As DataRow = WinMain.DtsMain.Tables("DttConfig").NewRow
        dr.Item("DtcIDc") = inpID
        If ai Then
            dr.Item("DtcValueInteval") = New TimeSpan(h, m, s)
            dr.Item("DtcValueTime") = dtInit
            dr.Item("DtcAsInteval") = True
        Else
            dr.Item("DtcValueInteval") = New TimeSpan(0)
            dr.Item("DtcValueTime") = dtInit.AddHours(h).AddMinutes(m).AddSeconds(s)
            dr.Item("DtcAsInteval") = False
        End If
        dr.Item("DtcConfiged") = True
        dr.Item("DtcEnable") = False
        dr.Item("DtcTag") = inpID.ToString("X").ToCharArray()(0)
        WinMain.DtsMain.Tables("DttConfig").Select("DtcIDc=" & inpID.ToString)(0).Delete()
        WinMain.DtsMain.Tables("DttConfig").Rows.Add(dr)
        WinMain.DtsMain.Tables("DttConfig").AcceptChanges()
    End Sub
    Friend Sub ClearAlarm(inpID As Byte)
        WinMain.DtsMain.Tables("DttConfig").Select("DtcIDc=" & inpID.ToString)(0).Delete()
        WinMain.DtsMain.Tables("DttConfig").Rows.Add(EmptyConfig(inpID))
        WinMain.DtsMain.Tables("DttConfig").AcceptChanges()
    End Sub
    Friend Sub AlarmOn(inpID As Byte, en As Boolean)
        Dim ai As Boolean
        With WinMain.DtsMain.Tables("DttConfig").Select("DtcIDc=" & inpID.ToString)(0)
            ai = .Item("DtcAsInteval")
            If en And ai Then
                .Item("DtcValueTime") = WinMain.GlobalNow.Add(.Item("DtcValueInteval"))
            End If
            .Item("DtcEnable") = en
            .AcceptChanges()
        End With
    End Sub
    Friend Sub AllOnOff(en As Boolean)
        For Each dr As DataRow In WinMain.DtsMain.Tables("DttConfig").Rows
            If dr.Item("DtcConfiged") And (dr.Item("DtcEnable") <> en) Then
                Call AlarmOn(dr.Item("DtcIDc"), en)
            End If
        Next
    End Sub
    Friend Function GetTipString(inpID As Byte) As String
        Dim dr As DataRow = WinMain.DtsMain.Tables("DttConfig").Select("DtcIDc=" & inpID.ToString)(0)
        If dr.Item("DtcConfiged") = Status.Empty Then Return Nothing
        If dr.Item("DtcAsInteval") Then
            Dim ts As TimeSpan = dr.Item("DtcValueInteval")
            Return "Alarm " & inpID.ToString & ": Inteval " & ts.ToString("c")
        Else
            Dim dt As DateTime = dr.Item("DtcValueTime")
            Return "Alarm " & inpID.ToString & ": Time " & dt.ToString("HH:mm:ss")
        End If
    End Function
End Module
