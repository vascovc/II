Imports System.IO

Public Class Form1
    Dim path As String = "C:\Users\Vasco\Documents\MEGAsync\4-2\II\pratica_02\"

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub btn_soma_Click(sender As Object, e As EventArgs) Handles btn_soma.Click
        If IsNumeric(txt_op_1.Text) And IsNumeric(txt_op_2.Text) Then
            txt_result.Text = CInt(txt_op_1.Text) + CInt(txt_op_2.Text)
        Else
            txt_result.Text = "Erro"
        End If
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        If IsNumeric(txt_op_1.Text) And IsNumeric(txt_op_2.Text) Then
            txt_result.Text = CInt(txt_op_1.Text) * CInt(txt_op_2.Text)
        Else
            txt_result.Text = "Erro"
        End If
    End Sub

    Private Sub btn_sub_Click(sender As Object, e As EventArgs) Handles btn_sub.Click
        If IsNumeric(txt_op_1.Text) And IsNumeric(txt_op_2.Text) Then
            txt_result.Text = CInt(txt_op_1.Text) - CInt(txt_op_2.Text)
        Else
            txt_result.Text = "Erro"
        End If
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        If IsNumeric(txt_op_1.Text) And IsNumeric(txt_op_2.Text) Then
            txt_result.Text = CInt(txt_op_1.Text) / CInt(txt_op_2.Text)
        Else
            txt_result.Text = "Erro"
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        FileOpen(1, path + "resultados.txt", OpenMode.Append)
        PrintLine(1, "Resultado = " + txt_result.Text)
        FileClose()
    End Sub

    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        txt_ficheiro.Text = ""
        FileOpen(1, path + "resultados.txt", OpenMode.Input)
        While (EOF(1) = False)
            txt_ficheiro.Text = txt_ficheiro.Text + LineInput(1) + vbCrLf
        End While
        FileClose()
    End Sub
End Class
