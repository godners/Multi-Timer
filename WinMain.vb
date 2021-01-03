Public Class WinMain
    'Private ReadOnly AdjustAccuracy As Int32 = 15
    Private ReadOnly MyPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    Public Inited As Boolean = False
    Public GlobalNow As DateTime = Now()
    Public WinStyle As Byte = ThemeMain.WinStyle.Rich
    Friend LblID(15), LblAlarm(15), LblSpan(15) As Label
    Friend BtnSet(15), BtnON(15), BtnClear(15) As Button
    Friend GlobalConfiged As Boolean = False
    Friend GlobalEnabled As Boolean = False
    Friend GlobalDisabled As Boolean = False
    Friend NtiAlarm(15) As NotifyIcon
    Private Sub BtnSave_Click() Handles BtnSave.Click
        SfdMain.ShowDialog()
        DataOpr.SaveXML(SfdMain.FileName)
    End Sub
    Private Sub BtnLoad_Click() Handles BtnLoad.Click
        OfdMain.ShowDialog()
        If Not IO.File.Exists(OfdMain.FileName) Then Exit Sub
        Call DataOpr.LoadXML(OfdMain.FileName)
    End Sub
    Private Sub WinMain_Load() Handles MyBase.Load
        LblNow.Text = ThemeMain.AdjustString(Now.Millisecond)
        SfdMain.InitialDirectory = MyPath
        OfdMain.InitialDirectory = MyPath
        Call DataOpr.InitData()
        Call ThemeMain.InitControls()
        Call ThemeNotify.GraphNotify()
        Call ClickHandler()
        TmrInit.Enabled = True
    End Sub
    Private Sub TmrInit_Tick() Handles TmrInit.Tick
        Dim TimeDiff As Int32 = Now.Millisecond
        LblNow.Text = ThemeMain.AdjustString(TimeDiff)
        If TimeDiff > My.Settings.AdjustAccuracy Then Exit Sub
        TmrInit.Enabled = False
        Inited = True
        Call FlushAll()
        LblNow.Text = ThemeMain.FullTimeString(Now())
        TmrMain.Enabled = True
    End Sub
    Private Sub TmrMain_Tick() Handles TmrMain.Tick
        GlobalNow = Now()
        Call FlushAll()
    End Sub
    Private Sub ClickHandler()
        Dim i As Byte
        For i = 0 To 15 Step 1
            AddHandler BtnSet(i).Click, AddressOf BtnSet_Click
            AddHandler BtnClear(i).Click, AddressOf BtnClear_Click
            AddHandler BtnON(i).Click, AddressOf BtnON_Cleck
        Next
    End Sub
    Private Sub BtnAuthor_Click() Handles BtnAuthor.Click
        WinAuthor.Location = ThemeMain.WinLocation(Me, WinAuthor)
        Me.Enabled = False
        WinAuthor.Show()
    End Sub
    Private Sub BtnWordClock_Click() Handles BtnWordClock.Click
        WinStyle = ThemeMain.WinStyle.Word
        WinWord.Location = ThemeMain.WinLocation(Me, WinWord)
        Me.Hide()
        WinWord.Show()
    End Sub
    Private Sub BtnTinyClock_Click() Handles BtnTinyClock.Click
        WinStyle = ThemeMain.WinStyle.Tiny
        WinTiny.Location = ThemeMain.WinLocation(Me, WinTiny)
        Me.Hide()
        WinTiny.Show()
    End Sub
    Private Sub BtnAllOnOff_Click(sender As Button, e As EventArgs) Handles _
        BtnAllOn.Click, BtnAllOff.Click
        Call DataOpr.AllOnOff(Convert.ToBoolean(sender.Tag))
        Call FlushAll()
    End Sub
    Private Sub BtnAllClear_Click() Handles BtnAllClear.Click
        Call DataOpr.InitData()
        Call FlushAll()
    End Sub
    Private Sub BtnON_Cleck(ByVal sender As Button, ByVal e As EventArgs)
        Dim en As Boolean = Not DtsMain.Tables("DttConfig").Select("DtcIDc=" & sender.Tag)(0).Item("DtcEnable")
        Call DataOpr.AlarmOn(Convert.ToByte(sender.Tag), en)
        Call FlushAll()
    End Sub
    Private Sub NtiMain_Click() Handles NtiMain.Click, NtiMain.DoubleClick
        WinStyle = ThemeMain.WinStyle.Rich
        Me.ShowInTaskbar = True
        NtiMain.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub BtnClear_Click(ByVal sender As Button, ByVal e As EventArgs)
        Call DataOpr.ClearAlarm(Convert.ToByte(sender.Tag))
        Call FlushAll()
    End Sub
    Friend Sub BtnSet_Click(ByVal sender As Button, ByVal e As EventArgs)
        WinSet.SettingID = Convert.ToByte(sender.Tag)
        WinSet.Location = ThemeMain.WinLocation(Me, WinSet)
        Me.Enabled = False
        WinSet.Show()
    End Sub
    Friend Sub FlushAll()
        Call DataOpr.FlushDttStatus()
        Call DataOpr.FlushGlobalStatus()
        Call ThemeNotify.FlushNotify()
        Call ThemeMain.FlushWinClock(WinStyle)
    End Sub
    Private Sub WinMain_Resize() Handles Me.Resize
        If Not Inited Then Exit Sub
        If Me.WindowState <> FormWindowState.Minimized Then Exit Sub
        WinStyle = ThemeMain.WinStyle.Hide
        NtiMain.Visible = True
        Me.ShowInTaskbar = False
        Me.Hide()
    End Sub
End Class
