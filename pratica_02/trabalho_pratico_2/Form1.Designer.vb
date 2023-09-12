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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.bt_1 = New System.Windows.Forms.Button()
        Me.bt_9 = New System.Windows.Forms.Button()
        Me.bt_8 = New System.Windows.Forms.Button()
        Me.bt_7 = New System.Windows.Forms.Button()
        Me.bt_6 = New System.Windows.Forms.Button()
        Me.bt_5 = New System.Windows.Forms.Button()
        Me.bt_4 = New System.Windows.Forms.Button()
        Me.bt_3 = New System.Windows.Forms.Button()
        Me.bt_2 = New System.Windows.Forms.Button()
        Me.bt_0 = New System.Windows.Forms.Button()
        Me.btn_soma = New System.Windows.Forms.Button()
        Me.btn_sub = New System.Windows.Forms.Button()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.btn_mult = New System.Windows.Forms.Button()
        Me.bt_clear = New System.Windows.Forms.Button()
        Me.bt_equal = New System.Windows.Forms.Button()
        Me.bt_sair = New System.Windows.Forms.Button()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.txt_op_1 = New System.Windows.Forms.TextBox()
        Me.txt_op_2 = New System.Windows.Forms.TextBox()
        Me.txt_operation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimerDate = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 447)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(548, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 16)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePicker1.TabIndex = 1
        '
        'bt_1
        '
        Me.bt_1.Location = New System.Drawing.Point(59, 108)
        Me.bt_1.Name = "bt_1"
        Me.bt_1.Size = New System.Drawing.Size(48, 42)
        Me.bt_1.TabIndex = 2
        Me.bt_1.Text = "1"
        Me.bt_1.UseVisualStyleBackColor = True
        '
        'bt_9
        '
        Me.bt_9.Location = New System.Drawing.Point(214, 230)
        Me.bt_9.Name = "bt_9"
        Me.bt_9.Size = New System.Drawing.Size(48, 42)
        Me.bt_9.TabIndex = 3
        Me.bt_9.Text = "9"
        Me.bt_9.UseVisualStyleBackColor = True
        '
        'bt_8
        '
        Me.bt_8.Location = New System.Drawing.Point(135, 230)
        Me.bt_8.Name = "bt_8"
        Me.bt_8.Size = New System.Drawing.Size(48, 42)
        Me.bt_8.TabIndex = 4
        Me.bt_8.Text = "8"
        Me.bt_8.UseVisualStyleBackColor = True
        '
        'bt_7
        '
        Me.bt_7.Location = New System.Drawing.Point(59, 230)
        Me.bt_7.Name = "bt_7"
        Me.bt_7.Size = New System.Drawing.Size(48, 42)
        Me.bt_7.TabIndex = 5
        Me.bt_7.Text = "7"
        Me.bt_7.UseVisualStyleBackColor = True
        '
        'bt_6
        '
        Me.bt_6.Location = New System.Drawing.Point(214, 168)
        Me.bt_6.Name = "bt_6"
        Me.bt_6.Size = New System.Drawing.Size(48, 42)
        Me.bt_6.TabIndex = 6
        Me.bt_6.Text = "6"
        Me.bt_6.UseVisualStyleBackColor = True
        '
        'bt_5
        '
        Me.bt_5.Location = New System.Drawing.Point(135, 168)
        Me.bt_5.Name = "bt_5"
        Me.bt_5.Size = New System.Drawing.Size(48, 42)
        Me.bt_5.TabIndex = 7
        Me.bt_5.Text = "5"
        Me.bt_5.UseVisualStyleBackColor = True
        '
        'bt_4
        '
        Me.bt_4.Location = New System.Drawing.Point(59, 168)
        Me.bt_4.Name = "bt_4"
        Me.bt_4.Size = New System.Drawing.Size(48, 42)
        Me.bt_4.TabIndex = 8
        Me.bt_4.Text = "4"
        Me.bt_4.UseVisualStyleBackColor = True
        '
        'bt_3
        '
        Me.bt_3.Location = New System.Drawing.Point(214, 108)
        Me.bt_3.Name = "bt_3"
        Me.bt_3.Size = New System.Drawing.Size(48, 42)
        Me.bt_3.TabIndex = 9
        Me.bt_3.Text = "3"
        Me.bt_3.UseVisualStyleBackColor = True
        '
        'bt_2
        '
        Me.bt_2.Location = New System.Drawing.Point(135, 108)
        Me.bt_2.Name = "bt_2"
        Me.bt_2.Size = New System.Drawing.Size(48, 42)
        Me.bt_2.TabIndex = 10
        Me.bt_2.Text = "2"
        Me.bt_2.UseVisualStyleBackColor = True
        '
        'bt_0
        '
        Me.bt_0.Location = New System.Drawing.Point(59, 298)
        Me.bt_0.Name = "bt_0"
        Me.bt_0.Size = New System.Drawing.Size(48, 42)
        Me.bt_0.TabIndex = 11
        Me.bt_0.Text = "0"
        Me.bt_0.UseVisualStyleBackColor = True
        '
        'btn_soma
        '
        Me.btn_soma.Location = New System.Drawing.Point(327, 97)
        Me.btn_soma.Name = "btn_soma"
        Me.btn_soma.Size = New System.Drawing.Size(53, 53)
        Me.btn_soma.TabIndex = 12
        Me.btn_soma.Text = "+"
        Me.btn_soma.UseVisualStyleBackColor = True
        '
        'btn_sub
        '
        Me.btn_sub.Location = New System.Drawing.Point(327, 156)
        Me.btn_sub.Name = "btn_sub"
        Me.btn_sub.Size = New System.Drawing.Size(53, 53)
        Me.btn_sub.TabIndex = 13
        Me.btn_sub.Text = "-"
        Me.btn_sub.UseVisualStyleBackColor = True
        '
        'btn_div
        '
        Me.btn_div.Location = New System.Drawing.Point(327, 274)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(53, 53)
        Me.btn_div.TabIndex = 14
        Me.btn_div.Text = "/"
        Me.btn_div.UseVisualStyleBackColor = True
        '
        'btn_mult
        '
        Me.btn_mult.Location = New System.Drawing.Point(327, 215)
        Me.btn_mult.Name = "btn_mult"
        Me.btn_mult.Size = New System.Drawing.Size(53, 53)
        Me.btn_mult.TabIndex = 15
        Me.btn_mult.Text = "x"
        Me.btn_mult.UseVisualStyleBackColor = True
        '
        'bt_clear
        '
        Me.bt_clear.Location = New System.Drawing.Point(409, 119)
        Me.bt_clear.Name = "bt_clear"
        Me.bt_clear.Size = New System.Drawing.Size(94, 29)
        Me.bt_clear.TabIndex = 16
        Me.bt_clear.Text = "C"
        Me.bt_clear.UseVisualStyleBackColor = True
        '
        'bt_equal
        '
        Me.bt_equal.Location = New System.Drawing.Point(409, 175)
        Me.bt_equal.Name = "bt_equal"
        Me.bt_equal.Size = New System.Drawing.Size(94, 29)
        Me.bt_equal.TabIndex = 17
        Me.bt_equal.Text = "="
        Me.bt_equal.UseVisualStyleBackColor = True
        '
        'bt_sair
        '
        Me.bt_sair.Location = New System.Drawing.Point(409, 274)
        Me.bt_sair.Name = "bt_sair"
        Me.bt_sair.Size = New System.Drawing.Size(94, 29)
        Me.bt_sair.TabIndex = 18
        Me.bt_sair.Text = "Sair"
        Me.bt_sair.UseVisualStyleBackColor = True
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(59, 64)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.ReadOnly = True
        Me.txt_result.Size = New System.Drawing.Size(203, 27)
        Me.txt_result.TabIndex = 19
        '
        'txt_op_1
        '
        Me.txt_op_1.Location = New System.Drawing.Point(58, 381)
        Me.txt_op_1.Name = "txt_op_1"
        Me.txt_op_1.Size = New System.Drawing.Size(125, 27)
        Me.txt_op_1.TabIndex = 20
        '
        'txt_op_2
        '
        Me.txt_op_2.Location = New System.Drawing.Point(214, 381)
        Me.txt_op_2.Name = "txt_op_2"
        Me.txt_op_2.Size = New System.Drawing.Size(125, 27)
        Me.txt_op_2.TabIndex = 22
        '
        'txt_operation
        '
        Me.txt_operation.Location = New System.Drawing.Point(378, 381)
        Me.txt_operation.Name = "txt_operation"
        Me.txt_operation.Size = New System.Drawing.Size(125, 27)
        Me.txt_operation.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Operador 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Operador 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(378, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Operation"
        '
        'TimerDate
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 469)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_operation)
        Me.Controls.Add(Me.txt_op_2)
        Me.Controls.Add(Me.txt_op_1)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.bt_sair)
        Me.Controls.Add(Me.bt_equal)
        Me.Controls.Add(Me.bt_clear)
        Me.Controls.Add(Me.btn_mult)
        Me.Controls.Add(Me.btn_div)
        Me.Controls.Add(Me.btn_sub)
        Me.Controls.Add(Me.btn_soma)
        Me.Controls.Add(Me.bt_0)
        Me.Controls.Add(Me.bt_2)
        Me.Controls.Add(Me.bt_3)
        Me.Controls.Add(Me.bt_4)
        Me.Controls.Add(Me.bt_5)
        Me.Controls.Add(Me.bt_6)
        Me.Controls.Add(Me.bt_7)
        Me.Controls.Add(Me.bt_8)
        Me.Controls.Add(Me.bt_9)
        Me.Controls.Add(Me.bt_1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents bt_1 As Button
    Friend WithEvents bt_9 As Button
    Friend WithEvents bt_8 As Button
    Friend WithEvents bt_7 As Button
    Friend WithEvents bt_6 As Button
    Friend WithEvents bt_5 As Button
    Friend WithEvents bt_4 As Button
    Friend WithEvents bt_3 As Button
    Friend WithEvents bt_2 As Button
    Friend WithEvents bt_0 As Button
    Friend WithEvents btn_soma As Button
    Friend WithEvents btn_sub As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents bt_clear As Button
    Friend WithEvents bt_equal As Button
    Friend WithEvents bt_sair As Button
    Friend WithEvents txt_result As TextBox
    Friend WithEvents txt_op_1 As TextBox
    Friend WithEvents txt_op_2 As TextBox
    Friend WithEvents txt_operation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TimerDate As Timer
End Class
