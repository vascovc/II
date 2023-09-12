Imports System.IO.Ports
Imports FaconSvr

Public Class Form1
    Dim Y0 As Integer
    Dim Y1 As Integer
    Dim Y2 As Integer

    Dim X0 As Integer
    Dim X1 As Integer
    Dim X2 As Integer
    Dim X3 As Integer

    Dim fs As New FaconSvr.FaconServer

    Dim is_fs_connected As Boolean = False
    Dim CSG As String = "Channel0.Station0.Group0"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerReceive.Interval = 100
        TimerReceive.Enabled = True

        disconnect_gui()
    End Sub

    Private Sub ComunicaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComunicaçõesToolStripMenuItem.Click

        fs.OpenProject("C:\Users\Vasco Costa\Documents\MEGAsync\4-2\II\pratica_06\facon.fcs")
        'fs.Connect()
        is_fs_connected = True

        btn_y0.Enabled = True
        btn_y1.Enabled = True
        btn_y2.Enabled = True
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        Y0 = fs.GetItem(CSG, "Y0")
        Y1 = fs.GetItem(CSG, "Y1")
        Y2 = fs.GetItem(CSG, "Y2")

        X0 = fs.GetItem(CSG, "X0")
        X1 = fs.GetItem(CSG, "X1")
        X2 = fs.GetItem(CSG, "X2")
        X3 = fs.GetItem(CSG, "X3")

        txt_water_level.Text = fs.GetItem(CSG, "D300")

        chb_x0.Checked = X0
        chb_x1.Checked = X1
        chb_x2.Checked = X2
        chb_x3.Checked = X3

        chb_y0.Checked = Y0
        chb_y1.Checked = Y1
        chb_y2.Checked = Y2

        auto_mode_func()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btn_y0_Click(sender As Object, e As EventArgs) Handles btn_y0.Click
        Y0 = If(Y0 = 1, 0, 1)
        fs.SetItem(CSG, "Y0", Y0)
    End Sub

    Private Sub btn_y1_Click(sender As Object, e As EventArgs) Handles btn_y1.Click
        Y1 = If(Y1 = 1, 0, 1)
        fs.SetItem(CSG, "Y1", Y1)
    End Sub

    Private Sub btn_y2_Click(sender As Object, e As EventArgs) Handles btn_y2.Click
        Y2 = If(Y2 = 1, 0, 1)
        fs.SetItem(CSG, "Y2", Y2)
    End Sub

    Private Sub disconnect_gui()
        btn_y0.Enabled = False
        btn_y1.Enabled = False
        btn_y2.Enabled = False
        is_fs_connected = False
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

        fs.SetItem(CSG, "Y0", Y0)
        fs.SetItem(CSG, "Y1", Y1)
        fs.SetItem(CSG, "Y2", Y2)
        ToolStripStatusLabel1.Text = ""
        If X0 = 1 And X1 <> 1 Then
            ToolStripStatusLabel1.Text = "Vazio!!!"
        End If
        If X3 = 1 Then
            ToolStripStatusLabel1.Text = "Cheio!!!"
        End If

    End Sub
End Class
