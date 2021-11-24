Public Class frmNyArtist
    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        ' Lokal dataadapter för att spara
        Dim dataAdapter As New SQLite.SQLiteDataAdapter("Select * from artists", cnChinook)

        ' Använd en CommandBuilder för att spara
        Dim comBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)
        Dim ds As New DataSet

        ' Fyll datasetet med info från databasen
        dataAdapter.Fill(ds, "Artister")

        ' Skapa en datarow för att lägga till artisten
        Dim dr As DataRow
        dr = ds.Tables("Artister").NewRow
        ds.Tables("Artister").Rows.Add(dr)

        ' Tilldela värdet
        dr.Item("Name") = txtArtist.Text

        ' Skriv till databasen
        dataAdapter.Update(ds, "Artister")

        ' Meddela att allt gick bra till anropande formulär och stäng aktullt formulär
        DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub frmNyArtist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtArtist.Text = ""
    End Sub

    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class