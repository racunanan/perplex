<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppList
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
        Me.AvailableApps = New System.Windows.Forms.ListBox()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AvailableApps
        '
        Me.AvailableApps.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AvailableApps.FormattingEnabled = True
        Me.AvailableApps.ItemHeight = 21
        Me.AvailableApps.Location = New System.Drawing.Point(66, 36)
        Me.AvailableApps.Name = "AvailableApps"
        Me.AvailableApps.Size = New System.Drawing.Size(520, 130)
        Me.AvailableApps.TabIndex = 0
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CancelBtn.Location = New System.Drawing.Point(373, 198)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(99, 23)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddButton.Location = New System.Drawing.Point(161, 198)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(99, 23)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'AppList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 296)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.AvailableApps)
        Me.MaximumSize = New System.Drawing.Size(675, 335)
        Me.MinimumSize = New System.Drawing.Size(675, 335)
        Me.Name = "AppList"
        Me.Text = "Application List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AvailableApps As ListBox
    Friend WithEvents CancelBtn As Button
    Friend WithEvents AddButton As Button
End Class
