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
        Me.btn_send = New System.Windows.Forms.Button()
        Me.btn_receive = New System.Windows.Forms.Button()
        Me.txt_box_send = New System.Windows.Forms.TextBox()
        Me.txt_box_receive = New System.Windows.Forms.TextBox()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.btn_configure = New System.Windows.Forms.Button()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(87, 410)
        Me.btn_send.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(136, 47)
        Me.btn_send.TabIndex = 0
        Me.btn_send.Text = "Send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'btn_receive
        '
        Me.btn_receive.Location = New System.Drawing.Point(423, 410)
        Me.btn_receive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_receive.Name = "btn_receive"
        Me.btn_receive.Size = New System.Drawing.Size(125, 47)
        Me.btn_receive.TabIndex = 1
        Me.btn_receive.Text = "Receive"
        Me.btn_receive.UseVisualStyleBackColor = True
        '
        'txt_box_send
        '
        Me.txt_box_send.Location = New System.Drawing.Point(87, 65)
        Me.txt_box_send.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_box_send.Multiline = True
        Me.txt_box_send.Name = "txt_box_send"
        Me.txt_box_send.Size = New System.Drawing.Size(181, 324)
        Me.txt_box_send.TabIndex = 2
        '
        'txt_box_receive
        '
        Me.txt_box_receive.Location = New System.Drawing.Point(423, 65)
        Me.txt_box_receive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_box_receive.Multiline = True
        Me.txt_box_receive.Name = "txt_box_receive"
        Me.txt_box_receive.Size = New System.Drawing.Size(181, 324)
        Me.txt_box_receive.TabIndex = 3
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(701, 449)
        Me.btn_end.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(135, 44)
        Me.btn_end.TabIndex = 4
        Me.btn_end.Text = "Exit"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'btn_configure
        '
        Me.btn_configure.Location = New System.Drawing.Point(701, 65)
        Me.btn_configure.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_configure.Name = "btn_configure"
        Me.btn_configure.Size = New System.Drawing.Size(151, 44)
        Me.btn_configure.TabIndex = 5
        Me.btn_configure.Text = "Configure Port"
        Me.btn_configure.UseVisualStyleBackColor = True
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(701, 133)
        Me.btn_open.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(151, 43)
        Me.btn_open.TabIndex = 6
        Me.btn_open.Text = "Open Port"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btn_open)
        Me.Controls.Add(Me.btn_configure)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.txt_box_receive)
        Me.Controls.Add(Me.txt_box_send)
        Me.Controls.Add(Me.btn_receive)
        Me.Controls.Add(Me.btn_send)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_send As Button
    Friend WithEvents btn_receive As Button
    Friend WithEvents txt_box_send As TextBox
    Friend WithEvents txt_box_receive As TextBox
    Friend WithEvents btn_end As Button
    Friend WithEvents btn_configure As Button
    Friend WithEvents btn_open As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
