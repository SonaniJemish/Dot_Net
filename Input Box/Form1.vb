Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As String
        a = InputBox("Please enter your name :", "Details")

        If a = "" Then
            MessageBox.Show("Please Enter Name", "Name Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)
        End If

    End Sub
End Class
