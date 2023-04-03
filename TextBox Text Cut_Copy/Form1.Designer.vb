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
        Me.BtnBold = New System.Windows.Forms.Button()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.TxtOutput = New System.Windows.Forms.TextBox()
        Me.BtnItalic = New System.Windows.Forms.Button()
        Me.BtnCut = New System.Windows.Forms.Button()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.BtnPaste = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnBold
        '
        Me.BtnBold.Location = New System.Drawing.Point(131, 167)
        Me.BtnBold.Name = "BtnBold"
        Me.BtnBold.Size = New System.Drawing.Size(94, 29)
        Me.BtnBold.TabIndex = 0
        Me.BtnBold.Text = "BOLD"
        Me.BtnBold.UseVisualStyleBackColor = True
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(85, 64)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(195, 27)
        Me.TxtInput.TabIndex = 1
        '
        'TxtOutput
        '
        Me.TxtOutput.Location = New System.Drawing.Point(439, 64)
        Me.TxtOutput.Name = "TxtOutput"
        Me.TxtOutput.Size = New System.Drawing.Size(212, 27)
        Me.TxtOutput.TabIndex = 2
        '
        'BtnItalic
        '
        Me.BtnItalic.Location = New System.Drawing.Point(131, 243)
        Me.BtnItalic.Name = "BtnItalic"
        Me.BtnItalic.Size = New System.Drawing.Size(94, 29)
        Me.BtnItalic.TabIndex = 3
        Me.BtnItalic.Text = "ITALIC"
        Me.BtnItalic.UseVisualStyleBackColor = True
        '
        'BtnCut
        '
        Me.BtnCut.Location = New System.Drawing.Point(484, 167)
        Me.BtnCut.Name = "BtnCut"
        Me.BtnCut.Size = New System.Drawing.Size(94, 29)
        Me.BtnCut.TabIndex = 4
        Me.BtnCut.Text = "CUT"
        Me.BtnCut.UseVisualStyleBackColor = True
        '
        'BtnCopy
        '
        Me.BtnCopy.Location = New System.Drawing.Point(484, 243)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(94, 29)
        Me.BtnCopy.TabIndex = 5
        Me.BtnCopy.Text = "COPY"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'BtnPaste
        '
        Me.BtnPaste.Location = New System.Drawing.Point(484, 318)
        Me.BtnPaste.Name = "BtnPaste"
        Me.BtnPaste.Size = New System.Drawing.Size(94, 29)
        Me.BtnPaste.TabIndex = 6
        Me.BtnPaste.Text = "PASTE"
        Me.BtnPaste.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnPaste)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.BtnCut)
        Me.Controls.Add(Me.BtnItalic)
        Me.Controls.Add(Me.TxtOutput)
        Me.Controls.Add(Me.TxtInput)
        Me.Controls.Add(Me.BtnBold)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBold As Button
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents TxtOutput As TextBox
    Friend WithEvents BtnItalic As Button
    Friend WithEvents BtnCut As Button
    Friend WithEvents BtnCopy As Button
    Friend WithEvents BtnPaste As Button
End Class
