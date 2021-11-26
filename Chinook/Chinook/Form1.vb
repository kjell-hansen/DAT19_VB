Public Class Form1
    Public artistNode As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fyll trädvyn vid formulärinläsning
        reloadTree()
    End Sub

    Private Sub reloadTree()
        ' Rensa tidigare innehåll
        tvwArtisterAlbum.Nodes.Clear()

        Dim dt As DataTable = hamtaData("Select * from artists order by name")
        fyllTrad(dt, 0, Nothing, "Name", "ArtistId")

    End Sub

    Private Sub fyllTrad(tabell As DataTable, parentID As Integer, nod As TreeNode, title As String, tag As String)
        ' Rekursiv funktion för att fylla trädvyn

        ' Loopa igenom hela tabellen
        For Each row As DataRow In tabell.Rows
            ' Skapa en ny trädnod och sätt texten på noden
            Dim child As New TreeNode()
            child.Text = row(title).ToString

            ' Sätt en tag som gör det möjligt att söka efter "barn" till noden
            child.Tag = tag & "= " & row(tag).ToString

            If parentID = 0 Then
                ' Vi har en rotnod (=artist), lägg till den nya noden i trädvyn
                tvwArtisterAlbum.Nodes.Add(child)
                Dim dtChild As DataTable = hamtaData("select * from albums where " & child.Tag & " order by title")
                fyllTrad(dtChild, row(tag), child, "Title", "AlbumId")
                If artistNode = row("ArtistId") Then
                    tvwArtisterAlbum.SelectedNode = child
                    child.Expand()
                    child.Checked = True
                End If
            Else
                ' Vi har en barnnod (=album), lägg till i en befintlig nod i trädvyn
                nod.Nodes.Add(child)
            End If
        Next
        If Not IsNothing(tvwArtisterAlbum.SelectedNode) Then
            tvwArtisterAlbum.SelectedNode.EnsureVisible()
        End If
    End Sub

    Private Sub tvwArtisterAlbum_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwArtisterAlbum.AfterSelect
        btnRaderaArtist.Enabled = False
        btnRaderaAlbum.Enabled = False
        Dim nod As TreeNode
        If IsNothing(e.Node.Parent) Then
            ' Det är en artistnod => visa album i gridvyn
            showDataGrid("select * from albums where " & e.Node.Tag)
            grdAlbumLatar.Columns(0).Visible = False
            grdAlbumLatar.Columns(2).Visible = False
            If e.Node.Nodes.Count = 0 Then
                btnRaderaArtist.Enabled = True
            End If
            nod = e.Node
        Else
            ' Det är en albumnod => visa låtar i gridvyn
            showDataGrid("select * from tracks where " & e.Node.Tag)
            btnRaderaAlbum.Enabled = True
            nod = e.Node.Parent
        End If
        ' Hitta artistid från nodens tag
        artistNode = Val(Strings.Mid(nod.Tag, Strings.InStr(nod.Tag, "=") + 1))

    End Sub

    Private Sub showDataGrid(sql As String)
        ' Rensa befintlig data
        grdAlbumLatar.DataSource = Nothing

        ' Hämta nya data
        grdAlbumLatar.DataSource = hamtaData(sql)

        ' Justera bred på kolumner
        grdAlbumLatar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

    End Sub

    Private Sub btnNyArtist_Click(sender As Object, e As EventArgs) Handles btnNyArtist.Click
        If frmNyArtist.ShowDialog = DialogResult.OK Then
            reloadTree()
        End If
    End Sub

    Private Sub btnNyttAlbum_Click(sender As Object, e As EventArgs) Handles btnNyttAlbum.Click
        Dim artistId As String
        Dim nod As TreeNode

        If IsNothing(tvwArtisterAlbum.SelectedNode.Parent) Then
            ' Vi har en artist markerad, id finns i noden
            nod = tvwArtisterAlbum.SelectedNode
        Else
            ' Vi har ett album markerat, artistens id finns i föräldranoden
            nod = tvwArtisterAlbum.SelectedNode.Parent
        End If

        ' Hitta artistid från nodens tag
        artistId = Strings.Mid(nod.Tag, Strings.InStr(nod.Tag, "=") + 1)

        ' Sätt artistid och namn i det nya formuläret
        frmNyttAlbum.txtArtistID.Text = artistId
        frmNyttAlbum.artistnamn = nod.Text

        ' Visa formuläret och vänta på svaret
        If frmNyttAlbum.ShowDialog() = DialogResult.OK Then
            reloadTree()
        End If

    End Sub

    Private Sub btnRaderaArtist_Click(sender As Object, e As EventArgs) Handles btnRaderaArtist.Click
        Dim artistId As String
        Dim nod As TreeNode

        If IsNothing(tvwArtisterAlbum.SelectedNode.Parent) Then
            ' Hitta artistid från nodens tag
            nod = tvwArtisterAlbum.SelectedNode
            artistId = Strings.Mid(nod.Tag, Strings.InStr(nod.Tag, "=") + 1)
            raderaArtist(artistId)
        End If
    End Sub
    Private Sub raderaArtist(id As String)
        ' Lokal dataadapter för att spara
        Dim dataAdapter As New SQLite.SQLiteDataAdapter("Select * from artists where artistId=" & id, cnChinook)

        ' Använd en CommandBuilder för att spara
        Dim comBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)
        Dim ds As New DataSet

        ' Fyll datasetet med info från databasen
        dataAdapter.Fill(ds, "Artister")

        ' Ta bort första raden
        ds.Tables("Artister").Rows(0).Delete()

        ' Skriv till databasen
        dataAdapter.Update(ds, "Artister")

        reloadTree()
    End Sub


    Private Sub btnRaderaAlbum_Click(sender As Object, e As EventArgs) Handles btnRaderaAlbum.Click
        Dim albumId As String
        Dim nod As TreeNode

        If Not IsNothing(tvwArtisterAlbum.SelectedNode.Parent) Then
            ' Hitta albumtid från nodens tag
            nod = tvwArtisterAlbum.SelectedNode
            albumId = Strings.Mid(nod.Tag, Strings.InStr(nod.Tag, "=") + 1)
            raderaAlbum(albumId)
        End If

    End Sub
    Private Sub raderaAlbum(id As String)
        ' Lokal dataadapter för att spara
        Dim dataAdapter As New SQLite.SQLiteDataAdapter("Select * from albums where albumId=" & id, cnChinook)

        ' Använd en CommandBuilder för att spara
        Dim comBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)
        Dim ds As New DataSet

        ' Fyll datasetet med info från databasen
        dataAdapter.Fill(ds, "Album")

        ' Ta bort första raden
        ds.Tables("Album").Rows(0).Delete()

        ' Skriv till databasen
        dataAdapter.Update(ds, "Album")

        reloadTree()
    End Sub
End Class
