﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVinkel = New System.Windows.Forms.TextBox()
        Me.txtHastighet = New System.Windows.Forms.TextBox()
        Me.picKurva = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAntalTraffar = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBorja = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTid = New System.Windows.Forms.Label()
        CType(Me.picKurva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vinkel"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hastighet"
        Me.Label2.Visible = False
        '
        'txtVinkel
        '
        Me.txtVinkel.Location = New System.Drawing.Point(115, 48)
        Me.txtVinkel.Name = "txtVinkel"
        Me.txtVinkel.Size = New System.Drawing.Size(133, 27)
        Me.txtVinkel.TabIndex = 1
        Me.txtVinkel.Visible = False
        '
        'txtHastighet
        '
        Me.txtHastighet.Location = New System.Drawing.Point(115, 93)
        Me.txtHastighet.Name = "txtHastighet"
        Me.txtHastighet.Size = New System.Drawing.Size(133, 27)
        Me.txtHastighet.TabIndex = 1
        Me.txtHastighet.Visible = False
        '
        'picKurva
        '
        Me.picKurva.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picKurva.BackColor = System.Drawing.Color.White
        Me.picKurva.Enabled = False
        Me.picKurva.Location = New System.Drawing.Point(293, 0)
        Me.picKurva.Name = "picKurva"
        Me.picKurva.Size = New System.Drawing.Size(565, 464)
        Me.picKurva.TabIndex = 3
        Me.picKurva.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Antal träffar"
        '
        'lblAntalTraffar
        '
        Me.lblAntalTraffar.AutoSize = True
        Me.lblAntalTraffar.Location = New System.Drawing.Point(126, 300)
        Me.lblAntalTraffar.Name = "lblAntalTraffar"
        Me.lblAntalTraffar.Size = New System.Drawing.Size(61, 20)
        Me.lblAntalTraffar.TabIndex = 5
        Me.lblAntalTraffar.Text = "lblAntal"
        '
        'Timer1
        '
        '
        'btnBorja
        '
        Me.btnBorja.Location = New System.Drawing.Point(118, 227)
        Me.btnBorja.Name = "btnBorja"
        Me.btnBorja.Size = New System.Drawing.Size(91, 33)
        Me.btnBorja.TabIndex = 6
        Me.btnBorja.Text = "Börja!"
        Me.btnBorja.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Återstående tid"
        '
        'lblTid
        '
        Me.lblTid.AutoSize = True
        Me.lblTid.Location = New System.Drawing.Point(157, 339)
        Me.lblTid.Name = "lblTid"
        Me.lblTid.Size = New System.Drawing.Size(47, 20)
        Me.lblTid.TabIndex = 8
        Me.lblTid.Text = "lblTid"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 464)
        Me.Controls.Add(Me.lblTid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBorja)
        Me.Controls.Add(Me.lblAntalTraffar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picKurva)
        Me.Controls.Add(Me.txtHastighet)
        Me.Controls.Add(Me.txtVinkel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1149, 598)
        Me.MinimumSize = New System.Drawing.Size(730, 347)
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
    Friend WithEvents picKurva As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAntalTraffar As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnBorja As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTid As Label
End Class
