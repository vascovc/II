Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Calculadora" 'A palavra Calculadora aparece na parte de cima da janela Form1
        BackgroundImage = Image.FromFile("C:\Users\Vasco\Documents\MEGAsync\4-2\II\pratica_01\ua-top-1.jpg") 'Esta passa a ser a imagem de fundo da janela Form1
        'BackgroundImageLayout = ImageLayout.Stretch
        Height = 200 'A janela Form1 ocupa 200 por 500 pixeis no écran
        Width = 500
        Icon = New Icon("C:\Users\Vasco\Documents\MEGAsync\4-2\II\pratica_01\ua-favicon.ico") ' Esta imagem "icon" aparece no canto superior da janela Form1
        'Propriedade da TextBox1
        'A caixa de texto TextBox1, o seu canto superior esquerdo, tem as coordenadas X=50,Y=40
        TextBox1.Location = New Point(50, 40)
        TextBox1.Width = 100
        TextBox1.Height = 30
        TextBox2.Location = New Point(50, 120)
        TextBox2.Width = 100
        TextBox2.Height = 30
        TextBox3.Location = New Point(300, 75)
        TextBox3.Height = 100
        TextBox3.Width = 30
        Button1.Text = "+"
        Button1.BackColor = Color.Red 'O botao passa a ter a cor de fundo vermelha
        Button1.ForeColor = Color.Yellow 'e o texto a amarelo
        Button1.Location = New Point(175, 75)
        Button1.Visible = True
        Button1.Height = 40
        Button1.Width = 100
        Label1.Text = "X"
        Label1.BackColor = Color.Yellow 'A cor de fundo do Label1 passa a amarelo
        Label1.ForeColor = Color.Black 'e o texto que aparece no Label1, neste caso a letra X, passa preto
        Label1.Width = 100
        Label1.Location = New Point(50, 20)
        Label2.Text = "Y"
        Label2.BackColor = Color.Yellow
        Label2.ForeColor = Color.Black
        Label2.Width = 100
        Label2.Location = New Point(50, 100)
        Label3.Text = "Z"
        Label3.BackColor = Color.Yellow
        Label3.ForeColor = Color.Black
        Label3.Width = 100
        Label3.Location = New Point(300, 55)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Os conteúdos das caixas de texto da esquerda são convertidos em números inteiros
        ' e o resutado da sua soma é visulizado na caixa de texto da direita (textbox3)
        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            TextBox3.Text = CInt(TextBox1.Text) + CInt(TextBox2.Text)
        Else
            TextBox3.Text = "Erro! valores introduzidos nao numericos"
        End If
    End Sub
End Class
