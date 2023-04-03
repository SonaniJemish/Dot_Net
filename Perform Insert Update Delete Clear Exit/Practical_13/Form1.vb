Public Class Form1
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Clb2.Items.Add(TxtItems.Text)
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Clb2.Items.Remove(TxtItems.Text)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Clb2.Items.Clear()
    End Sub


End Class
