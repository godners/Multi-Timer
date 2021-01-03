Module ThemeWord
    Friend Function TinyTimeString(inp As DateTime) As String
        Return inp.ToString("HH:mm:ss")
    End Function
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
        Dim i, st As Byte
        Dim t As Char
        For Each dr As DataRow In WinMain.DtsMain.Tables("DttConfig").Rows
            i = dr.Item("DtcIDc")
            t = dr.Item("DtcTag")
            st = WinMain.DtsMain.Tables("DttStatus").Select("DtcIDs=" & i.ToString)(0).Item("DtcStatus")
            Call FlushIDLabel(i, t, st)
        Next
    End Sub
    Private Sub GraphIDLabel(inpID As Byte)
        WinWord.LblID(inpID) = New Label With {
            .Size = New Size(18, 19),
            .Location = GetLocation(inpID),
            .Tag = inpID.ToString,
            .Enabled = True
        }
        WinWord.Controls.Add(WinWord.LblID(inpID))
        WinWord.LblID(inpID).Show()
    End Sub
    Private Sub FlushIDLabel(inpID As Byte, t As Char, st As Byte)
        WinWord.LblID(inpID).Text = t.ToString
        WinWord.LblID(inpID).ForeColor = ThemeMain.GetMColor(st)
    End Sub
    Private Function GetLocation(inpID As Byte) As Point
        Return New Point(13 + (inpID Mod 8) * 26, If(inpID < 8, 66, 93))
    End Function
End Module
