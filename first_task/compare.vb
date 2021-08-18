Public Class compare
    Private Sub Compare_two_number(sender As Object, e As EventArgs) Handles compareButton.Click
        Dim number1 As Integer
        Dim number2 As Integer
        number1 = numberTextBox1.Text
        number2 = numberTextBox2.Text
        If number1 = number2 Then
            resultcompare.AppendText(number1 & " equal " & number2)
        End If
        If number1 <> number2 Then
            resultcompare.AppendText(vbNewLine & number1 & " not equal " & number2)
        End If
        If number1 > number2 Then
            resultcompare.AppendText(vbNewLine & number1 & " more " & number2)
        End If
        If number1 < number2 Then
            resultcompare.AppendText(vbNewLine & number1 & " less " & number2)
        End If
        If number1 <= number2 Then
            resultcompare.AppendText(vbNewLine & number1 & " less or equal " & number2)
        End If
        If number1 >= number2 Then
            resultcompare.AppendText(vbNewLine & number1 & " more or equal " & number2)
        End If
    End Sub
    'if user changed text in text box 1 then function mack clear of result
    Private Sub number1_textchanged(sender As Object, e As EventArgs) Handles numberTextBox1.TextChanged
        resultcompare.Clear()
    End Sub
End Class