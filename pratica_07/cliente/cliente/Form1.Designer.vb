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
        Me.components = New System.ComponentModel.Container()
        Me.btn_ligar = New System.Windows.Forms.Button()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.btn_desligar = New System.Windows.Forms.Button()
        Me.chb_X0 = New System.Windows.Forms.CheckBox()
        Me.chb_X1 = New System.Windows.Forms.CheckBox()
        Me.chb_X2 = New System.Windows.Forms.CheckBox()
        Me.chb_X3 = New System.Windows.Forms.CheckBox()
        Me.chb_Y0 = New System.Windows.Forms.CheckBox()
        Me.chb_Y1 = New System.Windows.Forms.CheckBox()
        Me.chb_Y2 = New System.Windows.Forms.CheckBox()
        Me.txt_vel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_connection_status = New System.Windows.Forms.TextBox()
        Me.timer_receive = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_vel_read = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_ligar
        '
        Me.btn_ligar.Location = New System.Drawing.Point(69, 49)
        Me.btn_ligar.Name = "btn_ligar"
        Me.btn_ligar.Size = New System.Drawing.Size(107, 42)
        Me.btn_ligar.TabIndex = 0
        Me.btn_ligar.Text = "Ligar 127.0.0.1"
        Me.btn_ligar.UseVisualStyleBackColor = True
        '
        'btn_enviar
        '
        Me.btn_enviar.Location = New System.Drawing.Point(257, 152)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(225, 42)
        Me.btn_enviar.TabIndex = 2
        Me.btn_enviar.Text = "Enviar chb e Vel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_enviar.UseVisualStyleBackColor = True
        '
        'btn_desligar
        '
        Me.btn_desligar.Location = New System.Drawing.Point(69, 110)
        Me.btn_desligar.Name = "btn_desligar"
        Me.btn_desligar.Size = New System.Drawing.Size(107, 42)
        Me.btn_desligar.TabIndex = 3
        Me.btn_desligar.Text = "Desligar"
        Me.btn_desligar.UseVisualStyleBackColor = True
        '
        'chb_X0
        '
        Me.chb_X0.AutoSize = True
        Me.chb_X0.Enabled = False
        Me.chb_X0.Location = New System.Drawing.Point(109, 290)
        Me.chb_X0.Name = "chb_X0"
        Me.chb_X0.Size = New System.Drawing.Size(44, 20)
        Me.chb_X0.TabIndex = 4
        Me.chb_X0.Text = "X0"
        Me.chb_X0.UseVisualStyleBackColor = True
        '
        'chb_X1
        '
        Me.chb_X1.AutoSize = True
        Me.chb_X1.Enabled = False
        Me.chb_X1.Location = New System.Drawing.Point(109, 316)
        Me.chb_X1.Name = "chb_X1"
        Me.chb_X1.Size = New System.Drawing.Size(44, 20)
        Me.chb_X1.TabIndex = 5
        Me.chb_X1.Text = "X1"
        Me.chb_X1.UseVisualStyleBackColor = True
        '
        'chb_X2
        '
        Me.chb_X2.AutoSize = True
        Me.chb_X2.Enabled = False
        Me.chb_X2.Location = New System.Drawing.Point(109, 339)
        Me.chb_X2.Name = "chb_X2"
        Me.chb_X2.Size = New System.Drawing.Size(44, 20)
        Me.chb_X2.TabIndex = 6
        Me.chb_X2.Text = "X2"
        Me.chb_X2.UseVisualStyleBackColor = True
        '
        'chb_X3
        '
        Me.chb_X3.AutoSize = True
        Me.chb_X3.Enabled = False
        Me.chb_X3.Location = New System.Drawing.Point(109, 365)
        Me.chb_X3.Name = "chb_X3"
        Me.chb_X3.Size = New System.Drawing.Size(44, 20)
        Me.chb_X3.TabIndex = 7
        Me.chb_X3.Text = "X3"
        Me.chb_X3.UseVisualStyleBackColor = True
        '
        'chb_Y0
        '
        Me.chb_Y0.AutoSize = True
        Me.chb_Y0.Location = New System.Drawing.Point(257, 70)
        Me.chb_Y0.Name = "chb_Y0"
        Me.chb_Y0.Size = New System.Drawing.Size(45, 20)
        Me.chb_Y0.TabIndex = 8
        Me.chb_Y0.Text = "Y0"
        Me.chb_Y0.UseVisualStyleBackColor = True
        '
        'chb_Y1
        '
        Me.chb_Y1.AutoSize = True
        Me.chb_Y1.Location = New System.Drawing.Point(257, 97)
        Me.chb_Y1.Name = "chb_Y1"
        Me.chb_Y1.Size = New System.Drawing.Size(45, 20)
        Me.chb_Y1.TabIndex = 9
        Me.chb_Y1.Text = "Y1"
        Me.chb_Y1.UseVisualStyleBackColor = True
        '
        'chb_Y2
        '
        Me.chb_Y2.AutoSize = True
        Me.chb_Y2.Location = New System.Drawing.Point(257, 124)
        Me.chb_Y2.Name = "chb_Y2"
        Me.chb_Y2.Size = New System.Drawing.Size(45, 20)
        Me.chb_Y2.TabIndex = 10
        Me.chb_Y2.Text = "Y2"
        Me.chb_Y2.UseVisualStyleBackColor = True
        '
        'txt_vel
        '
        Me.txt_vel.Location = New System.Drawing.Point(349, 124)
        Me.txt_vel.Name = "txt_vel"
        Me.txt_vel.Size = New System.Drawing.Size(133, 22)
        Me.txt_vel.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(349, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Velocidade do motor"
        '
        'txt_connection_status
        '
        Me.txt_connection_status.Location = New System.Drawing.Point(69, 218)
        Me.txt_connection_status.Name = "txt_connection_status"
        Me.txt_connection_status.Size = New System.Drawing.Size(413, 22)
        Me.txt_connection_status.TabIndex = 13
        '
        'timer_receive
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Velocidade do motor lida"
        '
        'txt_vel_read
        '
        Me.txt_vel_read.Location = New System.Drawing.Point(256, 336)
        Me.txt_vel_read.Name = "txt_vel_read"
        Me.txt_vel_read.ReadOnly = True
        Me.txt_vel_read.Size = New System.Drawing.Size(155, 22)
        Me.txt_vel_read.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 450)
        Me.Controls.Add(Me.txt_vel_read)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_connection_status)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_vel)
        Me.Controls.Add(Me.chb_Y2)
        Me.Controls.Add(Me.chb_Y1)
        Me.Controls.Add(Me.chb_Y0)
        Me.Controls.Add(Me.chb_X3)
        Me.Controls.Add(Me.chb_X2)
        Me.Controls.Add(Me.chb_X1)
        Me.Controls.Add(Me.chb_X0)
        Me.Controls.Add(Me.btn_desligar)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.btn_ligar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ligar As Button
    Friend WithEvents btn_enviar As Button
    Friend WithEvents btn_desligar As Button
    Friend WithEvents chb_X0 As CheckBox
    Friend WithEvents chb_X1 As CheckBox
    Friend WithEvents chb_X2 As CheckBox
    Friend WithEvents chb_X3 As CheckBox
    Friend WithEvents chb_Y0 As CheckBox
    Friend WithEvents chb_Y1 As CheckBox
    Friend WithEvents chb_Y2 As CheckBox
    Friend WithEvents txt_vel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_connection_status As TextBox
    Friend WithEvents timer_receive As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_vel_read As TextBox
End Class
