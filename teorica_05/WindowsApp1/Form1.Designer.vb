<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_box = New System.Windows.Forms.TextBox()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.btn_write = New System.Windows.Forms.Button()
        Me.btn_disconnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_box
        '
        Me.txt_box.Location = New System.Drawing.Point(198, 150)
        Me.txt_box.Name = "txt_box"
        Me.txt_box.Size = New System.Drawing.Size(174, 22)
        Me.txt_box.TabIndex = 0
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(52, 78)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(102, 48)
        Me.btn_connect.TabIndex = 1
        Me.btn_connect.Text = "connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'btn_read
        '
        Me.btn_read.Location = New System.Drawing.Point(52, 132)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(102, 51)
        Me.btn_read.TabIndex = 2
        Me.btn_read.Text = "read item"
        Me.btn_read.UseVisualStyleBackColor = True
        '
        'btn_write
        '
        Me.btn_write.Location = New System.Drawing.Point(52, 189)
        Me.btn_write.Name = "btn_write"
        Me.btn_write.Size = New System.Drawing.Size(102, 50)
        Me.btn_write.TabIndex = 3
        Me.btn_write.Text = "write item"
        Me.btn_write.UseVisualStyleBackColor = True
        '
        'btn_disconnect
        '
        Me.btn_disconnect.Location = New System.Drawing.Point(52, 245)
        Me.btn_disconnect.Name = "btn_disconnect"
        Me.btn_disconnect.Size = New System.Drawing.Size(102, 65)
        Me.btn_disconnect.TabIndex = 4
        Me.btn_disconnect.Text = "disconnect"
        Me.btn_disconnect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_disconnect)
        Me.Controls.Add(Me.btn_write)
        Me.Controls.Add(Me.btn_read)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.txt_box)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_box As TextBox
    Friend WithEvents btn_connect As Button
    Friend WithEvents btn_read As Button
    Friend WithEvents btn_write As Button
    Friend WithEvents btn_disconnect As Button
End Class
