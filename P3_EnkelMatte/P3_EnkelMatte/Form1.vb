Public Class Form1
    Private Sub Tal1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tal1.KeyPress, Tal2.KeyPress
        ' Godkänn bara en punkt i rutan
        If e.KeyChar = "."c And InStr(sender.text, "."c) > 0 Then
            e.Handled = True
        End If

        ' Godkänn siffror, backspace och punkt
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack And e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub

    Private Sub RaknaUt_Click(sender As Object, e As EventArgs) Handles RaknaUt.Click
        Dim nr1 As Double = Val(Tal1.Text)
        Dim nr2 As Double = Val(Tal2.Text)

        Select Case Raknesatt.Text
            Case "+"
                Svar.Text = (nr1 + nr2).ToString
            Case "-"
                Svar.Text = (nr1 - nr2).ToString
            Case "/"
                If nr2 = 0 Then
                    Svar.Text = "Odefinierat"
                Else
                    Svar.Text = (nr1 / nr2).ToString
                End If
            Case "*"
                Svar.Text = (nr1 * nr2).ToString
        End Select
    End Sub
End Class
