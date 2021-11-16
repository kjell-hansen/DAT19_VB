Public Class Form1
    Private con As New Data.OleDb.OleDbConnection
    Private ds As New DataSet
    Private da As OleDb.OleDbDataAdapter
    Dim recordCount As Integer
    Dim postNr As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbProvider As String
        Dim dbSource As String
        Dim dbName As String
        Dim dbPath As String
        Dim sql As String

        ' Kombinera sökväg och databasnamn till en connection string
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbName = "Adresser.accdb"
        dbPath = "C:\temp\DAT19_VB\P7_Adressregister"

        dbSource = "Data Source= " & dbPath & "\" & dbName
        con.ConnectionString = dbProvider & dbSource

        ' Öppna databasen
        con.Open()

        ' Välj data att visa
        sql = "SELECT * from Personer"

        ' Koppla och fyll dataadaptern
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Adressbok")

        ' Räkna antal poster
        recordCount = ds.Tables("Adressbok").Rows.Count
        postNr = 0
        fyllFormular(postNr)

    End Sub

    Private Sub fyllFormular(postNr As Integer)

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
End Class
