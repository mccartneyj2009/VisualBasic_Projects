Imports System.Windows.Forms
Public Class setAlarm

    Public Function setAlarm() As String
        Dim result As String = "12:00:00 AM"
        Try
            result = mskTime.Text
            If radAM.Checked Then
                result &= " AM"
            Else
                result &= " PM"
            End If
            Return result
        Catch ex As Exception
            MessageBox.Show("Error entering time:" & ex.Message)
            result = "12:00:00 AM"
        End Try
        Return result
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.almTime.Text = setAlarm()
        Me.Close()
        Form1.almOn.Checked = True
        Form1.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        Form1.Show()
    End Sub
End Class