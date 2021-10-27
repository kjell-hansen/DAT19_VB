Public Class Form1
    Private Sub btnSla_Click(sender As Object, e As EventArgs) Handles btnSla.Click
        ' Rulla 100 varv
        For i = 0 To 100
            Dim tal As Integer
            tal = Int(Rnd() * 6)
            picTarning1.Image = imlTarningar.Images(tal)
            tal = Int(Rnd() * 6)
            picTarning2.Image = imlTarningar.Images(tal)
            tal = Int(Rnd() * 6)
            picTarning3.Image = imlTarningar.Images(tal)
            ' Lägg in en liten delay innan nästa varv
            For j = 0 To 1000
                Application.DoEvents()
            Next
        Next
    End Sub
End Class
