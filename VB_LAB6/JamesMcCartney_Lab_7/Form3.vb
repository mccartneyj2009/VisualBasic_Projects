Public Class Form3


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "This program allows the user to choose the background color of the first form seen."
        Label2.Text = "It also allows the user to navigate to a second form the can be used to divide two numbers."
        Label3.Text = "Programmer: James McCartney"
    End Sub
End Class