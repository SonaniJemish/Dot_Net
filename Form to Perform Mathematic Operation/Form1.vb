Public Class Form1
    Private Sub BtnITE_Click(sender As Object, e As EventArgs) Handles BtnITE.Click
        Dim a As Integer
        Dim b As Integer
        Dim op As String

        a = Int(TxtA.Text)
        b = Int(TxtB.Text)
        op = TxtOperation.Text

        If op = "+" Then
            TxtAns.Text = a + b
        ElseIf op = "-" Then
            TxtAns.Text = a - b
        ElseIf op = "*" Then
            TxtAns.Text = a * b
        ElseIf op = "/" Then
            TxtAns.Text = a / b
        Else
            MsgBox("Invalid Input....")
        End If
    End Sub

    Private Sub BtnSC_Click(sender As Object, e As EventArgs) Handles BtnSC.Click
        Dim a As Integer
        Dim b As Integer
        Dim op As String

        a = Int(TxtA.Text)
        b = Int(TxtB.Text)
        op = TxtOperation.Text

        Select Case op
            Case = "+"
                TxtAns.Text = a + b
            Case = "-"
                TxtAns.Text = a - b
            Case = "*"
                TxtAns.Text = a * b
            Case = "/"
                TxtAns.Text = a / b
            Case Else
                MsgBox("Invalid Input....")
        End Select
    End Sub
End Class
