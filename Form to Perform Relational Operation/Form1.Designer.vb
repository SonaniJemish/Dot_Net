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
        Me.BtnLess = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.BtnLessEqual = New System.Windows.Forms.Button()
        Me.BtnGreter = New System.Windows.Forms.Button()
        Me.BtnGreterEqual = New System.Windows.Forms.Button()
        Me.BtnEqual = New System.Windows.Forms.Button()
        Me.TxtAns = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnLess
        '
        Me.BtnLess.Location = New System.Drawing.Point(97, 152)
        Me.BtnLess.Name = "BtnLess"
        Me.BtnLess.Size = New System.Drawing.Size(94, 29)
        Me.BtnLess.TabIndex = 0
        Me.BtnLess.Text = "<"
        Me.BtnLess.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A"
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(454, 62)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(125, 27)
        Me.TxtB.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ans"
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(149, 62)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(125, 27)
        Me.TxtA.TabIndex = 5
        '
        'BtnLessEqual
        '
        Me.BtnLessEqual.Location = New System.Drawing.Point(97, 210)
        Me.BtnLessEqual.Name = "BtnLessEqual"
        Me.BtnLessEqual.Size = New System.Drawing.Size(94, 29)
        Me.BtnLessEqual.TabIndex = 6
        Me.BtnLessEqual.Text = "<="
        Me.BtnLessEqual.UseVisualStyleBackColor = True
        '
        'BtnGreter
        '
        Me.BtnGreter.Location = New System.Drawing.Point(97, 272)
        Me.BtnGreter.Name = "BtnGreter"
        Me.BtnGreter.Size = New System.Drawing.Size(94, 29)
        Me.BtnGreter.TabIndex = 7
        Me.BtnGreter.Text = ">"
        Me.BtnGreter.UseVisualStyleBackColor = True
        '
        'BtnGreterEqual
        '
        Me.BtnGreterEqual.Location = New System.Drawing.Point(97, 331)
        Me.BtnGreterEqual.Name = "BtnGreterEqual"
        Me.BtnGreterEqual.Size = New System.Drawing.Size(94, 29)
        Me.BtnGreterEqual.TabIndex = 8
        Me.BtnGreterEqual.Text = ">="
        Me.BtnGreterEqual.UseVisualStyleBackColor = True
        '
        'BtnEqual
        '
        Me.BtnEqual.Location = New System.Drawing.Point(97, 388)
        Me.BtnEqual.Name = "BtnEqual"
        Me.BtnEqual.Size = New System.Drawing.Size(94, 29)
        Me.BtnEqual.TabIndex = 9
        Me.BtnEqual.Text = "=="
        Me.BtnEqual.UseVisualStyleBackColor = True
        '
        'TxtAns
        '
        Me.TxtAns.Location = New System.Drawing.Point(368, 255)
        Me.TxtAns.Name = "TxtAns"
        Me.TxtAns.Size = New System.Drawing.Size(197, 27)
        Me.TxtAns.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtAns)
        Me.Controls.Add(Me.BtnEqual)
        Me.Controls.Add(Me.BtnGreterEqual)
        Me.Controls.Add(Me.BtnGreter)
        Me.Controls.Add(Me.BtnLessEqual)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLess)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLess As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtA As TextBox
    Friend WithEvents BtnLessEqual As Button
    Friend WithEvents BtnGreter As Button
    Friend WithEvents BtnGreterEqual As Button
    Friend WithEvents BtnEqual As Button
    Friend WithEvents TxtAns As TextBox
End Class
