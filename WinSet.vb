Public Class WinSet
    Friend SettingID As Byte
    Private dr As DataRow
    Private Sub WinSet_Shown() Handles Me.Shown
        Me.Text = WinTitleString()
        Call TransforConfig()
        Call InitControl()
        NudHour.Focus()
    End Sub
    Private Sub InitControl()
        If dr.Item("DtcConfiged") Then Call InitConfig() Else Call InitDefault()
    End Sub
    Private Sub InitDefault()
        RdbTime.Checked = True
        NudHour.Value = 0
        NudMinute.Value = 0
        NudSecond.Value = 0
        BtnON.Text = "&ON"
        BtnClear.Enabled = False
        BtnON.Tag = True.ToString
    End Sub
    Private Sub InitConfig()
        If dr.Item("DtcAsInteval") Then
            RdbInteval.Checked = True
            Dim ts As TimeSpan = dr.Item("DtcValueInteval")
            NudHour.Value = ts.Hours
            NudMinute.Value = ts.Minutes
            NudSecond.Value = ts.Seconds
        Else
            RdbTime.Checked = True
            Dim dt As DateTime = dr.Item("DtcValueTime")
            NudHour.Value = dt.Hour
            NudMinute.Value = dt.Minute
            NudSecond.Value = dt.Second
        End If
        BtnON.Text = If(dr.Item("DtcEnable"), "&OFF", "&ON")
        BtnClear.Enabled = True
    End Sub
    Private Sub TransforConfig()
        dr = WinMain.DtsMain.Tables("DttConfig").Select("DtcIDc=" & SettingID.ToString)(0)
    End Sub
    Private Function WinTitleString() As String
        Return "Alarm " & SettingID.ToString("X") & " - Multi Timer"
    End Function
    Private Sub NudHour_GotFocus(sender As NumericUpDown, e As EventArgs) Handles _
        NudHour.GotFocus, NudMinute.GotFocus, NudSecond.GotFocus
        sender.Select(0, sender.Value.ToString.Length)
    End Sub
    Private Sub WinSet_KeyDown(sender As Object, e As KeyEventArgs) Handles _
        Me.KeyDown, RdbTime.KeyDown, RdbInteval.KeyDown, NudHour.KeyDown, NudMinute.KeyDown, NudSecond.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.Enter
                If dr.Item("DtcEnable") Then BtnSet.PerformClick() Else BtnON.PerformClick()
        End Select
    End Sub
    Private Sub WinSet_Closed() Handles Me.Closed
        Call ThemeMain.WinClockShow(WinMain.WinStyle)
    End Sub
    Private Sub BtnON_Click() Handles BtnON.Click
        Dim en As Boolean = Not dr.Item("DtcEnable")
        Call DataOpr.SetAlarm(SettingID, RdbInteval.Checked, NudHour.Value, NudMinute.Value, NudSecond.Value)
        Call DataOpr.AlarmOn(SettingID, en)
        Call WinMain.FlushAll()
        Me.Close()
    End Sub
    Private Sub BtnSet_Click() Handles BtnSet.Click
        Dim en As Boolean = dr.Item("DtcEnable")
        Call DataOpr.SetAlarm(SettingID, RdbInteval.Checked, NudHour.Value, NudMinute.Value, NudSecond.Value)
        Call DataOpr.AlarmOn(SettingID, en)
        Call WinMain.FlushAll()
        Me.Close()
    End Sub
    Private Sub BtnClear_Click() Handles BtnClear.Click
        Call DataOpr.ClearAlarm(SettingID)
        Call WinMain.FlushAll()
        Me.Close()
    End Sub
End Class