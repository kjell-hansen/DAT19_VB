<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Tal1 = New System.Windows.Forms.TextBox()
        Me.Tal2 = New System.Windows.Forms.TextBox()
        Me.RaknaUt = New System.Windows.Forms.Button()
        Me.Svar = New System.Windows.Forms.Label()
        Me.Raknesatt = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Tal1
        '
        Me.Tal1.Location = New System.Drawing.Point(55, 38)
        Me.Tal1.Name = "Tal1"
        Me.Tal1.Size = New System.Drawing.Size(140, 27)
        Me.Tal1.TabIndex = 0
        '
        'Tal2
        '
        Me.Tal2.Location = New System.Drawing.Point(355, 38)
        Me.Tal2.Name = "Tal2"
        Me.Tal2.Size = New System.Drawing.Size(140, 27)
        Me.Tal2.TabIndex = 0
        '
        'RaknaUt
        '
        Me.RaknaUt.Location = New System.Drawing.Point(390, 87)
        Me.RaknaUt.Name = "RaknaUt"
        Me.RaknaUt.Size = New System.Drawing.Size(105, 45)
        Me.RaknaUt.TabIndex = 1
        Me.RaknaUt.Text = "Räkna!"
        Me.RaknaUt.UseVisualStyleBackColor = True
        '
        'Svar
        '
        Me.Svar.AutoSize = True
        Me.Svar.Location = New System.Drawing.Point(546, 41)
        Me.Svar.Name = "Svar"
        Me.Svar.Size = New System.Drawing.Size(49, 20)
        Me.Svar.TabIndex = 2
        Me.Svar.Text = "Svar :)"
        '
        'Raknesatt
        '
        Me.Raknesatt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Raknesatt.FormattingEnabled = True
        Me.Raknesatt.Items.AddRange(New Object() {"+", "-", "/", "*"})
        Me.Raknesatt.Location = New System.Drawing.Point(229, 37)
        Me.Raknesatt.Name = "Raknesatt"
        Me.Raknesatt.Size = New System.Drawing.Size(90, 28)
        Me.Raknesatt.TabIndex = 3
        '
        'Form1
        '
        Me.AcceptButton = Me.RaknaUt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 205)
        Me.Controls.Add(Me.Raknesatt)
        Me.Controls.Add(Me.Svar)
        Me.Controls.Add(Me.RaknaUt)
        Me.Controls.Add(Me.Tal2)
        Me.Controls.Add(Me.Tal1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Enkel matte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tal1 As TextBox
    Friend WithEvents Tal2 As TextBox
    Friend WithEvents RaknaUt As Button
    Friend WithEvents Svar As Label
    Friend WithEvents Raknesatt As ComboBox
End Class
