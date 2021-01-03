Module ThemeMain
    Friend Function FullTimeString(inp As DateTime) As String
        Return inp.ToString("yyyy-MM-dd HH:mm:ss.fff dddd", Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    End Function
    Friend Function AdjustString(inp As Int32) As String
        Return "Adjusting Time: " & inp.ToString("D3") & " ms..."
    End Function
    Friend Sub InitControls()
        Call GraphControl()
        Call FlushControl()
    End Sub
    Private Sub FlushControl()
        WinMain.LblNow.Text = FullTimeString(WinMain.GlobalNow)
        Dim i, st As Byte
        Dim t As Char
        Dim a As DateTime
        Dim tss, tsc As TimeSpan
        Dim e, c, ai As Boolean
        Dim drStatus As DataRow
        For Each dr As DataRow In WinMain.DtsMain.Tables("DttConfig").Rows
            i = dr.Item("DtcIDc")
            Call FlushSetButton(i)
            e = dr.Item("DtcEnable") And WinMain.Inited
            t = dr.Item("DtcTag")
            c = dr.Item("DtcConfiged") And WinMain.Inited
            Call FlushClearButton(i, c)
            Call FlushOnButton(i, c, e)
            drStatus = WinMain.DtsMain.Tables("DttStatus").Select("DtcIDs=" & i.ToString)(0)
            st = drStatus.Item("DtcStatus")
            Call FlushIDLabel(i, t, st)
            ai = dr.Item("DtcAsInteval")
            a = dr.Item("DtcValueTime")

            Call FlushAlarmLabel(i, a, st, ai)
            tss = drStatus.Item("DtcSpan")
            tsc = dr.Item("DtcValueInteval")
            Call FlushSpanLabel(i, tss, tsc, st, ai)
        Next
    End Sub
    Private Sub GraphControl()
        Dim i As Byte
        For Each dr As DataRow In WinMain.DtsMain.Tables("DttConfig").Rows
            i = dr.Item("DtcIDc")
            Call GraphIDLabel(i)
            Call GraphAlarmLabel(i)
            Call GraphSpanLabel(i)
            Call GraphSetButton(i)
            Call FlushSetButton(i)
            Call GraphOnButton(i)
            Call GraphClearButton(i)
        Next
    End Sub
    Private Sub GraphClearButton(inpID As Byte)
        WinMain.BtnClear(inpID) = New Button With {
            .Size = New Size(63, 27),
            .Location = GetLocation(inpID, ShiftX.BtnClear, False),
            .TabIndex = inpID * 3 + 2,
            .Enabled = False,
            .Tag = inpID.ToString
        }
        WinMain.Controls.Add(WinMain.BtnClear(inpID))
        WinMain.BtnClear(inpID).Show()
    End Sub
    Private Sub FlushClearButton(inpid As Byte, se As Boolean)
        WinMain.BtnClear(inpid).Enabled = se
        WinMain.BtnClear(inpid).Text = "CLEAR"
    End Sub
    Private Sub GraphOnButton(inpID As Byte)
        WinMain.BtnON(inpID) = New Button With {
            .Size = New Size(45, 27),
            .Location = GetLocation(inpID, ShiftX.BtnON, False),
            .TabIndex = inpID * 3 + 1,
            .Enabled = False,
            .Tag = inpID.ToString
        }
        WinMain.Controls.Add(WinMain.BtnON(inpID))
        WinMain.BtnON(inpID).Show()
    End Sub
    Private Sub FlushOnButton(inpID As Byte, se As Boolean, en As Boolean)
        WinMain.BtnON(inpID).Enabled = se
        WinMain.BtnON(inpID).Text = If(en, "OFF", "ON")
    End Sub
    Private Sub GraphSetButton(inpID As Byte)
        WinMain.BtnSet(inpID) = New Button With {
            .Size = New Size(45, 27),
            .Location = GetLocation(inpID, ShiftX.BtnSet, False),
            .TabIndex = inpID * 3,
            .Enabled = False,
            .Tag = inpID.ToString
        }
        WinMain.Controls.Add(WinMain.BtnSet(inpID))
        WinMain.BtnSet(inpID).Show()
    End Sub
    Private Sub FlushSetButton(inpID As Byte)
        WinMain.BtnSet(inpID).Enabled = WinMain.Inited
        WinMain.BtnSet(inpID).Text = "SET"
    End Sub
    Private Sub GraphSpanLabel(inpID As Byte)
        WinMain.LblSpan(inpID) = New Label With {
            .Size = New Size(81, 19),
            .Location = GetLocation(inpID, ShiftX.LblSpan, True)
        }
        WinMain.Controls.Add(WinMain.LblSpan(inpID))
        WinMain.LblSpan(inpID).Show()
    End Sub
    Private Sub FlushSpanLabel(inpID As Byte, tss As TimeSpan, tsc As TimeSpan, st As Byte, ai As Boolean)
        With WinMain.LblSpan(inpID)
            Select Case st
                Case DataOpr.Status.Empty
                    .Text = My.Settings.EmptyTimeString
                Case DataOpr.Status.Configed
                    .Text = If(ai, tsc.ToString("c"), My.Settings.EmptyTimeString)
                Case Else
                    .Text = tss.ToString("c")
            End Select
            .ForeColor = GetMColor(st)
        End With
    End Sub
    Private Sub GraphIDLabel(inpID As Byte)
        WinMain.LblID(inpID) = New Label With {
            .Size = My.Settings.sizeSingleWord,
            .Location = GetLocation(inpID, ShiftX.LblID, True)
        }
        WinMain.Controls.Add(WinMain.LblID(inpID))
        WinMain.LblID(inpID).Show()
    End Sub
    Private Sub FlushIDLabel(inpID As Byte, t As Char, st As Byte)
        WinMain.LblID(inpID).Text = t.ToString
        WinMain.LblID(inpID).ForeColor = GetMColor(st)
    End Sub
    Private Sub GraphAlarmLabel(inpID As Byte)
        WinMain.LblAlarm(inpID) = New Label With {
            .Size = New Size(81, 19),
            .Location = GetLocation(inpID, ShiftX.LblAlarm, True)
        }
        WinMain.Controls.Add(WinMain.LblAlarm(inpID))
        WinMain.LblAlarm(inpID).Show()
    End Sub
    Private Sub FlushAlarmLabel(inpID As Byte, dt As DateTime, st As Byte, ai As Boolean)
        With WinMain.LblAlarm(inpID)
            Select Case st
                Case DataOpr.Status.Empty
                    .Text = My.Settings.EmptyTimeString
                Case DataOpr.Status.Configed
                    .Text = If(ai, My.Settings.EmptyTimeString, dt.ToString("HH:mm:ss"))
                Case Else
                    .Text = dt.ToString("HH:mm:ss")
            End Select
            .ForeColor = GetMColor(st)
        End With
    End Sub
    Private Function GetLocation(inpID As Byte, ShiftX As Int32, isLabel As Boolean) As Point
        Return New Point(If(inpID < 8, 16, 397) + ShiftX, 85 + If(isLabel, 4, 0) + (inpID Mod 8) * 35)
    End Function
    Private Enum ShiftX
        LblID = 0
        LblAlarm = 26
        LblSpan = 115
        BtnSet = 204
        BtnON = 257
        BtnClear = 310
    End Enum
    Friend Function GetMColor(st As Byte) As Color
        Select Case st
            Case DataOpr.Status.Alarming
                Return Color.Red
            Case DataOpr.Status.Acted
                Return Color.Green
            Case DataOpr.Status.Enabled
                Return Color.Black
            Case Else
                Return Color.Gray
        End Select
    End Function
    Friend Function WinLocation(winFrom As Form, winTo As Form) As Point
        Return New Point(winFrom.Location.X + (winFrom.Size.Width - winTo.Size.Width) / 2,
                         winFrom.Location.Y + (winFrom.Size.Height - winTo.Size.Height) / 2)
    End Function
    Friend Sub FlushGlobalButton()
        With WinMain
            .BtnWordClock.Enabled = .Inited
            .BtnTinyClock.Enabled = .Inited
            .BtnLoad.Enabled = .Inited
            .BtnSave.Enabled = .Inited
            .BtnAllOn.Enabled = .GlobalDisabled
            .BtnAllOff.Enabled = .GlobalEnabled
            .BtnAllClear.Enabled = .GlobalConfiged
        End With
    End Sub
    Friend Enum WinStyle
        Hide = 0
        Rich = 1
        Tiny = 2
        Word = 3
    End Enum
    Friend Sub WinClockShow(ws As WinStyle)
        Select Case ws
            Case WinStyle.Hide
            Case WinStyle.Rich
                WinMain.Enabled = True
            Case WinStyle.Tiny
                WinTiny.Enabled = True
            Case WinStyle.Word
                WinWord.Enabled = True
            Case Else
                WinMain.Enabled = True
        End Select
    End Sub
    Friend Sub FlushWinClock(ws As WinStyle)
        Select Case ws
            Case WinStyle.Hide
            Case WinStyle.Rich
                Call ThemeMain.FlushControl()
                Call ThemeMain.FlushGlobalButton()
            Case WinStyle.Tiny
                Call ThemeTiny.FlushControl()
            Case WinStyle.Word
                Call ThemeWord.FlushControl()
            Case Else
                Call ThemeMain.FlushControl()
                Call ThemeMain.FlushGlobalButton()
        End Select
    End Sub

End Module
