'------------------------------------------------------------ 
'-                File Name : WindowMain.vb                 - 
'-                Part of Project: Assignment 6             - 
'------------------------------------------------------------
'-                Written By: Trent Killinger               - 
'-                Written On: 2-24-17                       - 
'------------------------------------------------------------ 
'- File Purpose:                                            - 
'-                                                          - 
'- This file contains the main gui                          -
'------------------------------------------------------------
'- calculatorCounter - counter that gives calculators a     -
'- unique name                                              -
'------------------------------------------------------------
Public Class WindowMain

    Dim calculatorCounter As Integer

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
        calculatorCounter = 0
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: NewToolStripMenuItem_Click     - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine adds a new calculator the the form       -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- window - new calculator host window                      -
    '------------------------------------------------------------
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim window As WindowCalculator = New WindowCalculator()
        calculatorCounter += 1
        window.Text &= " " & calculatorCounter
        window.MdiParent = Me
        window.Show()
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: ExitToolStripMenuItem_Click    - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine closes the gui                           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: CascadeToolStripMenuItem_Click - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine aranges MDI children in a cascade tile   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: CascadeToolStripMenuItem_Click - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine aranges MDI children in a vertical tile  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    '------------------------------------------------------------ 
    '-   Subprogram Name: TileHorizontalToolStripMenuItem_Click - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine aranges MDI children in a horizontal tile-
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- (none)                                                   -
    '------------------------------------------------------------
    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    '------------------------------------------------------------ 
    '-          Subprogram Name: AboutToolStripMenuItem_Click   - 
    '------------------------------------------------------------
    '-                Written By: Trent Killinger               - 
    '-                Written On: 2-26-17                       - 
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      - 
    '-                                                          - 
    '- This subroutine shows the about window                   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    - 
    '- sender – Identifies which particular control raised the  - 
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -    
    '------------------------------------------------------------ 
    '- Local Variable Dictionary:                               - 
    '- aboutWind - about window to show                         -
    '------------------------------------------------------------
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutWind As About = New About()
        aboutWind.ShowDialog()
    End Sub
End Class
