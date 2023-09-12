Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim Y0 As Integer
    Dim Y1 As Integer
    Dim Y2 As Integer

    Dim client As New Sockets.TcpClient
    Dim ip_address As IPAddress = IPAddress.Parse("127.0.0.1")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerReceive.Interval = 100
        TimerReceive.Enabled = True
        timer_send.Interval = 100

    End Sub

    Private Sub ComunicaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComunicaçõesToolStripMenuItem.Click
        btn_y0.Enabled = True
        btn_y1.Enabled = True
        btn_y2.Enabled = True
        client.Connect(ip_address, 81)
        timer_send.Enabled = True

    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        Dim Y0 As Integer
        Dim Y1 As Integer
        Dim Y2 As Integer

        Dim X0 As Integer
        Dim X1 As Integer
        Dim X2 As Integer
        Dim X3 As Integer
        If client.Connected Then
            Dim available_bytes_to_read = client.Available
            If available_bytes_to_read > 0 Then
                Dim stream As NetworkStream = client.GetStream()
                Dim buffer(available_bytes_to_read) As Byte
                stream.Read(buffer, 0, available_bytes_to_read)

                Dim i As Integer
                Dim texto_recebido = ""
                For i = 0 To available_bytes_to_read - 1
                    texto_recebido += Chr(buffer(i))
                Next i

                X0 = Mid(texto_recebido, 1, 1)
                X1 = Mid(texto_recebido, 2, 1)
                X2 = Mid(texto_recebido, 3, 1)
                X3 = Mid(texto_recebido, 4, 1)
                Y0 = Mid(texto_recebido, 5, 1)
                Y1 = Mid(texto_recebido, 6, 1)
                Y2 = Mid(texto_recebido, 7, 1)

                chb_x0.Checked = X0
                chb_x1.Checked = X1
                chb_x2.Checked = X2
                chb_x3.Checked = X3

                chb_y0.Checked = Y0
                chb_y1.Checked = Y1
                chb_y2.Checked = Y2
            End If

            ToolStripStatusLabel1.Text = ""
            If X0 = 1 And X1 <> 1 Then
                ToolStripStatusLabel1.Text = "Vazio!!!"
            End If
            If X3 = 1 Then
                ToolStripStatusLabel1.Text = "Cheio!!!"
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        client.Close()
        End
    End Sub

    Private Sub btn_y0_Click(sender As Object, e As EventArgs) Handles btn_y0.Click
        Y0 = If(Y0 = 1, 0, 1)
    End Sub

    Private Sub btn_y1_Click(sender As Object, e As EventArgs) Handles btn_y1.Click
        Y1 = If(Y1 = 1, 0, 1)
    End Sub

    Private Sub btn_y2_Click(sender As Object, e As EventArgs) Handles btn_y2.Click
        Y2 = If(Y2 = 1, 0, 1)
    End Sub

    Private Sub timer_send_Tick(sender As Object, e As EventArgs) Handles timer_send.Tick
        Dim bb() As Byte = {48, 48, 48}
        bb(0) = Convert.ToInt32(Y0) + 48
        bb(1) = Convert.ToInt32(Y1) + 48
        bb(2) = Convert.ToInt32(Y2) + 48

        If client.Connected Then
            Dim stream As NetworkStream = client.GetStream()
            stream.Write(bb, 0, 3)
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        client.Close()
    End Sub
End Class
