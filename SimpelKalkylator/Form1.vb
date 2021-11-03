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
        Dim resultat As Double
        txt2.Text = txtInput.Text

        Select Case txtOp.Text
            Case "+"
                resultat = Val(txt1.Text) + Val(txt2.Text)
            Case "-"
                resultat = Val(txt1.Text) - Val(txt2.Text)
            Case "/"
                resultat = Val(txt1.Text) / Val(txt2.Text)
            Case "*"
                resultat = Val(txt1.Text) * Val(txt2.Text)
            Case Else
                resultat = Val(txt2.Text)
        End Select
        txtOp.Text = sender.text
        txtInput.Text = formateraResultat(resultat)

        txt1.Text = txtInput.Text
        btnPunkt.Enabled = True
        nyBerakning = True
    End Sub

    Private Function formateraResultat(resultat As Double) As String
        Dim res As String
        Dim format As String = "0.#######"
        If resultat <> 0 Then
            format = Strings.Left(format, format.Length - Math.Log10(Math.Abs(resultat)))
        End If
        res = Strings.Replace(resultat.ToString(format), ",", ".")

        Return res

    End Function

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        btnPunkt.Enabled = True
        txtInput.Text = "0"
        nyBerakning = True
    End Sub
End Class
