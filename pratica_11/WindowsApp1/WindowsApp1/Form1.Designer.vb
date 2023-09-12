<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Connect = New System.Windows.Forms.Button()
        Me.btn_LerBD = New System.Windows.Forms.Button()
        Me.txt_Ver = New System.Windows.Forms.TextBox()
        Me.btn_InserirReg = New System.Windows.Forms.Button()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.txt_Nome = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_LerReg = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_UpdateReg = New System.Windows.Forms.Button()
        Me.btn_EliminarReg = New System.Windows.Forms.Button()
        Me.btn_Terminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_MaxIDalunos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Connect
        '
        Me.btn_Connect.Location = New System.Drawing.Point(12, 12)
        Me.btn_Connect.Name = "btn_Connect"
        Me.btn_Connect.Size = New System.Drawing.Size(143, 81)
        Me.btn_Connect.TabIndex = 0
        Me.btn_Connect.Text = "Connect"
        Me.btn_Connect.UseVisualStyleBackColor = True
        '
        'btn_LerBD
        '
        Me.btn_LerBD.Location = New System.Drawing.Point(12, 99)
        Me.btn_LerBD.Name = "btn_LerBD"
        Me.btn_LerBD.Size = New System.Drawing.Size(143, 82)
        Me.btn_LerBD.TabIndex = 1
        Me.btn_LerBD.Text = "Ler Base Dados"
        Me.btn_LerBD.UseVisualStyleBackColor = True
        '
        'txt_Ver
        '
        Me.txt_Ver.Location = New System.Drawing.Point(172, 59)
        Me.txt_Ver.Multiline = True
        Me.txt_Ver.Name = "txt_Ver"
        Me.txt_Ver.Size = New System.Drawing.Size(264, 253)
        Me.txt_Ver.TabIndex = 2
        '
        'btn_InserirReg
        '
        Me.btn_InserirReg.Location = New System.Drawing.Point(12, 187)
        Me.btn_InserirReg.Name = "btn_InserirReg"
        Me.btn_InserirReg.Size = New System.Drawing.Size(143, 78)
        Me.btn_InserirReg.TabIndex = 3
        Me.btn_InserirReg.Text = "Inserir Registo"
        Me.btn_InserirReg.UseVisualStyleBackColor = True
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(94, 21)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(100, 22)
        Me.txt_Id.TabIndex = 4
        '
        'txt_Nome
        '
        Me.txt_Nome.Location = New System.Drawing.Point(94, 49)
        Me.txt_Nome.Name = "txt_Nome"
        Me.txt_Nome.Size = New System.Drawing.Size(100, 22)
        Me.txt_Nome.TabIndex = 5
        '
        'txt_tel
        '
        Me.txt_tel.Location = New System.Drawing.Point(94, 77)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(100, 22)
        Me.txt_tel.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tel"
        '
        'btn_LerReg
        '
        Me.btn_LerReg.Location = New System.Drawing.Point(13, 272)
        Me.btn_LerReg.Name = "btn_LerReg"
        Me.btn_LerReg.Size = New System.Drawing.Size(142, 66)
        Me.btn_LerReg.TabIndex = 10
        Me.btn_LerReg.Text = "Ler Registo"
        Me.btn_LerReg.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_Id)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Nome)
        Me.GroupBox1.Controls.Add(Me.txt_tel)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 174)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registo"
        '
        'btn_UpdateReg
        '
        Me.btn_UpdateReg.Location = New System.Drawing.Point(13, 345)
        Me.btn_UpdateReg.Name = "btn_UpdateReg"
        Me.btn_UpdateReg.Size = New System.Drawing.Size(142, 65)
        Me.btn_UpdateReg.TabIndex = 12
        Me.btn_UpdateReg.Text = "Update Registo"
        Me.btn_UpdateReg.UseVisualStyleBackColor = True
        '
        'btn_EliminarReg
        '
        Me.btn_EliminarReg.Location = New System.Drawing.Point(13, 417)
        Me.btn_EliminarReg.Name = "btn_EliminarReg"
        Me.btn_EliminarReg.Size = New System.Drawing.Size(142, 75)
        Me.btn_EliminarReg.TabIndex = 13
        Me.btn_EliminarReg.Text = "Apagar Registo"
        Me.btn_EliminarReg.UseVisualStyleBackColor = True
        '
        'btn_Terminar
        '
        Me.btn_Terminar.Location = New System.Drawing.Point(442, 424)
        Me.btn_Terminar.Name = "btn_Terminar"
        Me.btn_Terminar.Size = New System.Drawing.Size(158, 68)
        Me.btn_Terminar.TabIndex = 14
        Me.btn_Terminar.Text = "Terminar"
        Me.btn_Terminar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(442, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 69)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Max ID: Alunos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_MaxIDalunos
        '
        Me.txt_MaxIDalunos.Location = New System.Drawing.Point(498, 41)
        Me.txt_MaxIDalunos.Name = "txt_MaxIDalunos"
        Me.txt_MaxIDalunos.Size = New System.Drawing.Size(100, 22)
        Me.txt_MaxIDalunos.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(444, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Max ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(172, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Leitura Registos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 504)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_MaxIDalunos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Terminar)
        Me.Controls.Add(Me.btn_EliminarReg)
        Me.Controls.Add(Me.btn_UpdateReg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_LerReg)
        Me.Controls.Add(Me.btn_InserirReg)
        Me.Controls.Add(Me.txt_Ver)
        Me.Controls.Add(Me.btn_LerBD)
        Me.Controls.Add(Me.btn_Connect)
        Me.Name = "Form1"
        Me.Text = "Base de Dados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Connect As Button
    Friend WithEvents btn_LerBD As Button
    Friend WithEvents txt_Ver As TextBox
    Friend WithEvents btn_InserirReg As Button
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents txt_Nome As TextBox
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_LerReg As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_UpdateReg As Button
    Friend WithEvents btn_EliminarReg As Button
    Friend WithEvents btn_Terminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_MaxIDalunos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
