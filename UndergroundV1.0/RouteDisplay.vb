Public Class RouteDisplay

    Private Stations As New List(Of StationName)
    Public Event NextPage()
    Public Event PrevPage()

    Sub init(Names As List(Of String), Lines As List(Of String), First As Integer)
        Location = New Point(0, 180)
        For i = First To Math.Min(First + 11, Names.Count - 1)
            Stations.Add(New StationName())
            Stations.Last.init(Names(i), Lines(i), New Point(i Mod 4, i \ 4))
        Next
        For Each Station In Stations
            Controls.Add(Station)
        Next
    End Sub

    Sub displayNext(Display As Boolean)
        If Display Then NextPageButton.Visible = True Else NextPageButton.Visible = False
    End Sub

    Sub displayPrev(Display As Boolean)
        If Display Then PrevPageButton.Visible = True Else PrevPageButton.Visible = False
    End Sub
End Class
