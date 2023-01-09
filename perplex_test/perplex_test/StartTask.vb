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
            startButton.Enabled = True
        End If
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        ' Calling translation function
        GlobalVariables.filename = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        GlobalVariables.filepath = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName)

        If GlobalVariables.mode.Equals("Purchase Order (PO) Transfer: SAP to Oracle") Then
            translationLogic.sap2oracle(OpenFileDialog1.FileName)
        ElseIf GlobalVariables.mode.Equals("Purchase Order (PO) Transfer: SAP to Netsuite") Then
            translationLogic.sap2netsuite(OpenFileDialog1.FileName)
        ElseIf GlobalVariables.mode.Equals("Purchase Order (PO) Transfer: Oracle to Netsuite") Then
            translationLogic.oracle2netsuite(OpenFileDialog1.FileName)
        ElseIf GlobalVariables.mode.Equals("Purchase Order (PO) Transfer: Oracle to SAP") Then
            translationLogic.oracle2sap(OpenFileDialog1.FileName)
        End If
        Close()
    End Sub
End Class