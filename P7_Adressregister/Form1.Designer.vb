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
        Me.txtFornamn = New System.Windows.Forms.TextBox()
        Me.txtEfternamn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPostnr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSkapad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Förnamn"
        '
        'txtFornamn
        '
        Me.txtFornamn.Location = New System.Drawing.Point(34, 44)
        Me.txtFornamn.Name = "txtFornamn"
        Me.txtFornamn.Size = New System.Drawing.Size(217, 27)
        Me.txtFornamn.TabIndex = 1
        '
        'txtEfternamn
        '
        Me.txtEfternamn.Location = New System.Drawing.Point(34, 119)
        Me.txtEfternamn.Name = "txtEfternamn"
        Me.txtEfternamn.Size = New System.Drawing.Size(217, 27)
        Me.txtEfternamn.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Efternamn"
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(34, 200)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(217, 27)
        Me.txtAdress.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Adress"
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(34, 271)
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(118, 27)
        Me.txtPostnr.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Postnr"
        '
        'txtOrt
        '
        Me.txtOrt.Location = New System.Drawing.Point(205, 271)
        Me.txtOrt.Name = "txtOrt"
        Me.txtOrt.Size = New System.Drawing.Size(217, 27)
        Me.txtOrt.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ort"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Skapad"
        '
        'lblSkapad
        '
        Me.lblSkapad.AutoSize = True
        Me.lblSkapad.Location = New System.Drawing.Point(113, 335)
        Me.lblSkapad.Name = "lblSkapad"
        Me.lblSkapad.Size = New System.Drawing.Size(75, 20)
        Me.lblSkapad.TabIndex = 10
        Me.lblSkapad.Text = "lblSkapad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 450)
        Me.Controls.Add(Me.lblSkapad)
        Me.Controls.Add(Me.txtOrt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPostnr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEfternamn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFornamn)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Adresser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFornamn As TextBox
    Friend WithEvents txtEfternamn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPostnr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOrt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSkapad As Label
End Class
