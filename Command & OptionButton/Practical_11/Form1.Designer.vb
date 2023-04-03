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
        Me.TxtCaption = New System.Windows.Forms.TextBox()
        Me.BtnCaption = New System.Windows.Forms.Button()
        Me.groupbox1 = New System.Windows.Forms.GroupBox()
        Me.RBtnBlue = New System.Windows.Forms.RadioButton()
        Me.RBtnGreen = New System.Windows.Forms.RadioButton()
        Me.RBtnRed = New System.Windows.Forms.RadioButton()
        Me.groupbox2 = New System.Windows.Forms.GroupBox()
        Me.RBtnPink = New System.Windows.Forms.RadioButton()
        Me.RBtnYellow = New System.Windows.Forms.RadioButton()
        Me.RBtnGray = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.groupbox1.SuspendLayout()
        Me.groupbox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your String"
        '
        'TxtCaption
        '
        Me.TxtCaption.Location = New System.Drawing.Point(285, 78)
        Me.TxtCaption.Name = "TxtCaption"
        Me.TxtCaption.Size = New System.Drawing.Size(319, 27)
        Me.TxtCaption.TabIndex = 1
        '
        'BtnCaption
        '
        Me.BtnCaption.Location = New System.Drawing.Point(285, 140)
        Me.BtnCaption.Name = "BtnCaption"
        Me.BtnCaption.Size = New System.Drawing.Size(190, 29)
        Me.BtnCaption.TabIndex = 2
        Me.BtnCaption.Text = "Caption Change"
        Me.BtnCaption.UseVisualStyleBackColor = True
        '
        'groupbox1
        '
        Me.groupbox1.Controls.Add(Me.RBtnBlue)
        Me.groupbox1.Controls.Add(Me.RBtnGreen)
        Me.groupbox1.Controls.Add(Me.RBtnRed)
        Me.groupbox1.Location = New System.Drawing.Point(91, 231)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Size = New System.Drawing.Size(250, 176)
        Me.groupbox1.TabIndex = 3
        Me.groupbox1.TabStop = False
        Me.groupbox1.Text = "FORCOLOR"
        '
        'RBtnBlue
        '
        Me.RBtnBlue.AutoSize = True
        Me.RBtnBlue.Location = New System.Drawing.Point(21, 131)
        Me.RBtnBlue.Name = "RBtnBlue"
        Me.RBtnBlue.Size = New System.Drawing.Size(59, 24)
        Me.RBtnBlue.TabIndex = 2
        Me.RBtnBlue.TabStop = True
        Me.RBtnBlue.Text = "Blue"
        Me.RBtnBlue.UseVisualStyleBackColor = True
        '
        'RBtnGreen
        '
        Me.RBtnGreen.AutoSize = True
        Me.RBtnGreen.Location = New System.Drawing.Point(21, 101)
        Me.RBtnGreen.Name = "RBtnGreen"
        Me.RBtnGreen.Size = New System.Drawing.Size(69, 24)
        Me.RBtnGreen.TabIndex = 1
        Me.RBtnGreen.TabStop = True
        Me.RBtnGreen.Text = "Green"
        Me.RBtnGreen.UseVisualStyleBackColor = True
        '
        'RBtnRed
        '
        Me.RBtnRed.AutoSize = True
        Me.RBtnRed.Location = New System.Drawing.Point(21, 71)
        Me.RBtnRed.Name = "RBtnRed"
        Me.RBtnRed.Size = New System.Drawing.Size(56, 24)
        Me.RBtnRed.TabIndex = 0
        Me.RBtnRed.TabStop = True
        Me.RBtnRed.Text = "Red"
        Me.RBtnRed.UseVisualStyleBackColor = True
        '
        'groupbox2
        '
        Me.groupbox2.Controls.Add(Me.RBtnPink)
        Me.groupbox2.Controls.Add(Me.RBtnYellow)
        Me.groupbox2.Controls.Add(Me.RBtnGray)
        Me.groupbox2.Location = New System.Drawing.Point(486, 231)
        Me.groupbox2.Name = "groupbox2"
        Me.groupbox2.Size = New System.Drawing.Size(250, 176)
        Me.groupbox2.TabIndex = 4
        Me.groupbox2.TabStop = False
        Me.groupbox2.Text = "BACKCOLOR"
        '
        'RBtnPink
        '
        Me.RBtnPink.AutoSize = True
        Me.RBtnPink.Location = New System.Drawing.Point(18, 131)
        Me.RBtnPink.Name = "RBtnPink"
        Me.RBtnPink.Size = New System.Drawing.Size(57, 24)
        Me.RBtnPink.TabIndex = 5
        Me.RBtnPink.TabStop = True
        Me.RBtnPink.Text = "Pink"
        Me.RBtnPink.UseVisualStyleBackColor = True
        '
        'RBtnYellow
        '
        Me.RBtnYellow.AutoSize = True
        Me.RBtnYellow.Location = New System.Drawing.Point(18, 71)
        Me.RBtnYellow.Name = "RBtnYellow"
        Me.RBtnYellow.Size = New System.Drawing.Size(73, 24)
        Me.RBtnYellow.TabIndex = 3
        Me.RBtnYellow.TabStop = True
        Me.RBtnYellow.Text = "Yellow"
        Me.RBtnYellow.UseVisualStyleBackColor = True
        '
        'RBtnGray
        '
        Me.RBtnGray.AutoSize = True
        Me.RBtnGray.Location = New System.Drawing.Point(18, 101)
        Me.RBtnGray.Name = "RBtnGray"
        Me.RBtnGray.Size = New System.Drawing.Size(60, 24)
        Me.RBtnGray.TabIndex = 4
        Me.RBtnGray.TabStop = True
        Me.RBtnGray.Text = "Gray"
        Me.RBtnGray.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.groupbox2)
        Me.Controls.Add(Me.groupbox1)
        Me.Controls.Add(Me.BtnCaption)
        Me.Controls.Add(Me.TxtCaption)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        Me.groupbox2.ResumeLayout(False)
        Me.groupbox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCaption As TextBox
    Friend WithEvents BtnCaption As Button
    Friend WithEvents groupbox1 As GroupBox
    Friend WithEvents RBtnBlue As RadioButton
    Friend WithEvents RBtnGreen As RadioButton
    Friend WithEvents RBtnRed As RadioButton
    Friend WithEvents groupbox2 As GroupBox
    Friend WithEvents RBtnPink As RadioButton
    Friend WithEvents RBtnYellow As RadioButton
    Friend WithEvents RBtnGray As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
