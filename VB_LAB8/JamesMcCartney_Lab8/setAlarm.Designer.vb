<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setAlarm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskTime = New System.Windows.Forms.MaskedTextBox()
        Me.radAM = New System.Windows.Forms.RadioButton()
        Me.radPM = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please set time for alarm."
        '
        'mskTime
        '
        Me.mskTime.Location = New System.Drawing.Point(91, 59)
        Me.mskTime.Mask = "90:00:00"
        Me.mskTime.Name = "mskTime"
        Me.mskTime.Size = New System.Drawing.Size(100, 22)
        Me.mskTime.TabIndex = 1
        '
        'radAM
        '
        Me.radAM.AutoSize = True
        Me.radAM.Checked = True
        Me.radAM.Location = New System.Drawing.Point(84, 96)
        Me.radAM.Name = "radAM"
        Me.radAM.Size = New System.Drawing.Size(49, 21)
        Me.radAM.TabIndex = 2
        Me.radAM.TabStop = True
        Me.radAM.Text = "AM"
        Me.radAM.UseVisualStyleBackColor = True
        '
        'radPM
        '
        Me.radPM.AutoSize = True
        Me.radPM.Location = New System.Drawing.Point(84, 132)
        Me.radPM.Name = "radPM"
        Me.radPM.Size = New System.Drawing.Size(49, 21)
        Me.radPM.TabIndex = 3
        Me.radPM.Text = "PM"
        Me.radPM.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(39, 195)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(169, 195)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'setAlarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.radPM)
        Me.Controls.Add(Me.radAM)
        Me.Controls.Add(Me.mskTime)
        Me.Controls.Add(Me.Label1)
        Me.Name = "setAlarm"
        Me.Text = "dialogform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents radAM As System.Windows.Forms.RadioButton
    Friend WithEvents radPM As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
