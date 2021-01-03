Public Class WinTiny
    Friend LblID(15), LblClock(11) As Label
    Friend gphClock As Graphics
    Friend penPin(2) As Pen
    Friend brsBlack, brsGray As SolidBrush
    Friend rtgDot, rtgEmpty As Rectangle
    Friend pntDot As Point
    Private Sub WinTiny_Load() Handles MyBase.Load
        gphClock = Me.CreateGraphics
        gphClock.Clip = New Region(New Rectangle(13, 13, 200, 200))
        gphClock.CompositingMode = Drawing2D.CompositingMode.SourceOver
        pntDot = New Point(113, 113)
        brsBlack = New SolidBrush(Me.ForeColor)
        brsGray = New SolidBrush(Me.BackColor)
        Call ThemeTiny.InitRadClock()
        rtgDot = SetRectangle(pntDot, rClock(ThemeTiny.RadType.Dot))
        rtgEmpty = SetRectangle(pntDot, rClock(ThemeTiny.RadType.Empty))
        Call ThemeTiny.InitClock()
        Call ThemeTiny.InitControl()
        Call LabelHandler()
    End Sub
    Private Sub WinTiny_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call ThemeTiny.FlushControl()
    End Sub
    Private Sub WinTiny_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If WinMain.WinStyle = ThemeMain.WinStyle.Tiny Then BtnRichClock.PerformClick()
    End Sub
    Private Sub BtnRichClock_Click() Handles BtnRichClock.Click
        WinMain.WinStyle = ThemeMain.WinStyle.Rich
        WinMain.Location = ThemeMain.WinLocation(Me, WinMain)
        Me.Hide()
        WinMain.Show()
    End Sub
    Private Sub BtnWordClock_Click() Handles BtnWordClock.Click
        WinMain.WinStyle = ThemeMain.WinStyle.Word
        WinWord.Location = ThemeMain.WinLocation(Me, WinWord)
        Me.Hide()
        WinWord.Show()
    End Sub
    Private Sub BtnAuthor_Click() Handles BtnAuthor.Click
        WinAuthor.Location = ThemeMain.WinLocation(Me, WinAuthor)
        Me.Enabled = False
        WinAuthor.Show()
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
    Private Function SetRectangle(d As Point, r As Double) As Rectangle
        Return New Rectangle(d.X - r, d.Y - r, r * 2, r * 2)
    End Function
End Class