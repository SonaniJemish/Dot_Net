Public Class Form1
    Dim temp As String
    Private Sub BtnBold_Click(sender As Object, e As EventArgs) Handles BtnBold.Click
        TxtOutput.Font = New Drawing.Font("arrial", 11, FontStyle.Bold)
        TxtOutput.Text = TxtInput.Text
    End Sub

    Private Sub BtnItalic_Click(sender As Object, e As EventArgs) Handles BtnItalic.Click
        TxtOutput.Font = New Drawing.Font("arrial", 11, FontStyle.Italic)
        TxtOutput.Text = TxtInput.Text
    End Sub

    Private Sub BtnCut_Click(sender As Object, e As EventArgs) Handles BtnCut.Click
        temp = TxtInput.Text
        TxtInput.Text = ""
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        temp = TxtInput.Text
    End Sub

    Private Sub BtnPaste_Click(sender As Object, e As EventArgs) Handles BtnPaste.Click
        TxtOutput.Text = temp
    End Sub
End Class
