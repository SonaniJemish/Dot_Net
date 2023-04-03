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
        Me.LblItems = New System.Windows.Forms.Label()
        Me.TxtItems = New System.Windows.Forms.TextBox()
        Me.BtnCount = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Clb2 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'LblItems
        '
        Me.LblItems.AutoSize = True
        Me.LblItems.Location = New System.Drawing.Point(34, 29)
        Me.LblItems.Name = "LblItems"
        Me.LblItems.Size = New System.Drawing.Size(45, 20)
        Me.LblItems.TabIndex = 0
        Me.LblItems.Text = "Items"
        '
        'TxtItems
        '
        Me.TxtItems.Location = New System.Drawing.Point(120, 26)
        Me.TxtItems.Name = "TxtItems"
        Me.TxtItems.Size = New System.Drawing.Size(240, 27)
        Me.TxtItems.TabIndex = 1
        '
        'BtnCount
        '
        Me.BtnCount.Location = New System.Drawing.Point(34, 138)
        Me.BtnCount.Name = "BtnCount"
        Me.BtnCount.Size = New System.Drawing.Size(133, 29)
        Me.BtnCount.TabIndex = 3
        Me.BtnCount.Text = "Count"
        Me.BtnCount.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(211, 342)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(127, 39)
        Me.BtnInsert.TabIndex = 9
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Lable2"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(585, 503)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(127, 39)
        Me.BtnExit.TabIndex = 11
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(585, 423)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(127, 39)
        Me.BtnRemove.TabIndex = 12
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(585, 342)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(127, 39)
        Me.BtnDelete.TabIndex = 13
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(211, 503)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(127, 39)
        Me.BtnClear.TabIndex = 14
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(211, 423)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(127, 39)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Clb2
        '
        Me.Clb2.FormattingEnabled = True
        Me.Clb2.Location = New System.Drawing.Point(441, 29)
        Me.Clb2.Name = "Clb2"
        Me.Clb2.Size = New System.Drawing.Size(388, 224)
        Me.Clb2.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 581)
        Me.Controls.Add(Me.Clb2)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnCount)
        Me.Controls.Add(Me.TxtItems)
        Me.Controls.Add(Me.LblItems)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblItems As Label
    Friend WithEvents TxtItems As TextBox
    Friend WithEvents BtnCount As Button
    Friend WithEvents BtnInsert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Clb2 As CheckedListBox
End Class
