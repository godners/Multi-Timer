Public Class WinTiny
    Private lblID(15) As Label
    Private lblWord(11) As Label
    Private rClock(3) As Double
    Private szeLbl As New Size(18, 19)
    Private penPin(2) As Pen
    Private gphClock As Graphics
    Private pntDot As Point
    Private rtgDot, rtgEmpty As Rectangle
    Private brsBlack, brsGray As SolidBrush
    Private Sub WinTiny_Closed(sender As Form, e As EventArgs) Handles Me.Closed
        WinMain.WinRich = True
        WinMain.Show()
        WinMain.Enabled = True
    End Sub
    Private Sub WinTiny_Shown(sender As Form, e As EventArgs) Handles Me.Shown
        WinMain.Hide()
        Call FlushLabel()
        Call FlushClock()
    End Sub
    Private Sub WinTiny_Load(sender As Form, e As EventArgs) Handles MyBase.Load
        rClock(0) = 73.83
        rClock(1) = 56.41
        rClock(2) = 43.12
        rClock(3) = 86.91
        pntDot = New Point(113, 113)
        brsBlack = New SolidBrush(Color.Black)
        brsGray = New SolidBrush(Me.BackColor)
        rtgDot = New Rectangle(105, 105, 16, 16)
        rtgEmpty = New Rectangle(110, 110, 6, 6)
        Call GraphLabel()
        Call GraphClock()
    End Sub
    Private Sub GraphLabel()
        Dim lct As New Point(13, 221)
        Dim i As Byte
        For i = 0 To 15 Step 1
            lblID(i) = New Label With {
                .Size = szeLbl,
                .Location = ControlLocation(lct, i),
                .Text = i.ToString("X"),
                .Tag = i
            }
            AddHandler lblID(i).Click, AddressOf lblID_Click
            AddHandler lblID(i).DoubleClick, AddressOf lblID_Click
            Me.Controls.Add(lblID(i))
            lblID(i).Show()
        Next
    End Sub
    Private Sub lblID_Click(sender As Label, e As MouseEventArgs)
        Dim ID As Byte = sender.Tag
        WinSet.ID = ID
        WinSet.dtShow = WinMain.dtNow
        WinSet.Location = New Point(Me.Location.X + (Me.Size.Width - WinSet.Size.Width) / 2,
                                    Me.Location.Y + (Me.Size.Height - WinSet.Height) / 2)
        Me.Enabled = False
        WinSet.Show()
    End Sub
    Public Sub FlushLabel()
        Dim i As Byte
        For i = 0 To 15 Step 1
            If WinMain.setAlarm(i) Then
                lblID(i).ForeColor = Color.Black
                If WinMain.dtNow > WinMain.dtAlarm(i) Then
                    If WinMain.dtNow - WinMain.dtAlarm(i) < WinMain.SpanRed Then
                        lblID(i).ForeColor = Color.Red
                    ElseIf WinMain.dtNow - WinMain.dtAlarm(i) < WinMain.SpanGreen Then
                        lblID(i).ForeColor = Color.Green
                    End If
                End If
            Else
                lblID(i).ForeColor = Color.Gray
            End If
        Next
    End Sub
    Private Function ControlLocation(Init As Point, ID As Byte) As Point
        Return New Point(Init.X + 26 * (ID Mod 8), Init.Y + 27 * (ID \ 8))
    End Function
    Private Sub GraphClock()
        Dim i As Byte
        For i = 0 To 11 Step 1
            lblWord(i) = New Label With {
                .Size = szeLbl,
                .Text = i.ToString("X").Replace("A", "X").Replace("B", "Y"),
                .Location = ClockLocation(New DateTime(2000, 1, 1, i, 0, 0), 3)
            }
            Me.Controls.Add(lblWord(i))
            lblWord(i).Show()
        Next
        gphClock = Me.CreateGraphics
        gphClock.Clip = New Region(New Rectangle(13, 13, 200, 200))
        gphClock.CompositingMode = Drawing2D.CompositingMode.SourceOver
        For i = 0 To 2 Step 1
            penPin(i) = New Pen(brsBlack, i * 2 + 1) With {
                .DashStyle = Drawing2D.DashStyle.Solid,
                .DashCap = Drawing2D.DashCap.Round,
                .StartCap = Drawing2D.LineCap.Triangle,
                .EndCap = Drawing2D.LineCap.Triangle
            }
        Next
    End Sub
    Public Sub FlushClock()
        Dim i As Byte
        gphClock.Clear(Me.BackColor)
        gphClock.FillEllipse(brsBlack, rtgDot)
        For i = 0 To 2 Step 1
            gphClock.DrawLine(penPin(i), pntDot, ClockLocation(WinMain.dtNow, i))
        Next
        gphClock.FillEllipse(brsGray, rtgEmpty)
    End Sub
    Private Function ClockLocation(dt As DateTime, t As Byte) As Point
        't { 0 = Second, 1 = Minute, 2 = Hour, 3 = Word }
        Dim Angel As Double = 0
        Select Case t
            Case 0
                Angel = dt.Second
                Angel *= Math.PI / 30
            Case 1
                Angel = dt.Minute + dt.Second / 60
                Angel *= Math.PI / 30
            Case 2, 3
                Angel = (dt.Hour Mod 12) + dt.Minute / 60 + dt.Second / 3600
                Angel *= Math.PI / 6
        End Select
        Dim x As Integer = Math.Round(113 + Math.Sin(Angel) * rClock(t) - IIf(t = 3, szeLbl.Width / 2, 0))
        Dim y As Integer = Math.Round(113 - Math.Cos(Angel) * rClock(t) - IIf(t = 3, szeLbl.Height / 2, 0))
        Return New Point(x, y)
    End Function
End Class