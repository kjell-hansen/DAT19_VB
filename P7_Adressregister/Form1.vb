Public Class frmDetalj
    Dim recordCount As Integer
    Dim postNr As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Koppla databas
        dbConnect()

        ' Räkna antal poster
        recordCount = ds.Tables("Adressbok").Rows.Count
        txtPost.MaxLength = Math.Ceiling(Math.Log10(recordCount))
        postNr = 0
        fyllFormular(postNr)

    End Sub

    Private Sub fyllFormular(postNr As Integer)
        ' Hantera felaktiga postinmatningar
        If postNr > recordCount - 1 Then
            postNr = recordCount - 1
        ElseIf postNr < 0 Then
            postNr = 0
        End If

        txtFornamn.Text = ds.Tables("Adressbok").Rows(postNr)("Fornamn")
        txtEfternamn.Text = ds.Tables("Adressbok").Rows(postNr)("Efternamn")
        txtAdress.Text = ds.Tables("Adressbok").Rows(postNr)("Adress")
        txtPostnr.Text = ds.Tables("Adressbok").Rows(postNr)("Postnr")
        txtOrt.Text = ds.Tables("Adressbok").Rows(postNr)("Ort")
        lblSkapad.Text = ds.Tables("Adressbok").Rows(postNr)("Skapad")

        ' Visa aktuellt postnr, den svåra varianten, eftersom Viktor vill
        txtPost.Text = postNr + 1

        ' Hantera knappar
        hanteraKnappar(postNr)
    End Sub
    Private Sub hanteraKnappar(postNr As Integer)
        btnFirst.Enabled = Not (postNr = 0)
        btnPrev.Enabled = Not (postNr = 0)

        btnLast.Enabled = Not (postNr = (recordCount - 1))
        btnNext.Enabled = Not (postNr = (recordCount - 1))

        If postNr = -1 Then
            btnRadera.Enabled = False
        Else
            btnRadera.Enabled = True
        End If
    End Sub
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        postNr = 0
        fyllFormular(postNr)
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        postNr = recordCount - 1
        fyllFormular(postNr)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        postNr -= 1
        fyllFormular(postNr)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        postNr += 1
        fyllFormular(postNr)
    End Sub

    Private Sub txtPost_Leave(sender As Object, e As EventArgs) Handles txtPost.Leave
        Dim input As Integer
        input = Val(txtPost.Text)
        postNr = input - 1
        fyllFormular(postNr)
    End Sub

    Private Sub txtPost_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPost.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPost_Leave(sender, e)
        End If
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        saveData()
    End Sub

    Private Sub saveData()
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dbRow As DataRow

        ' Kontrollera om det är en ny post eller en befintlig
        If postNr = -1 Then
            dbRow = ds.Tables("Adressbok").NewRow
            dbRow.Item("Skapad") = Now
        Else
            dbRow = ds.Tables("Adressbok").Rows(postNr)
        End If

        ' Tilldela databasraden nya värden
        dbRow.Item("Fornamn") = txtFornamn.Text
        dbRow.Item("Efternamn") = txtEfternamn.Text
        dbRow.Item("Adress") = txtAdress.Text
        dbRow.Item("Postnr") = txtPostnr.Text
        dbRow.Item("Ort") = txtOrt.Text

        ' Uppdatera dataadaptern
        If postNr = -1 Then
            ds.Tables("Adressbok").Rows.Add(dbRow)
            postNr = ds.Tables("Adressbok").Rows.Count - 1
            recordCount = ds.Tables("Adressbok").Rows.Count
        End If

        ' Uppdatera databasraden
        da.Update(ds, "Adressbok")

        ' Visa posten
        fyllFormular(postNr)

    End Sub

    Private Sub btnLaggTill_Click(sender As Object, e As EventArgs) Handles btnLaggTill.Click
        ' Tömma formuläret
        txtFornamn.Text = ""
        txtEfternamn.Text = ""
        txtAdress.Text = ""
        txtPostnr.Text = ""
        txtOrt.Text = ""
        lblSkapad.Text = ""

        ' Indikera ny post
        postNr = -1

        ' Släck alla knappar
        hanteraKnappar(postNr)
    End Sub

    Private Sub btnRadera_Click(sender As Object, e As EventArgs) Handles btnRadera.Click
        If MsgBox("Vill du verkligen radera den här posten?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Adressregister by Kjell") = MsgBoxResult.Yes Then
            raderaPost()
        End If
    End Sub

    Private Sub raderaPost()
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ' Ta bort posten från datasettet och uppdatera dataadaptern
        ds.Tables("Adressbok").Rows(postNr).Delete()
        da.Update(ds, "Adressbok")

        recordCount = ds.Tables("Adressbok").Rows.Count
        If postNr >= recordCount Then
            postNr = recordCount - 1
        End If

        ' Visa följande post
        fyllFormular(postNr)

    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        frmLista.Show()
        Me.Hide()
    End Sub
End Class
