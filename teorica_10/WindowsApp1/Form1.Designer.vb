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
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.txt_Ver = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(13, 13)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(134, 70)
        Me.btn_connect.TabIndex = 0
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'btn_read
        '
        Me.btn_read.Location = New System.Drawing.Point(12, 89)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(135, 75)
        Me.btn_read.TabIndex = 1
        Me.btn_read.Text = "Ler base de dados"
        Me.btn_read.UseVisualStyleBackColor = True
        '
        'txt_Ver
        '
        Me.txt_Ver.Location = New System.Drawing.Point(153, 13)
        Me.txt_Ver.Multiline = True
        Me.txt_Ver.Name = "txt_Ver"
        Me.txt_Ver.Size = New System.Drawing.Size(244, 151)
        Me.txt_Ver.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_Ver)
        Me.Controls.Add(Me.btn_read)
        Me.Controls.Add(Me.btn_connect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_connect As Button
    Friend WithEvents btn_read As Button
    Friend WithEvents txt_Ver As TextBox
End Class
