Public Class Table_Multiply
    Private counter As Integer = 0
    Private Sub tabel_multiply(sender As Object, e As EventArgs) Handles showbutton.Click
        Dim number As Integer
        number = numberTextBox1.Text
        tableTextBox1.AppendText("the table multiply number " & number)
        For num As Integer = 0 To 10
            tableTextBox1.AppendText(vbNewLine & num & " * " & number & " = " & num * number)
            counter += 1
        Next
    End Sub
    Private Sub print(sender As Object, e As EventArgs) Handles counterButton1.Click
        counterLabel2.Text = "the counter = " & counter
    End Sub
End Class