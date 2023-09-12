Public Class Form1
    Dim operator_1 As String
    Dim operator_2 As String
    Dim operation As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerDate.Interval = 500
        TimerDate.Enabled = True
    End Sub

    Private Sub bt_sair_Click(sender As Object, e As EventArgs) Handles bt_sair.Click
        End
    End Sub
    Private Sub set_operation_and_operator(operation_arg As String, operator1_arg As String)
        operation = operation_arg
        operator_1 = operator1_arg

        txt_result.Text = ""
        txt_op_1.Text = operator_1
        txt_operation.Text = operation
    End Sub

    Private Sub bt_clear_Click(sender As Object, e As EventArgs) Handles bt_clear.Click
        txt_result.Text = ""
        txt_op_2.Text = ""
        txt_op_1.Text = ""
        txt_operation.Text = ""
    End Sub

    Private Sub bt_equal_Click(sender As Object, e As EventArgs) Handles bt_equal.Click
        operator_2 = txt_result.Text
        txt_op_2.Text = operator_2
        If IsNumeric(operator_1) And IsNumeric(operator_2) Then
            If operation = "+" Then
                txt_result.Text = CDbl(operator_1) + CDbl(operator_2)
            ElseIf operation = "-" Then
                txt_result.Text = CDbl(operator_1) - CDbl(operator_2)
            ElseIf operation = "*" Then
                txt_result.Text = CDbl(operator_1) * CDbl(operator_2)
            ElseIf operation = "/" Then
                txt_result.Text = CDbl(operator_1) / CDbl(operator_2)
            End If
        Else
            txt_result.Text = "Erro"
        End If
    End Sub

    Private Sub bt_1_Click(sender As Object, e As EventArgs) Handles bt_1.Click
        txt_result.Text = txt_result.Text + "1"
    End Sub
    Private Sub bt_2_Click(sender As Object, e As EventArgs) Handles bt_2.Click
        txt_result.Text = txt_result.Text + "2"
    End Sub
    Private Sub bt_3_Click(sender As Object, e As EventArgs) Handles bt_3.Click
        txt_result.Text = txt_result.Text + "3"
    End Sub
    Private Sub bt_4_Click(sender As Object, e As EventArgs) Handles bt_4.Click
        txt_result.Text = txt_result.Text + "4"
    End Sub
    Private Sub bt_5_Click(sender As Object, e As EventArgs) Handles bt_5.Click
        txt_result.Text = txt_result.Text + "5"
    End Sub
    Private Sub bt_6_Click(sender As Object, e As EventArgs) Handles bt_6.Click
        txt_result.Text = txt_result.Text + "6"
    End Sub
    Private Sub bt_7_Click(sender As Object, e As EventArgs) Handles bt_7.Click
        txt_result.Text = txt_result.Text + "7"
    End Sub
    Private Sub bt_8_Click(sender As Object, e As EventArgs) Handles bt_8.Click
        txt_result.Text = txt_result.Text + "8"
    End Sub
    Private Sub bt_9_Click(sender As Object, e As EventArgs) Handles bt_9.Click
        txt_result.Text = txt_result.Text + "9"
    End Sub
    Private Sub bt_0_Click(sender As Object, e As EventArgs) Handles bt_0.Click
        txt_result.Text = txt_result.Text + "0"
    End Sub

    Private Sub btn_soma_Click(sender As Object, e As EventArgs) Handles btn_soma.Click
        set_operation_and_operator("+", txt_result.Text)
    End Sub

    Private Sub btn_sub_Click(sender As Object, e As EventArgs) Handles btn_sub.Click
        set_operation_and_operator("-", txt_result.Text)
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        set_operation_and_operator("*", txt_result.Text)
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        set_operation_and_operator("/", txt_result.Text)
    End Sub

    Private Sub TimerDate_Tick_1(sender As Object, e As EventArgs) Handles TimerDate.Tick
        ToolStripStatusLabel1.Text = Format(Now, "HH:mm:ss")
    End Sub
End Class
