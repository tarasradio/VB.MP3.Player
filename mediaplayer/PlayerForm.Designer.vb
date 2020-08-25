<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayerForm))
        Me.UpdateTitleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FilesListBox = New System.Windows.Forms.ListBox()
        Me.PlayControlButtons = New System.Windows.Forms.ToolStrip()
        Me.MinusVolumeButton = New System.Windows.Forms.ToolStripButton()
        Me.PrevFileButton = New System.Windows.Forms.ToolStripButton()
        Me.PlayPauseButton = New System.Windows.Forms.ToolStripButton()
        Me.NextFileButton = New System.Windows.Forms.ToolStripButton()
        Me.PlusVolumeButton = New System.Windows.Forms.ToolStripButton()
        Me.SelectedFileTitle = New System.Windows.Forms.Label()
        Me.DurationLabel = New System.Windows.Forms.Label()
        Me.WTFTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CurrentTimeLabel = New System.Windows.Forms.Label()
        Me.PlayProgress = New System.Windows.Forms.ProgressBar()
        Me.FileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppMenu = New System.Windows.Forms.MenuStrip()
        Me.SettingsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSettingsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CurrentFileTitle = New System.Windows.Forms.Label()
        Me.WTFTimer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BitrateLabel = New System.Windows.Forms.Label()
        Me.HiddenCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.PlayControlButtons.SuspendLayout()
        Me.AppMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdateTitleTimer
        '
        Me.UpdateTitleTimer.Enabled = True
        '
        'FilesListBox
        '
        Me.FilesListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilesListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FilesListBox.ForeColor = System.Drawing.Color.Indigo
        Me.FilesListBox.FormattingEnabled = True
        Me.FilesListBox.HorizontalScrollbar = True
        Me.FilesListBox.ItemHeight = 18
        Me.FilesListBox.Location = New System.Drawing.Point(12, 50)
        Me.FilesListBox.Name = "FilesListBox"
        Me.FilesListBox.Size = New System.Drawing.Size(240, 130)
        Me.FilesListBox.TabIndex = 2
        '
        'PlayControlButtons
        '
        Me.PlayControlButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PlayControlButtons.AutoSize = False
        Me.PlayControlButtons.BackColor = System.Drawing.SystemColors.Control
        Me.PlayControlButtons.Dock = System.Windows.Forms.DockStyle.None
        Me.PlayControlButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PlayControlButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinusVolumeButton, Me.PrevFileButton, Me.PlayPauseButton, Me.NextFileButton, Me.PlusVolumeButton})
        Me.PlayControlButtons.Location = New System.Drawing.Point(21, 228)
        Me.PlayControlButtons.Name = "PlayControlButtons"
        Me.PlayControlButtons.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.PlayControlButtons.Size = New System.Drawing.Size(231, 46)
        Me.PlayControlButtons.TabIndex = 3
        Me.PlayControlButtons.Text = "ToolStrip1"
        '
        'MinusVolumeButton
        '
        Me.MinusVolumeButton.AutoSize = False
        Me.MinusVolumeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MinusVolumeButton.Image = Global.mediaplayer.My.Resources.Resources.minusIcon
        Me.MinusVolumeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MinusVolumeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MinusVolumeButton.Name = "MinusVolumeButton"
        Me.MinusVolumeButton.Size = New System.Drawing.Size(44, 44)
        Me.MinusVolumeButton.Text = "Тише"
        '
        'PrevFileButton
        '
        Me.PrevFileButton.AutoSize = False
        Me.PrevFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrevFileButton.Image = Global.mediaplayer.My.Resources.Resources.backwardIcon
        Me.PrevFileButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrevFileButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrevFileButton.Name = "PrevFileButton"
        Me.PrevFileButton.Size = New System.Drawing.Size(44, 44)
        Me.PrevFileButton.Text = "Предыдущий"
        '
        'PlayPauseButton
        '
        Me.PlayPauseButton.AutoSize = False
        Me.PlayPauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlayPauseButton.Image = Global.mediaplayer.My.Resources.Resources.playIcon
        Me.PlayPauseButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PlayPauseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PlayPauseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PlayPauseButton.Name = "PlayPauseButton"
        Me.PlayPauseButton.Size = New System.Drawing.Size(44, 44)
        Me.PlayPauseButton.Text = "Играть"
        '
        'NextFileButton
        '
        Me.NextFileButton.AutoSize = False
        Me.NextFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NextFileButton.Image = Global.mediaplayer.My.Resources.Resources.forwardIcon
        Me.NextFileButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NextFileButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NextFileButton.Name = "NextFileButton"
        Me.NextFileButton.Size = New System.Drawing.Size(44, 44)
        Me.NextFileButton.Text = "Следующий"
        '
        'PlusVolumeButton
        '
        Me.PlusVolumeButton.AutoSize = False
        Me.PlusVolumeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlusVolumeButton.Image = Global.mediaplayer.My.Resources.Resources.plusIcon
        Me.PlusVolumeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PlusVolumeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PlusVolumeButton.Name = "PlusVolumeButton"
        Me.PlusVolumeButton.Size = New System.Drawing.Size(44, 44)
        Me.PlusVolumeButton.Text = "Громче"
        '
        'SelectedFileTitle
        '
        Me.SelectedFileTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectedFileTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SelectedFileTitle.ForeColor = System.Drawing.Color.SteelBlue
        Me.SelectedFileTitle.Location = New System.Drawing.Point(0, 0)
        Me.SelectedFileTitle.Name = "SelectedFileTitle"
        Me.SelectedFileTitle.Size = New System.Drawing.Size(240, 18)
        Me.SelectedFileTitle.TabIndex = 4
        '
        'DurationLabel
        '
        Me.DurationLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DurationLabel.AutoSize = True
        Me.DurationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DurationLabel.ForeColor = System.Drawing.Color.SteelBlue
        Me.DurationLabel.Location = New System.Drawing.Point(184, 203)
        Me.DurationLabel.Name = "DurationLabel"
        Me.DurationLabel.Size = New System.Drawing.Size(71, 25)
        Me.DurationLabel.TabIndex = 8
        Me.DurationLabel.Text = "00:00"
        '
        'WTFTimer2
        '
        Me.WTFTimer2.Enabled = True
        Me.WTFTimer2.Interval = 10
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel1.Location = New System.Drawing.Point(243, 228)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(21, 46)
        Me.Panel1.TabIndex = 10
        '
        'CurrentTimeLabel
        '
        Me.CurrentTimeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CurrentTimeLabel.AutoSize = True
        Me.CurrentTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CurrentTimeLabel.ForeColor = System.Drawing.Color.SteelBlue
        Me.CurrentTimeLabel.Location = New System.Drawing.Point(7, 202)
        Me.CurrentTimeLabel.Name = "CurrentTimeLabel"
        Me.CurrentTimeLabel.Size = New System.Drawing.Size(71, 25)
        Me.CurrentTimeLabel.TabIndex = 11
        Me.CurrentTimeLabel.Text = "00:00"
        '
        'PlayProgress
        '
        Me.PlayProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayProgress.Location = New System.Drawing.Point(84, 205)
        Me.PlayProgress.Name = "PlayProgress"
        Me.PlayProgress.Size = New System.Drawing.Size(94, 20)
        Me.PlayProgress.Step = 1
        Me.PlayProgress.TabIndex = 12
        '
        'FileMenuItem
        '
        Me.FileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileButton, Me.ExitButton})
        Me.FileMenuItem.Name = "FileMenuItem"
        Me.FileMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.FileMenuItem.Text = "Файл"
        '
        'OpenFileButton
        '
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(121, 22)
        Me.OpenFileButton.Text = "Открыть"
        '
        'ExitButton
        '
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(121, 22)
        Me.ExitButton.Text = "Выход"
        '
        'AppMenu
        '
        Me.AppMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuItem, Me.SettingsMenuItem, Me.HelpMenuItem})
        Me.AppMenu.Location = New System.Drawing.Point(0, 0)
        Me.AppMenu.Name = "AppMenu"
        Me.AppMenu.Size = New System.Drawing.Size(264, 24)
        Me.AppMenu.TabIndex = 5
        Me.AppMenu.Text = "MenuStrip1"
        '
        'SettingsMenuItem
        '
        Me.SettingsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSettingsButton})
        Me.SettingsMenuItem.Name = "SettingsMenuItem"
        Me.SettingsMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.SettingsMenuItem.Text = "Настройки"
        '
        'ViewSettingsButton
        '
        Me.ViewSettingsButton.Name = "ViewSettingsButton"
        Me.ViewSettingsButton.Size = New System.Drawing.Size(150, 22)
        Me.ViewSettingsButton.Text = "Отображение"
        '
        'HelpMenuItem
        '
        Me.HelpMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutButton})
        Me.HelpMenuItem.Name = "HelpMenuItem"
        Me.HelpMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.HelpMenuItem.Text = "Справка"
        '
        'AboutButton
        '
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(149, 22)
        Me.AboutButton.Text = "О программе"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.CurrentFileTitle)
        Me.Panel2.Controls.Add(Me.SelectedFileTitle)
        Me.Panel2.Location = New System.Drawing.Point(12, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 17)
        Me.Panel2.TabIndex = 13
        '
        'CurrentFileTitle
        '
        Me.CurrentFileTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentFileTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CurrentFileTitle.ForeColor = System.Drawing.Color.SteelBlue
        Me.CurrentFileTitle.Location = New System.Drawing.Point(0, 0)
        Me.CurrentFileTitle.Name = "CurrentFileTitle"
        Me.CurrentFileTitle.Size = New System.Drawing.Size(240, 18)
        Me.CurrentFileTitle.TabIndex = 14
        '
        'WTFTimer3
        '
        Me.WTFTimer3.Enabled = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 273)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 10)
        Me.Panel3.TabIndex = 14
        '
        'BitrateLabel
        '
        Me.BitrateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BitrateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BitrateLabel.ForeColor = System.Drawing.Color.SteelBlue
        Me.BitrateLabel.Location = New System.Drawing.Point(189, 186)
        Me.BitrateLabel.Name = "BitrateLabel"
        Me.BitrateLabel.Size = New System.Drawing.Size(63, 17)
        Me.BitrateLabel.TabIndex = 15
        Me.BitrateLabel.Text = "Битрейт"
        Me.BitrateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HiddenCheckBox
        '
        Me.HiddenCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HiddenCheckBox.AutoSize = True
        Me.HiddenCheckBox.ForeColor = System.Drawing.Color.SteelBlue
        Me.HiddenCheckBox.Location = New System.Drawing.Point(12, 185)
        Me.HiddenCheckBox.Name = "HiddenCheckBox"
        Me.HiddenCheckBox.Size = New System.Drawing.Size(73, 17)
        Me.HiddenCheckBox.TabIndex = 16
        Me.HiddenCheckBox.Text = "Спрятать"
        Me.HiddenCheckBox.UseVisualStyleBackColor = True
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 43)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 43)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 43)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 43)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 43)
        Me.ToolStripButton9.Text = "ToolStripButton9"
        '
        'PlayerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 278)
        Me.Controls.Add(Me.HiddenCheckBox)
        Me.Controls.Add(Me.BitrateLabel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PlayProgress)
        Me.Controls.Add(Me.CurrentTimeLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DurationLabel)
        Me.Controls.Add(Me.PlayControlButtons)
        Me.Controls.Add(Me.AppMenu)
        Me.Controls.Add(Me.FilesListBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.AppMenu
        Me.MinimumSize = New System.Drawing.Size(280, 180)
        Me.Name = "PlayerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB Mp3 Плеер (v0)"
        Me.PlayControlButtons.ResumeLayout(False)
        Me.PlayControlButtons.PerformLayout()
        Me.AppMenu.ResumeLayout(False)
        Me.AppMenu.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdateTitleTimer As System.Windows.Forms.Timer
    Friend WithEvents FilesListBox As System.Windows.Forms.ListBox
    Friend WithEvents PlayControlButtons As System.Windows.Forms.ToolStrip
    Friend WithEvents PlayPauseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrevFileButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NextFileButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SelectedFileTitle As System.Windows.Forms.Label
    Friend WithEvents DurationLabel As System.Windows.Forms.Label
    Friend WithEvents MinusVolumeButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PlusVolumeButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents WTFTimer2 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CurrentTimeLabel As System.Windows.Forms.Label
    Friend WithEvents PlayProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents FileMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CurrentFileTitle As System.Windows.Forms.Label
    Friend WithEvents WTFTimer3 As System.Windows.Forms.Timer
    Friend WithEvents ExitButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSettingsButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents AboutButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitrateLabel As System.Windows.Forms.Label
    Friend WithEvents HiddenCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripButton9 As ToolStripButton
End Class
