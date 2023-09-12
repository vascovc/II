Public Class Form2
    Private Sub form_configure_port_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim available_ports As Array = IO.Ports.SerialPort.GetPortNames
        Dim i As Integer

        combo_port.Items.Clear()
        For i = 0 To UBound(available_ports)
            combo_port.Items.Add(available_ports(i))
        Next
        combo_port.SelectedIndex = 0

        'os selectedIndex vao levar a que esteja sempre configurado

        combo_baud_rate.Items.Clear()
        combo_baud_rate.Items.Add("4800")
        combo_baud_rate.Items.Add("9600")
        combo_baud_rate.Items.Add("19200")
        combo_baud_rate.SelectedIndex = 1

        combo_parity.Items.Clear()
        combo_parity.Items.Add(IO.Ports.Parity.None)
        combo_parity.Items.Add(IO.Ports.Parity.Odd)
        combo_parity.Items.Add(IO.Ports.Parity.Even)
        combo_parity.SelectedIndex = 2

        combo_data_bits.Items.Clear()
        combo_data_bits.Items.Add("7")
        combo_data_bits.Items.Add("8")
        combo_data_bits.SelectedIndex = 0

        combo_stop.Items.Clear()
        combo_stop.Items.Add("1")
        combo_stop.Items.Add("2")
        combo_stop.SelectedIndex = 0

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Module_com_port_parameters.configuration_is_valid = False
        Me.Close()

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Module_com_port_parameters.port = combo_port.Text
        Module_com_port_parameters.baud_rate = combo_baud_rate.Text
        Select Case combo_parity.Text
            Case "None"
                Module_com_port_parameters.parity = IO.Ports.Parity.None
            Case "Even"
                Module_com_port_parameters.parity = IO.Ports.Parity.Even
            Case "Odd"
                Module_com_port_parameters.parity = IO.Ports.Parity.Odd
        End Select
        Module_com_port_parameters.data_bits = combo_data_bits.Text
        Module_com_port_parameters.stop_bits = combo_stop.Text
        Module_com_port_parameters.configuration_is_valid = True
        Me.Close()

    End Sub
End Class