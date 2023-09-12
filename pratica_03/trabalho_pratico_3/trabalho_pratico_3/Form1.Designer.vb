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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_send = New System.Windows.Forms.TextBox()
        Me.txt_receive = New System.Windows.Forms.TextBox()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.btn_configure = New System.Windows.Forms.Button()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_history = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TimerReceive
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data to send"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data to receive"
        '
        'txt_send
        '
        Me.txt_send.Location = New System.Drawing.Point(42, 88)
        Me.txt_send.Multiline = True
        Me.txt_send.Name = "txt_send"
        Me.txt_send.Size = New System.Drawing.Size(165, 237)
        Me.txt_send.TabIndex = 2
        '
        'txt_receive
        '
        Me.txt_receive.Location = New System.Drawing.Point(247, 88)
        Me.txt_receive.Multiline = True
        Me.txt_receive.Name = "txt_receive"
        Me.txt_receive.ReadOnly = True
        Me.txt_receive.Size = New System.Drawing.Size(166, 237)
        Me.txt_receive.TabIndex = 3
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(73, 349)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(96, 41)
        Me.btn_send.TabIndex = 4
        Me.btn_send.Text = "Send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'btn_configure
        '
        Me.btn_configure.Location = New System.Drawing.Point(483, 121)
        Me.btn_configure.Name = "btn_configure"
        Me.btn_configure.Size = New System.Drawing.Size(138, 43)
        Me.btn_configure.TabIndex = 5
        Me.btn_configure.Text = "Configure Port"
        Me.btn_configure.UseVisualStyleBackColor = True
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(483, 185)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(138, 45)
        Me.btn_open.TabIndex = 6
        Me.btn_open.Text = "Open port"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(504, 349)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(90, 41)
        Me.btn_end.TabIndex = 7
        Me.btn_end.Text = "Exit"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(696, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Communication History"
        '
        'txt_history
        '
        Me.txt_history.Location = New System.Drawing.Point(700, 88)
        Me.txt_history.Multiline = True
        Me.txt_history.Name = "txt_history"
        Me.txt_history.ReadOnly = True
        Me.txt_history.Size = New System.Drawing.Size(166, 237)
        Me.txt_history.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 423)
        Me.Controls.Add(Me.txt_history)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_open)
        Me.Controls.Add(Me.btn_configure)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.txt_receive)
        Me.Controls.Add(Me.txt_send)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_send As TextBox
    Friend WithEvents txt_receive As TextBox
    Friend WithEvents btn_send As Button
    Friend WithEvents btn_configure As Button
    Friend WithEvents btn_open As Button
    Friend WithEvents btn_end As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_history As TextBox
End Class
