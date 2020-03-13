Imports System.Speech.Synthesis
Imports System.Threading.Tasks
Public Class Form1
    Dim synth As SpeechSynthesizer = New SpeechSynthesizer
    Dim flag As Boolean = False

    'start current time timer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrntTimetmr.Start()
    End Sub

    'current time timer label
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles CrntTimetmr.Tick
        crntTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    ' exit application
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Application.Exit()
    End Sub

    'show alarm set page
    Private Sub SetAlarmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetAlarmToolStripMenuItem.Click
        setAlarm.Show()
        Me.Hide()
    End Sub

    'add five seconds to alarm time
    Private Sub fivescndbtn_Click(sender As Object, e As EventArgs) Handles fivescndbtn.Click
        almTime.Text = DateAdd(DateInterval.Second, 5, CDate(almTime.Text))
    End Sub

    'set alarm off
    Private Sub almTmr_Tick(sender As Object, e As EventArgs) Handles almTmr.Tick
        If almOn.Checked = True Then
            If crntTime.Text = almTime.Text Then
                'add sounds
                If AnnoyingBeepToolStripMenuItem.Checked Then
                    My.Computer.Audio.Play("C:\Users\jmccartney\Documents\Visual Studio 2012\_____Sounds\Sounds\_____Sounds\alarm_clock_1.wav", AudioPlayMode.BackgroundLoop)
                ElseIf TexttoSpeechToolStripMenuItem.Checked Then
                    synth.Dispose()
                    synth = New SpeechSynthesizer
                    synth.SpeakAsync(txttospch.Text)
                End If
            End If
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    'annoying sound menu item is checked
    Private Sub AnnoyingBeepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnoyingBeepToolStripMenuItem.Click
        AnnoyingBeepToolStripMenuItem.Checked = True
        TexttoSpeechToolStripMenuItem.Checked = False
    End Sub

    'text to speech menu item is checked
    Private Sub TexttoSpeechToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TexttoSpeechToolStripMenuItem.Click
        TexttoSpeechToolStripMenuItem.Checked = True
        AnnoyingBeepToolStripMenuItem.Checked = False
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub
End Class
