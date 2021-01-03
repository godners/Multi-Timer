Public Class WinAuthor
    Private imgAuthor(3) As Image
    Private imgAuthorID As Byte
    Private Sub WinAuthor_Closed() Handles Me.Closed
        Call ThemeMain.WinClockShow(WinMain.WinStyle)
    End Sub
    Private Sub Pcb_Click(sender As PictureBox, e As EventArgs) Handles _
        PtbVCP.Click, PtbOCP.Click, PtbRHCE.Click, PtbITSS.Click, PtbITIL.Click
        Dim dr As DataRow = DtsAuthor.Tables("DttLogo").Select("DtcIDl=" & sender.Tag)(0)
        ShowMessageBox(dr.Item("DtcContent"), dr.Item("DtcTitle"))
    End Sub
    Private Sub ShowMessageBox(str As String, tit As String)
        MessageBox.Show(str, tit, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub LlbURL_LinkClicked() Handles LlbURL.LinkClicked
        Dim strURL As String = "Open Source in GitHub:" &
            vbCrLf & LlbURL.Text &
            vbCrLf & "Copy URL to Clip-Board?"
        If MessageBox.Show(strURL, "Copy to Clip-Board?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            My.Computer.Clipboard.SetText(LlbURL.Text)
        End If
    End Sub
    Private Sub PtbAuthor_Click() Handles PtbAuthor.Click
        Call ReplaceAuthorImage()
    End Sub
    Private Sub WinAuthor_Load() Handles Me.Load
        Call InitDttLogo()
        imgAuthor(0) = My.Resources.Author01
        imgAuthor(1) = My.Resources.Author02
        imgAuthor(2) = My.Resources.Author03
        imgAuthor(3) = My.Resources.Author04
        imgAuthorID = WinMain.GlobalNow.Millisecond Mod 4
    End Sub
    Private Sub InitDttLogo()
        DtsAuthor.Tables("DttLogo").Clear()
        Dim dr As DataRow
        Dim i As Byte
        For Each sp As Configuration.SettingsProperty In My.Settings.Properties
            If sp.Name.Contains("CertTitle") Then
                dr = DtsAuthor.Tables("DttLogo").NewRow
                i = Convert.ToByte(sp.Name.Replace("CertTitle", ""))
                dr.Item("DtcIDl") = i
                dr.Item("DtcTitle") = sp.DefaultValue
                dr.Item("DtcContent") = My.Settings.Properties.Item("CertContent" & i.ToString).DefaultValue
                DtsAuthor.Tables("DttLogo").Rows.Add(dr)
                DtsAuthor.Tables("DttLogo").AcceptChanges()
            End If
        Next
    End Sub
    Private Sub WinAuthor_Shown() Handles Me.Shown
        Call ReplaceAuthorImage()
    End Sub
    Private Sub ReplaceAuthorImage()
        imgAuthorID = (imgAuthorID + 1) Mod 4
        PtbAuthor.Image = imgAuthor(imgAuthorID)
    End Sub
    Private Sub WinAuthor_KeyDown(sender As Object, e As KeyEventArgs) Handles _
        Me.KeyDown, Label1.KeyDown, Label2.KeyDown, Label3.KeyDown, Label4.KeyDown, Label5.KeyDown,
        PtbAuthor.KeyDown, PtbITIL.KeyDown, PtbITSS.KeyDown, PtbOCP.KeyDown, PtbRHCE.KeyDown, PtbVCP.KeyDown,
        LlbURL.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class