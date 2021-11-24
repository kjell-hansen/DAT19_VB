<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNyArtist
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
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(132, 42)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(216, 27)
        Me.txtArtist.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Artist"
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(111, 98)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(83, 31)
        Me.btnSpara.TabIndex = 2
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Location = New System.Drawing.Point(236, 98)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(91, 30)
        Me.btnAvbryt.TabIndex = 3
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'frmNyArtist
        '
        Me.AcceptButton = Me.btnSpara
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAvbryt
        Me.ClientSize = New System.Drawing.Size(456, 164)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtArtist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNyArtist"
        Me.Text = "frmNyArtist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArtist As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnAvbryt As Button
End Class
