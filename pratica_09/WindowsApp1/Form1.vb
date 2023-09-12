Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Dim local_address As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim server As New TcpListener(local_address, 81)
    Dim ligacao As New TcpClient
    Dim stream As NetworkStream

    Dim caminho_para_pasta_html As String = "C:\Users\Vasco\Documents\MEGAsync\4-2\II\pratica_09\"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If server.Pending Then
            ligacao = server.AcceptTcpClient()
            stream = ligacao.GetStream()
        End If
        If ligacao.Connected Then
            Dim caracteres_disponiveis As Integer
            caracteres_disponiveis = ligacao.Available
            If caracteres_disponiveis = 0 Then
                Return
            End If

            Dim caracteres(caracteres_disponiveis) As Byte

            stream.Read(caracteres, 0, caracteres_disponiveis)
            Dim texto_recebido As String

            Dim i As Integer
            texto_recebido = ""
            For i = 0 To caracteres_disponiveis - 1
                texto_recebido += Chr(caracteres(i))
            Next i

            'TextBox1.Text = TextBox1.Text + vbCrLf + texto_recebido
            TextBox1.Text = texto_recebido
            If texto_recebido.Length > 1 Then
                Dim primeira_linha = texto_recebido.Substring(0, texto_recebido.IndexOf(vbCrLf))
                Dim itens_primeira_linha = primeira_linha.Split(" ")
                Dim metodo = itens_primeira_linha(0)
                Dim caminho = itens_primeira_linha(1)

                If InStr(caminho, "Supervisao.html") Then
                    Enviar_ficheiro(caminho_para_pasta_html + "Supervisao.html")
                ElseIf InStr(caminho, "Controlo.html") Then
                    Enviar_ficheiro(caminho_para_pasta_html + "Controlo.html")
                ElseIf InStr(caminho, "Reservatorio.html") Then
                    Enviar_ficheiro(caminho_para_pasta_html + "Reservatorio.html")
                ElseIf InStr(caminho, "Reservatorio2.html") Then
                    Enviar_ficheiro(caminho_para_pasta_html + "Reservatorio2.html")
                ElseIf InStr(caminho, "Rodape.html") Then
                    Enviar_ficheiro(caminho_para_pasta_html + "Rodape.html")
                ElseIf InStr(caminho, "Logo.html") Then
                    Enviar_ficheiro(caminho_para_pasta_html + "Logo.html")
                End If
            End If
            ligacao.Close()
            ligacao = New TcpClient
        End If
    End Sub
    Private Sub Enviar_ficheiro(ByVal caminho_do_ficheiro As String)
        If ligacao.Connected Then
            Dim stream_do_ficheiro As StreamReader = New StreamReader(caminho_do_ficheiro)
            Dim string_do_ficheiro As String = stream_do_ficheiro.ReadToEnd

            Dim estado = "HTTP/1.1 200 OK"
            Dim cabecalho = "Content-Type: text/html; charser=utf-8"

            Dim resposta = estado + vbNewLine + cabecalho + vbNewLine + vbNewLine + string_do_ficheiro

            Dim bytes_enviar() As Byte = Encoding.UTF8.GetBytes(resposta)
            stream.Write(bytes_enviar, 0, bytes_enviar.Length)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server.Start()
        Timer1.Enabled = True
    End Sub
End Class
