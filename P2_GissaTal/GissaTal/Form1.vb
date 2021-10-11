Public Class GissaFormular
    Dim Facit As Integer
    Private Sub GissaFormular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Töm innehållet i svarsrutan
        Svar.Text = ""

        ' Initierar slumptalsgeneratorn
        Randomize()

        ' Slumpa fram det rätta talet
        Facit = Int(Rnd() * 1000 + 1)

        Svar.Text = Facit.ToString

    End Sub

    Private Sub GissaKnapp_Click(sender As Object, e As EventArgs) Handles GissaKnapp.Click
        Dim forsok As Integer
        ' Läs in gissningen till en lokal variabel
        forsok = Int(Gissning.Text)

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
End Class
