Public Class WindowMain

    Dim calculatorCounter As Integer

    Public Sub New()
        InitializeComponent()
        calculatorCounter = 0
    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim window As WindowCalculator = New WindowCalculator()
        calculatorCounter += 1
        window.Text &= " " & calculatorCounter
        window.MdiParent = Me
        window.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutWind As About = New About()
        aboutWind.ShowDialog()
    End Sub

    Private Function ExitAndCheck()
        Dim close As Boolean = True
        For Each calc In MdiChildren
            Dim c As WindowCalculator = calc
            If Not c.IsBlank Then
                If Not MessageBox.Show(c.Text & " still has data. Exit?","Data Detected", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    close = False
                    Exit For
                End If
            End If
        Next
        Return close
    End Function

    Private Sub WindowMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not ExitAndCheck()
    End Sub
End Class
