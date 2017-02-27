Public Class WindowCalculator
    Public Function IsBlank()
        Dim calc As Calculator = CalculatorHost.Child
        If calc.IsBlank Then
            Return True
        End If
        Return False
    End Function
End Class