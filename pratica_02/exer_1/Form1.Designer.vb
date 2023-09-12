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
        Me.btn_mult = New System.Windows.Forms.Button()
        Me.btn_sub = New System.Windows.Forms.Button()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.bnt_sair = New System.Windows.Forms.Button()
        Me.txt_op_1 = New System.Windows.Forms.TextBox()
        Me.txt_op_2 = New System.Windows.Forms.TextBox()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_soma
        '
        Me.btn_soma.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_soma.Location = New System.Drawing.Point(35, 197)
        Me.btn_soma.Name = "btn_soma"
        Me.btn_soma.Size = New System.Drawing.Size(280, 131)
        Me.btn_soma.TabIndex = 0
        Me.btn_soma.Text = "+"
        Me.btn_soma.UseVisualStyleBackColor = True
        '
        'btn_mult
        '
        Me.btn_mult.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_mult.Location = New System.Drawing.Point(35, 325)
        Me.btn_mult.Name = "btn_mult"
        Me.btn_mult.Size = New System.Drawing.Size(280, 131)
        Me.btn_mult.TabIndex = 1
        Me.btn_mult.Text = "*"
        Me.btn_mult.UseVisualStyleBackColor = True
        '
        'btn_sub
        '
        Me.btn_sub.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_sub.Location = New System.Drawing.Point(319, 197)
        Me.btn_sub.Name = "btn_sub"
        Me.btn_sub.Size = New System.Drawing.Size(280, 131)
        Me.btn_sub.TabIndex = 2
        Me.btn_sub.Text = "-"
        Me.btn_sub.UseVisualStyleBackColor = True
        '
        'btn_div
        '
        Me.btn_div.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_div.Location = New System.Drawing.Point(319, 325)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(280, 131)
        Me.btn_div.TabIndex = 3
        Me.btn_div.Text = "/"
        Me.btn_div.UseVisualStyleBackColor = True
        '
        'bnt_sair
        '
        Me.bnt_sair.Location = New System.Drawing.Point(641, 371)
        Me.bnt_sair.Name = "bnt_sair"
        Me.bnt_sair.Size = New System.Drawing.Size(94, 29)
        Me.bnt_sair.TabIndex = 4
        Me.bnt_sair.Text = "Sair"
        Me.bnt_sair.UseVisualStyleBackColor = True
        '
        'txt_op_1
        '
        Me.txt_op_1.Location = New System.Drawing.Point(84, 157)
        Me.txt_op_1.Name = "txt_op_1"
        Me.txt_op_1.Size = New System.Drawing.Size(125, 27)
        Me.txt_op_1.TabIndex = 5
        '
        'txt_op_2
        '
        Me.txt_op_2.Location = New System.Drawing.Point(269, 159)
        Me.txt_op_2.Name = "txt_op_2"
        Me.txt_op_2.Size = New System.Drawing.Size(125, 27)
        Me.txt_op_2.TabIndex = 6
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(524, 159)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(125, 27)
        Me.txt_result.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Operador 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Operador 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(524, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 476)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.txt_op_2)
        Me.Controls.Add(Me.txt_op_1)
        Me.Controls.Add(Me.bnt_sair)
        Me.Controls.Add(Me.btn_div)
        Me.Controls.Add(Me.btn_sub)
        Me.Controls.Add(Me.btn_mult)
        Me.Controls.Add(Me.btn_soma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_soma As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_sub As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents bnt_sair As Button
    Friend WithEvents txt_op_1 As TextBox
    Friend WithEvents txt_op_2 As TextBox
    Friend WithEvents txt_result As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
