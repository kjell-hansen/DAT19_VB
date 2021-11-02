Imports System.Globalization

Public Class frmKalkylator
    Dim resultat As Double
    Dim berakning As String
    Dim nyInmatning As Boolean

    Private Sub NumbersClick(sender As Object, e As EventArgs) Handles btn9.Click, btnDecimal.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        If nyInmatning = False Then
            ' Tillåt bara 8 siffror
            If (txtInput.TextLength > 7 AndAlso txtInput.Text.Contains(btnDecimal.Text) = False) _
            OrElse (txtInput.TextLength > 8 AndAlso txtInput.Text.Contains(btnDecimal.Text)) _
            OrElse (txtInput.Text = "0" AndAlso sender Is btn0) _
            OrElse (txtInput.TextLength = 8 AndAlso sender Is btnDecimal) Then
                Exit Sub
            End If
        Else
            nyInmatning = False
            txtInput.Text = sender.Text
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

    Private Sub ClearTextbox()
        txtInput.Text = "0"
        btnDecimal.Enabled = True
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        ClearTextbox()
    End Sub

    Private Sub frmKalkylator_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnDecimal.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        ClearTextbox()
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles btnSubtract.Click, btnMultiply.Click, btnDivide.Click, btnAdd.Click, btnEquals.Click
        Select Case berakning
            Case "+"
                resultat += Double.Parse(txtInput.Text)
            Case "-"
                resultat -= Double.Parse(txtInput.Text)
            Case "×"
                resultat *= Double.Parse(txtInput.Text)
            Case "/"
                resultat /= Double.Parse(txtInput.Text)
            Case Else
                resultat = Double.Parse(txtInput.Text)
        End Select
        txtInput.Text = resultat
        nyInmatning = True
        btnDecimal.Enabled = True
        berakning = sender.text
    End Sub
End Class
