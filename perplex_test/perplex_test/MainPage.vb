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

    Private Sub AddTaskButton_Click(sender As Object, e As EventArgs) Handles AddTaskButton.Click
        Dim newTask As New NewTask
        newTask.Show()
    End Sub

    Private Sub RemoveTaskButton_Click(sender As Object, e As EventArgs) Handles RemoveTaskButton.Click
        Dim item As String

        item = TaskList.GetItemText(TaskList.SelectedItem)
        TaskList.Items.Remove(item)
    End Sub

    Private Sub StartTaskButton_Click(sender As Object, e As EventArgs) Handles StartTaskButton.Click
        Dim startTask As New StartTask
        startTask.Show()
    End Sub

End Class
