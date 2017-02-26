<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CalculatorHost = New System.Windows.Forms.Integration.ElementHost()
        Me.Calculator1 = New Assignment6.Calculator()
        Me.SuspendLayout()
        '
        'CalculatorHost
        '
        Me.CalculatorHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalculatorHost.Location = New System.Drawing.Point(0, 0)
        Me.CalculatorHost.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CalculatorHost.Name = "CalculatorHost"
        Me.CalculatorHost.Size = New System.Drawing.Size(674, 829)
        Me.CalculatorHost.TabIndex = 0
        Me.CalculatorHost.Child = Me.Calculator1
        '
        'WindowCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 829)
        Me.Controls.Add(Me.CalculatorHost)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MinimumSize = New System.Drawing.Size(700, 900)
        Me.Name = "WindowCalculator"
        Me.Text = "WindowCalculator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CalculatorHost As Integration.ElementHost
    Friend Calculator1 As Calculator
End Class
