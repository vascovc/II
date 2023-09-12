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
        Me.txt_receber = New System.Windows.Forms.TextBox()
        Me.txt_connected = New System.Windows.Forms.TextBox()
        Me.btn_desligar = New System.Windows.Forms.Button()
        Me.chb_y0 = New System.Windows.Forms.CheckBox()
        Me.chb_y1 = New System.Windows.Forms.CheckBox()
        Me.chb_y2 = New System.Windows.Forms.CheckBox()
        Me.chb_x0 = New System.Windows.Forms.CheckBox()
        Me.chb_x1 = New System.Windows.Forms.CheckBox()
        Me.chb_x2 = New System.Windows.Forms.CheckBox()
        Me.chb_x3 = New System.Windows.Forms.CheckBox()
        Me.txt_vel = New System.Windows.Forms.TextBox()
        Me.txt_vel_read = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timer_send = New System.Windows.Forms.Timer(Me.components)
        Me.timer_receive = New System.Windows.Forms.Timer(Me.components)
        Me.timer_verify_connection = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txt_receber
        '
        Me.txt_receber.Location = New System.Drawing.Point(48, 37)
        Me.txt_receber.Multiline = True
        Me.txt_receber.Name = "txt_receber"
        Me.txt_receber.Size = New System.Drawing.Size(289, 215)
        Me.txt_receber.TabIndex = 0
        '
        'txt_connected
        '
        Me.txt_connected.Location = New System.Drawing.Point(48, 271)
        Me.txt_connected.Name = "txt_connected"
        Me.txt_connected.Size = New System.Drawing.Size(187, 22)
        Me.txt_connected.TabIndex = 1
        '
        'btn_desligar
        '
        Me.btn_desligar.Location = New System.Drawing.Point(241, 266)
        Me.btn_desligar.Name = "btn_desligar"
        Me.btn_desligar.Size = New System.Drawing.Size(96, 32)
        Me.btn_desligar.TabIndex = 2
        Me.btn_desligar.Text = "Desligar"
        Me.btn_desligar.UseVisualStyleBackColor = True
        '
        'chb_y0
        '
        Me.chb_y0.AutoSize = True
        Me.chb_y0.Enabled = False
        Me.chb_y0.Location = New System.Drawing.Point(368, 39)
        Me.chb_y0.Name = "chb_y0"
        Me.chb_y0.Size = New System.Drawing.Size(45, 20)
        Me.chb_y0.TabIndex = 3
        Me.chb_y0.Text = "Y0"
        Me.chb_y0.UseVisualStyleBackColor = True
        '
        'chb_y1
        '
        Me.chb_y1.AutoSize = True
        Me.chb_y1.Enabled = False
        Me.chb_y1.Location = New System.Drawing.Point(368, 65)
        Me.chb_y1.Name = "chb_y1"
        Me.chb_y1.Size = New System.Drawing.Size(45, 20)
        Me.chb_y1.TabIndex = 4
        Me.chb_y1.Text = "Y1"
        Me.chb_y1.UseVisualStyleBackColor = True
        '
        'chb_y2
        '
        Me.chb_y2.AutoSize = True
        Me.chb_y2.Enabled = False
        Me.chb_y2.Location = New System.Drawing.Point(368, 91)
        Me.chb_y2.Name = "chb_y2"
        Me.chb_y2.Size = New System.Drawing.Size(45, 20)
        Me.chb_y2.TabIndex = 5
        Me.chb_y2.Text = "Y2"
        Me.chb_y2.UseVisualStyleBackColor = True
        '
        'chb_x0
        '
        Me.chb_x0.AutoSize = True
        Me.chb_x0.Location = New System.Drawing.Point(48, 299)
        Me.chb_x0.Name = "chb_x0"
        Me.chb_x0.Size = New System.Drawing.Size(44, 20)
        Me.chb_x0.TabIndex = 6
        Me.chb_x0.Text = "X0"
        Me.chb_x0.UseVisualStyleBackColor = True
        '
        'chb_x1
        '
        Me.chb_x1.AutoSize = True
        Me.chb_x1.Location = New System.Drawing.Point(48, 325)
        Me.chb_x1.Name = "chb_x1"
        Me.chb_x1.Size = New System.Drawing.Size(44, 20)
        Me.chb_x1.TabIndex = 7
        Me.chb_x1.Text = "X1"
        Me.chb_x1.UseVisualStyleBackColor = True
        '
        'chb_x2
        '
        Me.chb_x2.AutoSize = True
        Me.chb_x2.Location = New System.Drawing.Point(48, 351)
        Me.chb_x2.Name = "chb_x2"
        Me.chb_x2.Size = New System.Drawing.Size(44, 20)
        Me.chb_x2.TabIndex = 8
        Me.chb_x2.Text = "X2"
        Me.chb_x2.UseVisualStyleBackColor = True
        '
        'chb_x3
        '
        Me.chb_x3.AutoSize = True
        Me.chb_x3.Location = New System.Drawing.Point(48, 377)
        Me.chb_x3.Name = "chb_x3"
        Me.chb_x3.Size = New System.Drawing.Size(44, 20)
        Me.chb_x3.TabIndex = 9
        Me.chb_x3.Text = "X3"
        Me.chb_x3.UseVisualStyleBackColor = True
        '
        'txt_vel
        '
        Me.txt_vel.Enabled = False
        Me.txt_vel.Location = New System.Drawing.Point(368, 169)
        Me.txt_vel.Name = "txt_vel"
        Me.txt_vel.Size = New System.Drawing.Size(100, 22)
        Me.txt_vel.TabIndex = 10
        '
        'txt_vel_read
        '
        Me.txt_vel_read.Location = New System.Drawing.Point(150, 351)
        Me.txt_vel_read.Name = "txt_vel_read"
        Me.txt_vel_read.Size = New System.Drawing.Size(100, 22)
        Me.txt_vel_read.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Velocidade do motor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Velocidade do motor lida"
        '
        'timer_send
        '
        '
        'timer_receive
        '
        '
        'timer_verify_connection
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_vel_read)
        Me.Controls.Add(Me.txt_vel)
        Me.Controls.Add(Me.chb_x3)
        Me.Controls.Add(Me.chb_x2)
        Me.Controls.Add(Me.chb_x1)
        Me.Controls.Add(Me.chb_x0)
        Me.Controls.Add(Me.chb_y2)
        Me.Controls.Add(Me.chb_y1)
        Me.Controls.Add(Me.chb_y0)
        Me.Controls.Add(Me.btn_desligar)
        Me.Controls.Add(Me.txt_connected)
        Me.Controls.Add(Me.txt_receber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_receber As TextBox
    Friend WithEvents txt_connected As TextBox
    Friend WithEvents btn_desligar As Button
    Friend WithEvents chb_y0 As CheckBox
    Friend WithEvents chb_y1 As CheckBox
    Friend WithEvents chb_y2 As CheckBox
    Friend WithEvents chb_x0 As CheckBox
    Friend WithEvents chb_x1 As CheckBox
    Friend WithEvents chb_x2 As CheckBox
    Friend WithEvents chb_x3 As CheckBox
    Friend WithEvents txt_vel As TextBox
    Friend WithEvents txt_vel_read As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents timer_send As Timer
    Friend WithEvents timer_receive As Timer
    Friend WithEvents timer_verify_connection As Timer
End Class
