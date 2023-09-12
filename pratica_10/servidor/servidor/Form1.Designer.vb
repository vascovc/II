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
        Me.chb_y0 = New System.Windows.Forms.CheckBox()
        Me.chb_y1 = New System.Windows.Forms.CheckBox()
        Me.chb_y2 = New System.Windows.Forms.CheckBox()
        Me.chb_x0 = New System.Windows.Forms.CheckBox()
        Me.chb_x1 = New System.Windows.Forms.CheckBox()
        Me.chb_x2 = New System.Windows.Forms.CheckBox()
        Me.chb_x3 = New System.Windows.Forms.CheckBox()
        Me.txt_water_level = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timer_send = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_receber
        '
        Me.txt_receber.Location = New System.Drawing.Point(32, 39)
        Me.txt_receber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_receber.Multiline = True
        Me.txt_receber.Name = "txt_receber"
        Me.txt_receber.Size = New System.Drawing.Size(289, 214)
        Me.txt_receber.TabIndex = 0
        '
        'chb_y0
        '
        Me.chb_y0.AutoSize = True
        Me.chb_y0.Enabled = False
        Me.chb_y0.Location = New System.Drawing.Point(368, 39)
        Me.chb_y0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.chb_y1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.chb_y2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_y2.Name = "chb_y2"
        Me.chb_y2.Size = New System.Drawing.Size(45, 20)
        Me.chb_y2.TabIndex = 5
        Me.chb_y2.Text = "Y2"
        Me.chb_y2.UseVisualStyleBackColor = True
        '
        'chb_x0
        '
        Me.chb_x0.AutoSize = True
        Me.chb_x0.Location = New System.Drawing.Point(424, 39)
        Me.chb_x0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_x0.Name = "chb_x0"
        Me.chb_x0.Size = New System.Drawing.Size(44, 20)
        Me.chb_x0.TabIndex = 6
        Me.chb_x0.Text = "X0"
        Me.chb_x0.UseVisualStyleBackColor = True
        '
        'chb_x1
        '
        Me.chb_x1.AutoSize = True
        Me.chb_x1.Location = New System.Drawing.Point(424, 65)
        Me.chb_x1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_x1.Name = "chb_x1"
        Me.chb_x1.Size = New System.Drawing.Size(44, 20)
        Me.chb_x1.TabIndex = 7
        Me.chb_x1.Text = "X1"
        Me.chb_x1.UseVisualStyleBackColor = True
        '
        'chb_x2
        '
        Me.chb_x2.AutoSize = True
        Me.chb_x2.Location = New System.Drawing.Point(424, 91)
        Me.chb_x2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_x2.Name = "chb_x2"
        Me.chb_x2.Size = New System.Drawing.Size(44, 20)
        Me.chb_x2.TabIndex = 8
        Me.chb_x2.Text = "X2"
        Me.chb_x2.UseVisualStyleBackColor = True
        '
        'chb_x3
        '
        Me.chb_x3.AutoSize = True
        Me.chb_x3.Location = New System.Drawing.Point(424, 117)
        Me.chb_x3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_x3.Name = "chb_x3"
        Me.chb_x3.Size = New System.Drawing.Size(44, 20)
        Me.chb_x3.TabIndex = 9
        Me.chb_x3.Text = "X3"
        Me.chb_x3.UseVisualStyleBackColor = True
        '
        'txt_water_level
        '
        Me.txt_water_level.Enabled = False
        Me.txt_water_level.Location = New System.Drawing.Point(368, 183)
        Me.txt_water_level.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_water_level.Name = "txt_water_level"
        Me.txt_water_level.Size = New System.Drawing.Size(100, 22)
        Me.txt_water_level.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Water Level"
        '
        'timer_send
        '
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Received Messages" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 290)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_water_level)
        Me.Controls.Add(Me.chb_x3)
        Me.Controls.Add(Me.chb_x2)
        Me.Controls.Add(Me.chb_x1)
        Me.Controls.Add(Me.chb_x0)
        Me.Controls.Add(Me.chb_y2)
        Me.Controls.Add(Me.chb_y1)
        Me.Controls.Add(Me.chb_y0)
        Me.Controls.Add(Me.txt_receber)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_receber As TextBox
    Friend WithEvents chb_y0 As CheckBox
    Friend WithEvents chb_y1 As CheckBox
    Friend WithEvents chb_y2 As CheckBox
    Friend WithEvents chb_x0 As CheckBox
    Friend WithEvents chb_x1 As CheckBox
    Friend WithEvents chb_x2 As CheckBox
    Friend WithEvents chb_x3 As CheckBox
    Friend WithEvents txt_water_level As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents timer_send As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
End Class
