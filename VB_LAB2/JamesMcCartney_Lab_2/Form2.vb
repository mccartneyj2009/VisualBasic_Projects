Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim colorChoices As New ColorDialog()
        If colorChoices.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.BackColor = colorChoices.Color
        End If
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myform1 = New Form1
        myform1.Show()
        Me.Hide()
    End Sub
End Class