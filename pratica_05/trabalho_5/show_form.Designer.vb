<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class show_form
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
        Me.txt_send = New System.Windows.Forms.TextBox()
        Me.txt_received = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_send
        '
        Me.txt_send.Location = New System.Drawing.Point(28, 46)
        Me.txt_send.Multiline = True
        Me.txt_send.Name = "txt_send"
        Me.txt_send.Size = New System.Drawing.Size(283, 365)
        Me.txt_send.TabIndex = 0
        '
        'txt_received
        '
        Me.txt_received.Location = New System.Drawing.Point(374, 46)
        Me.txt_received.Multiline = True
        Me.txt_received.Name = "txt_received"
        Me.txt_received.Size = New System.Drawing.Size(357, 365)
        Me.txt_received.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mensagem enviada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mensagem Recebida"
        '
        'show_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_received)
        Me.Controls.Add(Me.txt_send)
        Me.Name = "show_form"
        Me.Text = "show"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_send As TextBox
    Friend WithEvents txt_received As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
