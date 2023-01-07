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

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("py", "./../jsontranslator.py ./../sap_files/sap_PO_example.json 1")
        'Dim oStartInfo As New ProcessStartInfo("py", "./../jsontranslator.py" + " " + OpenFileDialog1.FileName + " " + GlobalVariables.mode)
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.StartInfo.CreateNoWindow = True ' to hide cmd window. and it's has to be here,before start and before startinfo=startinfo
        oProcess.Start()
        Close()
    End Sub
End Class