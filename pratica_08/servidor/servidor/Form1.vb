Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim local_address As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim server As New TcpListener(local_address, 81)
    Dim connection As New TcpClient

    Dim fs As New FaconSvr.FaconServer
    Dim is_fs_connected As Boolean = False
    Dim CSG As String = "Channel0.Station0.Group0"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server.Start()
        'timer_receive.Interval = 100
        'timer_send.Interval = 100
        Timer1.Interval = 100

        'timer_receive.Enabled = True
        'timer_send.Enabled = True
        Timer1.Enabled = True
        Me.Text = "Servidor"

        fs.OpenProject("C:\Users\Vasco\Documents\MEGAsync\4-2\II\pratica_08\facon.fcs")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If server.Pending() Then
            connection = server.AcceptTcpClient()
        End If

        If connection.Connected Then
            Dim message_size As Integer = connection.Available
            Dim stream As NetworkStream = connection.GetStream
            If message_size > 0 Then
                Dim buffer(5000) As Byte
                stream.Read(buffer, 0, message_size)

                Dim message_in As String = ""
                Dim i As Integer
                For i = 0 To message_size - 1
                    message_in += Chr(buffer(i))
                Next i
                txt_receber.Text = message_in + vbCrLf + txt_receber.Text
                Dim Y0, Y1, Y2 As String
                Y0 = Mid(message_in, 1, 1)
                Y1 = Mid(message_in, 2, 1)
                Y2 = Mid(message_in, 3, 1)

                fs.SetItem(CSG, "Y0", Y0)
                fs.SetItem(CSG, "Y1", Y1)
                fs.SetItem(CSG, "Y2", Y2)
            End If
        End If

        chb_x0.CheckState = fs.GetItem(CSG, "X0")
        chb_x1.CheckState = fs.GetItem(CSG, "X1")
        chb_x2.CheckState = fs.GetItem(CSG, "X2")
        chb_x3.CheckState = fs.GetItem(CSG, "X3")
        chb_y0.CheckState = fs.GetItem(CSG, "Y0")
        chb_y1.CheckState = fs.GetItem(CSG, "Y1")
        chb_y2.CheckState = fs.GetItem(CSG, "Y2")
        If connection.Connected Then
            Dim status(7) As Byte
            status(0) = chb_x0.CheckState + 48
            status(1) = chb_x1.CheckState + 48
            status(2) = chb_x2.CheckState + 48
            status(3) = chb_x3.CheckState + 48
            status(4) = chb_y0.CheckState + 48
            status(5) = chb_y1.CheckState + 48
            status(6) = chb_y2.CheckState + 48
            Dim stream As NetworkStream = connection.GetStream
            stream.Write(status, 0, status.Length)
        End If
    End Sub
End Class
