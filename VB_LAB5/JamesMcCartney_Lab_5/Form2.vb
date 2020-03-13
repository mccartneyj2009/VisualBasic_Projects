Public Class Form2
    Dim Part2Class As part2Class = New part2Class()
    Dim Part2bClass As part2bClass = New part2bClass()

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Num1 As Integer = CType(TextBox1.Text, Integer)
        Dim Num2 As Integer = CType(TextBox2.Text, Integer)
        MessageBox.Show(Part2Class.calculate(Num1, Num2).ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Num1 As Integer = CType(TextBox1.Text, Integer)
        Dim Num2 As Integer = CType(TextBox2.Text, Integer)
        MessageBox.Show(part2bClass.calculate(Num1, Num2).ToString)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class