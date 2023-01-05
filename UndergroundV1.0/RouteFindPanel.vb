Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class RouteFindPanel

    Private SortingButtons As New List(Of Button)
    Private CurrentRoute As New RouteInfo
    Private Sub RouteFindPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        StartStationBox.Items.AddRange(getNames)
        EndStationBox.Items.AddRange(getNames)
        SortingButtons.AddRange({DistanceButton, IdealTimeButton, PeakTimeButton, OffPeakTimeButton})
    End Sub
    Private Sub StationBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StartStationBox.SelectedIndexChanged, EndStationBox.SelectedIndexChanged
        FromLabel.Focus()
    End Sub
    Private Sub FindRouteButton_Click(sender As Object, e As EventArgs) Handles FindRouteButton.Click
        While th.IsAlive
            Thread.Sleep(1)
        End While
        If StartStationBox.SelectedItem IsNot Nothing AndAlso EndStationBox.SelectedItem IsNot Nothing AndAlso StartStationBox.SelectedItem <> EndStationBox.SelectedItem Then
            For i = 1 To 4
                If SortingButtons(i - 1).BackColor = Color.Chocolate Then CurrentRoute = getShortestRoute(StartStationBox.SelectedItem, EndStationBox.SelectedItem, i)
            Next
            For Each Station In CurrentRoute.GetStations
                Console.WriteLine(Station)
            Next
            Console.WriteLine(CurrentRoute.GetTotalCost)
        End If
    End Sub

    Private Sub DistanceButton_Click(sender As Button, e As EventArgs) Handles DistanceButton.Click, PeakTimeButton.Click, OffPeakTimeButton.Click, IdealTimeButton.Click
        For Each Button In SortingButtons
            Button.BackColor = Color.Transparent
        Next
        sender.BackColor = Color.Chocolate
    End Sub
End Class
