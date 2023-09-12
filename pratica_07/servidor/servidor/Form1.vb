Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim local_address As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim server As New TcpListener(local_address, 81)
    Dim connection As New TcpClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server.Start()
        timer_receive.Enabled = True
        timer_send.Enabled = True
        timer_verify_connection.Enabled = True
        txt_vel_read.Text = "0"
        Me.Text = "Servidor"
    End Sub

    Private Sub timer_receive_Tick(sender As Object, e As EventArgs) Handles timer_receive.Tick
        If server.Pending Then
            connection = server.AcceptTcpClient()
        End If
        If connection.Connected Then
            Dim message_size As Integer = connection.Available
            If message_size > 0 Then
                Dim message_in_stream As NetworkStream = connection.GetStream
                Dim buffer(5000) As Byte
                message_in_stream.Read(buffer, 0, message_size)

                Dim message_in As String = ""
                Dim i As Integer
                For i = 0 To message_size - 1
                    message_in += Chr(buffer(i))
                Next i
                txt_receber.Text = message_in + vbCrLf + txt_receber.Text

                chb_y0.Checked = Mid(message_in, 1, 1)
                chb_y1.Checked = Mid(message_in, 2, 1)
                chb_y2.Checked = Mid(message_in, 3, 1)
                txt_vel.Text = Asc(Mid(message_in, 4, 1))
            End If
        End If
    End Sub

    Private Sub timer_send_Tick(sender As Object, e As EventArgs) Handles timer_send.Tick
        If connection.Connected Then
            Dim buffer(5) As Byte
            buffer(0) = chb_x0.CheckState + 48
            buffer(1) = chb_x1.CheckState + 48
            buffer(2) = chb_x2.CheckState + 48
            buffer(3) = chb_x3.CheckState + 48
            If txt_vel_read.Text <> "" Then
                buffer(4) = CInt(txt_vel_read.Text)
            End If

            Dim message_out_stream As NetworkStream
            message_out_stream = connection.GetStream
            message_out_stream.Write(buffer, 0, 5)
        End If
    End Sub

    Private Sub timer_verify_connection_Tick(sender As Object, e As EventArgs) Handles timer_verify_connection.Tick
        txt_connected.Text = connection.Connected
    End Sub

End Class
