'------------------------------------------------------------ 
'-                File Name : WindowCalculator.vb           - 
'-                Part of Project: Assignment 6             - 
'------------------------------------------------------------
'-                Written By: Trent Killinger               - 
'-                Written On: 2-24-17                       - 
'------------------------------------------------------------ 
'- File Purpose:                                            - 
'-                                                          - 
'- This file contains the calculator host control that hosts-
'- the calculator wpf control                               -
'------------------------------------------------------------
'- (none)                                                   -
'------------------------------------------------------------
Public Class WindowCalculator

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
    Private Sub WindowCalculator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim c As Calculator = CalculatorHost.Child
        If Not c.IsBlank() Then
            If Not MessageBox.Show(Me.Text & " still has data. Exit?", "Data Detected", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class