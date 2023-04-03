<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblOutput = New System.Windows.Forms.Label()
        Me.CBoxPlaying = New System.Windows.Forms.CheckBox()
        Me.CBoxSinging = New System.Windows.Forms.CheckBox()
        Me.CBoxReading = New System.Windows.Forms.CheckBox()
        Me.CBoxCooking = New System.Windows.Forms.CheckBox()
        Me.CBoxDancing = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LblOutput
        '
        Me.LblOutput.AutoSize = True
        Me.LblOutput.Location = New System.Drawing.Point(581, 56)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(0, 20)
        Me.LblOutput.TabIndex = 0
        '
        'CBoxPlaying
        '
        Me.CBoxPlaying.AutoSize = True
        Me.CBoxPlaying.Location = New System.Drawing.Point(63, 68)
        Me.CBoxPlaying.Name = "CBoxPlaying"
        Me.CBoxPlaying.Size = New System.Drawing.Size(79, 24)
        Me.CBoxPlaying.TabIndex = 1
        Me.CBoxPlaying.Text = "Playing"
        Me.CBoxPlaying.UseVisualStyleBackColor = True
        '
        'CBoxSinging
        '
        Me.CBoxSinging.AutoSize = True
        Me.CBoxSinging.Location = New System.Drawing.Point(63, 118)
        Me.CBoxSinging.Name = "CBoxSinging"
        Me.CBoxSinging.Size = New System.Drawing.Size(81, 24)
        Me.CBoxSinging.TabIndex = 2
        Me.CBoxSinging.Text = "Singing"
        Me.CBoxSinging.UseVisualStyleBackColor = True
        '
        'CBoxReading
        '
        Me.CBoxReading.AutoSize = True
        Me.CBoxReading.Location = New System.Drawing.Point(63, 168)
        Me.CBoxReading.Name = "CBoxReading"
        Me.CBoxReading.Size = New System.Drawing.Size(86, 24)
        Me.CBoxReading.TabIndex = 3
        Me.CBoxReading.Text = "Reading"
        Me.CBoxReading.UseVisualStyleBackColor = True
        '
        'CBoxCooking
        '
        Me.CBoxCooking.AutoSize = True
        Me.CBoxCooking.Location = New System.Drawing.Point(63, 225)
        Me.CBoxCooking.Name = "CBoxCooking"
        Me.CBoxCooking.Size = New System.Drawing.Size(86, 24)
        Me.CBoxCooking.TabIndex = 4
        Me.CBoxCooking.Text = "Cooking"
        Me.CBoxCooking.UseVisualStyleBackColor = True
        '
        'CBoxDancing
        '
        Me.CBoxDancing.AutoSize = True
        Me.CBoxDancing.Location = New System.Drawing.Point(63, 277)
        Me.CBoxDancing.Name = "CBoxDancing"
        Me.CBoxDancing.Size = New System.Drawing.Size(86, 24)
        Me.CBoxDancing.TabIndex = 5
        Me.CBoxDancing.Text = "Dancing"
        Me.CBoxDancing.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CBoxDancing)
        Me.Controls.Add(Me.CBoxCooking)
        Me.Controls.Add(Me.CBoxReading)
        Me.Controls.Add(Me.CBoxSinging)
        Me.Controls.Add(Me.CBoxPlaying)
        Me.Controls.Add(Me.LblOutput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblOutput As Label
    Friend WithEvents CBoxPlaying As CheckBox
    Friend WithEvents CBoxSinging As CheckBox
    Friend WithEvents CBoxReading As CheckBox
    Friend WithEvents CBoxCooking As CheckBox
    Friend WithEvents CBoxDancing As CheckBox
End Class
