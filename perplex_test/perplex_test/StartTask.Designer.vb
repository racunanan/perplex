<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartTask
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CancelStartTaskButton = New System.Windows.Forms.Button()
        Me.startButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderPath = New System.Windows.Forms.TextBox()
        Me.Filename = New System.Windows.Forms.TextBox()
        Me.SelectFolderBtn = New System.Windows.Forms.Button()
        Me.SelectFileBtn = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(34, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Folder: "
        '
        'CancelStartTaskButton
        '
        Me.CancelStartTaskButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CancelStartTaskButton.Location = New System.Drawing.Point(355, 130)
        Me.CancelStartTaskButton.Name = "CancelStartTaskButton"
        Me.CancelStartTaskButton.Size = New System.Drawing.Size(99, 23)
        Me.CancelStartTaskButton.TabIndex = 8
        Me.CancelStartTaskButton.Text = "Cancel"
        Me.CancelStartTaskButton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Enabled = False
        Me.startButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.startButton.Location = New System.Drawing.Point(97, 130)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(99, 23)
        Me.startButton.TabIndex = 10
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(56, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Select File: "
        '
        'FolderPath
        '
        Me.FolderPath.Enabled = False
        Me.FolderPath.Location = New System.Drawing.Point(173, 25)
        Me.FolderPath.Name = "FolderPath"
        Me.FolderPath.Size = New System.Drawing.Size(248, 23)
        Me.FolderPath.TabIndex = 12
        '
        'Filename
        '
        Me.Filename.Enabled = False
        Me.Filename.Location = New System.Drawing.Point(173, 77)
        Me.Filename.Name = "Filename"
        Me.Filename.Size = New System.Drawing.Size(248, 23)
        Me.Filename.TabIndex = 13
        '
        'SelectFolderBtn
        '
        Me.SelectFolderBtn.Location = New System.Drawing.Point(439, 24)
        Me.SelectFolderBtn.Name = "SelectFolderBtn"
        Me.SelectFolderBtn.Size = New System.Drawing.Size(92, 23)
        Me.SelectFolderBtn.TabIndex = 14
        Me.SelectFolderBtn.Text = "Choose..."
        Me.SelectFolderBtn.UseVisualStyleBackColor = True
        '
        'SelectFileBtn
        '
        Me.SelectFileBtn.Location = New System.Drawing.Point(439, 76)
        Me.SelectFileBtn.Name = "SelectFileBtn"
        Me.SelectFileBtn.Size = New System.Drawing.Size(92, 23)
        Me.SelectFileBtn.TabIndex = 15
        Me.SelectFileBtn.Text = "Choose..."
        Me.SelectFileBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StartTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 187)
        Me.Controls.Add(Me.SelectFileBtn)
        Me.Controls.Add(Me.SelectFolderBtn)
        Me.Controls.Add(Me.Filename)
        Me.Controls.Add(Me.FolderPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.CancelStartTaskButton)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(591, 226)
        Me.MinimumSize = New System.Drawing.Size(591, 226)
        Me.Name = "StartTask"
        Me.Text = "Start Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CancelStartTaskButton As Button
    Friend WithEvents startButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderPath As TextBox
    Friend WithEvents Filename As TextBox
    Friend WithEvents SelectFolderBtn As Button
    Friend WithEvents SelectFileBtn As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
