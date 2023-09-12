' Imports
Imports MySql.Data.MySqlClient

Public Class Form1

    ' Definir objetos globais
    Dim cn As New MySqlConnection ' Ligação
    Dim cmd As New MySqlCommand ' Manda comandos
    Dim data_reader As MySqlDataReader ' Recebe respostas

    ' Botão para dar connect
    Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connect.Click

        ' Configurar o obj tipo cn
        cn.ConnectionString = "Server=localhost; User Id=root; Password=Asdfghjkl0; Database=alunos"

        ' Verificações de erros de ligação
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

    ' Botão para ler a BD
    Private Sub btn_LerBD_Click(sender As Object, e As EventArgs) Handles btn_LerBD.Click

        ' Leitura sequencial dos dados existentes na base de dados
        Dim str As String
        'Selecção da tabela da base de dados para leitura dos dados
        cmd.CommandText = "SELECT * FROM dados_alunos"
        data_reader = cmd.ExecuteReader
        ' Leitura sequencial da tabela.. Guarda o conteúdo dos registos na variável str
        While data_reader.Read
            str = str & data_reader("id") & vbTab & data_reader("nome") & vbTab & data_reader("telefone") & vbCrLf
        End While
        txt_Ver.Text = str ' Visualiza os dados de todos os registos
        data_reader.Close()

    End Sub

    ' Botão para inserir Registo
    Private Sub btn_InserirReg_Click(sender As Object, e As EventArgs) Handles btn_InserirReg.Click

        ' Insere Registo numa Base de Dados
        cmd.CommandText = "Insert into dados_alunos(id, nome, telefone) Values('" & txt_Id.Text & "','" &
        txt_Nome.Text & "','" & txt_tel.Text & "')"
        cmd.ExecuteNonQuery()

    End Sub

    'Botão para ler um registo
    Private Sub btn_LerReg_Click(sender As Object, e As EventArgs) Handles btn_LerReg.Click

        ' Leitura de um Registo Especifico
        Dim str As String
        ' Procura do Registo pretendido
        cmd.CommandText = "Select * From dados_alunos Where id='" & txt_Id.Text & "'"
        'cmd.CommandText = "Select * From alunos_telef Where nome='xx' "
        data_reader = cmd.ExecuteReader
        ' Leitura do Registo
        data_reader.Read()
        txt_Nome.Text = data_reader("nome")
        txt_tel.Text = data_reader("telefone")
        data_reader.Close()

    End Sub

    ' Botão para atualziar um registo
    Private Sub btn_UpdateReg_Click(sender As Object, e As EventArgs) Handles btn_UpdateReg.Click

        ' Update de um registo existente
        cmd.CommandText = "UPDATE dados_alunos Set nome='" & txt_Nome.Text & "', telefone='" & txt_tel.Text &
        "' where id='" & CInt(txt_Id.Text) & "'"
        cmd.ExecuteNonQuery()

    End Sub

    ' Botão para eliminar registo
    Private Sub btn_EliminarReg_Click(sender As Object, e As EventArgs) Handles btn_EliminarReg.Click

        ' Apagar Registo através da chave de indexação
        cmd.CommandText = "Delete From dados_al Where id='" & txt_Id.Text & "' "
        cmd.ExecuteNonQuery()

    End Sub

    ' Botão para terminar
    Private Sub btn_Terminar_Click(sender As Object, e As EventArgs) Handles btn_Terminar.Click

        End ' Fim da aplicação

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Procura o registo com o max id
        cmd.CommandText = "Select max(id) From dados_alunos"
        ' executa o comando para leitura do máximo id do registo
        Dim total As Integer = cmd.ExecuteScalar
        txt_MaxIDalunos.Text = total.ToString

    End Sub

End Class
