Public Class dfltText

    Private Sub TransformedTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransformedTextToolStripMenuItem.Click
        Me.Hide()
        transText.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub Form1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        g.RotateTransform(0)
        g.TranslateTransform(50, 50)
        g.DrawString("This is the text" & vbCrLf & "that will be used to eximplify" & vbCrLf &
                     "the features of" & vbCrLf & "using GDI+ to transform text.", New Font("Times New Roman", 12), Brushes.Black, 0, 0)
        g.ResetTransform()
    End Sub

End Class
