Module modData
    Public con As New Data.OleDb.OleDbConnection
    Public ds As New DataSet
    Public da As OleDb.OleDbDataAdapter

    Public Sub dbConnect()
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

    End Sub
End Module
