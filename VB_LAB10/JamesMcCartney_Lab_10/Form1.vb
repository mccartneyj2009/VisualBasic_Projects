Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsStore.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.DsStore.Products)
        Label1.Text = BindingNavigator1.CountItem.Text.Substring(1)
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Try
            ProductsBindingSource.EndEdit()
            ProductsTableAdapter.Update(DsStore.Products)
            MessageBox.Show("Saved")
            Me.ProductsTableAdapter.Fill(Me.DsStore.Products)
            Label1.Text = BindingNavigator1.CountItem.Text
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

End Class
