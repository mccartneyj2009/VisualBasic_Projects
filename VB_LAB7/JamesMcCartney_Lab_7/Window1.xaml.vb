Public Class Window1

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim mainwindow As New MainWindow

        mainwindow.Show()
        Me.Hide()

    End Sub

  

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        Dim value As Int32 = textbox1.Text * textbox2.Text

        labelval.Content = value

    End Sub
End Class
