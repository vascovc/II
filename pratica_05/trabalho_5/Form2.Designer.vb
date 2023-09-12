<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.combo_parity = New System.Windows.Forms.ComboBox()
        Me.combo_baud_rate = New System.Windows.Forms.ComboBox()
        Me.combo_port = New System.Windows.Forms.ComboBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combo_data_bits = New System.Windows.Forms.ComboBox()
        Me.combo_stop = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'combo_parity
        '
        Me.combo_parity.FormattingEnabled = True
        Me.combo_parity.Location = New System.Drawing.Point(153, 96)
        Me.combo_parity.Name = "combo_parity"
        Me.combo_parity.Size = New System.Drawing.Size(121, 24)
        Me.combo_parity.TabIndex = 15
        '
        'combo_baud_rate
        '
        Me.combo_baud_rate.FormattingEnabled = True
        Me.combo_baud_rate.Location = New System.Drawing.Point(153, 64)
        Me.combo_baud_rate.Name = "combo_baud_rate"
        Me.combo_baud_rate.Size = New System.Drawing.Size(121, 24)
        Me.combo_baud_rate.TabIndex = 14
        '
        'combo_port
        '
        Me.combo_port.FormattingEnabled = True
        Me.combo_port.Location = New System.Drawing.Point(153, 29)
        Me.combo_port.Name = "combo_port"
        Me.combo_port.Size = New System.Drawing.Size(121, 24)
        Me.combo_port.TabIndex = 13
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(193, 206)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(81, 41)
        Me.btn_ok.TabIndex = 12
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(27, 207)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(77, 40)
        Me.btn_cancel.TabIndex = 11
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Parity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "BaudRate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Data Bits"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Stop Bit"
        '
        'combo_data_bits
        '
        Me.combo_data_bits.FormattingEnabled = True
        Me.combo_data_bits.Location = New System.Drawing.Point(153, 128)
        Me.combo_data_bits.Name = "combo_data_bits"
        Me.combo_data_bits.Size = New System.Drawing.Size(121, 24)
        Me.combo_data_bits.TabIndex = 18
        '
        'combo_stop
        '
        Me.combo_stop.FormattingEnabled = True
        Me.combo_stop.Location = New System.Drawing.Point(153, 161)
        Me.combo_stop.Name = "combo_stop"
        Me.combo_stop.Size = New System.Drawing.Size(121, 24)
        Me.combo_stop.TabIndex = 19
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 274)
        Me.Controls.Add(Me.combo_stop)
        Me.Controls.Add(Me.combo_data_bits)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.combo_parity)
        Me.Controls.Add(Me.combo_baud_rate)
        Me.Controls.Add(Me.combo_port)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combo_parity As ComboBox
    Friend WithEvents combo_baud_rate As ComboBox
    Friend WithEvents combo_port As ComboBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents combo_data_bits As ComboBox
    Friend WithEvents combo_stop As ComboBox
End Class
