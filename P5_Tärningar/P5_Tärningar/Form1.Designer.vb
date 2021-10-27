<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTärningar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTärningar))
        Me.btnSla = New System.Windows.Forms.Button()
        Me.picTarning1 = New System.Windows.Forms.PictureBox()
        Me.picTarning2 = New System.Windows.Forms.PictureBox()
        Me.picTarning3 = New System.Windows.Forms.PictureBox()
        Me.imlTarningar = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picTarning1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarning2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarning3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSla
        '
        Me.btnSla.Location = New System.Drawing.Point(144, 137)
        Me.btnSla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSla.Name = "btnSla"
        Me.btnSla.Size = New System.Drawing.Size(99, 45)
        Me.btnSla.TabIndex = 0
        Me.btnSla.Text = "Slå!"
        Me.btnSla.UseVisualStyleBackColor = True
        '
        'picTarning1
        '
        Me.picTarning1.Location = New System.Drawing.Point(72, 40)
        Me.picTarning1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picTarning1.Name = "picTarning1"
        Me.picTarning1.Size = New System.Drawing.Size(64, 64)
        Me.picTarning1.TabIndex = 1
        Me.picTarning1.TabStop = False
        '
        'picTarning2
        '
        Me.picTarning2.Location = New System.Drawing.Point(162, 40)
        Me.picTarning2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picTarning2.Name = "picTarning2"
        Me.picTarning2.Size = New System.Drawing.Size(64, 64)
        Me.picTarning2.TabIndex = 1
        Me.picTarning2.TabStop = False
        '
        'picTarning3
        '
        Me.picTarning3.Location = New System.Drawing.Point(242, 40)
        Me.picTarning3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        'Timer1
        '
        Me.Timer1.Tag = "Timer1"
        '
        'Timer2
        '
        Me.Timer2.Tag = "Timer2"
        '
        'Timer3
        '
        Me.Timer3.Tag = "Timer3"
        '
        'frmTärningar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 207)
        Me.Controls.Add(Me.picTarning3)
        Me.Controls.Add(Me.picTarning2)
        Me.Controls.Add(Me.picTarning1)
        Me.Controls.Add(Me.btnSla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTärningar"
        Me.Text = "Slå tärningar"
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
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
