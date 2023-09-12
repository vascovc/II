Imports System.IO.Ports

Public Class Form1
    Dim Y0 As Integer
    Dim Y1 As Integer
    Dim Y2 As Integer

    Dim X0 As Integer
    Dim X1 As Integer
    Dim X2 As Integer
    Dim X3 As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerReceive.Interval = 100
        disconnect_gui()
    End Sub

    Private Sub ComunicaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComunicaçõesToolStripMenuItem.Click

        Form2.StartPosition = FormStartPosition.CenterParent
        Form2.ShowDialog()

        If Module_com_port_parameters.configuration_is_valid = True Then
            With SerialPort1
                .PortName = Module_com_port_parameters.port
                .BaudRate = Module_com_port_parameters.baud_rate
                .Parity = Module_com_port_parameters.parity
                .DataBits = Module_com_port_parameters.data_bits
                .StopBits = Module_com_port_parameters.stop_bits
            End With

        End If

    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        If SerialPort1.BytesToRead = 0 Then
            Return
        End If

        Dim data = SerialPort1.ReadExisting()

        Dim start_position = InStr(data, "s")

        If start_position = 0 Then
            Return
        End If

        Dim end_position = InStr(data, "e")

        Dim data_crop As String = Mid(data, start_position, end_position - start_position + 1)

        If Not Len(data_crop) = Len("s_ToPC0000000A_e") Then
            Return
        End If

        show_form.txt_received.Text += Now.ToString + " " + data_crop + vbCrLf

        chb_y0.Checked = Mid(data_crop, 7, 1)
        chb_y1.Checked = Mid(data_crop, 8, 1)
        chb_y2.Checked = Mid(data_crop, 9, 1)

        X0 = Mid(data_crop, 10, 1)
        X1 = Mid(data_crop, 11, 1)
        X2 = Mid(data_crop, 12, 1)
        X3 = Mid(data_crop, 13, 1)

        chb_x0.Checked = X0
        chb_x1.Checked = X1
        chb_x2.Checked = X2
        chb_x3.Checked = X3

        Dim level = Asc(Mid(data_crop, 14, 1))
        txt_water_level.Text = level

        auto_mode_func()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        show_form.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub send_command()
        Dim output As String = "s_ToPLC" + CStr(Y0) + CStr(Y1) + CStr(Y2) + "_e"
        SerialPort1.Write(output)
        show_form.txt_send.Text += Now.ToString + " " + output + vbCrLf

    End Sub

    Private Sub btn_y0_Click(sender As Object, e As EventArgs) Handles btn_y0.Click
        Y0 = If(Y0 = 1, 0, 1)
        send_command()
    End Sub

    Private Sub btn_y1_Click(sender As Object, e As EventArgs) Handles btn_y1.Click
        Y1 = If(Y1 = 1, 0, 1)
        send_command()
    End Sub

    Private Sub btn_y2_Click(sender As Object, e As EventArgs) Handles btn_y2.Click
        Y2 = If(Y2 = 1, 0, 1)
        send_command()
    End Sub

    Private Sub OpenPortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPortToolStripMenuItem.Click
        If Module_com_port_parameters.configuration_is_valid = True Then
            If SerialPort1.IsOpen Then
                disconnect_gui()
                SerialPort1.Close()
                OpenPortToolStripMenuItem.Text = "Open Port"
            Else
                SerialPort1.Open()
                OpenPortToolStripMenuItem.Text = "Close Port"
                btn_y0.Enabled = True
                btn_y1.Enabled = True
                btn_y2.Enabled = True
                TimerReceive.Enabled = True
            End If
        Else
            MsgBox("Cannot open port with an invalid configuration!")
        End If
    End Sub

    Private Sub disconnect_gui()
        TimerReceive.Enabled = False
        btn_y0.Enabled = False
        btn_y1.Enabled = False
        btn_y2.Enabled = False
    End Sub

    Private Sub auto_mode_func()
        If X1 = 0 Then
            Y0 = 1
            Y1 = 1
            Y2 = 0
        End If
        If X1 = 1 Then
            Y2 = 1
        End If
        If X2 = 1 Then
            Y0 = 0
            Y1 = 0
        End If

        send_command()

        ToolStripStatusLabel1.Text = ""
        If X0 = 1 And X1 <> 1 Then
            ToolStripStatusLabel1.Text = "Reservatorio Vazio!!!"
        End If
        If X3 = 1 Then
            ToolStripStatusLabel1.Text = "Reservatorio Cheio!!!"
        End If

    End Sub

End Class
