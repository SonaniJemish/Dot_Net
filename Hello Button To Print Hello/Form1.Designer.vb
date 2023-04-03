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
        Me.TxtPrint = New System.Windows.Forms.TextBox()
        Me.BtnHello = New System.Windows.Forms.Button()
        Me.BtnClr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtPrint
        '
        Me.TxtPrint.Location = New System.Drawing.Point(271, 113)
        Me.TxtPrint.Name = "TxtPrint"
        Me.TxtPrint.Size = New System.Drawing.Size(246, 27)
        Me.TxtPrint.TabIndex = 0
        '
        'BtnHello
        '
        Me.BtnHello.Location = New System.Drawing.Point(156, 268)
        Me.BtnHello.Name = "BtnHello"
        Me.BtnHello.Size = New System.Drawing.Size(94, 29)
        Me.BtnHello.TabIndex = 1
        Me.BtnHello.Text = "Hello"
        Me.BtnHello.UseVisualStyleBackColor = True
        '
        'BtnClr
        '
        Me.BtnClr.Location = New System.Drawing.Point(568, 268)
        Me.BtnClr.Name = "BtnClr"
        Me.BtnClr.Size = New System.Drawing.Size(94, 29)
        Me.BtnClr.TabIndex = 2
        Me.BtnClr.Text = "Clear"
        Me.BtnClr.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnClr)
        Me.Controls.Add(Me.BtnHello)
        Me.Controls.Add(Me.TxtPrint)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPrint As TextBox
    Friend WithEvents BtnHello As Button
    Friend WithEvents BtnClr As Button
End Class
