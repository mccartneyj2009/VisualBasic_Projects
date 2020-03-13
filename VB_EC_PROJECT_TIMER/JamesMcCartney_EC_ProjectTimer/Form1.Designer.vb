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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.spanlbl = New System.Windows.Forms.Label()
        Me.Startbtn = New System.Windows.Forms.Button()
        Me.Stopbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Time Worked:"
        '
        'spanlbl
        '
        Me.spanlbl.AutoSize = True
        Me.spanlbl.Location = New System.Drawing.Point(373, 187)
        Me.spanlbl.Name = "spanlbl"
        Me.spanlbl.Size = New System.Drawing.Size(0, 17)
        Me.spanlbl.TabIndex = 0
        '
        'Startbtn
        '
        Me.Startbtn.Location = New System.Drawing.Point(240, 317)
        Me.Startbtn.Name = "Startbtn"
        Me.Startbtn.Size = New System.Drawing.Size(75, 23)
        Me.Startbtn.TabIndex = 1
        Me.Startbtn.Text = "Start"
        Me.Startbtn.UseVisualStyleBackColor = True
        '
        'Stopbtn
        '
        Me.Stopbtn.Location = New System.Drawing.Point(346, 317)
        Me.Stopbtn.Name = "Stopbtn"
        Me.Stopbtn.Size = New System.Drawing.Size(75, 23)
        Me.Stopbtn.TabIndex = 1
        Me.Stopbtn.Text = "Stop"
        Me.Stopbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 459)
        Me.Controls.Add(Me.Stopbtn)
        Me.Controls.Add(Me.Startbtn)
        Me.Controls.Add(Me.spanlbl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents spanlbl As System.Windows.Forms.Label
    Friend WithEvents Startbtn As System.Windows.Forms.Button
    Friend WithEvents Stopbtn As System.Windows.Forms.Button

End Class
