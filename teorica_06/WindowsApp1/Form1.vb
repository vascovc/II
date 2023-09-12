Imports System.ComponentModel
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Public Class Form1
    Dim espera_ligacao As New TcpListener(85)
    Dim ligacao As New TcpClient
    Dim msg_tx_rx As NetworkStream
    Dim ss(1000) As Byte
    Dim n_bytes, i As UInteger

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If espera_ligacao.Pending = True Then
            ligacao = espera_ligacao.AcceptTcpClient
        End If
        n_bytes = ligacao.Available
        If n_bytes > 0 Then
            msg_tx_rx = ligacao.GetStream
            msg_tx_rx.Read(ss, 0, n_bytes)

            TextBox1.Text = Encoding.Default.GetChars(ss)
            msg_tx_rx.Write(ss, 0, n_bytes)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        espera_ligacao.Start()
        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub
End Class
