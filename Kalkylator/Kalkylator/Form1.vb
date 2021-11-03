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

    Private Sub NumbersClick(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        If nyInmatning = False Then
            Dim maxLangd = 8 - txtInput.Text.Contains(btnDecimal.Text)
            ' Avbryt om antalet tecken är mer än 8
            If txtInput.TextLength >= maxLangd Then
                Exit Sub
            End If
        Else
            ' Ny inmatning ta ner flaggan och nollställ inmatningsrutan
            nyInmatning = False
            txtInput.Text = "0"
        End If

        ' Skriv in siffra i textrutan
        If txtInput.Text = "0" Then
            txtInput.Text = sender.Text
        Else
            txtInput.Text &= sender.Text
        End If

    End Sub
    Private Sub DecimalClick(sender As Object, e As EventArgs) Handles btnDecimal.Click
        ' Disabla decimaltecknet så snart vi fått ett
        If txtInput.TextLength < 8 Then
            btnDecimal.Enabled = False
            nyInmatning = False
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
