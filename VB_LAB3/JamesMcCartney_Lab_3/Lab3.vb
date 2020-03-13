
Public Class Lab3
    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        'label 1
        If TextBox1.Text <> "" Then
            ErrorProvider1.Clear()
            Label1.Text = TextBox1.Text
        Else
            ErrorProvider1.SetError(TextBox1, "Please enter text")
            Label1.Text = "Please enter text"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'label 2
        Label2.Text = MaskedTextBox1.Text
        'label 3
        If RadioButton1.Checked Then
            Label3.Text = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            Label3.Text = RadioButton2.Text
        ElseIf RadioButton3.Checked Then
            Label3.Text = RadioButton3.Text
        Else
            Label3.Text = ""
        End If
        'label 6
        If CheckBox1.CheckState = CheckState.Checked Then
            Label6.Text = CheckBox1.Text
        Else
            Label6.Text = ""
        End If
        'label 7
        If CheckBox2.CheckState = CheckState.Checked Then
            Label7.Text = CheckBox2.Text
        Else
            Label7.Text = ""
        End If
        'label 8
        Label8.Text = MonthCalendar1.SelectionStart


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myform2 = New Lab3B
        myform2.Show()
        Me.Hide()
    End Sub
End Class



