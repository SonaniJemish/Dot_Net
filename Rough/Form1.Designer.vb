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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RBtnQ1Yes = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RBtnQ2No = New System.Windows.Forms.RadioButton()
        Me.RBtnQ1No = New System.Windows.Forms.RadioButton()
        Me.RBtnQ2Yes = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Q1 : 4th Semester ?"
        '
        'RBtnQ1Yes
        '
        Me.RBtnQ1Yes.AutoSize = True
        Me.RBtnQ1Yes.Location = New System.Drawing.Point(31, 84)
        Me.RBtnQ1Yes.Name = "RBtnQ1Yes"
        Me.RBtnQ1Yes.Size = New System.Drawing.Size(51, 24)
        Me.RBtnQ1Yes.TabIndex = 1
        Me.RBtnQ1Yes.TabStop = True
        Me.RBtnQ1Yes.Text = "Yes"
        Me.RBtnQ1Yes.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Q2 : Studing Java ?"
        '
        'RBtnQ2No
        '
        Me.RBtnQ2No.AutoSize = True
        Me.RBtnQ2No.Location = New System.Drawing.Point(126, 108)
        Me.RBtnQ2No.Name = "RBtnQ2No"
        Me.RBtnQ2No.Size = New System.Drawing.Size(50, 24)
        Me.RBtnQ2No.TabIndex = 4
        Me.RBtnQ2No.TabStop = True
        Me.RBtnQ2No.Text = "No"
        Me.RBtnQ2No.UseVisualStyleBackColor = True
        '
        'RBtnQ1No
        '
        Me.RBtnQ1No.AutoSize = True
        Me.RBtnQ1No.Location = New System.Drawing.Point(126, 84)
        Me.RBtnQ1No.Name = "RBtnQ1No"
        Me.RBtnQ1No.Size = New System.Drawing.Size(50, 24)
        Me.RBtnQ1No.TabIndex = 5
        Me.RBtnQ1No.TabStop = True
        Me.RBtnQ1No.Text = "No"
        Me.RBtnQ1No.UseVisualStyleBackColor = True
        '
        'RBtnQ2Yes
        '
        Me.RBtnQ2Yes.AutoSize = True
        Me.RBtnQ2Yes.Location = New System.Drawing.Point(31, 108)
        Me.RBtnQ2Yes.Name = "RBtnQ2Yes"
        Me.RBtnQ2Yes.Size = New System.Drawing.Size(51, 24)
        Me.RBtnQ2Yes.TabIndex = 2
        Me.RBtnQ2Yes.TabStop = True
        Me.RBtnQ2Yes.Text = "Yes"
        Me.RBtnQ2Yes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RBtnQ1Yes)
        Me.GroupBox1.Controls.Add(Me.RBtnQ1No)
        Me.GroupBox1.Location = New System.Drawing.Point(317, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 149)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBtnQ2Yes)
        Me.GroupBox2.Controls.Add(Me.RBtnQ2No)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 164)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RBtnQ1Yes As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents RBtnQ2No As RadioButton
    Friend WithEvents RBtnQ1No As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBtnQ2Yes As RadioButton
End Class
