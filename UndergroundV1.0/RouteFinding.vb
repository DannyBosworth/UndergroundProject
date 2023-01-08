Imports System.IO

Public Module RouteFinding
    Function getNames()
        Dim Names(271) As String
        Using reader As TextReader = New StringReader(My.Resources.StationNames)
            Dim i = 0
            Do Until i = 272
                Names(i) = reader.ReadLine
                i += 1
            Loop
        End Using
        Return Names
    End Function

    Function getShortestRoute(StartName As String, EndName As String, SortIndex As Integer) As RouteInfo
        Dim StartIndex As Integer
        Dim CurrentStation As Integer
        Dim Route As New RouteInfo
        For i = 0 To 271
            If Stations(i).GetName = StartName Then
                StartIndex = i
                For j = 0 To 271
                    If Stations(i).GetRoutes(j).GetName = EndName Then CurrentStation = j
                Next
            End If
        Next
        Do Until CurrentStation = 0
            Route.addStation(Stations(StartIndex).GetRoutes(CurrentStation).GetName, Stations(StartIndex).GetRoutes(CurrentStation).GetRoute(SortIndex)(0), Stations(StartIndex).GetRoutes(CurrentStation).GetRoute(SortIndex)(2))
            CurrentStation = Stations(StartIndex).GetRoutes(CurrentStation).GetRoute(SortIndex)(1)
        Loop
        Route.routeFinished()
        Return Route
    End Function

    Class RouteInfo
        Private Stations As New List(Of String)
        Private Costs As New List(Of Decimal)
        Private Lines As New List(Of String)
        Private TotalCost As Decimal
        Sub addStation(Name As String, Cost As Decimal, Line As String)
            Stations.Add(Name)
            Costs.Add(Cost)
            Lines.Add(Line)
        End Sub

        Sub routeFinished()
            TotalCost = Costs.Sum
            Stations.Reverse()
            Costs.Reverse()
            Lines.Reverse()
        End Sub

        ReadOnly Property GetStations() As List(Of String)
            Get
                Return Stations
            End Get
        End Property

        ReadOnly Property GetCosts() As List(Of Decimal)
            Get
                Return Costs
            End Get
        End Property

        ReadOnly Property GetTotalCost As Decimal
            Get
                Return TotalCost
            End Get
        End Property

        ReadOnly Property GetLines As List(Of String)
            Get
                Return Lines
            End Get
        End Property
    End Class

End Module
