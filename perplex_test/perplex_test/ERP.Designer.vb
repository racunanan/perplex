<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FileList = New System.Windows.Forms.ComboBox()
        Me.OpenFileButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FileList
        '
        Me.FileList.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FileList.FormattingEnabled = True
        Me.FileList.Location = New System.Drawing.Point(376, 179)
        Me.FileList.Name = "FileList"
        Me.FileList.Size = New System.Drawing.Size(304, 23)
        Me.FileList.TabIndex = 15
        '
        'OpenFileButton
        '
        Me.OpenFileButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OpenFileButton.Location = New System.Drawing.Point(376, 250)
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(99, 23)
        Me.OpenFileButton.TabIndex = 14
        Me.OpenFileButton.Text = "Open"
        Me.OpenFileButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(121, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Filename/Path: C://somePath/"
        '
        'ERP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FileList)
        Me.Controls.Add(Me.OpenFileButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ERP"
        Me.Text = "ERP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileList As ComboBox
    Friend WithEvents OpenFileButton As Button
    Friend WithEvents Label1 As Label
End Class
