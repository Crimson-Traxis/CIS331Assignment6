Public Class Calculator

    Dim leftSide As Decimal
    Dim Operation As Operations
    Dim rightSide As Decimal

    Private Sub buttonSrqt_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonSrqt.Click

    End Sub

    Private Sub Grid_KeyDown(sender As Object, e As System.Windows.Input.KeyEventArgs)
        Select Case e.Key
            Case System.Windows.Input.Key.D0 Or System.Windows.Input.Key.NumPad0
                MessageBox.Show("0")
            Case System.Windows.Input.Key.D0 Or System.Windows.Input.Key.NumPad1
            Case System.Windows.Input.Key.D2 Or System.Windows.Input.Key.NumPad2
            Case System.Windows.Input.Key.D3 Or System.Windows.Input.Key.NumPad3
            Case System.Windows.Input.Key.D4 Or System.Windows.Input.Key.NumPad4
            Case System.Windows.Input.Key.D5 Or System.Windows.Input.Key.NumPad5
            Case System.Windows.Input.Key.D6 Or System.Windows.Input.Key.NumPad6
            Case System.Windows.Input.Key.D7 Or System.Windows.Input.Key.NumPad7
            Case System.Windows.Input.Key.D8 Or System.Windows.Input.Key.NumPad8
            Case System.Windows.Input.Key.D9 Or System.Windows.Input.Key.NumPad9
            Case System.Windows.Input.Key.Divide
            Case System.Windows.Input.Key.Multiply
            Case System.Windows.Input.Key.Subtract
            Case System.Windows.Input.Key.Add
            Case System.Windows.Input.Key.Decimal
            Case System.Windows.Input.Key.Enter
        End Select
    End Sub

    Private Sub buttonSin_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonSin.Click

    End Sub

    Private Sub buttonCos_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonCos.Click

    End Sub

    Private Sub buttonTan_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonTan.Click

    End Sub

    Private Sub buttonC_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonC.Click

    End Sub

    Private Sub buttonCE_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonCE.Click

    End Sub

    Private Sub button7_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button7.Click

    End Sub

    Private Sub button8_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button8.Click

    End Sub

    Private Sub button9_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button9.Click

    End Sub

    Private Sub buttonMod_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonMod.Click

    End Sub

    Private Sub buttonExponential_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonExponential.Click

    End Sub

    Private Sub button4_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button4.Click

    End Sub

    Private Sub button5_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button5.Click

    End Sub

    Private Sub button6_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button6.Click

    End Sub

    Private Sub buttonMultiply_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonMultiply.Click

    End Sub

    Private Sub buttonDivide_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonDivide.Click

    End Sub

    Private Sub button1_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button1.Click

    End Sub

    Private Sub button2_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button2.Click

    End Sub

    Private Sub button3_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button3.Click

    End Sub

    Private Sub buttonSubstract_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonSubstract.Click

    End Sub

    Private Sub buttonPosNeg_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonPosNeg.Click

    End Sub

    Private Sub button0_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles button0.Click
        textboxOutput.Text = "0"
    End Sub

    Private Sub buttonPoint_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonPoint.Click

    End Sub

    Private Sub buttonEquals_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles buttonEquals.Click

    End Sub


End Class
