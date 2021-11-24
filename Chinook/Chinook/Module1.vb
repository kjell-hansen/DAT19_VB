Imports System.Data.SQLite

Module modData

    Public Function cnChinook() As SQLiteConnection
        Dim cnString As New SQLiteConnectionStringBuilder()
        Static cnConnection As SQLiteConnection

        If cnConnection Is Nothing Then
            cnString.DataSource = "c:\temp\DAT19_VB\chinook\chinook.db"
            cnString.ForeignKeys = True

            ' Skapa kopplingen
            cnConnection = New SQLiteConnection(cnString.ToString)
        End If

        Return cnConnection

    End Function

    Public Function hamtaData(sql As String) As DataTable
        Dim dt As New DataTable()
        ' Skapa kommandoobjekt
        Dim cmd As New SQLiteCommand(sql, cnChinook)
        ' Exekvera kommandot
        Dim da As New SQLiteDataAdapter(cmd)

        ' Fyll returobjektet
        da.Fill(dt)

        ' Returnera datatabellen
        Return dt

    End Function
End Module
