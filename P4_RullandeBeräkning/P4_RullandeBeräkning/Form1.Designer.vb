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
        Me.txtTal = New System.Windows.Forms.TextBox()
        Me.btnLaggTill = New System.Windows.Forms.Button()
        Me.lstTal = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSumma = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMedel = New System.Windows.Forms.Label()
        Me.btnBorjaOm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTal
        '
        Me.txtTal.Location = New System.Drawing.Point(53, 29)
        Me.txtTal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTal.Name = "txtTal"
        Me.txtTal.Size = New System.Drawing.Size(126, 23)
        Me.txtTal.TabIndex = 0
        '
        'btnLaggTill
        '
        Me.btnLaggTill.Location = New System.Drawing.Point(259, 28)
        Me.btnLaggTill.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLaggTill.Name = "btnLaggTill"
        Me.btnLaggTill.Size = New System.Drawing.Size(89, 28)
        Me.btnLaggTill.TabIndex = 1
        Me.btnLaggTill.Text = "Lägg till"
        Me.btnLaggTill.UseVisualStyleBackColor = True
        '
        'lstTal
        '
        Me.lstTal.FormattingEnabled = True
        Me.lstTal.ItemHeight = 15
        Me.lstTal.Location = New System.Drawing.Point(445, 34)
        Me.lstTal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTal.Name = "lstTal"
        Me.lstTal.Size = New System.Drawing.Size(188, 154)
        Me.lstTal.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Summa"
        '
        'lblSumma
        '
        Me.lblSumma.AutoSize = True
        Me.lblSumma.Location = New System.Drawing.Point(145, 90)
        Me.lblSumma.Name = "lblSumma"
        Me.lblSumma.Size = New System.Drawing.Size(62, 15)
        Me.lblSumma.TabIndex = 4
        Me.lblSumma.Text = "lblSUmma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Medel"
        '
        'lblMedel
        '
        Me.lblMedel.AutoSize = True
        Me.lblMedel.Location = New System.Drawing.Point(145, 118)
        Me.lblMedel.Name = "lblMedel"
        Me.lblMedel.Size = New System.Drawing.Size(53, 15)
        Me.lblMedel.TabIndex = 4
        Me.lblMedel.Text = "lblMedel"
        '
        'btnBorjaOm
        '
        Me.btnBorjaOm.Location = New System.Drawing.Point(262, 74)
        Me.btnBorjaOm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBorjaOm.Name = "btnBorjaOm"
        Me.btnBorjaOm.Size = New System.Drawing.Size(85, 30)
        Me.btnBorjaOm.TabIndex = 5
        Me.btnBorjaOm.Text = "Börja om"
        Me.btnBorjaOm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnLaggTill
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBorjaOm
        Me.ClientSize = New System.Drawing.Size(700, 209)
        Me.Controls.Add(Me.btnBorjaOm)
        Me.Controls.Add(Me.lblMedel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSumma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTal)
        Me.Controls.Add(Me.btnLaggTill)
        Me.Controls.Add(Me.txtTal)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTal As TextBox
    Friend WithEvents btnLaggTill As Button
    Friend WithEvents lstTal As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSumma As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMedel As Label
    Friend WithEvents btnBorjaOm As Button
End Class
