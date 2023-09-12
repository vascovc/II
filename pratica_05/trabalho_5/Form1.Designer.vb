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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComunicaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chb_y0 = New System.Windows.Forms.CheckBox()
        Me.chb_y1 = New System.Windows.Forms.CheckBox()
        Me.chb_x3 = New System.Windows.Forms.CheckBox()
        Me.chb_x2 = New System.Windows.Forms.CheckBox()
        Me.chb_x1 = New System.Windows.Forms.CheckBox()
        Me.chb_x0 = New System.Windows.Forms.CheckBox()
        Me.chb_y2 = New System.Windows.Forms.CheckBox()
        Me.btn_y0 = New System.Windows.Forms.Button()
        Me.btn_y1 = New System.Windows.Forms.Button()
        Me.btn_y2 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_water_level = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(43, 47)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(715, 334)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComunicaçõesToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ExitToolStripMenuItem, Me.OpenPortToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(820, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComunicaçõesToolStripMenuItem
        '
        Me.ComunicaçõesToolStripMenuItem.Name = "ComunicaçõesToolStripMenuItem"
        Me.ComunicaçõesToolStripMenuItem.Size = New System.Drawing.Size(119, 26)
        Me.ComunicaçõesToolStripMenuItem.Text = "Comunicações"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OpenPortToolStripMenuItem
        '
        Me.OpenPortToolStripMenuItem.Name = "OpenPortToolStripMenuItem"
        Me.OpenPortToolStripMenuItem.Size = New System.Drawing.Size(91, 26)
        Me.OpenPortToolStripMenuItem.Text = "Open port"
        '
        'chb_y0
        '
        Me.chb_y0.AutoSize = True
        Me.chb_y0.Location = New System.Drawing.Point(57, 124)
        Me.chb_y0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_y0.Name = "chb_y0"
        Me.chb_y0.Size = New System.Drawing.Size(90, 20)
        Me.chb_y0.TabIndex = 2
        Me.chb_y0.Text = "Y0 (pump)"
        Me.chb_y0.UseVisualStyleBackColor = True
        '
        'chb_y1
        '
        Me.chb_y1.AutoSize = True
        Me.chb_y1.Location = New System.Drawing.Point(219, 105)
        Me.chb_y1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_y1.Name = "chb_y1"
        Me.chb_y1.Size = New System.Drawing.Size(63, 20)
        Me.chb_y1.TabIndex = 3
        Me.chb_y1.Text = "Y1(in)"
        Me.chb_y1.UseVisualStyleBackColor = True
        '
        'chb_x3
        '
        Me.chb_x3.AutoSize = True
        Me.chb_x3.Location = New System.Drawing.Point(520, 114)
        Me.chb_x3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_x3.Name = "chb_x3"
        Me.chb_x3.Size = New System.Drawing.Size(74, 20)
        Me.chb_x3.TabIndex = 4
        Me.chb_x3.Text = "X3 over"
        Me.chb_x3.UseVisualStyleBackColor = True
        '
        'chb_x2
        '
        Me.chb_x2.AutoSize = True
        Me.chb_x2.Location = New System.Drawing.Point(520, 142)
        Me.chb_x2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_x2.Name = "chb_x2"
        Me.chb_x2.Size = New System.Drawing.Size(63, 20)
        Me.chb_x2.TabIndex = 5
        Me.chb_x2.Text = "X2 full"
        Me.chb_x2.UseVisualStyleBackColor = True
        '
        'chb_x1
        '
        Me.chb_x1.AutoSize = True
        Me.chb_x1.Location = New System.Drawing.Point(520, 228)
        Me.chb_x1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_x1.Name = "chb_x1"
        Me.chb_x1.Size = New System.Drawing.Size(44, 20)
        Me.chb_x1.TabIndex = 6
        Me.chb_x1.Text = "X1"
        Me.chb_x1.UseVisualStyleBackColor = True
        '
        'chb_x0
        '
        Me.chb_x0.AutoSize = True
        Me.chb_x0.Location = New System.Drawing.Point(520, 281)
        Me.chb_x0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_x0.Name = "chb_x0"
        Me.chb_x0.Size = New System.Drawing.Size(102, 20)
        Me.chb_x0.TabIndex = 7
        Me.chb_x0.Text = "X0 (alarm in)"
        Me.chb_x0.UseVisualStyleBackColor = True
        '
        'chb_y2
        '
        Me.chb_y2.AutoSize = True
        Me.chb_y2.Location = New System.Drawing.Point(632, 190)
        Me.chb_y2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_y2.Name = "chb_y2"
        Me.chb_y2.Size = New System.Drawing.Size(71, 20)
        Me.chb_y2.TabIndex = 8
        Me.chb_y2.Text = "Y2(out)"
        Me.chb_y2.UseVisualStyleBackColor = True
        '
        'btn_y0
        '
        Me.btn_y0.Location = New System.Drawing.Point(57, 343)
        Me.btn_y0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_y0.Name = "btn_y0"
        Me.btn_y0.Size = New System.Drawing.Size(75, 34)
        Me.btn_y0.TabIndex = 9
        Me.btn_y0.Text = "Ativar Y0"
        Me.btn_y0.UseVisualStyleBackColor = True
        '
        'btn_y1
        '
        Me.btn_y1.Location = New System.Drawing.Point(219, 263)
        Me.btn_y1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_y1.Name = "btn_y1"
        Me.btn_y1.Size = New System.Drawing.Size(75, 41)
        Me.btn_y1.TabIndex = 10
        Me.btn_y1.Text = "Ativar Y1"
        Me.btn_y1.UseVisualStyleBackColor = True
        '
        'btn_y2
        '
        Me.btn_y2.Location = New System.Drawing.Point(632, 354)
        Me.btn_y2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_y2.Name = "btn_y2"
        Me.btn_y2.Size = New System.Drawing.Size(75, 34)
        Me.btn_y2.TabIndex = 11
        Me.btn_y2.Text = "Ativar Y2"
        Me.btn_y2.UseVisualStyleBackColor = True
        '
        'TimerReceive
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(391, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Water Level"
        '
        'txt_water_level
        '
        Me.txt_water_level.Location = New System.Drawing.Point(381, 62)
        Me.txt_water_level.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_water_level.Name = "txt_water_level"
        Me.txt_water_level.Size = New System.Drawing.Size(100, 22)
        Me.txt_water_level.TabIndex = 13
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 414)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(820, 24)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 18)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 438)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txt_water_level)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_y2)
        Me.Controls.Add(Me.btn_y1)
        Me.Controls.Add(Me.btn_y0)
        Me.Controls.Add(Me.chb_y2)
        Me.Controls.Add(Me.chb_x0)
        Me.Controls.Add(Me.chb_x1)
        Me.Controls.Add(Me.chb_x2)
        Me.Controls.Add(Me.chb_x3)
        Me.Controls.Add(Me.chb_y1)
        Me.Controls.Add(Me.chb_y0)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ComunicaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chb_y0 As CheckBox
    Friend WithEvents chb_y1 As CheckBox
    Friend WithEvents chb_x3 As CheckBox
    Friend WithEvents chb_x2 As CheckBox
    Friend WithEvents chb_x1 As CheckBox
    Friend WithEvents chb_x0 As CheckBox
    Friend WithEvents chb_y2 As CheckBox
    Friend WithEvents btn_y0 As Button
    Friend WithEvents btn_y1 As Button
    Friend WithEvents btn_y2 As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_water_level As TextBox
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
