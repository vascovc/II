Public Class Form1
    Dim data_received As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_send.Text = "my first message"

        TimerReceive.Interval = 300
        TimerReceive.Enabled = False 'only tic when open
        Module_com_port_parameters.configuration_is_valid = False
        btn_send.Enabled = False
        btn_open.Enabled = False 'nao era preciso fazer isto, vai dar sempre como configurado por causa dos default indexes
    End Sub

    Private Sub btn_configure_Click(sender As Object, e As EventArgs) Handles btn_configure.Click
        form_configure_port.StartPosition = FormStartPosition.CenterParent
        form_configure_port.ShowDialog()

        If Module_com_port_parameters.configuration_is_valid = True Then
            With SerialPort1
                .PortName = Module_com_port_parameters.port
                .BaudRate = Module_com_port_parameters.baud_rate
                .Parity = Module_com_port_parameters.parity
            End With
            btn_open.Enabled = True
        End If
    End Sub

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        If Module_com_port_parameters.configuration_is_valid = True Then
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
                btn_open.Text = "Open Port"
                btn_open.BackColor = Color.LightGray
                TimerReceive.Enabled = False
                btn_send.Enabled = False
            Else
                SerialPort1.Open()
                btn_open.Text = "close port"
                btn_open.BackColor = Color.Red
                TimerReceive.Enabled = True
                btn_send.Enabled = True
            End If

        Else
            MsgBox("Cannot open port with an invalid configuration")
        End If
    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        data_received = data_received & SerialPort1.ReadExisting
        If Len(data_received) > 0 Then
            txt_receive.Text = data_received
            txt_history.Text = TimeOfDay.ToLongTimeString + ":" + data_received + vbNewLine + txt_history.Text
            data_received = ""
        End If
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        SerialPort1.Write(txt_send.Text)
    End Sub
End Class
