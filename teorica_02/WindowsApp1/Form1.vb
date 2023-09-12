Imports System.ComponentModel
Imports System.IO.Ports

Public Class Form1
    Dim tx, rx As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Start()
        SerialPort1.PortName = "com6"
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = IO.Ports.Parity.Even
        SerialPort1.DataBits = 8
        SerialPort1.StopBits = 2
        SerialPort1.Handshake = IO.Ports.Handshake.None
        SerialPort1.Encoding = System.Text.UTF8Encoding.UTF8
        SerialPort1.Open()
    End Sub

    Private Sub BtEnviar_Click(sender As Object, e As EventArgs) Handles BtEnviar.Click
        tx = txtEnviar.Text
        SerialPort1.Write(tx)
        'Dim barray() As Byte = {48, 127, 230, 51, 52, 0} 
        'SerialPort1.Write(barray, 0, 6) 
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RadioButton1.Checked = Not (RadioButton1.Checked)
        txtReceber.Text = rx
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If SerialPort1.IsOpen() Then
            SerialPort1.Close()
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        rx = rx & SerialPort1.ReadExisting()
    End Sub
End Class
