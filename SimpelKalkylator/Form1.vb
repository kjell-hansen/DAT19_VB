Public Class frmKalkylator
    Dim nyBerakning As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initierar variabler
        txtInput.Text = "0"
        nyBerakning = True
    End Sub
    Private Sub nummer_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        ' Tillåt 8 tecken, 9 med punkt (true = -1 därför minus!)
        Dim maxLangd = 8 - txtInput.Text.Contains(".")

        ' Initiera inputrutan om det är en ny inmatning
        If nyBerakning Then
            txtInput.Text = "0"
        End If

        ' Kolla längden på strängen
        If txtInput.TextLength < maxLangd Then
            ' Sätt värdet på input 
            If txtInput.Text = "0" Then
                txtInput.Text = sender.text
            Else
                txtInput.Text &= sender.text
            End If
        End If

        ' Ta bort flaggan för att det är en ny inmatning
        nyBerakning = False
    End Sub
    Private Sub btnPunkt_Click(sender As Object, e As EventArgs) Handles btnPunkt.Click
        ' Hantera punkt
        ' Tillåt bara punkt om det är mindre än 8 tecken i rutan
        If txtInput.TextLength < 8 Then
            ' Lägg till en punkt
            txtInput.Text &= "."
            ' Förhindra att fler punkter läggs till
            btnPunkt.Enabled = False
            ' Ta bort flaggan för att det är en ny inmatning
            nyBerakning = False
        End If
    End Sub
    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        ' Återställ alla variabler och flaggor
        btnPunkt.Enabled = True
        txtInput.Text = "0"
        txt1.Text = ""
        txtOp.Text = ""
        txt2.Text = ""
        nyBerakning = True
    End Sub
    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        ' Återställ flaggan för punkt och att det är ny inmatning, töm inmatningsrutan
        btnPunkt.Enabled = True
        txtInput.Text = "0"
        nyBerakning = True
    End Sub
    Private Sub rakna_Click(sender As Object, e As EventArgs) Handles btnAddition.Click, btnSubtraktion.Click, btnMultiplikation.Click, btnLikaMed.Click, btnDivision.Click
        ' Utför beräkning
        ' Slutligt resultat
        Dim resultat As Double

        ' Sätt andra talet till inmatad text
        txt2.Text = txtInput.Text

        ' Kolla vilken operator som valdes förra gången
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
        ' Tilldela vilken operator som ska användas härnäst
        txtOp.Text = sender.text

        ' Formatera resultatet (8 siffror)
        txtInput.Text = formateraResultat(resultat)

        ' Sätt första talet till nuvarande resultat
        txt1.Text = txtInput.Text

        ' Hissa flaggor för att tillåta punkt och att det är en ny inmatning
        btnPunkt.Enabled = True
        nyBerakning = True
    End Sub
    Private Function formateraResultat(resultat As Double) As String
        ' Formatera talet
        Dim res As String

        ' Division med noll
        If Double.IsInfinity(resultat) Or Double.IsNaN(resultat) Then
            Return "E: Div/0"
        End If

        ' För stort tal
        If Math.Abs(resultat) > 99999999 Then
            Return "E: Overfl."
        End If

        ' Formatsträng för utdata, 8 siffror 
        Dim format As String = "0.#######"

        If resultat <> 0 Then
            ' Ta bort lika många decimaler som antalet siffror i heltalsdelen av talet
            format = Strings.Left(format, format.Length - Math.Log10(Math.Abs(resultat)))
        End If

        ' Byt ut komma-tecken mot punkt
        res = Strings.Replace(resultat.ToString(format), ",", ".")

        ' Returnera det formaterade talet
        Return res

    End Function
End Class
