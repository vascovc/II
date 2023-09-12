Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Public Class Form1
    Dim local_address As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim server As New TcpListener(local_address, 81)
    Dim connection As New TcpClient

    Dim fs As New FaconSvr.FaconServer
    Dim is_fs_connected As Boolean = False
    Dim CSG As String = "Channel0.Station0.Group0"

    Dim stream As NetworkStream
    Dim caminho_para_pasta_html As String = "C:\Users\Vasco Costa\Documents\MEGAsync\4-2\II\pratica_10\"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server.Start()
        Timer1.Interval = 100

        Timer1.Enabled = True
        Me.Text = "Servidor"

        fs.OpenProject("C:\Users\Vasco Costa\Documents\MEGAsync\4-2\II\pratica_10\facon.fcs")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If server.Pending() Then
            connection = server.AcceptTcpClient()
            stream = connection.GetStream
        End If
        If connection.Connected Then
            Dim caracteres_disponiveis As Integer
            caracteres_disponiveis = connection.Available
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
            If texto_recebido.Length > 1 Then
                Dim primeira_linha = texto_recebido.Substring(0, texto_recebido.IndexOf(vbCrLf))
                Dim itens_primeira_linha = primeira_linha.Split(" ")
                Dim metodo = itens_primeira_linha(0)
                Dim caminho = itens_primeira_linha(1)

                txt_receber.Text = texto_recebido

                If InStr(primeira_linha, "Y0=1") Then
                    fs.SetItem(CSG, "Y0", 1)
                ElseIf InStr(primeira_linha, "Y0=0") Then
                    fs.SetItem(CSG, "Y0", 0)
                    ' Vamos dar set a items ao Y1
                ElseIf InStr(primeira_linha, "Y1=1") Then
                    fs.SetItem(CSG, "Y1", 1)
                ElseIf InStr(primeira_linha, "Y1=0") Then
                    fs.SetItem(CSG, "Y1", 0)
                    ' Vamos dar set a items ao Y2
                ElseIf InStr(primeira_linha, "Y2=1") Then
                    fs.SetItem(CSG, "Y2", 1)
                ElseIf InStr(primeira_linha, "Y2=0") Then
                    fs.SetItem(CSG, "Y2", 0)
                End If

                If InStr(caminho, "Supervisao.html") Then
                    Enviar_Ficheiro(caminho_para_pasta_html + "Supervisao.html")
                ElseIf InStr(caminho, "Controlo.html") Then
                    Enviar_Ficheiro(caminho_para_pasta_html + "Controlo.html")
                ElseIf InStr(caminho, "Reservatorio.html") Then
                    Enviar_Ficheiro(caminho_para_pasta_html + "Reservatorio.html")
                ElseIf InStr(caminho, "Reservatorio2.html") Then
                    Enviar_Ficheiro(caminho_para_pasta_html + "Reservatorio2.html")
                ElseIf InStr(caminho, "Rodape.html") Then
                    Enviar_Ficheiro(caminho_para_pasta_html + "Rodape.html")
                ElseIf InStr(caminho, "Logo.html") Then
                    Enviar_Ficheiro(caminho_para_pasta_html + "Logo.html")
                End If
            End If
            connection.Close()
            connection = New TcpClient
        End If

        chb_x0.CheckState = fs.GetItem(CSG, "X0")
        chb_x1.CheckState = fs.GetItem(CSG, "X1")
        chb_x2.CheckState = fs.GetItem(CSG, "X2")
        chb_x3.CheckState = fs.GetItem(CSG, "X3")
        chb_y0.CheckState = fs.GetItem(CSG, "Y0")
        chb_y1.CheckState = fs.GetItem(CSG, "Y1")
        chb_y2.CheckState = fs.GetItem(CSG, "Y2")
    End Sub
    Private Sub Enviar_Ficheiro(ByVal caminho_do_ficheiro As String)
        If connection.Connected Then
            Dim stream_do_ficheiro As StreamReader = New StreamReader(caminho_do_ficheiro)
            Dim string_do_ficheiro As String = stream_do_ficheiro.ReadToEnd
            stream_do_ficheiro.Close()

            Dim v_a_mon() As String = {"X0", "X1", "X2", "X3", "Y0", "Y1", "Y2"}

            Dim X0 = Mid(fs.GetItem(CSG, "X0"), 1, 1)
            Dim X1 = Mid(fs.GetItem(CSG, "X1"), 1, 1)
            Dim X2 = Mid(fs.GetItem(CSG, "X2"), 1, 1)
            Dim X3 = Mid(fs.GetItem(CSG, "X3"), 1, 1)
            Dim Y0 = Mid(fs.GetItem(CSG, "Y0"), 1, 1)
            Dim Y1 = Mid(fs.GetItem(CSG, "Y1"), 1, 1)
            Dim Y2 = Mid(fs.GetItem(CSG, "Y2"), 1, 1)

            string_do_ficheiro = Replace(string_do_ficheiro, "VALORX0", X0)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORX1", X1)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORX2", X2)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORX3", X3)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORY0", Y0)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORY1", Y1)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORY2", Y2)

            Dim header = "HTTP/1.1 200 OK" + vbNewLine + "Content-Type: text/html; charset=utf-8" + vbNewLine + vbNewLine
            Dim reply = header + string_do_ficheiro
            Dim reply_bytes() As Byte = Encoding.UTF8.GetBytes(reply)
            stream.Write(reply_bytes, 0, reply_bytes.Length)
        End If

    End Sub
End Class
