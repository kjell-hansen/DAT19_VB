Public Class GissaFormular
    Dim Facit As Integer
    Dim Antal As Integer
    Private Sub GissaFormular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initierar slumptalsgeneratorn
        Randomize()

        ' Initiera formuläret
        BorjaOmFranBorjan()

    End Sub

    Private Sub GissaKnapp_Click(sender As Object, e As EventArgs) Handles GissaKnapp.Click
        Dim forsok As Integer
        ' Läs in gissningen till en lokal variabel
        forsok = Int(Gissning.Text)

        ' Räkna upp antalet gissningar och skriv ut
        Antal += 1
        AntalGissningar.Text = Antal.ToString & " gissningar"

        ' Markera texten i textrutan
        Gissning.SelectAll()
        Gissning.Focus()

        ' Kontrollerar hur gissningen var i förhållande till rätt svar
        If forsok < Facit Then
            Svar.Text = "Du gissade för lågt!"
        ElseIf forsok > Facit Then
            Svar.Text = "Du gissade för högt!"
        Else
            Svar.Text = "Hurra!"
        End If
    End Sub

    Private Sub Gissning_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Gissning.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub BorjaOmFranBorjan()
        ' Töm innehållet i svarsrutan
        Gissning.Text = ""


        ' Slumpa fram det rätta talet
        Facit = Int(Rnd() * 1000 + 1)

        ' Nollställ antal gissningar och skriv ut
        Antal = 0
        AntalGissningar.Text = Antal.ToString & " gissningar"

        Svar.Text = "Jag tänker på ett tal mellan 1 och 1000. Gissa vilket!"

    End Sub

    Private Sub BorjaOm_Click(sender As Object, e As EventArgs) Handles BorjaOm.Click
        ' Starta om 
        BorjaOmFranBorjan()

    End Sub

    Private Sub Gissning_TextChanged(sender As Object, e As EventArgs) Handles Gissning.TextChanged
        If Gissning.Text <> "" Then
            GissaKnapp.Enabled = True
        Else
            GissaKnapp.Enabled = False
        End If
    End Sub
End Class
