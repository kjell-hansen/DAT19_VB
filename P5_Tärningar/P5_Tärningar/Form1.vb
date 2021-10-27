Public Class frmTärningar
    Dim ticks(3) As Integer
    Dim timers(3) As Timer
    Dim picBoxes(3) As PictureBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Skapa en array med timers
        timers(0) = Timer1
        timers(1) = Timer2
        timers(2) = Timer3

        ' Skapa en array med pictureboxar
        picBoxes(0) = picTarning1
        picBoxes(1) = picTarning2
        picBoxes(2) = picTarning3

    End Sub
    Private Sub btnSla_Click(sender As Object, e As EventArgs) Handles btnSla.Click
        ' Förhindra spammklick på knappen
        btnSla.Enabled = False

        ' Initiera timers och räkna ticks
        For i = 0 To 2
            ticks(i) = Int(Rnd() * 100) + 10
            timers(i).Interval = 100
            timers(i).Start()
        Next

        ' Rulla tills alla tärningar räknat ner till 0
        While ticks(0) > 0 And ticks(1) > 0 And ticks(2) > 0
            Application.DoEvents()
        End While

        btnSla.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick, Timer2.Tick, Timer3.Tick
        ' Hantera timer-ticks för alla timers

        Dim tal, index As Integer
        ' Hitta vilken timer det är som skickar eventet
        Select Case sender.Tag
            Case "Timer1"
                index = 0
            Case "Timer2"
                index = 1
            Case "Timer3"
                index = 2
        End Select

        ' Minska tick
        ticks(index) -= 1

        ' Rita ut tärningen
        tal = Int(Rnd() * 6)
        picBoxes(index).Image = imlTarningar.Images(tal)

        ' Justera tick intervallet så att tärningen saktar ner
        timers(index).Interval = 100 - ticks(index)

        ' Stäng av timern om den är klar
        If ticks(index) < 0 Then
            timers(index).Enabled = False
        End If

    End Sub

End Class
