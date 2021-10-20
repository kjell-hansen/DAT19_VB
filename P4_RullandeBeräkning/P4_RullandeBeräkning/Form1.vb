Public Class Form1
    Private Sub txtTal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTal.KeyPress
        ' Tillåt siffror, backspace och .
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack And e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Finns det redan en . strunta i nästa
        If e.KeyChar = "."c And InStr(sender.text, ".") > 0 Then
            e.Handled = True
        End If

        ' Hantera minustecken
        If e.KeyChar = "-"c Then
            If sender.Text.StartsWith("-"c) Then
                sender.Text = Mid(sender.Text, 2)
            Else
                sender.Text = "-" & sender.Text
            End If
            sender.select(sender.text.length, 0)
        End If
    End Sub

    Private Sub btnLaggTill_Click(sender As Object, e As EventArgs) Handles btnLaggTill.Click
        ' Hoppa ut om talet är inkorrekt
        If txtTal.Text = "" Or txtTal.Text = "." Or txtTal.Text = "-" Then
            Exit Sub
        End If

        ' Lägg till talet från rutan
        lstTal.Items.Add(txtTal.Text)

        ' Rensa textrutan
        txtTal.Text = ""

        ' Räkna statistik
        Statistik()
    End Sub

    Private Sub btnBorjaOm_Click(sender As Object, e As EventArgs) Handles btnBorjaOm.Click
        ' Ta bort allt i listrutan
        lstTal.Items.Clear()

        ' Ta bort summa och medel
        lblMedel.Text = ""
        lblSumma.Text = ""

        ' Ta bort text i textrutan och sätt fokus dit
        txtTal.Text = ""
        txtTal.Focus()

    End Sub

    Private Sub lstTal_KeyDown(sender As Object, e As KeyEventArgs) Handles lstTal.KeyDown
        If e.KeyCode = Keys.Delete And lstTal.SelectedIndex > -1 Then
            lstTal.Items.RemoveAt(lstTal.SelectedIndex)
            Statistik()
        End If
    End Sub

    Private Sub Statistik()
        ' Summera alla tal i listan
        Dim Summa As Double
        For i = 0 To lstTal.Items.Count - 1
            Summa = Summa + Val(lstTal.Items(i))
        Next

        lblSumma.Text = Summa.ToString

        ' Räkna medel för alla tal i listan
        lblMedel.Text = (Summa / lstTal.Items.Count).ToString

    End Sub
End Class
