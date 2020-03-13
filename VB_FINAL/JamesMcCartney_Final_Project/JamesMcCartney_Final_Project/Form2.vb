Public Class transText

    Private Sub DefaultTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultTextToolStripMenuItem.Click
        Me.Hide()
        dfltText.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        dfltText.Close()
    End Sub

    Public Sub Form1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        g.RotateTransform(33)
        g.TranslateTransform(250, 0)
        g.ScaleTransform(1.5, 0.5)
        g.DrawString("This is the text" & vbCrLf & "that will be used to eximplify" & vbCrLf &
                     "the features of" & vbCrLf & "using GDI+ to transform text.", New Font("Delta LCD", 20), Brushes.Red, 0, 0)
        g.ResetTransform()
    End Sub

End Class