'addition program enter two number by user and show in label after click add button
Public Class calculater
    Dim number1 As Integer 'first number enterd by user 
    Dim number2 As Integer 'seconed number enterd by user
    Dim result As Integer
    Private Sub addition_number(sender As Object, e As EventArgs) Handles AddButton.Click
        number1 = number1textbox.Text 'get first number from user 
        number2 = number2textbox.Text 'get seconed number from user 
        result = number1 + number2 'sum of two number
        Resultaddtwonumber.Text = "the sum of two number =" & result 'display the result in label 

    End Sub
    'sub program enter two number by user and show in label after click sub button
    Private Sub sub_number(sender As Object, e As EventArgs) Handles subbutton.Click
        number1 = number1textbox.Text 'get first number from user 
        number2 = number2textbox.Text 'get seconed number from user 
        result = number1 - number2 'sub of two number
        Resultaddtwonumber.Text = "the sub of two number =" & result 'display the result in label 

    End Sub
    'multiply program enter two number by user and show in label after click multilpy button
    Private Sub mul_number(sender As Object, e As EventArgs) Handles multiButton.Click
        number1 = number1textbox.Text 'get first number from user 
        number2 = number2textbox.Text 'get seconed number from user 
        result = number1 * number2 'mul of two number
        Resultaddtwonumber.Text = "the multiply of two number = " & result 'display the result in label 

    End Sub
    'divsion program enter two number by user and show in label after click divion button
    Private Sub div_number(sender As Object, e As EventArgs) Handles divButton.Click
        number1 = number1textbox.Text 'get first number from user 
        number2 = number2textbox.Text 'get seconed number from user
        Try
            result = number1 \ number2 'divsion of two number
            Resultaddtwonumber.Text = "the divsion of two number =" & result 'display the result in label 
        Catch ex As DivideByZeroException
            Resultaddtwonumber.Text = ex.Message
        End Try



    End Sub
    'mod program enter two number by user and show in label after click mod button
    Private Sub mod_number(sender As Object, e As EventArgs) Handles modButton.Click
        number1 = number1textbox.Text 'get first number from user 
        number2 = number2textbox.Text 'get seconed number from user 
        result = number1 Mod number2 'mod of  number1 by number2
        Resultaddtwonumber.Text = "the mod of two number =" & result 'display the result in label 

    End Sub
    'power program enter two number by user and show in label after click power button
    Private Sub power_number(sender As Object, e As EventArgs) Handles powButton.Click
        number1 = number1textbox.Text 'get first number from user 
        number2 = number2textbox.Text 'get seconed number from user 
        result = number1 ^ number2 'power of  number1 for number2 
        Resultaddtwonumber.Text = "the sum of two number =" & result 'display the result in label 

    End Sub

End Class