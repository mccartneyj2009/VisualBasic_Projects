Public Class Form1
    Dim Part1Class As Part1Class = New Part1Class()



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer = CType(TextBox1.Text, Integer)
        Dim num2 As Integer = CType(TextBox2.Text, Integer)
        If TextBox3.Text <> "" Then
            Dim num3 As Integer = CType(TextBox3.Text, Integer)
            MessageBox.Show(Part1Class.Add(num1, num2, num3).ToString())
        Else
            MessageBox.Show(Part1Class.Add(num1, num2).ToString())
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text <> "" Then
            MessageBox.Show(Part1Class.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text))
        Else
            MessageBox.Show(Part1Class.Add(TextBox1.Text, TextBox2.Text))
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class