Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim ip_address As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim client As New TcpClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_desligar.Enabled = False
        btn_ligar.Enabled = True
        txt_vel.Text = "0"
        Me.Text = "cliente"
    End Sub

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        If client.Connected Then
            Dim buffer(5) As Byte
            buffer(0) = chb_Y0.CheckState + 48
            buffer(1) = chb_Y1.CheckState + 48
            buffer(2) = chb_Y2.CheckState + 48
            If txt_vel.Text <> "" Then
                buffer(3) = CInt(txt_vel.Text)
            End If


            Dim message_out_stream As NetworkStream
            message_out_stream = client.GetStream
            message_out_stream.Write(buffer, 0, 4)
        End If
    End Sub

    Private Sub timer_receive_Tick(sender As Object, e As EventArgs) Handles timer_receive.Tick
        txt_connection_status.Text = client.Connected
        If client.Connected Then
            Dim message_size As Integer = client.Available
            If message_size > 0 Then
                Dim message_in_stream As NetworkStream = client.GetStream
                Dim buffer(5000) As Byte
                message_in_stream.Read(buffer, 0, message_size)

                Dim message_in As String = ""
                Dim i As Integer
                For i = 0 To message_size - 1
                    message_in += Chr(buffer(i))
                Next i

                chb_X0.Checked = Mid(message_in, 1, 1)
                chb_X1.Checked = Mid(message_in, 2, 1)
                chb_X2.Checked = Mid(message_in, 3, 1)
                chb_X3.Checked = Mid(message_in, 4, 1)
                txt_vel_read.Text = Asc(Mid(message_in, 5, 1))


            End If
        End If
    End Sub

    Private Sub btn_desligar_Click(sender As Object, e As EventArgs) Handles btn_desligar.Click
        client.Close()
        client = New TcpClient
        btn_ligar.Enabled = True
        btn_desligar.Enabled = False
        timer_receive.Enabled = False
    End Sub

    Private Sub btn_ligar_Click(sender As Object, e As EventArgs) Handles btn_ligar.Click
        client.Connect(ip_address, 81)
        btn_ligar.Enabled = False
        btn_desligar.Enabled = True
        timer_receive.Enabled = True
    End Sub
End Class
