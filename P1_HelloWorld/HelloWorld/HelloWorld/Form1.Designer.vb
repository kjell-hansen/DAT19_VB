<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorldFormular
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
        Me.TryckHarKnapp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TryckHarKnapp
        '
        Me.TryckHarKnapp.Location = New System.Drawing.Point(308, 140)
        Me.TryckHarKnapp.Name = "TryckHarKnapp"
        Me.TryckHarKnapp.Size = New System.Drawing.Size(241, 96)
        Me.TryckHarKnapp.TabIndex = 0
        Me.TryckHarKnapp.Text = "Tryck här!"
        Me.TryckHarKnapp.UseVisualStyleBackColor = True
        '
        'HelloWorldFormular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 325)
        Me.Controls.Add(Me.TryckHarKnapp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HelloWorldFormular"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TryckHarKnapp As Button
End Class
