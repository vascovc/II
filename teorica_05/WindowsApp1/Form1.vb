Imports System.ComponentModel

Public Class Form1
    Dim fs As New FaconSvr.FaconServer
    Dim path As String = "C:\Users\Vasco\Documents\MEGAsync\4-2\II\teorica_05\"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fs.OpenProject(path + "aula.fcs")
    End Sub

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        fs.Connect()
    End Sub

    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        txt_box.Text = fs.GetItem("Channel0.Station0.Group0", "M100")
    End Sub

    Private Sub btn_write_Click(sender As Object, e As EventArgs) Handles btn_write.Click
        Dim ss As String
        ss = txt_box.Text
        fs.SetItem("Channel0.Station0.Group0", "M100", ss)
    End Sub

    Private Sub btn_disconnect_Click(sender As Object, e As EventArgs) Handles btn_disconnect.Click
        fs.Disconnect()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        fs.Disconnect()
    End Sub

End Class
