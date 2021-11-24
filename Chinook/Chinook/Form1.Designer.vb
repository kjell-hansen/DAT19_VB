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
        Me.tvwArtisterAlbum = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNyArtist = New System.Windows.Forms.Button()
        Me.grdAlbumLatar = New System.Windows.Forms.DataGridView()
        Me.btnNyttAlbum = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.grdAlbumLatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvwArtisterAlbum
        '
        Me.tvwArtisterAlbum.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvwArtisterAlbum.Location = New System.Drawing.Point(0, 0)
        Me.tvwArtisterAlbum.Name = "tvwArtisterAlbum"
        Me.tvwArtisterAlbum.Size = New System.Drawing.Size(251, 450)
        Me.tvwArtisterAlbum.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNyttAlbum)
        Me.Panel1.Controls.Add(Me.btnNyArtist)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(251, 374)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 76)
        Me.Panel1.TabIndex = 1
        '
        'btnNyArtist
        '
        Me.btnNyArtist.Location = New System.Drawing.Point(60, 20)
        Me.btnNyArtist.Name = "btnNyArtist"
        Me.btnNyArtist.Size = New System.Drawing.Size(95, 37)
        Me.btnNyArtist.TabIndex = 0
        Me.btnNyArtist.Text = "Ny artist"
        Me.btnNyArtist.UseVisualStyleBackColor = True
        '
        'grdAlbumLatar
        '
        Me.grdAlbumLatar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAlbumLatar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAlbumLatar.Location = New System.Drawing.Point(251, 0)
        Me.grdAlbumLatar.Name = "grdAlbumLatar"
        Me.grdAlbumLatar.RowHeadersWidth = 51
        Me.grdAlbumLatar.RowTemplate.Height = 29
        Me.grdAlbumLatar.Size = New System.Drawing.Size(549, 374)
        Me.grdAlbumLatar.TabIndex = 2
        '
        'btnNyttAlbum
        '
        Me.btnNyttAlbum.Location = New System.Drawing.Point(184, 20)
        Me.btnNyttAlbum.Name = "btnNyttAlbum"
        Me.btnNyttAlbum.Size = New System.Drawing.Size(94, 37)
        Me.btnNyttAlbum.TabIndex = 1
        Me.btnNyttAlbum.Text = "Nytt album"
        Me.btnNyttAlbum.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grdAlbumLatar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tvwArtisterAlbum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdAlbumLatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvwArtisterAlbum As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grdAlbumLatar As DataGridView
    Friend WithEvents btnNyArtist As Button
    Friend WithEvents btnNyttAlbum As Button
End Class
