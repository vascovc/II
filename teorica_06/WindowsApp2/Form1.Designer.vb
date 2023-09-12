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
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.btn_desc = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_estado_ligacao = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(80, 49)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(93, 35)
        Me.btn_connect.TabIndex = 0
        Me.btn_connect.Text = "bt_connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(80, 108)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(93, 35)
        Me.btn_send.TabIndex = 1
        Me.btn_send.Text = "btn_send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'btn_desc
        '
        Me.btn_desc.Location = New System.Drawing.Point(80, 175)
        Me.btn_desc.Name = "btn_desc"
        Me.btn_desc.Size = New System.Drawing.Size(93, 35)
        Me.btn_desc.TabIndex = 2
        Me.btn_desc.Text = "bt_desconnect"
        Me.btn_desc.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(80, 235)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(117, 16)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Estado da ligação"
        '
        'txt_estado_ligacao
        '
        Me.txt_estado_ligacao.Location = New System.Drawing.Point(83, 268)
        Me.txt_estado_ligacao.Name = "txt_estado_ligacao"
        Me.txt_estado_ligacao.Size = New System.Drawing.Size(100, 22)
        Me.txt_estado_ligacao.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_estado_ligacao)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btn_desc)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.btn_connect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_connect As Button
    Friend WithEvents btn_send As Button
    Friend WithEvents btn_desc As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents label1 As Label
    Friend WithEvents txt_estado_ligacao As TextBox
End Class
