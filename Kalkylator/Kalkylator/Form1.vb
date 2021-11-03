Imports System.Globalization

Public Class frmKalkylator
    Dim resultat As Double          ' Variabel för att minnas tidigare resultat
    Dim berakning As String         ' Variabel för att minnas önskat räknesätt
    Dim nyInmatning As Boolean      ' Flagga för om det är en ny inmatning eller fortsatt
    Dim minne As Double             ' Variabel för att hålla tal i minnet

    Private Sub frmKalkylator_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Sätt lokalt anpassat decimaltecken
        btnDecimal.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

        ' Rensa inmatningsrutan och förbered för inmatning
        ClearTextbox()

        lblMemory.Text = ""
    End Sub

    Private Sub NumbersClick(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        btnEquals.Focus()
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
        btnEquals.Focus()
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
        btnEquals.Focus()

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
    Private Sub UnaryFunc(sender As Object, e As EventArgs) Handles btnSquare.Click, btnSqRoot.Click, btnInvert.Click
        Dim input, res As Double
        btnEquals.Focus()
        If Double.TryParse(txtInput.Text, input) = False Then
            Exit Sub
        End If

        If sender Is btnSquare Then
            res = input * input
        ElseIf sender Is btnInvert Then
            res = 1 / input
        ElseIf sender Is btnSqRoot Then
            res = Math.Sqrt(input)
        End If

        txtInput.Text = formateraResultat(res)

        ' Förbered för ny inmatning
        nyInmatning = True
        btnDecimal.Enabled = True

    End Sub

    Private Function formateraResultat(resultat As Double) As String
        ' Formaterar resultatet och returnerar det som en sträng

        ' Division med noll
        If Double.IsInfinity(resultat) Then
            Return "E: Div/0"
        End If

        ' Hantera NaN (troligen roten ur negativt tal)
        If Double.IsNaN(resultat) Then
            Return "E: Irr"
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
        btnEquals.Focus()
    End Sub

    Private Sub btnOpposite_Click(sender As Object, e As EventArgs) Handles btnOpposite.Click
        If txtInput.Text.StartsWith("-") Then
            txtInput.Text = Strings.Right(txtInput.Text, txtInput.Text.Length - 1)
        Else
            txtInput.Text = "-" & txtInput.Text
        End If
    End Sub

    Private Sub btnMC_Click(sender As Object, e As EventArgs) Handles btnMC.Click
        minne = 0
        lblMemory.Text = ""

        ' Förbered för ny inmatning
        nyInmatning = True
        btnDecimal.Enabled = True

    End Sub

    Private Sub btnMR_Click(sender As Object, e As EventArgs) Handles btnMR.Click
        If minne <> 0 Then
            txtInput.Text = minne.ToString
        End If

        ' Förbered för ny inmatning
        nyInmatning = True
        btnDecimal.Enabled = True

    End Sub

    Private Sub btnMemoryAdd_Click(sender As Object, e As EventArgs) Handles btnMemoryAdd.Click
        Calculate(sender, e)
        minne += txtInput.Text
        If minne = 0 Then
            lblMemory.Text = ""
        Else
            lblMemory.Text = "M"
        End If
    End Sub

    'Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
    '    MyBase.OnKeyDown(e)
    '    Console.WriteLine(e.KeyCode)

    '    If (e.KeyCode = Keys.CapsLock) Then
    '        ' do some thing ...
    '        Dim value = 20
    '    ElseIf (e.KeyCode = Keys.Control) Then
    '        Dim value = 6
    '    End If

    'End Sub

    Private Sub frmKalkylator_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Modifiers = Keys.Shift + Keys.Control Then
            Select Case e.KeyCode
                Case Keys.OemQuestion
                    btnSquare.PerformClick()
                Case Keys.D7
                    btnInvert.PerformClick()
            End Select
            Exit Sub
        End If
        If e.Modifiers = Keys.Control Then
            Select Case e.KeyCode
                Case Keys.Multiply
                    btnSquare.PerformClick()
                Case Keys.Divide
                    btnInvert.PerformClick()
            End Select
            Exit Sub
        End If

        If e.Modifiers = Keys.Shift Then
            Select Case e.KeyCode
                Case Keys.OemQuestion
                    btnMultiply.PerformClick()
                Case Keys.D1
                    btnOpposite.PerformClick()
                Case Keys.D7
                    btnDivide.PerformClick()
                Case Keys.C
                    btnC.PerformClick()
                Case Else
                    Debug.WriteLine(e.KeyCode)
            End Select
            Exit Sub
        End If

        Select Case e.KeyCode
            Case Keys.Enter
                btnEquals.PerformClick()
            Case Keys.D1, Keys.NumPad1
                btn1.PerformClick()
            Case Keys.D2, Keys.NumPad2
                btn2.PerformClick()
            Case Keys.D3, Keys.NumPad3
                btn3.PerformClick()
            Case Keys.D4, Keys.NumPad4
                btn4.PerformClick()
            Case Keys.D5, Keys.NumPad5
                btn5.PerformClick()
            Case Keys.D6, Keys.NumPad6
                btn6.PerformClick()
            Case Keys.D7, Keys.NumPad7
                btn7.PerformClick()
            Case Keys.D8, Keys.NumPad8
                btn8.PerformClick()
            Case Keys.D9, Keys.NumPad9
                btn9.PerformClick()
            Case Keys.D0, Keys.NumPad0
                btn0.PerformClick()
            Case Keys.Multiply
                btnMultiply.PerformClick()
            Case Keys.Divide
                btnDivide.PerformClick()
            Case Keys.Add, Keys.Oemplus
                btnAdd.PerformClick()
            Case Keys.Subtract, Keys.OemMinus
                btnSubtract.PerformClick()
            Case Keys.Decimal, Keys.OemPeriod
                btnDecimal.PerformClick()
            Case Keys.Delete
                btnC.PerformClick()
        End Select
    End Sub

End Class
