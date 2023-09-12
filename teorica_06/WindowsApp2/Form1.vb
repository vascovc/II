Imports System.Net.Sockets

Public Class Form1
    Dim cliente As New TcpClient
    Dim msg_tx_rx As NetworkStream
    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        cliente.Connect("127.0.0.1", 85)
        If cliente.Connected Then
            msg_tx_rx = cliente.GetStream
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        label1.Text = cliente.Connected
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        Dim bb() As Byte = {48, 49, 50, 51}
        msg_tx_rx.Write(bb, 0, 4)
    End Sub

    Private Sub btn_desc_Click(sender As Object, e As EventArgs) Handles btn_desc.Click
        cliente.Close()
        cliente = New TcpClient
    End Sub
End Class
