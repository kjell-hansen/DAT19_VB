Public Class Form1
    Dim xMal, yMal As Single
    Dim antalTraffar As Integer
    Private Sub btnRita_Click(sender As Object, e As EventArgs) Handles btnRita.Click
        ' Definiera variabler som behövs för att rita ut projektilbanan
        Dim x, y, hastighet, tid, vinkel As Single
        Dim punkt As System.Drawing.Graphics
        Dim penna As New System.Drawing.Pen(Brushes.Black, 4)
        ' Hämta data från inmatningen
        hastighet = Val(txtHastighet.Text)
        vinkel = Val(txtVinkel.Text)

        punkt = picKurva.CreateGraphics()

        Do
            tid = tid + 10 / hastighet

            'Beräkna aktuell position
            x = hastighet * Math.Cos(vinkel * Math.PI / 180) * tid
            y = picKurva.Height - (hastighet * Math.Sin(vinkel * Math.PI / 180) * tid - 9.82 * tid * tid / 2)

            'Rita ut punkten
            punkt.DrawEllipse(penna, x, y, 2, 2)
            ' Träffade vi målet?
            If traff(x, y) Then
                Exit Do
            End If
        Loop While x < picKurva.Width And y > 0 And y < picKurva.Height

    End Sub

    Private Sub btnRensa_Click(sender As Object, e As EventArgs) Handles btnRensa.Click
        picKurva.CreateGraphics.Clear(picKurva.BackColor)
        ritaMal()
    End Sub

    Private Sub txtVinkel_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVinkel.Validating
        If (Val(txtVinkel.Text) > 90 Or Val(txtVinkel.Text) < 0) Then
            btnRita.Enabled = False
            txtVinkel.BackColor = Color.Pink
        Else
            btnRita.Enabled = True
            txtVinkel.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub ritaMal()
        ' Definiera variabler för målet
        Dim punkt As System.Drawing.Graphics
        Dim penna As New System.Drawing.Pen(Brushes.Red, 4)

        ' Hitta koordinater för målet
        xMal = picKurva.Width * Rnd()
        yMal = picKurva.Height * Rnd()

        'Rita ut målet
        punkt = picKurva.CreateGraphics
        punkt.DrawEllipse(penna, xMal, yMal, 10, 10)

    End Sub
    Private Function traff(x As Single, y As Single) As Boolean
        ' Titta om vi har samma x och y-koordinater som målet
        If Math.Abs(x + 5 - xMal) < 10 And Math.Abs(y + 5 - yMal) < 10 Then
            ' Öka antalet träffar
            antalTraffar += 1
            lblAntalTraffar.Text = antalTraffar
            ' Rensa rutan och rita nytt mål
            btnRensa.PerformClick()
            ' Returnera att det var en träff
            Return True
        End If

        ' Returnera miss
        Return False
    End Function
End Class
