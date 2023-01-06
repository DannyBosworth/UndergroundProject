Public Class RouteDisplay

    Private Stations As New List(Of StationName)
    Sub New(Names As List(Of String), Lines As List(Of String), First As Integer)
        Location = New Point(0, 180)
        For i = First To Math.Min(First + 11, Names.Count - 1)
            Stations.Add(New StationName(Names(i), Lines(i), New Point(i \ 3, i Mod 4)))
        Next
        For Each Station In Stations
            Controls.Add(Station)
        Next
    End Sub

End Class
