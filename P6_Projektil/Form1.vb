Imports System.ComponentModel

Public Class Form1
    Dim xMal, yMal As Single
    Dim antalTraffar As Integer
    Dim startTid As Long
    Private Sub skjut()
        ' Definiera variabler som behövs för att rita ut projektilbanan
        Dim x, y, hastighet, tid, vinkel As Single
        Dim punkt As System.Drawing.Graphics
        Dim penna As New System.Drawing.Pen(Brushes.Black, 4)
        ' Hämta data från inmatningen
        hastighet = Val(txtHastighet.Text)
        vinkel = Val(txtVinkel.Text)

        punkt = picKurva.CreateGraphics()

        Do
            tid = tid + 1 / hastighet

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

    Private Sub btnRensa_Click()
        picKurva.CreateGraphics.Clear(picKurva.BackColor)
        ritaMal(xMal, yMal)
    End Sub

    Private Sub txtVinkel_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVinkel.Validating
        If Timer1.Enabled = True Then
            If (Val(txtVinkel.Text) > 90 Or Val(txtVinkel.Text) < 0) Then
                txtVinkel.BackColor = Color.Pink
            Else
                txtVinkel.BackColor = SystemColors.Window
            End If
        End If
    End Sub

    Private Sub ritaMal(xMal As Single, yMal As Single)
        ' Definiera variabler för målet
        Dim punkt As System.Drawing.Graphics
        Dim penna As New System.Drawing.Pen(Brushes.Red, 4)

        'Rita ut målet
        punkt = picKurva.CreateGraphics
        punkt.DrawEllipse(penna, xMal, yMal, 10, 10)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAntalTraffar.Text = antalTraffar

        ' Hitta koordinater för målet
        xMal = picKurva.Width * Rnd()
        yMal = picKurva.Height * Rnd()

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ritaMal(xMal, yMal)

    End Sub

    Private Sub btnBorja_Click(sender As Object, e As EventArgs) Handles btnBorja.Click
        btnBorja.Enabled = False
        antalTraffar = 0
        lblAntalTraffar.Text = antalTraffar
        picKurva.Enabled = True
        ritaMal(xMal, yMal)

        Timer1.Start()
        startTid = Now.Ticks

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tidPasserad As Long = Now.Ticks - startTid
        Dim tidKvar As New TimeSpan(tidPasserad)

        lblTid.Text = 60 - tidKvar.TotalSeconds

        If tidKvar.TotalSeconds > 60 Then
            ' Inaktivera picture-boxen
            picKurva.Enabled = False
            ' Nolla tidstexten
            lblTid.Text = 0
            ' Enable Börja, disabla skjut
            btnBorja.Enabled = True
            ' Stoppa timern
            Timer1.Stop()
        End If

    End Sub

    Private Sub picKurva_MouseMove(sender As Object, e As MouseEventArgs) Handles picKurva.MouseMove
        Dim linje As System.Drawing.Graphics
        Dim penna As New System.Drawing.Pen(Brushes.Green, 2)
        Dim sudd As New System.Drawing.Pen(picKurva.BackColor, 2)
        Static x, y As Single

        If e.Button = MouseButtons.Left Then
            linje = picKurva.CreateGraphics
            linje.DrawLine(sudd, x, y, 0, picKurva.Height)
            x = e.X
            y = e.Y
            txtHastighet.Text = Math.Round(Math.Sqrt(x * x + (picKurva.Height - y) ^ 2), 0)
            txtVinkel.Text = Math.Round(Math.Atan((picKurva.Height - y) / x) * 180 / Math.PI, 1)
            linje.DrawLine(penna, x, y, 0, picKurva.Height)
            ritaMal(xMal, yMal)
        End If
    End Sub

    Private Sub picKurva_MouseUp(sender As Object, e As MouseEventArgs) Handles picKurva.MouseUp
        If e.Button = MouseButtons.Left Then
            skjut()
        End If
    End Sub

    Private Function traff(x As Single, y As Single) As Boolean
        ' Titta om vi har samma x och y-koordinater som målet
        If Math.Abs(x - xMal) < 10 And Math.Abs(y - yMal) < 10 Then
            ' Öka antalet träffar
            antalTraffar += 1
            lblAntalTraffar.Text = antalTraffar

            ' Hitta koordinater för nya målet
            ' Marginal runt hela på 50px
            xMal = (picKurva.Width - 100) * Rnd() + 50
            yMal = (picKurva.Height - 100) * Rnd() + 50

            ' Rensa rutan och rita nytt mål
            btnRensa_Click()
            ' Returnera att det var en träff
            Return True
        End If

        ' Returnera miss
        Return False
    End Function
End Class
