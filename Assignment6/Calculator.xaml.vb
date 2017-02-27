Public Class Calculator

    Dim leftSide As Decimal
    Dim operation As Operations
    Dim rightSide As Decimal
    Dim calcMode As Mode
    Dim inputAfterOperation As Boolean

    Public Sub New()
        InitializeComponent()
        radioButtonFloat.IsChecked = True
        calcMode = Mode.FLOAT
        leftSide = 0
        rightSide = 0
        operation = Operations.NONE
        inputAfterOperation = False
    End Sub

    Private Sub buttonSrqt_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonSrqt.Click
        If calcMode = Mode.INT Then
            textboxOutput.Text = Math.Floor(Math.Sqrt(Convert.ToDouble(textboxOutput.Text)))
        Else
            textboxOutput.Text = Math.Sqrt(Convert.ToDouble(textboxOutput.Text))
        End If
    End Sub

    Private Sub buttonSin_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonSin.Click
        If calcMode = Mode.INT Then
            textboxOutput.Text = Math.Floor(Math.Sin(Convert.ToDouble(textboxOutput.Text)))
        Else
            textboxOutput.Text = Math.Sin(Convert.ToDouble(textboxOutput.Text))
        End If
    End Sub

    Private Sub buttonCos_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonCos.Click
        If calcMode = Mode.INT Then
            textboxOutput.Text = Math.Floor(Math.Sqrt(Convert.ToDouble(textboxOutput.Text)))
        Else
            textboxOutput.Text = Math.Cos(Convert.ToDouble(textboxOutput.Text))
        End If
    End Sub

    Private Sub buttonTan_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonTan.Click
        If calcMode = Mode.INT Then
            textboxOutput.Text = Math.Floor(Math.Tan(Convert.ToDouble(textboxOutput.Text)))
        Else
            textboxOutput.Text = Math.Tan(Convert.ToDouble(textboxOutput.Text))
        End If
    End Sub

    Private Sub buttonC_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonC.Click
        ResetCalculator()
    End Sub

    Private Sub buttonCE_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonCE.Click
        textboxOutput.Text = "0"
    End Sub

#Region "Numeric Button Click Events"
    Private Sub button0_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button0.Click
        AddToOutput(0)
    End Sub

    Private Sub button1_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button1.Click
        AddToOutput(1)
    End Sub

    Private Sub button2_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button2.Click
        AddToOutput(2)
    End Sub

    Private Sub button3_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button3.Click
        AddToOutput(3)
    End Sub

    Private Sub button4_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button4.Click
        AddToOutput(4)
    End Sub

    Private Sub button5_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button5.Click
        AddToOutput(5)
    End Sub

    Private Sub button6_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button6.Click
        AddToOutput(6)
    End Sub

    Private Sub button7_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button7.Click
        AddToOutput(7)
    End Sub

    Private Sub button8_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button8.Click
        AddToOutput(8)
    End Sub

    Private Sub button9_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button9.Click
        AddToOutput(9)
    End Sub
#End Region

    Private Sub buttonMod_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonMod.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.MODULUS
    End Sub

    Private Sub buttonExponential_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonExponential.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.POWER
    End Sub

    Private Sub buttonMultiply_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonMultiply.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.MULTIPLY
    End Sub

    Private Sub buttonDivide_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonDivide.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.DIVIDE
    End Sub

    Private Sub buttonSubstract_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonSubstract.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.SUBTRACT
    End Sub

    Private Sub buttonPosNeg_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonPosNeg.Click
        If textboxOutput.Text.Contains("-") Then
            textboxOutput.Text = textboxOutput.Text.Replace("-", "")
        ElseIf textboxOutput.Text <> "0" Then
            textboxOutput.Text = textboxOutput.Text.Insert(0, "-")
        End If
    End Sub

    Private Sub buttonPoint_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonPoint.Click
        AddToOutput(".")
    End Sub

    Private Sub buttonEquals_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonEquals.Click
        If inputAfterOperation Then
            rightSide = Convert.ToDouble(textboxOutput.Text)
            Calculate()
        Else
            ResetCalculator()
        End If

    End Sub

    Private Sub radioButtonFloat_Checked(sender As Object, e As System.Windows.RoutedEventArgs) Handles radioButtonFloat.Checked
        buttonMod.IsEnabled = False
        calcMode = Mode.FLOAT
        textboxOutput.Text = "0"
        leftSide = 0
        rightSide = 0
        operation = Operations.NONE
    End Sub

    Private Sub radioButtonInt_Checked(sender As Object, e As System.Windows.RoutedEventArgs) Handles radioButtonInt.Checked
        buttonMod.IsEnabled = True
        calcMode = Mode.INT
        buttonC_Click(buttonC, New System.Windows.RoutedEventArgs())
    End Sub

    Private Sub Calculate()
        If calcMode = Mode.INT Then
            Dim left As Integer = Math.Floor(leftSide)
            Dim right As Integer = Math.Floor(rightSide)
            Select Case (operation)
                Case Operations.DIVIDE
                    textboxOutput.Text = left \ right
                Case Operations.MULTIPLY
                    textboxOutput.Text = left * right
                Case Operations.MODULUS
                    textboxOutput.Text = left Mod right
                Case Operations.POWER
                    textboxOutput.Text = Math.Pow(left, right)
                Case Operations.ADD
                    textboxOutput.Text = left + right
                Case Operations.SUBTRACT
                    textboxOutput.Text = left - right
            End Select
        Else
            Select Case (operation)
                Case Operations.DIVIDE
                    textboxOutput.Text = leftSide / rightSide
                Case Operations.MULTIPLY
                    textboxOutput.Text = leftSide * rightSide
                Case Operations.MODULUS
                    textboxOutput.Text = leftSide Mod rightSide
                Case Operations.POWER
                    textboxOutput.Text = Math.Pow(leftSide, rightSide)
                Case Operations.ADD
                    textboxOutput.Text = leftSide + rightSide
                Case Operations.SUBTRACT
                    textboxOutput.Text = leftSide - rightSide
            End Select
        End If
        leftSide = Convert.ToDecimal(textboxOutput.Text)
        rightSide = 0
        inputAfterOperation = False
        operation = Operations.NONE
    End Sub

    Private Sub AddToOutput(num As String)
        If operation = Operations.NONE Then
            If textboxOutput.Text = "0" Or textboxOutput.Text = "NaN" Or Not inputAfterOperation Then
                textboxOutput.Text = num
            Else
                AddAndDetectPoint(num)
            End If
            leftSide = Convert.ToDecimal(textboxOutput.Text)
        Else
            If Not inputAfterOperation Then
                textboxOutput.Text = num
                inputAfterOperation = True
            Else
                AddAndDetectPoint(num)
            End If
            rightSide = Convert.ToDecimal(textboxOutput.Text)
        End If
    End Sub

    Private Sub AddAndDetectPoint(character As String)
        If textboxOutput.Text <> "0" Or textboxOutput.Text <> "NaN" Then
            Select Case character
                Case "."
                    If Not textboxOutput.Text.Contains(".") Then
                        textboxOutput.Text &= character
                    End If
                Case Else
                    textboxOutput.Text &= character
            End Select
        Else
            textboxOutput.Text = character
        End If

    End Sub

    Private Sub ResetCalculator()
        rightSide = 0
        leftSide = 0
        operation = Operations.NONE
        textboxOutput.Text = 0
    End Sub

    Private Sub buttonPlus_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonPlus.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.ADD
    End Sub

    Public Function IsBlank()
        If textboxOutput.Text = "0" Then
            Return True
        End If
        Return False
    End Function
End Class
