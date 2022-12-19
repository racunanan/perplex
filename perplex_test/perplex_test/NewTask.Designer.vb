<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTask
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddNewTaskButton = New System.Windows.Forms.Button()
        Me.CancelNewTaskButton = New System.Windows.Forms.Button()
        Me.NewTaskList = New System.Windows.Forms.ComboBox()
        Me.AppListDropdown = New System.Windows.Forms.ComboBox()
        Me.AppListDropdown2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(85, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Transaction:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(85, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Source:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(85, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Destination:"
        '
        'AddNewTaskButton
        '
        Me.AddNewTaskButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddNewTaskButton.Location = New System.Drawing.Point(85, 309)
        Me.AddNewTaskButton.Name = "AddNewTaskButton"
        Me.AddNewTaskButton.Size = New System.Drawing.Size(140, 23)
        Me.AddNewTaskButton.TabIndex = 10
        Me.AddNewTaskButton.Text = "Add"
        Me.AddNewTaskButton.UseVisualStyleBackColor = True
        '
        'CancelNewTaskButton
        '
        Me.CancelNewTaskButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CancelNewTaskButton.Location = New System.Drawing.Point(580, 309)
        Me.CancelNewTaskButton.Name = "CancelNewTaskButton"
        Me.CancelNewTaskButton.Size = New System.Drawing.Size(140, 23)
        Me.CancelNewTaskButton.TabIndex = 11
        Me.CancelNewTaskButton.Text = "Cancel"
        Me.CancelNewTaskButton.UseVisualStyleBackColor = True
        '
        'NewTaskList
        '
        Me.NewTaskList.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NewTaskList.FormattingEnabled = True
        Me.NewTaskList.Location = New System.Drawing.Point(323, 98)
        Me.NewTaskList.Name = "NewTaskList"
        Me.NewTaskList.Size = New System.Drawing.Size(397, 29)
        Me.NewTaskList.TabIndex = 12
        '
        'AppListDropdown
        '
        Me.AppListDropdown.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AppListDropdown.FormattingEnabled = True
        Me.AppListDropdown.Location = New System.Drawing.Point(323, 176)
        Me.AppListDropdown.Name = "AppListDropdown"
        Me.AppListDropdown.Size = New System.Drawing.Size(397, 29)
        Me.AppListDropdown.TabIndex = 13
        '
        'AppListDropdown2
        '
        Me.AppListDropdown2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AppListDropdown2.FormattingEnabled = True
        Me.AppListDropdown2.Location = New System.Drawing.Point(323, 253)
        Me.AppListDropdown2.Name = "AppListDropdown2"
        Me.AppListDropdown2.Size = New System.Drawing.Size(397, 29)
        Me.AppListDropdown2.TabIndex = 14
        '
        'NewTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AppListDropdown2)
        Me.Controls.Add(Me.AppListDropdown)
        Me.Controls.Add(Me.NewTaskList)
        Me.Controls.Add(Me.CancelNewTaskButton)
        Me.Controls.Add(Me.AddNewTaskButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewTask"
        Me.Text = "New Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AddNewTaskButton As Button
    Friend WithEvents CancelNewTaskButton As Button
    Friend WithEvents NewTaskList As ComboBox
    Friend WithEvents AppListDropdown As ComboBox
    Friend WithEvents AppListDropdown2 As ComboBox
End Class
