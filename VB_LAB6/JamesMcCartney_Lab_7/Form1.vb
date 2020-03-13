Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OpenForm2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenForm2ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackColor = Color.Red
        ssinfo.Text = "Red Background"
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Color.Green
        ssinfo.Text = "Green Background"
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.CornflowerBlue
        ssinfo.Text = "Blue Background"
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.BackColor = Color.Red
        ssinfo.Text = "Red Background"
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.BackColor = Color.Green
        ssinfo.Text = "Green Background"
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.BackColor = Color.CornflowerBlue
        ssinfo.Text = "Blue Background"
    End Sub

    Private Sub RedToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem1.Click
        Me.BackColor = Color.Red
        ssinfo.Text = "Red Background"
    End Sub

    Private Sub GreenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem1.Click
        Me.BackColor = Color.Green
        ssinfo.Text = "Green Background"
    End Sub

    Private Sub BlueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem1.Click
        Me.BackColor = Color.CornflowerBlue
        ssinfo.Text = "Blue Background"
    End Sub


End Class
