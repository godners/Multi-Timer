Module ThemeNotify
    Friend Sub GraphNotify()
        For Each dr As DataRow In WinMain.DtsMain.Tables("DttConfig").Rows
            Call GraphAlarmNotify(dr.Item("DtcIDc"), dr.Item("DtcTag"))
        Next
    End Sub
    Friend Sub FlushNotify()
        With WinMain.DtsMain
            For Each dr As DataRow In .Tables("DttStatus").Rows
                Call FlushAlarmNotify(dr.Item("DtcIDs"), dr.Item("DtcStatus"),
                        .Tables("DttConfig").Select("DtcIDc=" & dr.Item("DtcIDs").ToString)(0).Item("DtcValueTime"))
            Next
        End With
    End Sub
    Private Sub GraphAlarmNotify(inpID As Byte, t As Char)
        WinMain.NtiAlarm(inpID) = New NotifyIcon With {
            .BalloonTipIcon = ToolTipIcon.Info,
            .BalloonTipTitle = "Timer " & t.ToString & " Alarming.",
            .Icon = My.Resources.Alarm,
            .Visible = False
        }
    End Sub
    Private Sub FlushAlarmNotify(inpID As Byte, s As Byte, dt As DateTime)
        With WinMain.NtiAlarm(inpID)
            If s = DataOpr.Status.Alarming Then
                If Not .Visible Then
                    .BalloonTipText = "Alarming on " & dt.ToString("HH:mm:ss")
                    .Visible = True
                    .ShowBalloonTip((New TimeSpan(1, 0, 0, 0) - My.Settings.tsAlarming).TotalMilliseconds)
                End If
            Else
                .Visible = False
                .BalloonTipText = Nothing
            End If
        End With
    End Sub
End Module
