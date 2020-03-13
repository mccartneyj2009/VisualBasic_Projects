Public Class Form1
    Dim start
    Dim stops
    Dim span


    Private Sub Startbtn_Click(sender As Object, e As EventArgs) Handles Startbtn.Click
        start = DateTime.Now
    End Sub

    Private Sub Stopbtn_Click(sender As Object, e As EventArgs) Handles Stopbtn.Click
        stops = DateTime.Now
        span = span + (stops - start)
        spanlbl.Text = span.ToString
    End Sub
End Class
