Public Class Form1

    Public Sub Change(ByVal chg As Color)
        If chg = Color.Red Then
            Me.BackColor = Drawing.Color.Red
        ElseIf chg = Color.Blue Then
            Me.BackColor = Drawing.Color.Blue
        ElseIf chg = Color.Green Then
            Me.BackColor = Drawing.Color.Green
        ElseIf chg = Color.Yellow Then
            Me.BackColor = Drawing.Color.Yellow
        End If
    End Sub

    Public Enum Color
        Red
        Blue
        Green
        Yellow
    End Enum

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Change(Color.Red)
        Label1.Text = "Red"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Change(Color.Blue)
        Label1.Text = "Blue"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Change(Color.Green)
        Label1.Text = "Green"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Change(Color.Yellow)
        Label1.Text = "Yellow"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = DefaultBackColor
        Label1.Text = " "
    End Sub
End Class
