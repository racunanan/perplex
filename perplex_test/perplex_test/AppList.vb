Public Class AppList
    Dim apps() As String = {"SAP", "Oracle", "Netsuite"}

    Private Sub AppList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim status As Integer

        MainPage.Enabled = False
        For Each item In apps
            status = My.Forms.MainPage.ActiveApps.FindString(item)
            If status = -1 Then
                AvailableApps.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub AppList_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        MainPage.Enabled = True
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim item As String

        item = AvailableApps.GetItemText(AvailableApps.SelectedItem)
        If item <> "" Then
            My.Forms.MainPage.ActiveApps.Items.Add(item)
            Close()
        End If
    End Sub
End Class