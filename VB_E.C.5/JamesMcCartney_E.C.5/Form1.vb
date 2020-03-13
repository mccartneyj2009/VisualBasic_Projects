Public Class Form1

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub openFilebtn_Click(sender As Object, e As EventArgs) Handles openFilebtn.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.Text
    End Sub
End Class
