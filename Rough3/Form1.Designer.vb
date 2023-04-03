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
        Me.BtnMDArray = New System.Windows.Forms.Button()
        Me.BtnFA = New System.Windows.Forms.Button()
        Me.BtnD = New System.Windows.Forms.Button()
        Me.LblDArray = New System.Windows.Forms.Label()
        Me.LblMDArray = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtAns
        '
        Me.TxtAns.Location = New System.Drawing.Point(262, 28)
        Me.TxtAns.Multiline = True
        Me.TxtAns.Name = "TxtAns"
        Me.TxtAns.Size = New System.Drawing.Size(301, 157)
        Me.TxtAns.TabIndex = 0
        '
        'BtnMDArray
        '
        Me.BtnMDArray.Location = New System.Drawing.Point(68, 219)
        Me.BtnMDArray.Name = "BtnMDArray"
        Me.BtnMDArray.Size = New System.Drawing.Size(178, 29)
        Me.BtnMDArray.TabIndex = 1
        Me.BtnMDArray.Text = "Multi Dimensional"
        Me.BtnMDArray.UseVisualStyleBackColor = True
        '
        'BtnFA
        '
        Me.BtnFA.Location = New System.Drawing.Point(382, 219)
        Me.BtnFA.Name = "BtnFA"
        Me.BtnFA.Size = New System.Drawing.Size(94, 29)
        Me.BtnFA.TabIndex = 2
        Me.BtnFA.Text = "Fix Array"
        Me.BtnFA.UseVisualStyleBackColor = True
        '
        'BtnD
        '
        Me.BtnD.Location = New System.Drawing.Point(629, 219)
        Me.BtnD.Name = "BtnD"
        Me.BtnD.Size = New System.Drawing.Size(94, 29)
        Me.BtnD.TabIndex = 3
        Me.BtnD.Text = "Dynamic"
        Me.BtnD.UseVisualStyleBackColor = True
        '
        'LblDArray
        '
        Me.LblDArray.AutoSize = True
        Me.LblDArray.Location = New System.Drawing.Point(632, 262)
        Me.LblDArray.Name = "LblDArray"
        Me.LblDArray.Size = New System.Drawing.Size(0, 20)
        Me.LblDArray.TabIndex = 4
        '
        'LblMDArray
        '
        Me.LblMDArray.AutoSize = True
        Me.LblMDArray.Location = New System.Drawing.Point(68, 262)
        Me.LblMDArray.Name = "LblMDArray"
        Me.LblMDArray.Size = New System.Drawing.Size(0, 20)
        Me.LblMDArray.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 601)
        Me.Controls.Add(Me.LblMDArray)
        Me.Controls.Add(Me.LblDArray)
        Me.Controls.Add(Me.BtnD)
        Me.Controls.Add(Me.BtnFA)
        Me.Controls.Add(Me.BtnMDArray)
        Me.Controls.Add(Me.TxtAns)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtAns As TextBox
    Friend WithEvents BtnMDArray As Button
    Friend WithEvents BtnFA As Button
    Friend WithEvents BtnD As Button
    Friend WithEvents LblDArray As Label
    Friend WithEvents LblMDArray As Label
End Class
