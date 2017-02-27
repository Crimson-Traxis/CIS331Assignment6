'------------------------------------------------------------ 
'-                File Name : Calculator.xaml.vb            - 
'-                Part of Project: Assignment 6             - 
'------------------------------------------------------------
'-                Written By: Trent Killinger               - 
'-                Written On: 2-24-17                       - 
'------------------------------------------------------------ 
'- File Purpose:                                            - 
'-                                                          - 
'- This file contains the calculator control that will be   -
'- embeded into a WPF interop host                          -
'------------------------------------------------------------
'- Variable Dictionary                                      - 
'- leftSide - Left side of equation                         -
'- operation - Operation to be preformed                    -
'- rightSide - Right side of equation                       -
'- calcMode - INT or FLOAT mode                             -
'- inputAfterOperation - true if operation has be outputted -
'------------------------------------------------------------

Public Class Calculator

    Dim leftSide As Decimal
    Dim operation As Operations
    Dim rightSide As Decimal
    Dim calcMode As Mode
    Dim inputAfterOperation As Boolean

    '------------------------------------------------------------ 
    '-                Subprogram Name: New                      - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-24-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine creates the gui and instantiates default -
    '- member data/objects                                      -
    '------------------------------------------------------------ 
    '- Parameter Dictionary:                                    - 
    '- (None)                                                   - 
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (None)                                                   - 
    '------------------------------------------------------------
    Public Sub New()
        InitializeComponent()
        radioButtonFloat.IsChecked = True
        calcMode = Mode.FLOAT
        leftSide = 0
        rightSide = 0
        operation = Operations.NONE
        inputAfterOperation = False
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonSrqt_Click               - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine does the squareroot of the number in the -
    '- output textbox                                           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonSrqt_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonSrqt.Click
        If calcMode = Mode.INT Then
            textboxOutput.Text = Math.Floor(Math.Sqrt(Decimal.Parse(textboxOutput.Text)))
        Else
            textboxOutput.Text = Math.Sqrt(Decimal.Parse(textboxOutput.Text))
        End If
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonSin_Click                - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine does the sin of the number in the        -
    '- output textbox                                           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonSin_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonSin.Click
        If calcMode = Mode.INT Then
            textboxOutput.Text = Math.Floor(Math.Sin(Decimal.Parse(textboxOutput.Text)))
        Else
            textboxOutput.Text = Math.Sin(Decimal.Parse(textboxOutput.Text))
        End If
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonCos_Click                - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine does the cos of the number in the        -
    '- output textbox                                           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonCos_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonCos.Click
        If calcMode = Mode.INT Then
            textboxOutput.Text = Math.Floor(Math.Sqrt(Decimal.Parse(textboxOutput.Text)))
        Else
            textboxOutput.Text = Math.Cos(Decimal.Parse(textboxOutput.Text))
        End If
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonTan_Click                - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine does the Tan of the number in the        -
    '- output textbox                                           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonTan_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonTan.Click
        If calcMode = Mode.INT Then
            textboxOutput.Text = Math.Floor(Math.Tan(Decimal.Parse(textboxOutput.Text)))
        Else
            textboxOutput.Text = Math.Tan(Decimal.Parse(textboxOutput.Text))
        End If
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonC_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine resets the entire calculator             -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonC_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonC.Click
        ResetCalculator()
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonC_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine resets the calculator output             -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonCE_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonCE.Click
        textboxOutput.Text = "0"
    End Sub

#Region "Numeric Button Click Events"

    '------------------------------------------------------------ 
    '-          Subprogram Name: button0_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends 0 to the output                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub button0_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button0.Click
        AddToOutput(0)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: button0_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends 1 to the output                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub button1_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button1.Click
        AddToOutput(1)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: button0_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends 2 to the output                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub button2_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button2.Click
        AddToOutput(2)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: button0_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends 3 to the output                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub button3_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button3.Click
        AddToOutput(3)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: button0_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends 4 to the output                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub button4_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button4.Click
        AddToOutput(4)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: button0_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends 5 to the output                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub button5_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button5.Click
        AddToOutput(5)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: button0_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends 6 to the output                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub button6_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button6.Click
        AddToOutput(6)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: button0_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends 7 to the output                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub button7_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button7.Click
        AddToOutput(7)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: button0_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends 8 to the output                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub button8_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button8.Click
        AddToOutput(8)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: button0_Click                  - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends 9 to the output                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub button9_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button9.Click
        AddToOutput(9)
    End Sub
