Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tb1
        Dim tb2
        Dim res As Double

        Try
            tb1 = Convert.ToDouble(TextBox1.Text)
            tb2 = Convert.ToDouble(TextBox2.Text)
            res = tb1 / tb2

        Catch ex As Exception

        End Try
        If tb2 = 0 Then
            Label1.Text = "Cannot divide by 0 or letters"
        Else
            Label1.Text = res
        End If



    End Sub

End Class