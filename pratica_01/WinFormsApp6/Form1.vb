Imports System.IO
Imports System.Xml

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim fileToSave As StreamWriter
        fileToSave = New StreamWriter(txtPath.Text, True)
        fileToSave.Write("Olá")
        fileToSave.Close()
    End Sub
    Private Sub button_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim result As Integer
        result = OpenFileDialog1.ShowDialog()
        If result = 1 Then
            Dim file As StreamReader
            file = New StreamReader(OpenFileDialog1.FileName)
            RichTextBox2.Text = file.ReadToEnd()
            file.Close()
        End If
    End Sub
End Class
