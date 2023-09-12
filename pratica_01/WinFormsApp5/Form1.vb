Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer
        ' Mostra ao utilizador a janela de diálogo
        ' Na janela de diálogo o utilizador pode retornar "Cancel"
        ' sem selecionar nenhum ficheiro.
        ' Se o ficheiro foi seleccionado a funçao retorna 1 caso contrário retorna 2
        result = OpenFileDialog1.ShowDialog()
        ' Se um ficheiro imagem foi seleccionado
        If result = 1 Then
            ' Quando o utilizador sai da janela de diálogo,
            ' o nome e a localização do ficheiro seleccionado
            ' está memorizado na propriedade "FileName"
            txtOpen.Text = OpenFileDialog1.FileName
        Else
            txtOpen.Text = "Nenhum ficheiro selecionado"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Filter: Quando a Janela de di·logo aparecer ao utilizador
        ' serao mostrados apenas os ficheiros com a extensao *.bmp
        OpenFileDialog1.Filter = "Ficherios de image|*.bmp|jpg|*.jpg"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.ShowDialog()
        txtSave.Text = SaveFileDialog1.FileName
    End Sub
End Class
