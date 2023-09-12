Imports MySql.Data.MySqlClient

Public Class Form1
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim data_reader As MySqlDataReader

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        cn.ConnectionString = "Server=localhost;User Id=root;Password=;Database=alunos"

        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
                MsgBox("Ligação Correcta à Base de Dados alunos...")
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox("Ligação Incorrecta à Base de Dados alunos...")
        End Try
        cmd.Connection = cn
    End Sub

    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        Dim str As String
        'Selecção da tabela da base de dados para leitura dos dados
        cmd.CommandText = "SELECT * FROM dados_al"
        data_reader = cmd.ExecuteReader
        ' Leitura sequencial da tabela.. Guarda o conteúdo dos registos na variável str
        While data_reader.Read
            str = str & data_reader("idDados_Al") & vbTab & data_reader("Nome") & vbTab & data_reader("Telefone") & vbCrLf
        End While
        txt_Ver.Text = str ' Visualiza os dados de todos os registos
        data_reader.Close()

    End Sub
End Class
