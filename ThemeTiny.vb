Module ThemeTiny
    Friend rClock(5) As Double
    Friend Sub InitControl()
        Call GraphControl()
        Call FlushControl()
    End Sub
    Private Sub GraphControl()
        Dim i As Byte
        For Each dr As DataRow In WinMain.DtsMain.Tables("DttConfig").Rows
            i = dr.Item("DtcIDc")
            Call GraphIDLabel(i)
        Next
    End Sub
    Friend Sub FlushControl()
        WinWord.LblNow.Text = TinyTimeString(WinMain.GlobalNow)
        Call FlushClock()
        Dim i, st As Byte
        Dim t As Char
        For Each dr As DataRow In WinMain.DtsMain.Tables("DttConfig").Rows
            i = dr.Item("DtcIDc")
            t = dr.Item("DtcTag")
            st = WinMain.DtsMain.Tables("DttStatus").Select("DtcIDs=" & i.ToString)(0).Item("DtcStatus")
            Call FlushIDLabel(i, t, st)
        Next
    End Sub
    Friend Sub InitClock()
        Call GraphClock()
        Call FlushClock()
    End Sub
    Private Sub GraphClock()
        Dim i As Byte
        For i = 0 To 2 Step 1
            WinTiny.penPin(i) = New Pen(WinTiny.brsBlack, i * 2 + 1) With {
                .DashStyle = Drawing2D.DashStyle.Solid,
                .DashCap = Drawing2D.DashCap.Round,
                .StartCap = Drawing2D.LineCap.Triangle,
                .EndCap = Drawing2D.LineCap.Triangle
            }
        Next
        For i = 0 To 11 Step 1
            Call GraphClockLabel(i)
        Next
    End Sub
    Private Sub GraphClockLabel(inp As Byte)
        WinTiny.LblClock(inp) = New Label With {
            .Size = My.Settings.sizeSingleWord,
            .Text = GetClockWord(inp),
            .Location = ClockPoint(DataOpr.dtInit.AddHours(inp), RadType.Word)
        }
        WinTiny.Controls.Add(WinTiny.LblClock(inp))
        WinTiny.LblClock(inp).Show()
    End Sub
    Friend Sub FlushClock()
        With WinTiny
            .gphClock.Clear(.BackColor)
            .gphClock.FillEllipse(.brsBlack, .rtgDot)
            .gphClock.DrawLine(.penPin(RadType.Second), .pntDot, ClockPoint(WinMain.GlobalNow, RadType.Second))
            .gphClock.DrawLine(.penPin(RadType.Minute), .pntDot, ClockPoint(WinMain.GlobalNow, RadType.Minute))
            .gphClock.DrawLine(.penPin(RadType.Hour), .pntDot, ClockPoint(WinMain.GlobalNow, RadType.Hour))
            .gphClock.FillEllipse(WinTiny.brsGray, WinTiny.rtgEmpty)
        End With
    End Sub
    Private Function ClockPoint(dt As DateTime, r As RadType) As Point
        Dim Angel As Double
        Select Case r
            Case RadType.Hour, RadType.Word
                Angel = (dt.Hour Mod 12) + dt.Minute / 60 + dt.Second / 3600
                Angel *= Math.PI / 6
            Case RadType.Minute
                Angel = dt.Minute + dt.Second / 60
                Angel *= Math.PI / 30
            Case RadType.Second
                Angel = dt.Second
                Angel *= Math.PI / 30
            Case Else
                Angel = 0
        End Select
        Return New Point(Math.Round(WinTiny.pntDot.X + Math.Sin(Angel) * rClock(r) - If(r = RadType.Word, My.Settings.sizeSingleWord.Width / 2, 0), 0),
                         Math.Round(WinTiny.pntDot.Y - Math.Cos(Angel) * rClock(r) - If(r = RadType.Word, My.Settings.sizeSingleWord.Height / 2, 0), 0))
    End Function
    Private Function GetClockWord(inp As Byte) As String
        Select Case inp
            Case 0 To 9
                Return inp.ToString
            Case 10
                Return "X"
            Case 11
                Return "Y"
            Case Else
                Return ""
        End Select
    End Function
    Friend Sub InitRadClock()
        rClock(RadType.Hour) = 43.12
        rClock(RadType.Minute) = 56.41
        rClock(RadType.Second) = 73.83
        rClock(RadType.Word) = 86.91
        rClock(RadType.Dot) = 8
        rClock(RadType.Empty) = 3
    End Sub
    Private Sub GraphIDLabel(inpID As Byte)
        WinTiny.LblID(inpID) = New Label With {
            .Size = New Size(18, 19),
            .Location = GetLocation(inpID),
            .Tag = inpID.ToString,
            .Enabled = True
        }
        WinTiny.Controls.Add(WinTiny.LblID(inpID))
        WinTiny.LblID(inpID).Show()

    End Sub
    Private Sub FlushIDLabel(inpID As Byte, t As Char, st As Byte)
        WinTiny.LblID(inpID).Text = t.ToString
        WinTiny.LblID(inpID).ForeColor = ThemeMain.GetMColor(st)
    End Sub
    Private Function GetLocation(inpID As Byte) As Point
        Return New Point(13 + (inpID Mod 8) * 26, If(inpID < 8, 221, 248))
    End Function
    Friend Enum RadType
        Second = 0
        Minute = 1
        Hour = 2
        Word = 3
        Dot = 4
        Empty = 5
    End Enum
End Module
