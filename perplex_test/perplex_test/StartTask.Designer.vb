﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.FileList = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(96, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filename/Path: C://somePath/"
        '
        'CancelStartTaskButton
        '
        Me.CancelStartTaskButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CancelStartTaskButton.Location = New System.Drawing.Point(351, 214)
        Me.CancelStartTaskButton.Name = "CancelStartTaskButton"
        Me.CancelStartTaskButton.Size = New System.Drawing.Size(99, 23)
        Me.CancelStartTaskButton.TabIndex = 8
        Me.CancelStartTaskButton.Text = "Cancel"
        Me.CancelStartTaskButton.UseVisualStyleBackColor = True
        '
        'FileList
        '
        Me.FileList.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FileList.FormattingEnabled = True
        Me.FileList.Location = New System.Drawing.Point(351, 143)
        Me.FileList.Name = "FileList"
        Me.FileList.Size = New System.Drawing.Size(304, 23)
        Me.FileList.TabIndex = 9
        '
        'StartTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FileList)
        Me.Controls.Add(Me.CancelStartTaskButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StartTask"
        Me.Text = "Start Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CancelStartTaskButton As Button
    Friend WithEvents FileList As ComboBox
End Class
