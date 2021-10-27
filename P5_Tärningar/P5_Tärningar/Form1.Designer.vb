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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSla = New System.Windows.Forms.Button()
        Me.picTarning1 = New System.Windows.Forms.PictureBox()
        Me.picTarning2 = New System.Windows.Forms.PictureBox()
        Me.picTarning3 = New System.Windows.Forms.PictureBox()
        Me.imlTarningar = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.picTarning1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarning2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarning3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSla
        '
        Me.btnSla.Location = New System.Drawing.Point(164, 159)
        Me.btnSla.Name = "btnSla"
        Me.btnSla.Size = New System.Drawing.Size(113, 60)
        Me.btnSla.TabIndex = 0
        Me.btnSla.Text = "Slå!"
        Me.btnSla.UseVisualStyleBackColor = True
        '
        'picTarning1
        '
        Me.picTarning1.Location = New System.Drawing.Point(82, 53)
        Me.picTarning1.Name = "picTarning1"
        Me.picTarning1.Size = New System.Drawing.Size(64, 64)
        Me.picTarning1.TabIndex = 1
        Me.picTarning1.TabStop = False
        '
        'picTarning2
        '
        Me.picTarning2.Location = New System.Drawing.Point(185, 53)
        Me.picTarning2.Name = "picTarning2"
        Me.picTarning2.Size = New System.Drawing.Size(64, 64)
        Me.picTarning2.TabIndex = 1
        Me.picTarning2.TabStop = False
        '
        'picTarning3
        '
        Me.picTarning3.Location = New System.Drawing.Point(277, 53)
        Me.picTarning3.Name = "picTarning3"
        Me.picTarning3.Size = New System.Drawing.Size(64, 64)
        Me.picTarning3.TabIndex = 1
        Me.picTarning3.TabStop = False
        '
        'imlTarningar
        '
        Me.imlTarningar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imlTarningar.ImageStream = CType(resources.GetObject("imlTarningar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlTarningar.TransparentColor = System.Drawing.Color.Transparent
        Me.imlTarningar.Images.SetKeyName(0, "1.png")
        Me.imlTarningar.Images.SetKeyName(1, "2.png")
        Me.imlTarningar.Images.SetKeyName(2, "3.png")
        Me.imlTarningar.Images.SetKeyName(3, "4.png")
        Me.imlTarningar.Images.SetKeyName(4, "5.png")
        Me.imlTarningar.Images.SetKeyName(5, "6.png")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 276)
        Me.Controls.Add(Me.picTarning3)
        Me.Controls.Add(Me.picTarning2)
        Me.Controls.Add(Me.picTarning1)
        Me.Controls.Add(Me.btnSla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picTarning1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarning2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarning3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSla As Button
    Friend WithEvents picTarning1 As PictureBox
    Friend WithEvents picTarning2 As PictureBox
    Friend WithEvents picTarning3 As PictureBox
    Friend WithEvents imlTarningar As ImageList
End Class
