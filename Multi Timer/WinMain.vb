Public Class WinMain
    Private lblAlarm(15), lblSpan(15), lblID(15) As Label
    Public btnSet(15) As Button
    Private btnON(15), btnClr(15) As Button
    Private ntiAlarm(15) As NotifyIcon
    Public enAlarm(15), setAlarm(15), intAlarm(15), onAlarm(15), WinRich As Boolean
    Public dtAlarm(15), dtNow As DateTime
    Public spanAlarm(15) As TimeSpan
    Public SpanRed, SpanGreen As TimeSpan
    Private Sub FlushSpan()
        Dim i As Byte
        For i = 0 To 15 Step 1
            If dtNow > dtAlarm(i) And dtNow - dtAlarm(i) < SpanRed Then
                If Not onAlarm(i) Then
                    ntiAlarm(i).BalloonTipText = "Alarming on " & dtAlarm(i).ToString("HH:mm:ss")
                    ntiAlarm(i).Visible = True
                    ntiAlarm(i).ShowBalloonTip(SpanRed.TotalMilliseconds)
                End If
                onAlarm(i) = True
            Else
                onAlarm(i) = False
                ntiAlarm(i).Visible = False
                ntiAlarm(i).BalloonTipText = Nothing
            End If
        Next
    End Sub
    Private Sub FlushLabel()
        Dim i As Byte
        For i = 0 To 15 Step 1
            If setAlarm(i) Then
                lblAlarm(i).Text = dtAlarm(i).ToString("HH:mm:ss")
                lblSpan(i).Text = (dtAlarm(i) - dtNow).ToString("hh\:mm\:ss")
                lblAlarm(i).ForeColor = Color.Black
                lblSpan(i).ForeColor = Color.Black
                If dtNow > dtAlarm(i) Then
                    If dtNow - dtAlarm(i) < SpanRed Then
                        lblAlarm(i).ForeColor = Color.Red
                        lblSpan(i).ForeColor = Color.Red
                    ElseIf dtNow - dtAlarm(i) < SpanGreen Then
                        lblAlarm(i).ForeColor = Color.Green
                        lblSpan(i).ForeColor = Color.Green
                    End If
                End If
            Else
                lblAlarm(i).Text = "00:00:00"
                lblSpan(i).Text = "00:00:00"
                lblAlarm(i).ForeColor = Color.Gray
                lblSpan(i).ForeColor = Color.Gray
            End If
        Next
    End Sub
    Private Sub FlushButton()
        Dim i As Byte
        Dim Oned, Offed, Seted As Boolean
        Oned = False
        Offed = False
        Seted = False
        For i = 0 To 15 Step 1
            btnClr(i).Enabled = setAlarm(i)
            btnON(i).Enabled = setAlarm(i)
            Seted = Seted Or setAlarm(i)
            btnON(i).Text = IIf(setAlarm(i) And enAlarm(i), "OFF", "ON")
            Oned = Oned Or (setAlarm(i) And enAlarm(i))
            Offed = Offed Or (setAlarm(i) And (Not enAlarm(i)))
        Next
        btnAllOFF.Enabled = Oned
        btnAllON.Enabled = Offed
        btnAllClr.Enabled = Seted
    End Sub
    Private Sub WinMain_Load(sender As Form, e As EventArgs) Handles MyBase.Load
        WinRich = True
        SpanRed = New TimeSpan(0, 1, 0)
        SpanGreen = New TimeSpan(1, 0, 0)
        Call GraphLabel()
        Call GraphButton()
        Call GraphNotifyIcon()
        Dim i As Byte
        For i = 0 To 15 Step 1
            enAlarm(i) = False
            setAlarm(i) = False
            intAlarm(i) = False
            onAlarm(i) = False
        Next
        tmrInit.Enabled = True
    End Sub
    Private Function ControlLocation(Init As Point, ID As Byte) As Point
        Return New Point(Init.X + 381 * (ID \ 8), Init.Y + 37 * (ID Mod 8))
    End Function
    Private Sub GraphNotifyIcon()
        For i = 0 To 15 Step 1
            ntiAlarm(i) = New NotifyIcon With {
                .BalloonTipIcon = ToolTipIcon.Info,
                .BalloonTipTitle = "Timer " & i.ToString("X") & " Alarming.",
                .Icon = My.Resources.Alarm,
                .Visible = False
            }
        Next
    End Sub
    Private Sub GraphButton()
        Dim szeS As New Size(45, 29)
        Dim lctSet As New Point(217, 58)
        Dim lctON As New Point(270, 58)
        Dim szeL As New Size(63, 29)
        Dim lctClr As New Point(323, 58)
        For i = 0 To 15 Step 1
            btnSet(i) = New Button With {
                .Size = szeS,
                .Location = ControlLocation(lctSet, i),
                .Text = "SET",
                .Tag = i,
                .TabIndex = i * 3,
                .Enabled = False
            }
            AddHandler btnSet(i).Click, AddressOf SetClick
            Me.Controls.Add(btnSet(i))
            btnSet(i).Show()
            btnON(i) = New Button With {
                .Size = szeS,
                .Location = ControlLocation(lctON, i),
                .Text = "ON",
                .Tag = i,
                .TabIndex = i * 3 + 1,
                .Enabled = False
            }
            AddHandler btnON(i).Click, AddressOf AlarmClick
            Me.Controls.Add(btnON(i))
            btnON(i).Show()
            btnClr(i) = New Button With {
                .Size = szeL,
                .Location = ControlLocation(lctClr, i),
                .Text = "CLEAR",
                .Tag = i,
                .TabIndex = i * 3 + 2,
                .Enabled = False
            }
            AddHandler btnClr(i).Click, AddressOf ClrClick
            Me.Controls.Add(btnClr(i))
            btnClr(i).Show()
        Next
    End Sub
    Private Sub btnAllOFF_Click(sender As Button, e As EventArgs) Handles btnAllOFF.Click
        Dim i As Byte
        For i = 0 To 15 Step 1
            If setAlarm(i) Then OffAlarm(i)
        Next
    End Sub
    Private Sub btnAllON_Click(sender As Button, e As EventArgs) Handles btnAllON.Click
        Dim i As Byte
        For i = 0 To 15 Step 1
            If setAlarm(i) Then
                enAlarm(i) = True
            End If
        Next
    End Sub
    Private Sub btnAllClr_Click(sender As Button, e As EventArgs) Handles btnAllClr.Click
        Dim i As Byte
        For i = 0 To 15 Step 1
            ClearAlarm(i)
        Next
    End Sub
    Private Sub GraphLabel()
        Dim szeID As New Size(18, 19)
        Dim lctID As New Point(13, 63)
        Dim szeSize As New Size(81, 19)
        Dim lctAlarm As New Point(39, 63)
        Dim lctSpan As New Point(128, 63)
        Dim i As Byte
        For i = 0 To 15 Step 1
            lblID(i) = New Label With {
                .Size = szeID,
                .Location = ControlLocation(lctID, i),
                .Text = i.ToString("X")
            }
            Me.Controls.Add(lblID(i))
            lblID(i).Show()
            lblAlarm(i) = New Label With {
                .Size = szeSize,
                .Location = ControlLocation(lctAlarm, i),
                .Text = "00:00:00",
                .ForeColor = Color.Gray
            }
            Me.Controls.Add(lblAlarm(i))
            lblAlarm(i).Show()
            lblSpan(i) = New Label With {
                .Size = szeSize,
                .Location = ControlLocation(lctSpan, i),
                .Text = "00:00:00",
                .ForeColor = Color.Gray
            }
            Me.Controls.Add(lblSpan(i))
            lblSpan(i).Show()
        Next
    End Sub
    Private Sub ntiMain_MouseDoubleClick(sender As NotifyIcon, e As MouseEventArgs) Handles ntiMain.DoubleClick, ntiMain.Click
        Me.ShowInTaskbar = True
        ntiMain.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub tmrInit_Tick(sender As Timer, e As EventArgs) Handles tmrInit.Tick
        Dim dt As DateTime = Now
        If dt.Millisecond < 5 Or dt.Millisecond > 994 Then
            tmrInit.Enabled = False
            TmrMain.Enabled = True
            btnTiny.Enabled = True
            btnTiny.Image = My.Resources.TinyEn
            For Each btn As Button In btnSet
                btn.Enabled = True
            Next
        End If
    End Sub
    Private Sub TmrMain_Tick(sender As Timer, e As EventArgs) Handles TmrMain.Tick
        dtNow = Now
        If WinRich Then
            lblNow.Text = NowString(dtNow)
            Call FlushButton()
            Call FlushLabel()
        Else
            WinTiny.LblNow.Text = NowString(dtNow)
            Call WinTiny.FlushLabel()
            Call WinTiny.FlushClock()
        End If
        Call FlushSpan()
    End Sub
    Private Sub AlarmClick(ByVal sender As Button, ByVal e As EventArgs)
        Dim ID As Byte = sender.Tag
        enAlarm(ID) = Not enAlarm(ID)
    End Sub
    Private Sub SetClick(ByVal sender As Button, ByVal e As EventArgs)
        Dim ID As Byte = sender.Tag
        WinSet.ID = ID
        WinSet.dtShow = dtNow
        WinSet.Location = New Point(Me.Location.X + (Me.Size.Width - WinSet.Size.Width) / 2,
                                    Me.Location.Y + (Me.Size.Height - WinSet.Height) / 2)
        Me.Enabled = False
        WinSet.Show()
    End Sub
    Private Sub ClrClick(ByVal sender As Button, ByVal e As EventArgs)
        Dim ID As Byte = sender.Tag
        ClearAlarm(ID)
    End Sub
    Private Sub WinMain_Resize(sender As Form, e As EventArgs) Handles Me.Resize
        If Not WinRich Then Exit Sub
        If Me.WindowState = FormWindowState.Minimized Then
            ntiMain.Visible = True
            Me.ShowInTaskbar = False
            Me.Hide()
        End If
    End Sub
    Private Sub ClearAlarm(ID As Byte)
        setAlarm(ID) = False
        intAlarm(ID) = False
        dtAlarm(ID) = Nothing
        spanAlarm(ID) = Nothing
        onAlarm(ID) = False
    End Sub
    Private Sub OffAlarm(ID As Byte)
        enAlarm(ID) = False
        onAlarm(ID) = False
    End Sub
    Private Sub btnTiny_Click(sender As Button, e As EventArgs) Handles btnTiny.Click
        WinRich = False
        WinTiny.LblNow.Text = NowString(dtNow)
        WinTiny.Location = New Point(Me.Location.X + (Me.Size.Width - WinTiny.Size.Width) / 2,
                                     Me.Location.Y + (Me.Size.Height - WinTiny.Height) / 2)
        Me.Enabled = False
        WinTiny.Show()
    End Sub
    Private Sub WinMain_Shown(sender As Form, e As EventArgs) Handles Me.Shown
        If TmrMain.Enabled Then
            lblNow.Text = NowString(dtNow)
            Call FlushButton()
            Call FlushLabel()
        End If
    End Sub
End Class
