Imports System.Threading

Public Class StartTask
    Dim files() As String = {"file1.json", "file2.json", "file3.json"}

    Private Sub StartTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPage.Enabled = False

        For Each item In files
            FileList.Items.Add(item)
        Next
    End Sub
    Private Sub StartTask_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        MainPage.Enabled = True
    End Sub

    Private Sub CancelStartTaskButton_Click(sender As Object, e As EventArgs) Handles CancelStartTaskButton.Click
        Close()
    End Sub


End Class