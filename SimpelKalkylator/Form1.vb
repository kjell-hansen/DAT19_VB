Public Class frmKalkylator
    Dim nyBerakning As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Text = "0"
        nyBerakning = True
    End Sub
    Private Sub nummer_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        Dim maxLangd = 8 - txtInput.Text.Contains(".")
        If nyBerakning Then
            txtInput.Text = 0
        End If

        If txtInput.TextLength < maxLangd Then
            If txtInput.Text = "0" Then
                txtInput.Text = sender.text
            Else
                txtInput.Text &= sender.text
            End If
        End If
        nyBerakning = False
    End Sub

    Private Sub btnPunkt_Click(sender As Object, e As EventArgs) Handles btnPunkt.Click
        If txtInput.TextLength < 8 Then
            txtInput.Text &= "."
            btnPunkt.Enabled = False
            nyBerakning = False
        End If
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        btnPunkt.Enabled = True
        txtInput.Text = "0"
        txt1.Text = ""
        txtOp.Text = ""
        txt2.Text = ""
        nyBerakning = True
    End Sub

    Private Sub rakna_Click(sender As Object, e As EventArgs) Handles btnAddition.Click, btnSubtraktion.Click, btnMultiplikation.Click, btnLikaMed.Click, btnDivision.Click
        txt2.Text = txtInput.Text

        Select Case txtOp.Text
            Case "+"
                txtInput.Text = Val(txt1.Text) + Val(txt2.Text)
            Case "-"
                txtInput.Text = Val(txt1.Text) - Val(txt2.Text)
            Case "/"
                txtInput.Text = Val(txt1.Text) / Val(txt2.Text)
            Case "*"
                txtInput.Text = Val(txt1.Text) * Val(txt2.Text)
            Case Else

        End Select
        txtOp.Text = sender.text
        txtInput.Text = Strings.Replace(txtInput.Text, ",", ".")
        txt1.Text = txtInput.Text
        btnPunkt.Enabled = True
        nyBerakning = True
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        btnPunkt.Enabled = True
        txtInput.Text = "0"
        nyBerakning = True
    End Sub
End Class
