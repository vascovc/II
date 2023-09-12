Imports System.Reflection.Emit

Public Class Form1
    Dim aa As String = "global"
    Dim i As Integer = 0

    Private Sub bt_change_form_Click(sender As Object, e As EventArgs) Handles bt_change_form.Click
        'Dim bb As String = "Local"
        'TextBox1.Text = bb
        For i = 0 To 3 Step 1
            TextBox1.Text = TextBox1.Text + CStr(i)
        Next

        If (i = 3) Then
            TextBox1.Text = "i = " + CStr(i)
        End If

        If (i = 4) Then
            TextBox1.Text = "i = " + CStr(i)
        End If

        Form2.ShowDialog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = sss

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Form2.TextBox1.Text
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TextBox1.Text = "adeus"
    End Sub
End Class
