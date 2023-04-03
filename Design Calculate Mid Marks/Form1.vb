Public Class Form1
    Private Sub BtnFinal_Click(sender As Object, e As EventArgs) Handles BtnFinal.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim sum As Integer

        a = TxtTest1.Text
        b = TxtTest2.Text
        c = TxtMid.Text

        sum = (a * 0.25) + (b * 0.25) + (c * 0.5)

        TxtFinal.Text = sum
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtTest1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtTest2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtMid.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
