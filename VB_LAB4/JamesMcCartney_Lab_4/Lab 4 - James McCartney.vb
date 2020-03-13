Public Class Form1
    Dim myNewClass As InputClass = New InputClass()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBanner.Text = myNewClass._Banner
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        myNewClass.YourName = txtName.Text
        MessageBox.Show(myNewClass.YourName)
        txtName.Text = ""
    End Sub

End Class
