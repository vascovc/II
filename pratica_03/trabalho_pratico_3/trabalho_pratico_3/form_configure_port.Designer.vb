<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_configure_port
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.combo_port = New System.Windows.Forms.ComboBox()
        Me.combo_baud_rate = New System.Windows.Forms.ComboBox()
        Me.combo_parity = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BaudRate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Parity"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(37, 176)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(77, 40)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(191, 175)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(81, 41)
        Me.btn_ok.TabIndex = 4
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'combo_port
        '
        Me.combo_port.FormattingEnabled = True
        Me.combo_port.Location = New System.Drawing.Point(166, 57)
        Me.combo_port.Name = "combo_port"
        Me.combo_port.Size = New System.Drawing.Size(121, 24)
        Me.combo_port.TabIndex = 5
        '
        'combo_baud_rate
        '
        Me.combo_baud_rate.FormattingEnabled = True
        Me.combo_baud_rate.Location = New System.Drawing.Point(166, 92)
        Me.combo_baud_rate.Name = "combo_baud_rate"
        Me.combo_baud_rate.Size = New System.Drawing.Size(121, 24)
        Me.combo_baud_rate.TabIndex = 6
        '
        'combo_parity
        '
        Me.combo_parity.FormattingEnabled = True
        Me.combo_parity.Location = New System.Drawing.Point(166, 124)
        Me.combo_parity.Name = "combo_parity"
        Me.combo_parity.Size = New System.Drawing.Size(121, 24)
        Me.combo_parity.TabIndex = 7
        '
        'form_configure_port
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 254)
        Me.Controls.Add(Me.combo_parity)
        Me.Controls.Add(Me.combo_baud_rate)
        Me.Controls.Add(Me.combo_port)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_configure_port"
        Me.Text = "form_configure_port"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents combo_port As ComboBox
    Friend WithEvents combo_baud_rate As ComboBox
    Friend WithEvents combo_parity As ComboBox
End Class
