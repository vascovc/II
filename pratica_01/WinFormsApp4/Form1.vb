Public Class Form1
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtYear.Text = DateTimePicker1.Value.Year
        txtMonth.Text = DateTimePicker1.Value.Month
        txtDay.Text = DateTimePicker1.Value.Day
        txtDate.Text = DateTimePicker1.Value.Date
    End Sub
End Class
