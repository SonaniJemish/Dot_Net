Public Class Form1
    Dim a(3) As String
    Private Sub BtnFA_Click(sender As Object, e As EventArgs) Handles BtnFA.Click
        a(0) = "Sunday"
        a(1) = "Monday"
        a(2) = "Tuesday"
        a(3) = "Wednesday"

        For i = 0 To a.Length - 1
            TxtAns.Text += a(i) & vbCrLf
        Next
    End Sub

    Private Sub BtnD_Click(sender As Object, e As EventArgs) Handles BtnD.Click
        ReDim Preserve a(5)
        a(4) = "Thursday"
        a(5) = "Friday"

        For i = 0 To a.Length - 1
            LblDArray.Text += a(i) & vbCrLf
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnMDArray.Click
        Dim a(,) As Integer = {{2, 0}, {6, 2}, {3, 0}, {3, 0}, {7, 0}, {1, 2}}
        Dim i, j As Integer

        For i = 0 To 5
            For j = 0 To 1
                LblMDArray.Text += "a[" + i.ToString() + "," + j.ToString() + "] = " + a(i, j).ToString() & vbCrLf
            Next j
        Next i
    End Sub
End Class
