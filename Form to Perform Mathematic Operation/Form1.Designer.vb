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
        Me.BtnITE = New System.Windows.Forms.Button()
        Me.BtnSC = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.TxtOperation = New System.Windows.Forms.TextBox()
        Me.TxtAns = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnITE
        '
        Me.BtnITE.Location = New System.Drawing.Point(113, 329)
        Me.BtnITE.Name = "BtnITE"
        Me.BtnITE.Size = New System.Drawing.Size(147, 29)
        Me.BtnITE.TabIndex = 0
        Me.BtnITE.Text = "IF..THEN..ELSE"
        Me.BtnITE.UseVisualStyleBackColor = True
        '
        'BtnSC
        '
        Me.BtnSC.Location = New System.Drawing.Point(478, 329)
        Me.BtnSC.Name = "BtnSC"
        Me.BtnSC.Size = New System.Drawing.Size(158, 29)
        Me.BtnSC.TabIndex = 1
        Me.BtnSC.Text = "SELECT..CASE"
        Me.BtnSC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Operation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ans"
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(227, 31)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(125, 27)
        Me.TxtA.TabIndex = 6
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(227, 94)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(125, 27)
        Me.TxtB.TabIndex = 7
        '
        'TxtOperation
        '
        Me.TxtOperation.Location = New System.Drawing.Point(227, 159)
        Me.TxtOperation.Name = "TxtOperation"
        Me.TxtOperation.Size = New System.Drawing.Size(125, 27)
        Me.TxtOperation.TabIndex = 8
        '
        'TxtAns
        '
        Me.TxtAns.Location = New System.Drawing.Point(297, 255)
        Me.TxtAns.Name = "TxtAns"
        Me.TxtAns.Size = New System.Drawing.Size(125, 27)
        Me.TxtAns.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtAns)
        Me.Controls.Add(Me.TxtOperation)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSC)
        Me.Controls.Add(Me.BtnITE)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnITE As Button
    Friend WithEvents BtnSC As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtA As TextBox
    Friend WithEvents TxtB As TextBox
    Friend WithEvents TxtOperation As TextBox
    Friend WithEvents TxtAns As TextBox
End Class
