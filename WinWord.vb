Public Class WinWord
    Friend LblID(15) As Label
    Private Sub WinWord_Load() Handles MyBase.Load
        Call ThemeWord.InitControl()
        Call LabelHandler()
    End Sub
    Private Sub WinWord_Shown() Handles Me.Shown
        LblNow.Text = ThemeWord.TinyTimeString(WinMain.GlobalNow)
        Call ThemeWord.FlushControl()
    End Sub
    Private Sub WinWord_Closed() Handles Me.Closed
        If WinMain.WinStyle = ThemeMain.WinStyle.Word Then BtnRichClock.PerformClick()
    End Sub
    Private Sub BtnAuthor_Click() Handles BtnAuthor.Click
        WinAuthor.Location = ThemeMain.WinLocation(Me, WinAuthor)
        Me.Enabled = False
        WinAuthor.Show()
    End Sub
    Private Sub BtnRichClock_Click() Handles BtnRichClock.Click
        WinMain.WinStyle = ThemeMain.WinStyle.Rich
        WinMain.Location = ThemeMain.WinLocation(Me, WinMain)
        Me.Hide()
        WinMain.Show()
    End Sub
    Private Sub BtnTinyClock_Click() Handles BtnTinyClock.Click
        WinMain.WinStyle = ThemeMain.WinStyle.Tiny
        WinTiny.Location = ThemeMain.WinLocation(Me, WinTiny)
        Me.Hide()
        WinTiny.Show()
    End Sub
    Private Sub LabelHandler()
        Dim i As Byte
        For i = 0 To 15 Step 1
            AddHandler LblID(i).Click, AddressOf LblID_Click
            AddHandler LblID(i).DoubleClick, AddressOf LblID_Click
        Next
    End Sub
    Private Sub LblID_Click(ByVal sender As Label, ByVal e As EventArgs)
        WinSet.SettingID = Convert.ToByte(sender.Tag)
        WinSet.Location = ThemeMain.WinLocation(Me, WinSet)
        Me.Enabled = False
        WinSet.Show()
    End Sub

End Class