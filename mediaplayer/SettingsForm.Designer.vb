<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ForecolorLabel = New System.Windows.Forms.Label()
        Me.ChangeForecolorButton = New System.Windows.Forms.Button()
        Me.ForecolorView = New System.Windows.Forms.PictureBox()
        Me.ChangeFilesListBackcolorButton = New System.Windows.Forms.Button()
        Me.FilesListBackcolorLabel = New System.Windows.Forms.Label()
        Me.FilesListBackcolorView = New System.Windows.Forms.PictureBox()
        Me.ChangePlayerBackColorButton = New System.Windows.Forms.Button()
        Me.PlayerBackcolorLabel = New System.Windows.Forms.Label()
        Me.PlayerBackcolorView = New System.Windows.Forms.PictureBox()
        Me.SetDefaultSettingsButton = New System.Windows.Forms.Button()
        Me.RestoreDefaultsLabel = New System.Windows.Forms.Label()
        CType(Me.ForecolorView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilesListBackcolorView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerBackcolorView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ForecolorLabel
        '
        Me.ForecolorLabel.AutoSize = True
        Me.ForecolorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForecolorLabel.Location = New System.Drawing.Point(14, 9)
        Me.ForecolorLabel.Name = "ForecolorLabel"
        Me.ForecolorLabel.Size = New System.Drawing.Size(90, 16)
        Me.ForecolorLabel.TabIndex = 1
        Me.ForecolorLabel.Text = "Цвет текста:"
        '
        'ChangeForecolorButton
        '
        Me.ChangeForecolorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ChangeForecolorButton.Location = New System.Drawing.Point(181, 6)
        Me.ChangeForecolorButton.Name = "ChangeForecolorButton"
        Me.ChangeForecolorButton.Size = New System.Drawing.Size(91, 23)
        Me.ChangeForecolorButton.TabIndex = 2
        Me.ChangeForecolorButton.Text = "Изменить"
        Me.ChangeForecolorButton.UseVisualStyleBackColor = True
        '
        'ForecolorView
        '
        Me.ForecolorView.Location = New System.Drawing.Point(114, 6)
        Me.ForecolorView.Name = "ForecolorView"
        Me.ForecolorView.Size = New System.Drawing.Size(61, 23)
        Me.ForecolorView.TabIndex = 0
        Me.ForecolorView.TabStop = False
        '
        'ChangeFilesListBackcolorButton
        '
        Me.ChangeFilesListBackcolorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ChangeFilesListBackcolorButton.Location = New System.Drawing.Point(181, 35)
        Me.ChangeFilesListBackcolorButton.Name = "ChangeFilesListBackcolorButton"
        Me.ChangeFilesListBackcolorButton.Size = New System.Drawing.Size(91, 23)
        Me.ChangeFilesListBackcolorButton.TabIndex = 5
        Me.ChangeFilesListBackcolorButton.Text = "Изменить"
        Me.ChangeFilesListBackcolorButton.UseVisualStyleBackColor = True
        '
        'FilesListBackcolorLabel
        '
        Me.FilesListBackcolorLabel.AutoSize = True
        Me.FilesListBackcolorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FilesListBackcolorLabel.Location = New System.Drawing.Point(14, 38)
        Me.FilesListBackcolorLabel.Name = "FilesListBackcolorLabel"
        Me.FilesListBackcolorLabel.Size = New System.Drawing.Size(91, 16)
        Me.FilesListBackcolorLabel.TabIndex = 4
        Me.FilesListBackcolorLabel.Text = "Цвет списка:"
        '
        'FilesListBackcolorView
        '
        Me.FilesListBackcolorView.Location = New System.Drawing.Point(114, 35)
        Me.FilesListBackcolorView.Name = "FilesListBackcolorView"
        Me.FilesListBackcolorView.Size = New System.Drawing.Size(61, 23)
        Me.FilesListBackcolorView.TabIndex = 3
        Me.FilesListBackcolorView.TabStop = False
        '
        'ChangePlayerBackcolorButton
        '
        Me.ChangePlayerBackColorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ChangePlayerBackColorButton.Location = New System.Drawing.Point(181, 64)
        Me.ChangePlayerBackColorButton.Name = "ChangePlayerBackcolorButton"
        Me.ChangePlayerBackColorButton.Size = New System.Drawing.Size(91, 23)
        Me.ChangePlayerBackColorButton.TabIndex = 8
        Me.ChangePlayerBackColorButton.Text = "Изменить"
        Me.ChangePlayerBackColorButton.UseVisualStyleBackColor = True
        '
        'PlayerBackcolorLabel
        '
        Me.PlayerBackcolorLabel.AutoSize = True
        Me.PlayerBackcolorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PlayerBackcolorLabel.Location = New System.Drawing.Point(14, 67)
        Me.PlayerBackcolorLabel.Name = "PlayerBackcolorLabel"
        Me.PlayerBackcolorLabel.Size = New System.Drawing.Size(94, 16)
        Me.PlayerBackcolorLabel.TabIndex = 7
        Me.PlayerBackcolorLabel.Text = "Цвет плеера:"
        '
        'PlayerBackcolorView
        '
        Me.PlayerBackcolorView.Location = New System.Drawing.Point(114, 64)
        Me.PlayerBackcolorView.Name = "PlayerBackcolorView"
        Me.PlayerBackcolorView.Size = New System.Drawing.Size(61, 23)
        Me.PlayerBackcolorView.TabIndex = 6
        Me.PlayerBackcolorView.TabStop = False
        '
        'SetDefaultSettingsButton
        '
        Me.SetDefaultSettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SetDefaultSettingsButton.Location = New System.Drawing.Point(181, 93)
        Me.SetDefaultSettingsButton.Name = "SetDefaultSettingsButton"
        Me.SetDefaultSettingsButton.Size = New System.Drawing.Size(91, 23)
        Me.SetDefaultSettingsButton.TabIndex = 9
        Me.SetDefaultSettingsButton.Text = "Применить"
        Me.SetDefaultSettingsButton.UseVisualStyleBackColor = True
        '
        'RestoreDefaultsLabel
        '
        Me.RestoreDefaultsLabel.AutoSize = True
        Me.RestoreDefaultsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RestoreDefaultsLabel.Location = New System.Drawing.Point(12, 96)
        Me.RestoreDefaultsLabel.Name = "RestoreDefaultsLabel"
        Me.RestoreDefaultsLabel.Size = New System.Drawing.Size(155, 16)
        Me.RestoreDefaultsLabel.TabIndex = 10
        Me.RestoreDefaultsLabel.Text = "Вернуть стандартные:"
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 121)
        Me.Controls.Add(Me.RestoreDefaultsLabel)
        Me.Controls.Add(Me.SetDefaultSettingsButton)
        Me.Controls.Add(Me.ChangePlayerBackColorButton)
        Me.Controls.Add(Me.PlayerBackcolorLabel)
        Me.Controls.Add(Me.PlayerBackcolorView)
        Me.Controls.Add(Me.ChangeFilesListBackcolorButton)
        Me.Controls.Add(Me.FilesListBackcolorLabel)
        Me.Controls.Add(Me.FilesListBackcolorView)
        Me.Controls.Add(Me.ChangeForecolorButton)
        Me.Controls.Add(Me.ForecolorLabel)
        Me.Controls.Add(Me.ForecolorView)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 160)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 160)
        Me.Name = "SettingsForm"
        Me.Text = "Отображение"
        CType(Me.ForecolorView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilesListBackcolorView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerBackcolorView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ForecolorView As System.Windows.Forms.PictureBox
    Friend WithEvents ForecolorLabel As System.Windows.Forms.Label
    Friend WithEvents ChangeForecolorButton As System.Windows.Forms.Button
    Friend WithEvents ChangeFilesListBackcolorButton As System.Windows.Forms.Button
    Friend WithEvents FilesListBackcolorLabel As System.Windows.Forms.Label
    Friend WithEvents FilesListBackcolorView As System.Windows.Forms.PictureBox
    Friend WithEvents ChangePlayerBackColorButton As System.Windows.Forms.Button
    Friend WithEvents PlayerBackcolorLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerBackcolorView As System.Windows.Forms.PictureBox
    Friend WithEvents SetDefaultSettingsButton As System.Windows.Forms.Button
    Friend WithEvents RestoreDefaultsLabel As System.Windows.Forms.Label
End Class
