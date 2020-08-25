Imports WMPLib
Imports System.IO
Public Class PlayerForm

    Private wmpLib As New WMPLib.WindowsMediaPlayer
    Private filesDirectory As String = String.Empty
    Private lastFileName As String = String.Empty

    Private Sub PlayerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BackColor = My.Settings.playerBackColor
        FilesListBox.BackColor = My.Settings.filesListBackColor
        FilesListBox.ForeColor = My.Settings.forecolor
        wmpLib.settings.volume = 90 '(0 - 100)

        PlayPauseButton.Image = My.Resources.playIcon
        '
        Me.UpdateTitleTimer.Interval = 40
        Me.UpdateTitleTimer.Enabled = True
        Me.SelectedFileTitle.Visible = True
        Me.CurrentFileTitle.Visible = False

        If My.Application.CommandLineArgs.Count > 0 Then
            wmpLib.currentMedia = wmpLib.newMedia(My.Application.CommandLineArgs(0))
            SelectedFileTitle.Text = wmpLib.currentMedia.name
            CurrentFileTitle.Text = wmpLib.currentMedia.name
            filesDirectory = Path.GetDirectoryName(My.Application.CommandLineArgs(0))
            Dim myfile As String = My.Application.CommandLineArgs(0)

            For Each files As String In IO.Directory.GetFiles(filesDirectory, "*.mp3", IO.SearchOption.TopDirectoryOnly)
                FilesListBox.Items.Add(My.Computer.FileSystem.GetFileInfo(files).Name)
            Next

            FilesListBox.SelectedItem = My.Computer.FileSystem.GetFileInfo(myfile).Name

            PlayPauseButton.Image = My.Resources.pauseIcon
        Else
            PlayPauseButton.Enabled = False
        End If

    End Sub

    Private Sub FilesListBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FilesListBox.KeyUp
        If e.KeyCode = Keys.Delete Then
            Dim selind = FilesListBox.SelectedIndex
            If FilesListBox.Items.Count <> 0 Then
                FilesListBox.Items.RemoveAt(selind)
                If FilesListBox.Items.Count <> 0 Then
                    FilesListBox.SelectedIndex = selind
                End If
            End If
        End If

    End Sub


    Private Sub FilesListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FilesListBox.SelectedIndexChanged
        wmpLib.currentMedia = wmpLib.newMedia(filesDirectory + "\" + FilesListBox.SelectedItem)
        SelectedFileTitle.Text = wmpLib.currentMedia.name
        CurrentFileTitle.Text = wmpLib.currentMedia.name
        BitrateLabel.Text = wmpLib.currentMedia.getItemInfo("bitrate")
    End Sub

    Private Sub PlayPauseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayPauseButton.Click

        If wmpLib.playState = WMPPlayState.wmppsPlaying Then
            PlayPauseButton.Image = My.Resources.playIcon
            wmpLib.controls.pause()
            PlayPauseButton.Text = "Продолжить"
        Else
            PlayPauseButton.Image = My.Resources.pauseIcon
            wmpLib.controls.play()
            PlayPauseButton.Text = "Пауза"
        End If
    End Sub

    Private Sub NextFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextFileButton.Click
        FilesListBox.SelectedIndex = FilesListBox.SelectedIndex + 1
        wmpLib.currentMedia = wmpLib.newMedia(filesDirectory + "\" + FilesListBox.SelectedItem)
        SelectedFileTitle.Text = wmpLib.currentMedia.name
        CurrentFileTitle.Text = wmpLib.currentMedia.name
    End Sub

    Private Sub PrevFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrevFileButton.Click
        FilesListBox.SelectedIndex = FilesListBox.SelectedIndex - 1
        wmpLib.currentMedia = wmpLib.newMedia(filesDirectory + "\" + FilesListBox.SelectedItem)
        SelectedFileTitle.Text = wmpLib.currentMedia.name
        CurrentFileTitle.Text = wmpLib.currentMedia.name
        DurationLabel.Text = wmpLib.currentMedia.durationString
    End Sub

    Private Sub UpdateTitleTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateTitleTimer.Tick

        Me.SelectedFileTitle.Left -= 5

        If Me.SelectedFileTitle.Left < 0 - Me.SelectedFileTitle.Width Then
            Me.SelectedFileTitle.Left = Me.Width - Me.SelectedFileTitle.Width
            Me.CurrentFileTitle.Visible = False
            Exit Sub
        End If

        If Me.SelectedFileTitle.Left > Me.Width Then
            Me.SelectedFileTitle.Left = 0
            Me.CurrentFileTitle.Visible = False
            Exit Sub
        End If


        If Me.SelectedFileTitle.Left < 0 Then
            Me.CurrentFileTitle.Left = Me.Width + Me.SelectedFileTitle.Left
            Me.CurrentFileTitle.Visible = True
            Exit Sub
        Else
            Me.CurrentFileTitle.Visible = False
        End If

        If Me.SelectedFileTitle.Left > Me.Width - Me.SelectedFileTitle.Width Then
            Me.CurrentFileTitle.Left = Me.SelectedFileTitle.Left - Me.Width
            Me.CurrentFileTitle.Visible = True
        Else
            Me.CurrentFileTitle.Visible = False
        End If

    End Sub

    Private Sub OpenFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileButton.Click

        Dim openFileDialog As New OpenFileDialog

        If openFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            lastFileName = openFileDialog.FileName

            filesDirectory = Path.GetDirectoryName(openFileDialog.FileName)

            Dim openFileName As String = openFileDialog.FileName

            FilesListBox.Items.Clear()

            For Each file As String In IO.Directory.GetFiles(filesDirectory, "*.mp3", IO.SearchOption.TopDirectoryOnly)
                FilesListBox.Items.Add(My.Computer.FileSystem.GetFileInfo(file).Name)
            Next

            FilesListBox.SelectedItem = My.Computer.FileSystem.GetFileInfo(openFileName).Name

            PlayPauseButton.Enabled = True

        End If
    End Sub

    Private Sub MinusVolumeButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinusVolumeButton.Click
        If wmpLib.settings.volume <> 0 Then
            wmpLib.settings.volume = wmpLib.settings.volume - 10
        End If
    End Sub

    Private Sub PlusVolumeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusVolumeButton.Click
        If wmpLib.settings.volume <> 100 Then
            wmpLib.settings.volume = wmpLib.settings.volume + 10
        End If
    End Sub



    Private Sub UpdateTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles WTFTimer2.Tick
        If wmpLib.playState = WMPPlayState.wmppsStopped Then
            If wmpLib.controls.currentPosition = 0 Then

                If FilesListBox.SelectedIndex = FilesListBox.Items.Count - 1 Then
                    FilesListBox.SelectedIndex = 0
                Else
                    FilesListBox.SelectedIndex = FilesListBox.SelectedIndex + 1
                End If

                wmpLib.currentMedia = wmpLib.newMedia(filesDirectory + "\" + FilesListBox.SelectedItem)
                SelectedFileTitle.Text = wmpLib.currentMedia.name
                CurrentFileTitle.Text = wmpLib.currentMedia.name

            End If
        Else
            If wmpLib.controls.currentPosition <> 0 Then
                PlayProgress.Maximum = wmpLib.currentMedia.duration
                PlayProgress.Value = Int(wmpLib.controls.currentPosition)
            End If

        End If
        If wmpLib.controls.currentPosition = 0 Then
            CurrentTimeLabel.Text = "00:00"
        Else
            CurrentTimeLabel.Text = wmpLib.controls.currentPositionString()
        End If
    End Sub

    Private Sub PlayProgress_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PlayProgress.Click
        Dim position As Double
        If wmpLib.playState <> WMPPlayState.wmppsUndefined Then
            position = e.Location.X / PlayProgress.Width
            wmpLib.controls.currentPosition = position * wmpLib.currentMedia.duration
            PlayProgress.Value = Int(wmpLib.controls.currentPosition)
        End If
    End Sub

    Private Sub WTFTimer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WTFTimer3.Tick
        If wmpLib.playState = WMPPlayState.wmppsPlaying Then
            PlayPauseButton.Image = My.Resources.pauseIcon
            PlayPauseButton.Text = "Пауза"
            DurationLabel.Text = wmpLib.currentMedia.durationString
            BitrateLabel.Text = Mid(wmpLib.currentMedia.getItemInfo("bitrate"), 1, 3) + " " + "КБ/С"
        Else
            PlayPauseButton.Image = My.Resources.playIcon
            PlayPauseButton.Text = "Продолжить"
        End If
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub ViewSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSettingsButton.Click
        SettingsForm.ShowDialog()
    End Sub

    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click
        AboutForm.Show()
    End Sub

    Private Sub HiddenCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HiddenCheckBox.CheckedChanged
        If HiddenCheckBox.Checked = True Then
            HiddenCheckBox.Text = "Вернуть"
            FilesListBox.Visible = False
            Me.MinimumSize = New Size(280, 180)
            Me.Size = New Size(280, 180)

        Else
            HiddenCheckBox.Text = "Спрятать"
            FilesListBox.Visible = True
            Me.MinimumSize = New Size(280, 314)
            Me.Size = New Size(280, 314)
        End If
    End Sub
End Class