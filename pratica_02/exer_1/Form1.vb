Public Class Form1
    Private Sub bnt_sair_Click(sender As Object, e As EventArgs) Handles bnt_sair.Click
        End
    End Sub

    Private Sub btn_soma_Click(sender As Object, e As EventArgs) Handles btn_soma.Click
        If IsNumeric(txt_op_1.Text) And IsNumeric(txt_op_2.Text) Then
            txt_result.Text = CInt(txt_op_1.Text) + CInt(txt_op_2.Text)
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

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        If IsNumeric(txt_op_1.Text) And IsNumeric(txt_op_2.Text) Then
            txt_result.Text = CInt(txt_op_1.Text) * CInt(txt_op_2.Text)
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
End Class
