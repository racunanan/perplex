Public Class MainPage
    Private Sub AddAppButton_Click(sender As Object, e As EventArgs) Handles AddAppButton.Click
        Dim appList As New AppList
        appList.Show()
    End Sub

    Private Sub RemoveAppButton_Click(sender As Object, e As EventArgs) Handles RemoveAppButton.Click
        Dim item As String

        item = ActiveApps.GetItemText(ActiveApps.SelectedItem)
        ActiveApps.Items.Remove(item)
    End Sub
End Class
