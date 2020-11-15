Public Class WinSet
    Public ID As Byte
    Public dtShow As DateTime
    Private Sub WinSet_Shown(sender As Form, e As EventArgs) Handles Me.Shown
        Me.Text = "Set " & ID.ToString("X") & " - Multi Timer"
        lblShown.Text = "Shown Time: " & dtShow.ToString("HH:mm:ss")
        btnClr.Enabled = WinMain.setAlarm(ID)
        If WinMain.setAlarm(ID) Then
            If WinMain.intAlarm(ID) Then
                rdoInt.Checked = True
                TxtH.Text = WinMain.spanAlarm(ID).Hours.ToString.PadLeft(2, "0")
                TxtM.Text = WinMain.spanAlarm(ID).Minutes.ToString.PadLeft(2, "0")
                TxtS.Text = WinMain.spanAlarm(ID).Seconds.ToString.PadLeft(2, "0")
            Else
                rdoTime.Checked = True
                TxtH.Text = WinMain.dtAlarm(ID).Hour.ToString.PadLeft(2, "0")
                TxtM.Text = WinMain.dtAlarm(ID).Minute.ToString.PadLeft(2, "0")
                TxtS.Text = WinMain.dtAlarm(ID).Second.ToString.PadLeft(2, "0")
            End If
        Else
            rdoTime.Checked = True
            TxtH.Text = dtShow.Hour.ToString.PadLeft(2, "0")
            TxtM.Text = dtShow.Minute.ToString.PadLeft(2, "0")
            TxtS.Text = dtShow.Second.ToString.PadLeft(2, "0")
        End If
        TxtH.SelectAll()
    End Sub
    Private Sub TextBox_GotFocus(sender As TextBox, e As EventArgs) Handles _
            TxtH.GotFocus, TxtM.GotFocus, TxtS.GotFocus, TxtH.Click, TxtM.Click, TxtS.Click
        sender.SelectAll()
    End Sub
    Private Sub WinSet_Closed(sender As Form, e As EventArgs) Handles Me.Closed
        If WinMain.WinRich Then
            WinMain.Enabled = True
        Else
            WinTiny.Enabled = True
        End If
    End Sub
    Private Sub BtnSet_Click(sender As Button, e As EventArgs) Handles BtnSet.Click
        Call SetAlarm()
        Me.Close()
    End Sub
    Private Sub SetAlarm()
        Dim h As Byte = Convert.ToByte(TxtH.Text)
        Dim m As Byte = Convert.ToByte(TxtM.Text)
        Dim s As Byte = Convert.ToByte(TxtS.Text)
        If h < 0 Or h > 24 Then
            MessageBox.Show(TxtH.Text & " is NOT a hour value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtH.Focus()
            Exit Sub
        End If
        If m < 0 Or m > 60 Then
            MessageBox.Show(TxtM.Text & " is NOT a minute value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtH.Focus()
            Exit Sub
        End If
        If s < 0 Or s > 60 Then
            MessageBox.Show(TxtS.Text & " is NOT a second value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtH.Focus()
            Exit Sub
        End If
        WinMain.setAlarm(ID) = True
        WinMain.intAlarm(ID) = rdoInt.Checked
        If rdoInt.Checked Then
            Dim ts As New TimeSpan(h, m, s)
            WinMain.spanAlarm(ID) = ts
            WinMain.dtAlarm(ID) = dtShow + ts
        Else
            Dim dtAlarm As New DateTime(WinMain.dtNow.Year, WinMain.dtNow.Month, WinMain.dtNow.Day, h, m, s)
            If dtAlarm < WinMain.dtNow Then dtAlarm = dtAlarm.AddDays(1)
            WinMain.dtAlarm(ID) = dtAlarm
            WinMain.spanAlarm(ID) = dtAlarm - dtShow
        End If
    End Sub
    Private Sub BtnON_Click(sender As Button, e As EventArgs) Handles BtnON.Click
        Call SetAlarm()
        WinMain.enAlarm(ID) = True
        Me.Close()
    End Sub
    Private Sub btnClr_Click(sender As Button, e As EventArgs) Handles btnClr.Click
        WinMain.setAlarm(ID) = False
        WinMain.intAlarm(ID) = False
        WinMain.dtAlarm(ID) = Nothing
        WinMain.spanAlarm(ID) = Nothing
        Me.Close()
    End Sub

End Class