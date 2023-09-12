Imports Opc.UaFx.Client

Public Class Form1
    Dim ip
    Dim client
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_ip.Text = "ibhlinkua_011088:48010"
        txt_ns.Text = "7"
        txt_s.Text = ".Publish.struct1.u2"
        txt_write.Text = "True"

        btn_update.Enabled = True
        btn_start.Enabled = False
        btn_stop.Enabled = False
        btn_read.Enabled = False
        btn_write.Enabled = False
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        ip = "opc.tcp://" + txt_ip.Text
        btn_update.Enabled = True
        btn_start.Enabled = True
        btn_stop.Enabled = False
        btn_read.Enabled = False
        btn_write.Enabled = False
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        client = New OpcClient(Convert.ToString(ip))
        client.connect()
        btn_update.Enabled = False
        btn_start.Enabled = False
        btn_stop.Enabled = True
        btn_read.Enabled = True
        btn_write.Enabled = True
    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        client.Disconnect()
        btn_update.Enabled = True
        btn_start.Enabled = True
        btn_stop.Enabled = False
        btn_read.Enabled = False
        btn_write.Enabled = False
    End Sub

    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        Dim id = "ns=" + txt_ns.Text & ";s=" & txt_s.Text
        Dim opc_value = client.ReadNode(Convert.ToString(id))
        txt_read.Text = Convert.ToString(opc_value)

    End Sub

    Private Sub btn_write_Click(sender As Object, e As EventArgs) Handles btn_write.Click
        Dim id = "ns=" + txt_ns.Text & ";s=" & txt_s.Text
        Dim opc_value = client.WriteNode(Convert.ToString(id), Convert.ToString(txt_write.Text))

    End Sub
End Class
