<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_soma = New System.Windows.Forms.Button()
        Me.btn_sub = New System.Windows.Forms.Button()
        Me.btn_mult = New System.Windows.Forms.Button()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.txt_op_1 = New System.Windows.Forms.TextBox()
        Me.txt_op_2 = New System.Windows.Forms.TextBox()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.txt_ficheiro = New System.Windows.Forms.TextBox()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_soma
        '
        Me.btn_soma.Location = New System.Drawing.Point(62, 236)
        Me.btn_soma.Name = "btn_soma"
        Me.btn_soma.Size = New System.Drawing.Size(94, 29)
        Me.btn_soma.TabIndex = 0
        Me.btn_soma.Text = "+"
        Me.btn_soma.UseVisualStyleBackColor = True
        '
        'btn_sub
        '
        Me.btn_sub.Location = New System.Drawing.Point(66, 280)
        Me.btn_sub.Name = "btn_sub"
        Me.btn_sub.Size = New System.Drawing.Size(94, 29)
        Me.btn_sub.TabIndex = 1
        Me.btn_sub.Text = "-"
        Me.btn_sub.UseVisualStyleBackColor = True
        '
        'btn_mult
        '
        Me.btn_mult.Location = New System.Drawing.Point(195, 236)
        Me.btn_mult.Name = "btn_mult"
        Me.btn_mult.Size = New System.Drawing.Size(94, 29)
        Me.btn_mult.TabIndex = 2
        Me.btn_mult.Text = "*"
        Me.btn_mult.UseVisualStyleBackColor = True
        '
        'btn_div
        '
        Me.btn_div.Location = New System.Drawing.Point(195, 280)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(94, 29)
        Me.btn_div.TabIndex = 3
        Me.btn_div.Text = "/"
        Me.btn_div.UseVisualStyleBackColor = True
        '
        'txt_op_1
        '
        Me.txt_op_1.Location = New System.Drawing.Point(62, 188)
        Me.txt_op_1.Name = "txt_op_1"
        Me.txt_op_1.Size = New System.Drawing.Size(125, 27)
        Me.txt_op_1.TabIndex = 4
        '
        'txt_op_2
        '
        Me.txt_op_2.Location = New System.Drawing.Point(214, 186)
        Me.txt_op_2.Name = "txt_op_2"
        Me.txt_op_2.Size = New System.Drawing.Size(125, 27)
        Me.txt_op_2.TabIndex = 5
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(370, 188)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(125, 27)
        Me.txt_result.TabIndex = 6
        '
        'txt_ficheiro
        '
        Me.txt_ficheiro.Location = New System.Drawing.Point(540, 228)
        Me.txt_ficheiro.Multiline = True
        Me.txt_ficheiro.Name = "txt_ficheiro"
        Me.txt_ficheiro.Size = New System.Drawing.Size(194, 152)
        Me.txt_ficheiro.TabIndex = 7
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(62, 351)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(94, 29)
        Me.btn_end.TabIndex = 8
        Me.btn_end.Text = "Sair"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(540, 186)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 29)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "Gravar"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_read
        '
        Me.btn_read.Location = New System.Drawing.Point(640, 186)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(94, 29)
        Me.btn_read.TabIndex = 10
        Me.btn_read.Text = "Ler"
        Me.btn_read.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Operador 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Operador 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_read)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.txt_ficheiro)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.txt_op_2)
        Me.Controls.Add(Me.txt_op_1)
        Me.Controls.Add(Me.btn_div)
        Me.Controls.Add(Me.btn_mult)
        Me.Controls.Add(Me.btn_sub)
        Me.Controls.Add(Me.btn_soma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_soma As Button
    Friend WithEvents btn_sub As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents txt_op_1 As TextBox
    Friend WithEvents txt_op_2 As TextBox
    Friend WithEvents txt_result As TextBox
    Friend WithEvents txt_ficheiro As TextBox
    Friend WithEvents btn_end As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_read As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
