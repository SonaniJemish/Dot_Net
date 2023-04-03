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
        Me.TxtAns = New System.Windows.Forms.TextBox()
        Me.BtnMD = New System.Windows.Forms.Button()
        Me.BtnFA = New System.Windows.Forms.Button()
        Me.BtnD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDarray = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblMarray = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtAns
        '
        Me.TxtAns.Location = New System.Drawing.Point(269, 41)
        Me.TxtAns.Multiline = True
        Me.TxtAns.Name = "TxtAns"
        Me.TxtAns.Size = New System.Drawing.Size(231, 141)
        Me.TxtAns.TabIndex = 0
        '
        'BtnMD
        '
        Me.BtnMD.Location = New System.Drawing.Point(12, 180)
        Me.BtnMD.Name = "BtnMD"
        Me.BtnMD.Size = New System.Drawing.Size(198, 29)
        Me.BtnMD.TabIndex = 1
        Me.BtnMD.Text = "Multidimensional Array"
        Me.BtnMD.UseVisualStyleBackColor = True
        '
        'BtnFA
        '
        Me.BtnFA.Location = New System.Drawing.Point(339, 231)
        Me.BtnFA.Name = "BtnFA"
        Me.BtnFA.Size = New System.Drawing.Size(94, 29)
        Me.BtnFA.TabIndex = 2
        Me.BtnFA.Text = "Fix Array"
        Me.BtnFA.UseVisualStyleBackColor = True
        '
        'BtnD
        '
        Me.BtnD.Location = New System.Drawing.Point(566, 334)
        Me.BtnD.Name = "BtnD"
        Me.BtnD.Size = New System.Drawing.Size(94, 29)
        Me.BtnD.TabIndex = 3
        Me.BtnD.Text = "Dynamic"
        Me.BtnD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(566, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dynamic Array:"
        '
        'LblDarray
        '
        Me.LblDarray.AutoSize = True
        Me.LblDarray.Location = New System.Drawing.Point(566, 81)
        Me.LblDarray.Name = "LblDarray"
        Me.LblDarray.Size = New System.Drawing.Size(0, 20)
        Me.LblDarray.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Multi Dim. Array:"
        '
        'LblMarray
        '
        Me.LblMarray.AutoSize = True
        Me.LblMarray.Location = New System.Drawing.Point(12, 265)
        Me.LblMarray.Name = "LblMarray"
        Me.LblMarray.Size = New System.Drawing.Size(0, 20)
        Me.LblMarray.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 586)
        Me.Controls.Add(Me.LblMarray)
        Me.Controls.Add(Me.LblDarray)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnD)
        Me.Controls.Add(Me.BtnFA)
        Me.Controls.Add(Me.BtnMD)
        Me.Controls.Add(Me.TxtAns)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtAns As TextBox
    Friend WithEvents BtnMD As Button
    Friend WithEvents BtnFA As Button
    Friend WithEvents BtnD As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblDarray As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblMarray As Label
End Class
