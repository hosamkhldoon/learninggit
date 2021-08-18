'this program use to convert grade of subject from chracter to range
Public Class rangeofgrade
    Private Sub Convert_Grade(sender As Object, e As EventArgs) Handles convertButton.Click
        Dim grade As Char
        grade = gardetextbox.Text
        Select Case LCase(grade)
            Case "a"
                resultTextBox.Text = "the range from 80 to 100"
            Case "b"
                resultTextBox.Text = "the range from 70 to 79"
            Case "c"
                resultTextBox.Text = "the range from 60 to 69"
            Case "d"
                resultTextBox.Text = "the range from 50 to 59"


            Case Else
                resultTextBox.Text = "You fail in subject"

        End Select
    End Sub
    Private Sub Grade_textchanged(sender As Object, e As EventArgs) Handles gardetextbox.TextChanged
        resultTextBox.Clear()
    End Sub

End Class