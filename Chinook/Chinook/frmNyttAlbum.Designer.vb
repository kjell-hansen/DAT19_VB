<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNyttAlbum
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
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.txtArtistID = New System.Windows.Forms.TextBox()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Albumnamn"
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(131, 25)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(232, 27)
        Me.txtAlbum.TabIndex = 1
        '
        'txtArtistID
        '
        Me.txtArtistID.Location = New System.Drawing.Point(0, 105)
        Me.txtArtistID.Name = "txtArtistID"
        Me.txtArtistID.Size = New System.Drawing.Size(125, 27)
        Me.txtArtistID.TabIndex = 2
        Me.txtArtistID.Visible = False
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(131, 73)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(94, 29)
        Me.btnSpara.TabIndex = 3
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Location = New System.Drawing.Point(260, 73)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(94, 29)
        Me.btnAvbryt.TabIndex = 4
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'frmNyttAlbum
        '
        Me.AcceptButton = Me.btnSpara
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAvbryt
        Me.ClientSize = New System.Drawing.Size(409, 130)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.txtArtistID)
        Me.Controls.Add(Me.txtAlbum)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNyttAlbum"
        Me.Text = "frmNyttAlbum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents txtArtistID As TextBox
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnAvbryt As Button
End Class
