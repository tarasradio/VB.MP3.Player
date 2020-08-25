Public Class SettingsForm

    Private Sub ChangeForecolorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeForecolorButton.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            ForecolorView.BackColor = ColorDialog1.Color
            My.Settings.forecolor = ColorDialog1.Color
            PlayerForm.FilesListBox.ForeColor = My.Settings.forecolor
        End If
    End Sub

    Private Sub ChangeFilesListBackColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFilesListBackcolorButton.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            FilesListBackcolorView.BackColor = ColorDialog1.Color
            My.Settings.filesListBackColor = ColorDialog1.Color
            PlayerForm.FilesListBox.BackColor = My.Settings.filesListBackColor
        End If
    End Sub

    Private Sub ChangePlayerBackColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePlayerBackColorButton.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            PlayerBackcolorView.BackColor = ColorDialog1.Color
            My.Settings.playerBackColor = ColorDialog1.Color
            PlayerForm.BackColor = My.Settings.playerBackColor
            PlayerForm.PlayControlButtons.BackColor = My.Settings.playerBackColor
        End If
    End Sub

    Private Sub SettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ForecolorView.BackColor = My.Settings.forecolor
        FilesListBackcolorView.BackColor = My.Settings.filesListBackColor
        PlayerBackcolorView.BackColor = My.Settings.playerBackColor
    End Sub

    Private Sub SetDefaultSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDefaultSettingsButton.Click
        ForecolorView.BackColor = Color.Indigo
        My.Settings.forecolor = Color.Indigo
        PlayerForm.FilesListBox.ForeColor = Color.Indigo

        FilesListBackcolorView.BackColor = Color.White
        My.Settings.filesListBackColor = Color.White
        PlayerForm.FilesListBox.BackColor = Color.White

        PlayerBackcolorView.BackColor = Color.Empty
        My.Settings.playerBackColor = Color.Empty
        PlayerForm.BackColor = Color.Empty
        PlayerForm.PlayControlButtons.BackColor = Color.Empty
    End Sub
End Class