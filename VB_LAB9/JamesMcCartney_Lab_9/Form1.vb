Imports System.IO
Imports System.Net
Imports System.Text
Public Class Form1
 
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutPageToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Visible = True
        RichTextBox1.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "HTML Files(.html)|*.html|Text Files(.txt)|*.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim writer As New StreamWriter(SaveFileDialog1.FileName)
            writer.Write(RichTextBox1.Text)
            writer.Close()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        Dim myContent As String
        OpenFileDialog1.Filter = "HTML Files(.html)|*.html|Text Files(.txt)|*.txt|All Files(*.*)|*.*"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim reader As New StreamReader(OpenFileDialog1.FileName)
            myContent = reader.ReadToEnd
            reader.Close()
            RichTextBox1.Text = myContent
            RichTextBox1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Visible = True
        Try
            Dim sourceString As String = New System.Net.WebClient().DownloadString(TextBox1.Text)
            RichTextBox1.Text = sourceString
            Throw New System.Exception("Invalid web address")
            MessageBox.Show("Invalid web address")
        Catch ex As Exception

        End Try
    End Sub
End Class
