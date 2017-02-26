Public Class WindowCalculator

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub WindowCalculator_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Width += 1
        Me.Height += 1
    End Sub
End Class