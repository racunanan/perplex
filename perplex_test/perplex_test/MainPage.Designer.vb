<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AppsTab = New System.Windows.Forms.TabPage()
        Me.AddAppButton = New System.Windows.Forms.Button()
        Me.RemoveAppButton = New System.Windows.Forms.Button()
        Me.ActiveApps = New System.Windows.Forms.ListBox()
        Me.TasksTab = New System.Windows.Forms.TabPage()
        Me.Username = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.AppsTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AppsTab)
        Me.TabControl1.Controls.Add(Me.TasksTab)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(840, 457)
        Me.TabControl1.TabIndex = 0
        '
        'AppsTab
        '
        Me.AppsTab.Controls.Add(Me.AddAppButton)
        Me.AppsTab.Controls.Add(Me.RemoveAppButton)
        Me.AppsTab.Controls.Add(Me.ActiveApps)
        Me.AppsTab.Location = New System.Drawing.Point(4, 24)
        Me.AppsTab.Name = "AppsTab"
        Me.AppsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AppsTab.Size = New System.Drawing.Size(832, 429)
        Me.AppsTab.TabIndex = 0
        Me.AppsTab.Text = "Applications"
        Me.AppsTab.UseVisualStyleBackColor = True
        '
        'AddAppButton
        '
        Me.AddAppButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddAppButton.Location = New System.Drawing.Point(164, 280)
        Me.AddAppButton.Name = "AddAppButton"
        Me.AddAppButton.Size = New System.Drawing.Size(136, 26)
        Me.AddAppButton.TabIndex = 3
        Me.AddAppButton.Text = "Add Application"
        Me.AddAppButton.UseVisualStyleBackColor = True
        '
        'RemoveAppButton
        '
        Me.RemoveAppButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RemoveAppButton.Location = New System.Drawing.Point(515, 280)
        Me.RemoveAppButton.Name = "RemoveAppButton"
        Me.RemoveAppButton.Size = New System.Drawing.Size(136, 26)
        Me.RemoveAppButton.TabIndex = 2
        Me.RemoveAppButton.Text = "Remove Application"
        Me.RemoveAppButton.UseVisualStyleBackColor = True
        '
        'ActiveApps
        '
        Me.ActiveApps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActiveApps.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ActiveApps.FormattingEnabled = True
        Me.ActiveApps.ItemHeight = 30
        Me.ActiveApps.Location = New System.Drawing.Point(73, 44)
        Me.ActiveApps.Name = "ActiveApps"
        Me.ActiveApps.Size = New System.Drawing.Size(675, 214)
        Me.ActiveApps.TabIndex = 0
        '
        'TasksTab
        '
        Me.TasksTab.Location = New System.Drawing.Point(4, 24)
        Me.TasksTab.Name = "TasksTab"
        Me.TasksTab.Padding = New System.Windows.Forms.Padding(3)
        Me.TasksTab.Size = New System.Drawing.Size(832, 429)
        Me.TasksTab.TabIndex = 1
        Me.TasksTab.Text = "Tasks"
        Me.TasksTab.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Username.Location = New System.Drawing.Point(752, 11)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(87, 21)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 481)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximumSize = New System.Drawing.Size(880, 520)
        Me.MinimumSize = New System.Drawing.Size(880, 520)
        Me.Name = "MainPage"
        Me.Text = "pERPlex"
        Me.TabControl1.ResumeLayout(False)
        Me.AppsTab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AppsTab As TabPage
    Friend WithEvents TasksTab As TabPage
    Friend WithEvents Username As Label
    Friend WithEvents ActiveApps As ListBox
    Friend WithEvents AddAppButton As Button
    Friend WithEvents RemoveAppButton As Button
End Class
