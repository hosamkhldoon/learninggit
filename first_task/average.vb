Public Class average
    Private Sub submit_grade(sender As Object, e As EventArgs) Handles submitButton1.Click
        If gradeTextBox1.Text <> String.Empty Then
            gradeListBox1.Items.Add(gradeTextBox1.Text)
            gradeTextBox1.Clear()
        End If
    End Sub
    Private Sub compute_average(sender As Object, e As EventArgs) Handles averageButton2.Click
        Dim grade As Integer
        Dim counter As Integer
        Dim average As Double
        Dim sum As Integer = 0
        For counter = 0 To gradeListBox1.Items.Count - 1
            grade = gradeListBox1.Items(counter)
            sum += grade
        Next
        If gradeListBox1.Items.Count <> 0 Then
            average = sum / gradeListBox1.Items.Count
            aversageLabel1.Text = "your avarage for this grades is : " & String.Format("{0:F}", average)
        Else
            aversageLabel1.Text = "no grade we entered"
        End If

    End Sub
    Private Sub clear_grade(sender As Object, e As EventArgs) Handles clearButton3.Click
        gradeListBox1.Items.Clear()
        aversageLabel1.Text = String.Empty
    End Sub
End Class