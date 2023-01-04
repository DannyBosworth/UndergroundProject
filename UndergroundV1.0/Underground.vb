Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.Encoding
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Module Underground

    Public Stations(271) As Station

    Sub getRoutesFromFile()
        Stations = Deserialize()
        Console.Write(Stations)
    End Sub

    Sub getRoutesFromDijkstras()
        initStations()
        initConnections()
        getShortestRoutes()
    End Sub
    Sub initStations()
        Using reader As TextReader = New StringReader(My.Resources.StationNames)
            Dim i = 0
            Do Until i = 272
                Stations(i) = New Station(reader.ReadLine)
                i += 1
            Loop
        End Using
    End Sub

    Sub initConnections()
        Using reader As TextReader = New StringReader(My.Resources.StationConnections)
            Dim i = 0
            Do Until i = 743
                Dim Info As List(Of String) = reader.ReadLine.Split(",").ToList
                Stations.First(Function(Start) Info(2) = Start.GetName).AddConnection(Info)
                i += 1
            Loop
        End Using
    End Sub

    Sub getShortestRoutes()
        For i = 0 To 271
            For j = 3 To 6
                For Each Station In Dijkstras(Stations(i).GetName, j)
                    Stations(i).addShortestRoute(Station, j - 2)
                Next
            Next
            Console.WriteLine(i)
            Stations(i).TempCost = 0
            Stations(i).TempParent = 0
        Next
        Serialize()
    End Sub



    Function Dijkstras(Start As String, MinimumIndex As Integer) As List(Of Station)
        Dim Visited As New List(Of Station)
        Dim Unvisited As List(Of Station) = Stations.ToList
        Dim CurrentStation As Station
        Dim AdjacentStation As Station

        For Each S In Stations
            S.TempCost = 1000
        Next
        Unvisited(Unvisited.FindIndex(Function(Station) Station.GetName = Start.ToUpper)).TempCost = 0
        Do
            CurrentStation = Unvisited.OrderBy(Function(Station) Station.TempCost).First
            For Each Connection In CurrentStation.GetInfo
                If Not Visited.Contains(Stations.First(Function(Station) Station.GetName = Connection(2))) Then
                    AdjacentStation = Unvisited(Unvisited.FindIndex(Function(Station) Station.GetName = Connection(2)))
                Else
                    Continue For
                End If
                If AdjacentStation.TempCost = 1000 Then ' Or AdjacentStation.TempParent = Array.IndexOf(Stations, CurrentStation) Then
                    If AdjacentStation.TempCost > Connection(MinimumIndex) Then AdjacentStation.TempCost = Connection(MinimumIndex) + CurrentStation.TempCost
                Else
                    If AdjacentStation.TempCost > CurrentStation.TempCost + Connection(MinimumIndex) Then AdjacentStation.TempCost += Connection(MinimumIndex)
                End If
                AdjacentStation.TempParent = Array.IndexOf(Stations, CurrentStation)
            Next
            Unvisited.Remove(CurrentStation)
            Visited.Add(CurrentStation)
        Loop Until Unvisited.Count = 0
        Return Visited
    End Function

    Function Deserialize()
        Dim bf As New BinaryFormatter
        Using ms = New MemoryStream(My.Resources.StationInfo)
            Return bf.Deserialize(ms)
        End Using
    End Function

    Sub Serialize()
        Dim bf As New BinaryFormatter
        Using fs As New FileStream(Directory.GetParent(Directory.GetCurrentDirectory).Parent.FullName & "/Resources\StationInfo.bin", FileMode.OpenOrCreate)
            bf.Serialize(fs, Stations)
        End Using
    End Sub

    <Serializable> Class Station
        Private Name As String
        Private ShortestRoutes As New List(Of Route)
        Private Adjacents As New List(Of List(Of String))
        'each entry is an adjacent station and all info about that station in the form:
        'Line, Direction, Adjacent Station, Distance(km), Ideal Time(mins), Peak Time(mins), Off Peak Time(mins)
        Public TempCost As Decimal
        Public TempParent As Integer

        Sub New(NewName As String)
            Name = NewName
        End Sub

        Sub AddConnection(Info As List(Of String))
            Info.RemoveAt(2)
            Adjacents.Add(Info)
        End Sub

        Sub addShortestRoute(Station As Station, Index As Integer)
            If ShortestRoutes.Find(Function(S As Route) S.GetName = Station.GetName) Is Nothing Then
                Dim NewRoute As New Route(Station.GetName)
                NewRoute.addConnection(Index, Station.TempCost, Station.TempParent)
                ShortestRoutes.Add(NewRoute)
                Exit Sub
            Else
                ShortestRoutes.Find(Function(S As Route) S.GetName = Station.GetName).addConnection(Index, Station.TempCost, Station.TempParent)
            End If
        End Sub

        ReadOnly Property GetName As String
            Get
                Return Name
            End Get
        End Property

        ReadOnly Property GetInfo As List(Of List(Of String))
            Get
                Return Adjacents
            End Get
        End Property

        ReadOnly Property GetRoutes As List(Of Route)
            Get
                Return ShortestRoutes
            End Get
        End Property
    End Class

    <Serializable> Class Route
        Private StationName As String
        Private Distance() As Decimal
        Private IdealTime() As Decimal
        Private PeakTime() As Decimal
        Private OffPeaktime() As Decimal

        Sub New(Name As String)
            StationName = Name
        End Sub

        Sub addConnection(Index As Integer, Cost As Decimal, Parent As Decimal)
            Select Case Index
                Case 1 : Distance = {Cost, Parent}
                Case 2 : IdealTime = {Cost, Parent}
                Case 3 : PeakTime = {Cost, Parent}
                Case 4 : OffPeaktime = {Cost, Parent}
            End Select
        End Sub

        ReadOnly Property GetName As String
            Get
                Return StationName
            End Get
        End Property

        ReadOnly Property GetRoute(Index As Integer) As Decimal()
            Get
                Select Case Index
                    Case 1 : Return Distance
                    Case 2 : Return IdealTime
                    Case 3 : Return PeakTime
                    Case 4 : Return OffPeaktime
                End Select
                Return Nothing
            End Get
        End Property
    End Class
End Module
