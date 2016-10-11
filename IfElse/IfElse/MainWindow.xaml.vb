Class MainWindow 
    Sub RunCode(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Btn1Go.Click
        Dim str1 As String = TxtInput1.Text
        Dim str2 As String = TxtInput2.Text
        Dim evalNumber As Boolean = CheckNumeric.IsChecked

        If str1 = str2 Then
            Output("Strings Match!")
        ElseIf str1 > str2 Then
            Output("String 1 is greater than String 2!")
        ElseIf str1 < str2 Then
            Output("String 1 is less than String 2!")
        Else
            Output("String doesn't Match!")
        End If

        If evalNumber Then
            If IsNumeric(str1) And IsNumeric(str2) Then
                Dim dbl1 As Double = Double.Parse(str1)
                Dim dbl2 As Double = Double.Parse(str2)

                If dbl1 = dbl2 Then
                    Output("Numbers match!")
                ElseIf dbl1 > dbl2 Then
                    Output("Value 1 is greater than Value 2 match!")
                ElseIf dbl2 > dbl1 Then
                    Output("Value 2 is greater than Value 1 match!")
                End If

            End If

        End If
    End Sub

    Sub ClearOutput(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Btn2Clear.Click
        txtOutput.Text = ""
    End Sub

    Sub Output(ByVal Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub
End Class
