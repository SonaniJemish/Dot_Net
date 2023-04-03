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
        Me.BtnFinal = New System.Windows.Forms.Button()
        Me.TxtTest1 = New System.Windows.Forms.TextBox()
        Me.TxtTest2 = New System.Windows.Forms.TextBox()
        Me.TxtMid = New System.Windows.Forms.TextBox()
        Me.TxtFinal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnFinal
        '
        Me.BtnFinal.Location = New System.Drawing.Point(205, 269)
        Me.BtnFinal.Name = "BtnFinal"
        Me.BtnFinal.Size = New System.Drawing.Size(371, 29)
        Me.BtnFinal.TabIndex = 0
        Me.BtnFinal.Text = "Calculate Marks"
        Me.BtnFinal.UseVisualStyleBackColor = True
        '
        'TxtTest1
        '
        Me.TxtTest1.Location = New System.Drawing.Point(298, 35)
        Me.TxtTest1.Name = "TxtTest1"
        Me.TxtTest1.Size = New System.Drawing.Size(125, 27)
        Me.TxtTest1.TabIndex = 1
        '
        'TxtTest2
        '
        Me.TxtTest2.Location = New System.Drawing.Point(298, 98)
        Me.TxtTest2.Name = "TxtTest2"
        Me.TxtTest2.Size = New System.Drawing.Size(125, 27)
        Me.TxtTest2.TabIndex = 2
        '
        'TxtMid
        '
        Me.TxtMid.Location = New System.Drawing.Point(298, 159)
        Me.TxtMid.Name = "TxtMid"
        Me.TxtMid.Size = New System.Drawing.Size(125, 27)
        Me.TxtMid.TabIndex = 3
        '
        'TxtFinal
        '
        Me.TxtFinal.Location = New System.Drawing.Point(298, 359)
        Me.TxtFinal.Name = "TxtFinal"
        Me.TxtFinal.Size = New System.Drawing.Size(125, 27)
        Me.TxtFinal.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Class Test-1 Marks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Class Test-2 Marks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MID sem marks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Final Marks"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFinal)
        Me.Controls.Add(Me.TxtMid)
        Me.Controls.Add(Me.TxtTest2)
        Me.Controls.Add(Me.TxtTest1)
        Me.Controls.Add(Me.BtnFinal)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFinal As Button
    Friend WithEvents TxtTest1 As TextBox
    Friend WithEvents TxtTest2 As TextBox
    Friend WithEvents TxtMid As TextBox
    Friend WithEvents TxtFinal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
