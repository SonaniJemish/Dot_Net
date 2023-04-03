Public Class Form1
    Dim myArr(3) As String

    Private Sub BtnD_Click(sender As Object, e As EventArgs) Handles BtnD.Click
        ReDim Preserve myArr(5)
        myArr(4) = "XXXXX"
        myArr(5) = "YYYYY"

        For i = 0 To myArr.Length - 1

            LblDarray.Text += myArr(i) & vbCrLf

        Next
    End Sub

    Private Sub BtnFA_Click(sender As Object, e As EventArgs) Handles BtnFA.Click
        '  ReDim myArr(3)
        myArr(0) = "One"
        myArr(1) = "Two"
        myArr(2) = "Three"
        myArr(3) = "Four"

        For i = 0 To myArr.Length - 1

            TxtAns.Text += myArr(i) & vbCrLf

        Next
    End Sub

    Private Sub BtnMD_Click(sender As Object, e As EventArgs) Handles BtnMD.Click
        Dim a(,) As Integer = {{0, 0}, {1, 2}, {2, 4}, {3, 6}, {4, 8}}
        Dim i, j As Integer
        ' output each array element's value '

        For i = 0 To 4
            For j = 0 To 1
                LblMarray.Text += "a[" + i.ToString() + "," + j.ToString() + "] = " + a(i, j).ToString() & vbCrLf
            Next j
        Next i
    End Sub
End Class
