<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GissaFormular
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
        Me.Gissning = New System.Windows.Forms.TextBox()
        Me.GissaKnapp = New System.Windows.Forms.Button()
        Me.Svar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Gissning
        '
        Me.Gissning.Location = New System.Drawing.Point(91, 44)
        Me.Gissning.Name = "Gissning"
        Me.Gissning.Size = New System.Drawing.Size(199, 27)
        Me.Gissning.TabIndex = 0
        '
        'GissaKnapp
        '
        Me.GissaKnapp.Location = New System.Drawing.Point(333, 32)
        Me.GissaKnapp.Name = "GissaKnapp"
        Me.GissaKnapp.Size = New System.Drawing.Size(108, 50)
        Me.GissaKnapp.TabIndex = 1
        Me.GissaKnapp.Text = "Gissa!"
        Me.GissaKnapp.UseVisualStyleBackColor = True
        '
        'Svar
        '
        Me.Svar.AutoSize = True
        Me.Svar.Location = New System.Drawing.Point(124, 132)
        Me.Svar.Name = "Svar"
        Me.Svar.Size = New System.Drawing.Size(53, 20)
        Me.Svar.TabIndex = 2
        Me.Svar.Text = "Label1"
        '
        'GissaFormular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 231)
        Me.Controls.Add(Me.Svar)
        Me.Controls.Add(Me.GissaKnapp)
        Me.Controls.Add(Me.Gissning)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GissaFormular"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gissning As TextBox
    Friend WithEvents GissaKnapp As Button
    Friend WithEvents Svar As Label
End Class
