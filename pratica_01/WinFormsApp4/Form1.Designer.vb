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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(38, 166)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ano"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(431, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mês"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(431, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Data"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(494, 126)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(125, 27)
        Me.txtYear.TabIndex = 5
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(494, 160)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(125, 27)
        Me.txtMonth.TabIndex = 6
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(494, 194)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(125, 27)
        Me.txtDay.TabIndex = 7
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(494, 228)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(125, 27)
        Me.txtDate.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtDay As TextBox
    Friend WithEvents txtDate As TextBox
End Class
