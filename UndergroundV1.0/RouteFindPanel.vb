Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class RouteFindPanel

    Private SortingButtons As New List(Of Button)
    Private CurrentRoute As New RouteInfo
    Private RouteDisplayPanels As New List(Of RouteDisplay)
    Private CurrentRoutePanel As RouteDisplay
    Private Sub RouteFindPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Location = New Point(0, 120)
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
                If SortingButtons(i - 1).BackColor = Color.Chocolate Then
                    CurrentRoute = getShortestRoute(StartStationBox.SelectedItem, EndStationBox.SelectedItem, i)
                    displayRoute()
                End If
            Next
        End If
    End Sub

    Sub displayRoute()
        For i = 0 To (CurrentRoute.GetStations.Count - 0.1) \ 12
            RouteDisplayPanels.Add(New RouteDisplay)
            RouteDisplayPanels.Last.init(CurrentRoute.GetStations, CurrentRoute.GetLines, i * 12)
        Next
        CurrentRoutePanel = RouteDisplayPanels(0)
        If RouteDisplayPanels.Count > 1 Then CurrentRoutePanel.displayNext(True)
        AddHandler CurrentRoutePanel.NextPageButton.Click, AddressOf nextPage
        Controls.Add(CurrentRoutePanel)
    End Sub

    Sub nextPage()
        CurrentRoutePanel = RouteDisplayPanels(RouteDisplayPanels.IndexOf(CurrentRoutePanel) + 1)
        If CurrentRoutePanel IsNot RouteDisplayPanels.Last Then CurrentRoutePanel.displayNext(True) Else CurrentRoutePanel.displayNext(False)
        If CurrentRoutePanel IsNot RouteDisplayPanels.First Then CurrentRoutePanel.displayPrev(True) Else CurrentRoutePanel.displayPrev(False)
        AddHandler CurrentRoutePanel.NextPageButton.Click, AddressOf nextPage
        AddHandler CurrentRoutePanel.PrevPageButton.Click, AddressOf prevPage
        Controls.Add(CurrentRoutePanel)
    End Sub

    Sub prevPage()
        CurrentRoutePanel = RouteDisplayPanels(RouteDisplayPanels.IndexOf(CurrentRoutePanel) - 1)
        If CurrentRoutePanel IsNot RouteDisplayPanels.Last Then CurrentRoutePanel.displayNext(True) Else CurrentRoutePanel.displayNext(False)
        If CurrentRoutePanel IsNot RouteDisplayPanels.First Then CurrentRoutePanel.displayPrev(True) Else CurrentRoutePanel.displayPrev(False)
        AddHandler CurrentRoutePanel.NextPageButton.Click, AddressOf nextPage
        AddHandler CurrentRoutePanel.PrevPageButton.Click, AddressOf prevPage
        Controls.Add(CurrentRoutePanel)
    End Sub


    Private Sub DistanceButton_Click(sender As Button, e As EventArgs) Handles DistanceButton.Click, PeakTimeButton.Click, OffPeakTimeButton.Click, IdealTimeButton.Click
        For Each Button In SortingButtons
            Button.BackColor = Color.Transparent
        Next
        sender.BackColor = Color.Chocolate
    End Sub
End Class
