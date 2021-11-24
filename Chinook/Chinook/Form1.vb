Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fyll trädvyn vid formulärinläsning
        reloadTree()
    End Sub

    Private Sub reloadTree()
        ' Rensa tidigare innehåll
        tvwArtisterAlbum.Nodes.Clear()

        Dim dt As DataTable = hamtaData("Select * from artists")
        fyllTrad(dt, 0, Nothing, "Name", "ArtistId")

        ' Sortera trädet
        tvwArtisterAlbum.Sort()
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
                Dim dtChild As DataTable = hamtaData("select * from albums where " & child.Tag)
                fyllTrad(dtChild, row(tag), child, "Title", "AlbumId")
            Else
                ' Vi har en barnnod (=album), lägg till i en befintlig nod i trädvyn
                nod.Nodes.Add(child)
            End If
        Next
    End Sub

    Private Sub tvwArtisterAlbum_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwArtisterAlbum.AfterSelect
        If IsNothing(e.Node.Parent) Then
            ' Det är en artistnod => visa album i gridvyn
            showDataGrid("select * from albums where " & e.Node.Tag)
            grdAlbumLatar.Columns(0).Visible = False
            grdAlbumLatar.Columns(2).Visible = False
        Else
            ' Det är en albumnod => visa låtar i gridvyn
            showDataGrid("select * from tracks where " & e.Node.Tag)
        End If
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
        If IsNothing(tvwArtisterAlbum.SelectedNode.Parent) Then
            ' Vi har en artist markerad, id finns i slutet på nodens tag
            Dim artistId As String
            artistId = Strings.Mid(tvwArtisterAlbum.SelectedNode.Tag, Strings.InStr(tvwArtisterAlbum.SelectedNode.Tag, "=") + 1)
            frmNyttAlbum.txtArtistID.Text = artistId
        End If

        If frmNyttAlbum.ShowDialog() = DialogResult.OK Then
            reloadTree()
        End If

    End Sub
End Class
