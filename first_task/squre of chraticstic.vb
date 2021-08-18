Public Class squre_of_chraticstic
    Private Sub display_squre(sender As Object, e As EventArgs) Handles DisplayButton1.Click
        Dim number As Integer
        number = lengthUpDown1.Value
        Dim charcter As String
        charcter = charTextBox1.Text
        If charTextBox1.Text <> String.Empty And lengthUpDown1.Value <> 0 Then
            For row As Integer = 1 To number
                For coloumn As Integer = 1 To number
                    printTextBox1.AppendText(charcter & " ")
                Next
                printTextBox1.AppendText(vbCrLf)
            Next
        End If
    End Sub

End Class