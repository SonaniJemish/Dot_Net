Public Class Form1
    Private Sub CBoxPlaying_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxPlaying.CheckedChanged
        If CBoxPlaying.Checked Then
            LblOutput.Text += CBoxPlaying.Text & vbCrLf
        End If
    End Sub

    Private Sub CBoxSinging_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxSinging.CheckedChanged
        If CBoxSinging.Checked Then
            LblOutput.Text += CBoxSinging.Text & vbCrLf
        End If
    End Sub

    Private Sub CBoxReading_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxReading.CheckedChanged
        If CBoxReading.Checked Then
            LblOutput.Text += CBoxReading.Text & vbCrLf
        End If
    End Sub

    Private Sub CBoxCooking_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxCooking.CheckedChanged
        If CBoxCooking.Checked Then
            LblOutput.Text += CBoxCooking.Text & vbCrLf
        End If
    End Sub

    Private Sub CBoxDancing_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxDancing.CheckedChanged
        If CBoxDancing.Checked Then
            LblOutput.Text += CBoxDancing.Text & vbCrLf
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