#End Region

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonMod_Click                - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine calculates the current value if needed   -
    '- then sets the current operation to mod                   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonMod_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonMod.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.MODULUS
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonExponential_Click        - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine calculates the current value if needed   -
    '- then sets the current operation to exponentail           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonExponential_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonExponential.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.POWER
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonMultiply_Click           - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine calculates the current value if needed   -
    '- then sets the current operation to multiply              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonMultiply_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonMultiply.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.MULTIPLY
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonDivide_Click             - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine calculates the current value if needed   -
    '- then sets the current operation to divide                -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonDivide_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonDivide.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.DIVIDE
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonSubstract_Click          - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine calculates the current value if needed   -
    '- then sets the current operation to subtract              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonSubstract_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonSubstract.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.SUBTRACT
    End Sub

    '------------------------------------------------------------ 
    '-              Subprogram Name: buttonPlus_Click           - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine calculates the current value if needed   -
    '- then sets the current operation to addition              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonPlus_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonPlus.Click
        inputAfterOperation = False
        If rightSide <> 0 Then
            Calculate()
        End If
        operation = Operations.ADD
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonPosNeg_Click             - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine adds - if the number is positive or      -
    '- removes - if the number is negative                      -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonPosNeg_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonPosNeg.Click
        If textboxOutput.Text.Contains("-") Then
            textboxOutput.Text = textboxOutput.Text.Replace("-", "")
        ElseIf textboxOutput.Text <> "0" Then
            textboxOutput.Text = textboxOutput.Text.Insert(0, "-")
        End If
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonPoint_Click              - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine appends . to the output if it does not   -
    '- already exist                                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonPoint_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonPoint.Click
        AddToOutput(".")
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: buttonEquals_Click             - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine calculates the expression using the left -
    '- right and operation variables or sets the ouput to 0 if  -
    '- any value is missing                                     -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub buttonEquals_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonEquals.Click
        If inputAfterOperation Then
            Try
                rightSide = Decimal.Parse(textboxOutput.Text)
            Catch ex As Exception
                textboxOutput.Text = 0
                MessageBox.Show(ex.Message)
                rightSide = 0
            End Try
            Calculate()
        Else
            ResetCalculator()
        End If

    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: radioButtonFloat_Checked       - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine resets the calculator and sets the mode  -
    '- to float mode                                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub radioButtonFloat_Checked(sender As Object, e As System.Windows.RoutedEventArgs) Handles radioButtonFloat.Checked
        buttonMod.IsEnabled = False
        calcMode = Mode.FLOAT
        textboxOutput.Text = "0"
        leftSide = 0
        rightSide = 0
        operation = Operations.NONE
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: radioButtonInt_Checked         - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine resets the calculator and sets the mode  -
    '- to int mode                                              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub radioButtonInt_Checked(sender As Object, e As System.Windows.RoutedEventArgs) Handles radioButtonInt.Checked
        buttonMod.IsEnabled = True
        calcMode = Mode.INT
        buttonC_Click(buttonC, New System.Windows.RoutedEventArgs())
    End Sub

    '------------------------------------------------------------ 
    '-                Subprogram Name: Calculate                - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine calculates the expression using the left -
    '- right and operation variables                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
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
        Try
            leftSide = Decimal.Parse(textboxOutput.Text, System.Globalization.NumberStyles.Float)
        Catch ex As Exception
            textboxOutput.Text = 0
            MessageBox.Show(ex.Message)
            leftSide = 0
        End Try
        rightSide = 0
        inputAfterOperation = False
        operation = Operations.NONE
    End Sub

    '------------------------------------------------------------ 
    '-                Subprogram Name: AddToOutput              - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine determines to append to the current value-
    '- or replace it. The sub also sets the left hand variable  -
    '- when needed                                              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub AddToOutput(num As String)
        If operation = Operations.NONE Then
            If textboxOutput.Text = "0" Or textboxOutput.Text = "NaN" Or Not inputAfterOperation Then
                textboxOutput.Text = num
                inputAfterOperation = True
            Else
                AddAndDetectPoint(num)
            End If
            Try
                leftSide = Decimal.Parse(textboxOutput.Text, System.Globalization.NumberStyles.Float)
            Catch ex As Exception
                textboxOutput.Text = 0
                MessageBox.Show(ex.Message)
                leftSide = 0
            End Try
        Else
            If Not inputAfterOperation Then
                textboxOutput.Text = num
                inputAfterOperation = True
            Else
                AddAndDetectPoint(num)
            End If
            Try
                rightSide = Decimal.Parse(textboxOutput.Text)
            Catch ex As Exception
                textboxOutput.Text = 0
                MessageBox.Show(ex.Message)
                rightSide = 0
            End Try
        End If
    End Sub

    '------------------------------------------------------------ 
    '-                Subprogram Name: AddAndDetectPoint        - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine checks for a . in the output and adds .  -
    '- to the ouput if it does not exist                        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
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

    '------------------------------------------------------------ 
    '-                Subprogram Name: ResetCalculator          - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine sets the left and right hand to 0 while  -
    '- also setting the operation to none                       -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub ResetCalculator()
        rightSide = 0
        leftSide = 0
        operation = Operations.NONE
        textboxOutput.Text = 0
    End Sub

    '------------------------------------------------------------ 
    '-                Function Name: IsBlank                    - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-1-17                        - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This function returns true if the ouput is 0             -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- postResponse - string response from post request         -
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '------------------------------------------------------------
    '- Return:                                                  -
    '- True if output is 0 and no operatio is pending           -
    '------------------------------------------------------------
    Public Function IsBlank()
        If textboxOutput.Text = "0" And operation = Operations.NONE Then
            Return True
        End If
        Return False
    End Function
End Class
