<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAlarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlarmTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnoyingBeepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TexttoSpeechToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.almTime = New System.Windows.Forms.Label()
        Me.almOn = New System.Windows.Forms.CheckBox()
        Me.almtimelbl = New System.Windows.Forms.Label()
        Me.crntTimelbl = New System.Windows.Forms.Label()
        Me.crntTime = New System.Windows.Forms.Label()
        Me.fivescndbtn = New System.Windows.Forms.Button()
        Me.CrntTimetmr = New System.Windows.Forms.Timer(Me.components)
        Me.almTmr = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttospch = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.SetAlarmToolStripMenuItem, Me.AlarmTypeToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 24)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(154, 24)
        Me.ToolStripMenuItem2.Text = "Exit"
        '
        'SetAlarmToolStripMenuItem
        '
        Me.SetAlarmToolStripMenuItem.Name = "SetAlarmToolStripMenuItem"
        Me.SetAlarmToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.SetAlarmToolStripMenuItem.Text = "Set Alarm"
        '
        'AlarmTypeToolStripMenuItem
        '
        Me.AlarmTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnnoyingBeepToolStripMenuItem, Me.TexttoSpeechToolStripMenuItem})
        Me.AlarmTypeToolStripMenuItem.Name = "AlarmTypeToolStripMenuItem"
        Me.AlarmTypeToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.AlarmTypeToolStripMenuItem.Text = "Alarm Type"
        '
        'AnnoyingBeepToolStripMenuItem
        '
        Me.AnnoyingBeepToolStripMenuItem.Name = "AnnoyingBeepToolStripMenuItem"
        Me.AnnoyingBeepToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.AnnoyingBeepToolStripMenuItem.Text = "Annoying Beep"
        '
        'TexttoSpeechToolStripMenuItem
        '
        Me.TexttoSpeechToolStripMenuItem.Name = "TexttoSpeechToolStripMenuItem"
        Me.TexttoSpeechToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.TexttoSpeechToolStripMenuItem.Text = "Text-to-Speech"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.AboutUsToolStripMenuItem.Text = "About Application"
        '
        'almTime
        '
        Me.almTime.AutoSize = True
        Me.almTime.Location = New System.Drawing.Point(239, 198)
        Me.almTime.Name = "almTime"
        Me.almTime.Size = New System.Drawing.Size(88, 17)
        Me.almTime.TabIndex = 1
        Me.almTime.Text = "12:00:00 AM"
        '
        'almOn
        '
        Me.almOn.AutoSize = True
        Me.almOn.Location = New System.Drawing.Point(344, 196)
        Me.almOn.Name = "almOn"
        Me.almOn.Size = New System.Drawing.Size(89, 21)
        Me.almOn.TabIndex = 2
        Me.almOn.Text = "Alarm On"
        Me.almOn.UseVisualStyleBackColor = True
        '
        'almtimelbl
        '
        Me.almtimelbl.AutoSize = True
        Me.almtimelbl.Location = New System.Drawing.Point(160, 198)
        Me.almtimelbl.Name = "almtimelbl"
        Me.almtimelbl.Size = New System.Drawing.Size(83, 17)
        Me.almtimelbl.TabIndex = 3
        Me.almtimelbl.Text = "Alarm Time:"
        '
        'crntTimelbl
        '
        Me.crntTimelbl.AutoSize = True
        Me.crntTimelbl.Location = New System.Drawing.Point(202, 123)
        Me.crntTimelbl.Name = "crntTimelbl"
        Me.crntTimelbl.Size = New System.Drawing.Size(94, 17)
        Me.crntTimelbl.TabIndex = 3
        Me.crntTimelbl.Text = "Current Time:"
        '
        'crntTime
        '
        Me.crntTime.AutoSize = True
        Me.crntTime.Location = New System.Drawing.Point(302, 123)
        Me.crntTime.Name = "crntTime"
        Me.crntTime.Size = New System.Drawing.Size(88, 17)
        Me.crntTime.TabIndex = 1
        Me.crntTime.Text = "12:00:00 AM"
        '
        'fivescndbtn
        '
        Me.fivescndbtn.Location = New System.Drawing.Point(223, 296)
        Me.fivescndbtn.Name = "fivescndbtn"
        Me.fivescndbtn.Size = New System.Drawing.Size(146, 23)
        Me.fivescndbtn.TabIndex = 4
        Me.fivescndbtn.Text = "Add 5 Seconds"
        Me.fivescndbtn.UseVisualStyleBackColor = True
        '
        'CrntTimetmr
        '
        Me.CrntTimetmr.Enabled = True
        '
        'almTmr
        '
        Me.almTmr.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alarm Text:"
        '
        'txttospch
        '
        Me.txttospch.Location = New System.Drawing.Point(245, 235)
        Me.txttospch.Name = "txttospch"
        Me.txttospch.Size = New System.Drawing.Size(188, 22)
        Me.txttospch.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 471)
        Me.Controls.Add(Me.txttospch)
        Me.Controls.Add(Me.fivescndbtn)
        Me.Controls.Add(Me.crntTimelbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.almtimelbl)
        Me.Controls.Add(Me.almOn)
        Me.Controls.Add(Me.crntTime)
        Me.Controls.Add(Me.almTime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Lab 8"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAlarmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents almTime As System.Windows.Forms.Label
    Friend WithEvents almOn As System.Windows.Forms.CheckBox
    Friend WithEvents almtimelbl As System.Windows.Forms.Label
    Friend WithEvents crntTimelbl As System.Windows.Forms.Label
    Friend WithEvents crntTime As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fivescndbtn As System.Windows.Forms.Button
    Friend WithEvents CrntTimetmr As System.Windows.Forms.Timer
    Friend WithEvents almTmr As System.Windows.Forms.Timer
    Friend WithEvents AlarmTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnnoyingBeepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TexttoSpeechToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttospch As System.Windows.Forms.TextBox

End Class
