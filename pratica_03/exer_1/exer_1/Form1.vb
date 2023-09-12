Public Class Form1
    Dim data_received As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_box_send.Text = "My first message!"
    End Sub

    Private Sub btn_configure_Click(sender As Object, e As EventArgs) Handles btn_configure.Click
        With SerialPort1
            .PortName = "COM1"
            .BaudRate = 9600
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .Encoding = System.Text.Encoding.UTF8
        End With
    End Sub

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            btn_open.Text = "Open Port"
            btn_open.BackColor = Color.LightGray
        Else
            SerialPort1.Open()
            btn_open.Text = "close port"
            btn_open.BackColor = Color.Red

        End If
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        SerialPort1.Write(txt_box_send.Text)
    End Sub

    Private Sub btn_receive_Click(sender As Object, e As EventArgs) Handles btn_receive.Click
        data_received = data_received & SerialPort1.ReadExisting
        txt_box_receive.Text = data_received
        data_received = ""
    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub
End Class
