Class MainWindow 

    Private Sub btn_Click(sender As Object, e As RoutedEventArgs) Handles btn.Click
        Dim window1 As New Window1

        window1.Show()
        Me.Hide()

    End Sub
End Class
