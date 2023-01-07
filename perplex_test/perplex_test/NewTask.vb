﻿
Public Class NewTask
    Dim apps() As String = {"SAP", "Oracle", "Netsuite"}
    Dim tasks() As String = {"Purchase Order (PO) Transfer"}

    Private Sub NewTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim status As Integer
        MainPage.Enabled = False

        For Each item In tasks
            NewTaskList.Items.Add(item)
        Next
        For Each item In apps
            AppListDropdown.Items.Add(item)
            status = My.Forms.MainPage.ActiveApps.FindString(item)
            If status = -1 Then
                AppListDropdown.Items.Remove(item)
            End If
        Next
        For Each item In apps
            AppListDropdown2.Items.Add(item)
            status = My.Forms.MainPage.ActiveApps.FindString(item)
            If status = -1 Then
                AppListDropdown2.Items.Remove(item)
            End If
        Next
    End Sub
    Private Sub NewTask_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        MainPage.Enabled = True
    End Sub
    Private Sub AddNewTaskButton_Click(sender As Object, e As EventArgs) Handles AddNewTaskButton.Click
        Dim NewTaskChosen As String
        Dim NewSourceChosen As String
        Dim NewDestinationChosen As String
        Dim AddedTask As String
        Dim SourceToDest As String

        NewTaskChosen = NewTaskList.GetItemText(NewTaskList.SelectedItem)
        NewSourceChosen = AppListDropdown.GetItemText(AppListDropdown.SelectedItem)
        NewDestinationChosen = AppListDropdown2.GetItemText(AppListDropdown2.SelectedItem)
        AddedTask = NewTaskChosen + ": " + NewSourceChosen + " to " + NewDestinationChosen
        SourceToDest = NewSourceChosen + " to " + NewDestinationChosen

        If AddedTask <> "" Then
            'If SourceToDest.Equals("SAP to Oracle") Then
            'GlobalVariables.mode = "1"
            'ElseIf SourceToDest.Equals("SAP to NetSuite") Then
            'balVariables.mode = "2"
            'ElseIf SourceToDest.Equals("Oracle to NetSuite") Then
            'GlobalVariables.mode = "3"
            'End If
            My.Forms.MainPage.TaskList.Items.Add(AddedTask)
            Close()
        End If

    End Sub

    Private Sub CancelNewTaskButton_Click(sender As Object, e As EventArgs) Handles CancelNewTaskButton.Click
        Close()
    End Sub

End Class

Public Class GlobalVariables
    Public Shared mode As String
End Class
