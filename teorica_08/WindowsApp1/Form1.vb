Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Dim espera_ligacao_tcp As New TcpListener(81)
    Dim ligacao_tcp As New TcpClient
    Dim mensagem As NetworkStream
    Dim caracteres(2000) As Byte
    Dim n_Caracteres As Integer
    Dim texto_recebido As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True
        espera_ligacao_tcp.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer

        If espera_ligacao_tcp.Pending() Then
            ligacao_tcp = espera_ligacao_tcp.AcceptTcpClient
            mensagem = ligacao_tcp.GetStream

        End If

        If ligacao_tcp.Connected Then
            n_Caracteres = ligacao_tcp.Available
        End If

        If n_Caracteres > 0 Then
            mensagem.Read(caracteres, 0, n_Caracteres)
            For i = 0 To n_Caracteres - 1
                texto_recebido += Chr(caracteres(i))
            Next i
            TextBox1.Text += TextBox1.Text + texto_recebido + vbCrLf
            Dim ss As String = "<html>Esta e uma pagina de teste</html>"
            Dim arraybytes() As Byte = Encoding.Default.GetBytes(ss)
            mensagem.Write(arraybytes, 0, Len(ss))
            ligacao_tcp.Close()
            ligacao_tcp = New TcpClient
            n_Caracteres = 0
            texto_recebido = ""
        End If
    End Sub
End Class
