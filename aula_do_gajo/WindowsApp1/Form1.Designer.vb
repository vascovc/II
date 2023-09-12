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
        Me.txt_ip = New System.Windows.Forms.TextBox()
        Me.txt_ns = New System.Windows.Forms.TextBox()
        Me.txt_s = New System.Windows.Forms.TextBox()
        Me.txt_read = New System.Windows.Forms.TextBox()
        Me.txt_write = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.btn_write = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_ip
        '
        Me.txt_ip.Location = New System.Drawing.Point(97, 44)
        Me.txt_ip.Name = "txt_ip"
        Me.txt_ip.Size = New System.Drawing.Size(160, 22)
        Me.txt_ip.TabIndex = 0
        '
        'txt_ns
        '
        Me.txt_ns.Location = New System.Drawing.Point(97, 167)
        Me.txt_ns.Name = "txt_ns"
        Me.txt_ns.Size = New System.Drawing.Size(160, 22)
        Me.txt_ns.TabIndex = 1
        '
        'txt_s
        '
        Me.txt_s.Location = New System.Drawing.Point(97, 195)
        Me.txt_s.Name = "txt_s"
        Me.txt_s.Size = New System.Drawing.Size(160, 22)
        Me.txt_s.TabIndex = 2
        '
        'txt_read
        '
        Me.txt_read.Location = New System.Drawing.Point(97, 251)
        Me.txt_read.Multiline = True
        Me.txt_read.Name = "txt_read"
        Me.txt_read.Size = New System.Drawing.Size(160, 100)
        Me.txt_read.TabIndex = 3
        '
        'txt_write
        '
        Me.txt_write.Location = New System.Drawing.Point(97, 394)
        Me.txt_write.Name = "txt_write"
        Me.txt_write.Size = New System.Drawing.Size(160, 22)
        Me.txt_write.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ns"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "s"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Read Info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 394)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Write Info"
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(97, 72)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(160, 27)
        Me.btn_update.TabIndex = 10
        Me.btn_update.Text = "Update Configuration"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(97, 138)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(160, 27)
        Me.btn_stop.TabIndex = 11
        Me.btn_stop.Text = "Stop Connection"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(97, 105)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(160, 27)
        Me.btn_start.TabIndex = 12
        Me.btn_start.Text = "Start Connection"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_read
        '
        Me.btn_read.Location = New System.Drawing.Point(97, 223)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(160, 27)
        Me.btn_read.TabIndex = 13
        Me.btn_read.Text = "Read"
        Me.btn_read.UseVisualStyleBackColor = True
        '
        'btn_write
        '
        Me.btn_write.Location = New System.Drawing.Point(97, 361)
        Me.btn_write.Name = "btn_write"
        Me.btn_write.Size = New System.Drawing.Size(160, 27)
        Me.btn_write.TabIndex = 14
        Me.btn_write.Text = "Write"
        Me.btn_write.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 450)
        Me.Controls.Add(Me.btn_write)
        Me.Controls.Add(Me.btn_read)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_write)
        Me.Controls.Add(Me.txt_read)
        Me.Controls.Add(Me.txt_s)
        Me.Controls.Add(Me.txt_ns)
        Me.Controls.Add(Me.txt_ip)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_ip As TextBox
    Friend WithEvents txt_ns As TextBox
    Friend WithEvents txt_s As TextBox
    Friend WithEvents txt_read As TextBox
    Friend WithEvents txt_write As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_read As Button
    Friend WithEvents btn_write As Button
End Class
