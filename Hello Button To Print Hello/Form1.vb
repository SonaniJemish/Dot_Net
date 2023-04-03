Public Class Form1
    Private Sub BtnHello_Click(sender As Object, e As EventArgs) Handles BtnHello.Click
        TxtPrint.Text = "Hello"
    End Sub

    Private Sub BtnClr_Click(sender As Object, e As EventArgs) Handles BtnClr.Click
        TxtPrint.Text = ""
    End Sub
End Class
