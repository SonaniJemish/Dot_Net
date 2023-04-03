Public Class Form1
    Private Sub BtnCaption_Click(sender As Object, e As EventArgs) Handles BtnCaption.Click
        Me.Text = TxtCaption.Text
    End Sub

    Private Sub RBtnRed_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnRed.CheckedChanged
        If RBtnRed.Checked Then
            Me.ForeColor = Color.Red
        End If
    End Sub

    Private Sub RBtnGreen_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnGreen.CheckedChanged
        If RBtnGreen.Checked Then
            Me.ForeColor = Color.Green
        End If
    End Sub

    Private Sub RBtnBlue_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnBlue.CheckedChanged
        If RBtnBlue.Checked Then
            Me.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RBtnYellow_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnYellow.CheckedChanged
        If RBtnYellow.Checked Then
            Me.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub RBtnGray_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnGray.CheckedChanged
        If RBtnGray.Checked Then
            Me.BackColor = Color.Gray
        End If
    End Sub

    Private Sub RBtnPink_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnPink.CheckedChanged
        If RBtnPink.Checked Then
            Me.BackColor = Color.Pink
        End If
    End Sub
End Class
