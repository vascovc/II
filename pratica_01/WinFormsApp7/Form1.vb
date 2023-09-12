Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Bloco de notas"
        LastOperationStatusLabel.Text = ""
        OpenFileDialog1.Filter = "Ficheiros de texto|*.txt"
        OpenFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Ficheiros de texto|*.txt"
        UpdateLastChange("")
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim result = OpenFileDialog1.ShowDialog()
        If result = 1 Then
            Dim fileToOpen = New StreamReader(OpenFileDialog1.FileName)
            txtBox.Text = fileToOpen.ReadToEnd()
            Me.Text = OpenFileDialog1.FileName
            UpdateLastChange("Ficheiro aberto com sucesso.")
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If txtBox.Text.Length = 0 Then
            UpdateLastChange("Não existem dados a guardar no ficheiro.")
            Return
        End If
        SaveFileDialog1.FileName = OpenFileDialog1.FileName
        Dim result = SaveFileDialog1.ShowDialog()
        If result = 1 Then
            Dim fileToSave As StreamWriter
            fileToSave = New StreamWriter(SaveFileDialog1.FileName, False)
            fileToSave.Write(txtBox.Text)
            fileToSave.Close()
            Me.Text = SaveFileDialog1.FileName
            UpdateLastChange("Ficheiro guardado com sucesso")
        End If
    End Sub
    Private Sub UpdateLastChange(status)
        LastChangeStatusLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        LastOperationStatusLabel.Text = status
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class