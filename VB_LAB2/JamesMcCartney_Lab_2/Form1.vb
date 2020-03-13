Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myform2 = New Form2
        myform2.Show()
        Me.Hide() 
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myform3 = New Form3
        myform3.Show()
        Me.Hide()
    End Sub
End Class
