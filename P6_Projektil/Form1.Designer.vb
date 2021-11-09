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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVinkel = New System.Windows.Forms.TextBox()
        Me.txtHastighet = New System.Windows.Forms.TextBox()
        Me.btnRita = New System.Windows.Forms.Button()
        Me.btnRensa = New System.Windows.Forms.Button()
        Me.picKurva = New System.Windows.Forms.PictureBox()
        CType(Me.picKurva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vinkel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hastighet"
        '
        'txtVinkel
        '
        Me.txtVinkel.Location = New System.Drawing.Point(115, 48)
        Me.txtVinkel.Name = "txtVinkel"
        Me.txtVinkel.Size = New System.Drawing.Size(133, 27)
        Me.txtVinkel.TabIndex = 1
        '
        'txtHastighet
        '
        Me.txtHastighet.Location = New System.Drawing.Point(115, 94)
        Me.txtHastighet.Name = "txtHastighet"
        Me.txtHastighet.Size = New System.Drawing.Size(133, 27)
        Me.txtHastighet.TabIndex = 1
        '
        'btnRita
        '
        Me.btnRita.Location = New System.Drawing.Point(118, 169)
        Me.btnRita.Name = "btnRita"
        Me.btnRita.Size = New System.Drawing.Size(92, 32)
        Me.btnRita.TabIndex = 2
        Me.btnRita.Text = "Rita!"
        Me.btnRita.UseVisualStyleBackColor = True
        '
        'btnRensa
        '
        Me.btnRensa.Location = New System.Drawing.Point(118, 222)
        Me.btnRensa.Name = "btnRensa"
        Me.btnRensa.Size = New System.Drawing.Size(92, 32)
        Me.btnRensa.TabIndex = 2
        Me.btnRensa.Text = "Rensa!"
        Me.btnRensa.UseVisualStyleBackColor = True
        '
        'picKurva
        '
        Me.picKurva.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picKurva.BackColor = System.Drawing.Color.White
        Me.picKurva.Location = New System.Drawing.Point(292, 0)
        Me.picKurva.Name = "picKurva"
        Me.picKurva.Size = New System.Drawing.Size(564, 464)
        Me.picKurva.TabIndex = 3
        Me.picKurva.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 464)
        Me.Controls.Add(Me.picKurva)
        Me.Controls.Add(Me.btnRensa)
        Me.Controls.Add(Me.btnRita)
        Me.Controls.Add(Me.txtHastighet)
        Me.Controls.Add(Me.txtVinkel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1150, 600)
        Me.MinimumSize = New System.Drawing.Size(730, 350)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picKurva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVinkel As TextBox
    Friend WithEvents txtHastighet As TextBox
    Friend WithEvents btnRita As Button
    Friend WithEvents btnRensa As Button
    Friend WithEvents picKurva As PictureBox
End Class
