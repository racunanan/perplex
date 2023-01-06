Imports System.Diagnostics

Public Class Form1

    Public Value As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub proccess_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        On Error Resume Next
        If e.Data = "" Then
        Else
            Value = e.Data
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("cmd.exe", "dir")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        'oProcess.StartInfo.CreateNoWindow = True ' to hide cmd window. and it's has to be here,before start and before startinfo=startinfo
        oProcess.Start()

        Dim sOutput As String


        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        Console.WriteLine(sOutput)
        TextBox1.Text = sOutput
        Debug.Print(sOutput)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("python", "jsontranslator.py")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.StartInfo.CreateNoWindow = True ' to hide cmd window. and it's has to be here,before start and before startinfo=startinfo
        oProcess.Start()

        Dim sOutput As String

        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        Console.WriteLine(sOutput)
        TextBox1.Text = sOutput
        Debug.Print(sOutput)
    End Sub
End Class