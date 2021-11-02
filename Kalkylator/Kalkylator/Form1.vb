Imports System.Globalization

Public Class frmKalkylator
    Dim resultat As Double          ' Variabel för att minnas tidigare resultat
    Dim berakning As String         ' Variabel för att minnas önskat räknesätt
    Dim nyInmatning As Boolean      ' Flagga för om det är en ny inmatning eller fortsatt

    Private Sub frmKalkylator_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Sätt lokalt anpassat decimaltecken
        btnDecimal.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

        ' Rensa inmatningsrutan och förbered för inmatning
        ClearTextbox()
    End Sub

    Private Sub NumbersClick(sender As Object, e As EventArgs) Handles btn9.Click, btnDecimal.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        If nyInmatning = False Then
            ' Avbryt om
            '   - antalet tecken är mer än 7 (inget decimaltecken), 
            '   - antalet tecken är mer än 8 (varav ett är decimaltecken)
            '   - inmatat tal är en 0 och det bara finns en 0:a i rutan
            If (txtInput.TextLength > 7 AndAlso txtInput.Text.Contains(btnDecimal.Text) = False) _
            OrElse (txtInput.TextLength > 8 AndAlso txtInput.Text.Contains(btnDecimal.Text)) _
            OrElse (txtInput.Text = "0" AndAlso sender Is btn0) Then
                Exit Sub
            End If
        Else
            ' Ny inmatning ta ner flaggan och tilldela värdet från inmatningen till rutan
            '  (med hantering av decimaltecken)
            nyInmatning = False
            If sender Is btnDecimal Then
                txtInput.Text = "0" & sender.text
                btnDecimal.Enabled = False
            Else
                txtInput.Text = sender.Text
            End If
            Exit Sub
        End If

        ' Disabla decimaltecknet så snart vi fått ett
        If sender Is btnDecimal Then
            btnDecimal.Enabled = False
            txtInput.Text &= sender.Text
            Exit Sub
        End If

        ' Skriv in siffra/punkt i textrutan
        If txtInput.Text = "0" Then
            txtInput.Text = sender.Text
        Else
            txtInput.Text &= sender.Text
        End If

    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        ClearTextbox()
        berakning = ""
    End Sub
    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        ClearTextbox()
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles btnSubtract.Click, btnMultiply.Click, btnDivide.Click, btnAdd.Click, btnEquals.Click
        Dim input As Double
        If Double.TryParse(txtInput.Text, input) = False Then
            Exit Sub
        End If

        ' Vilken beräkning önskades förra gången?
        Select Case berakning
            Case "+"
                resultat += input
            Case "-"
                resultat -= input
            Case "×"
                resultat *= input
            Case "/"
                resultat /= input
            Case Else
                resultat = input
        End Select

        ' Skriv resultatet av beräkningen i textrutan
        txtInput.Text = formateraResultat(resultat)

        ' Förbered för ny inmatning
        nyInmatning = True
        btnDecimal.Enabled = True

        ' Minns vilken önskad beräkning är
        berakning = sender.text
    End Sub

    Private Function formateraResultat(resultat As Double) As String
        ' Formaterar resultatet och returnerar det som en sträng

        ' Division med noll
        If Double.IsInfinity(resultat) Then
            Return "E: Div/0"
        End If

        If Math.Abs(resultat) >= 100000000 Then
            Return "E:Overf."
        End If

        Dim strResultat As String
        Dim format As String = "0.#######"
        If (resultat <> CInt(resultat)) Then
            Dim potens As Integer = Math.Log10(Math.Abs(resultat))
            format = Strings.Left(format, format.Length - potens)
        End If

        strResultat = String.Format("{0:" & format & "}", resultat)

        Return strResultat
    End Function

    Private Sub ClearTextbox()
        ' Rensar textrutan
        txtInput.Text = "0"
        btnDecimal.Enabled = True
    End Sub
End Class
