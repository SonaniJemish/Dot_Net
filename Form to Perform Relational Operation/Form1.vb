Public Class Form1
    Private Sub BtnLess_Click(sender As Object, e As EventArgs) Handles BtnLess.Click
        If Int(TxtA.Text) < Int(TxtB.Text) Then

            TxtAns.Text = TxtA.Text & " is smaller than " & TxtB.Text
        Else
            TxtAns.Text = TxtB.Text & " is smaller than " & TxtA.Text
        End If
    End Sub

    Private Sub BtnLessEqual_Click(sender As Object, e As EventArgs) Handles BtnLessEqual.Click
        If Int(TxtA.Text) <= Int(TxtB.Text) Then

            TxtAns.Text = TxtA.Text & " is smaller and equal " & TxtB.Text
        Else
            TxtAns.Text = TxtB.Text & " is smaller and equal " & TxtA.Text
        End If
    End Sub

    Private Sub BtnGreter_Click(sender As Object, e As EventArgs) Handles BtnGreter.Click
        If Int(TxtA.Text) > Int(TxtB.Text) Then

            TxtAns.Text = TxtA.Text & " is greter than " & TxtB.Text
        Else
            TxtAns.Text = TxtB.Text & " is greter than " & TxtA.Text
        End If
    End Sub

    Private Sub BtnGreterEqual_Click(sender As Object, e As EventArgs) Handles BtnGreterEqual.Click
        If Int(TxtA.Text) >= Int(TxtB.Text) Then

            TxtAns.Text = TxtA.Text & " is greter and equal " & TxtB.Text
        Else
            TxtAns.Text = TxtB.Text & " is greter and equal " & TxtA.Text
        End If
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
        If Int(TxtA.Text) = Int(TxtB.Text) Then

            TxtAns.Text = TxtA.Text & " is equal to " & TxtB.Text
        Else
            TxtAns.Text = TxtB.Text & " is not equal to " & TxtA.Text
        End If
    End Sub
End Class
