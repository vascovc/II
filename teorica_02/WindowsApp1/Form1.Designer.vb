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
        Me.txtEnviar = New System.Windows.Forms.TextBox()
        Me.txtReceber = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.BtEnviar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEnviar
        '
        Me.txtEnviar.Location = New System.Drawing.Point(72, 104)
        Me.txtEnviar.Multiline = True
        Me.txtEnviar.Name = "txtEnviar"
        Me.txtEnviar.Size = New System.Drawing.Size(175, 209)
        Me.txtEnviar.TabIndex = 0
        '
        'txtReceber
        '
        Me.txtReceber.Location = New System.Drawing.Point(332, 104)
        Me.txtReceber.Multiline = True
        Me.txtReceber.Name = "txtReceber"
        Me.txtReceber.Size = New System.Drawing.Size(182, 209)
        Me.txtReceber.TabIndex = 1
        '
        'Timer1
        '
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(549, 380)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(109, 20)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'BtEnviar
        '
        Me.BtEnviar.Location = New System.Drawing.Point(72, 368)
        Me.BtEnviar.Name = "BtEnviar"
        Me.BtEnviar.Size = New System.Drawing.Size(150, 45)
        Me.BtEnviar.TabIndex = 3
        Me.BtEnviar.Text = "Enviar"
        Me.BtEnviar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtEnviar)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtReceber)
        Me.Controls.Add(Me.txtEnviar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEnviar As TextBox
    Friend WithEvents txtReceber As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents BtEnviar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
