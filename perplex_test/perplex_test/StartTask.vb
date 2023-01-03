Imports System.Threading

Public Class StartTask
    Private Sub StartTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPage.Enabled = False
        SelectFileBtn.Enabled = False
    End Sub
    Private Sub StartTask_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        MainPage.Enabled = True
    End Sub

    Private Sub CancelStartTaskButton_Click(sender As Object, e As EventArgs) Handles CancelStartTaskButton.Click
        Close()
    End Sub

    Private Sub SelectFolderBtn_Click(sender As Object, e As EventArgs) Handles SelectFolderBtn.Click
        If FolderBrowserDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FolderPath.Text = FolderBrowserDialog1.SelectedPath
            OpenFileDialog1.InitialDirectory = FolderBrowserDialog1.SelectedPath
            SelectFileBtn.Enabled = True
        End If
    End Sub

    Private Sub SelectFileBtn_Click(sender As Object, e As EventArgs) Handles SelectFileBtn.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Filename.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class