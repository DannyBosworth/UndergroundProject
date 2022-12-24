Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.Encoding
Imports System.Threading
Module Underground

    Public Routes(271) As Station

    Sub getRoutesFromFile()
        Routes = Deserialize()
        Console.Write(Routes)
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
                Routes(i) = New Station(reader.ReadLine)
                i += 1
            Loop
        End Using
    End Sub

    Sub initConnections()
        Using reader As TextReader = New StringReader(My.Resources.StationConnections)
            Dim i = 0
            Do Until i = 743
                Dim Info As List(Of String) = reader.ReadLine.Split(",").ToList
                Routes.First(Function(Start) Info(2) = Start.GetName).AddConnection(Info)
                i += 1
            Loop
        End Using
    End Sub

    Sub getShortestRoutes()
        For i = 0 To 271
            For j = 3 To 6
                For Each Station In Dijkstras(Routes(i).GetName, j)
                    Routes(i).addShortestRoute(Station, j - 2)
                Next
            Next
            Console.WriteLine(i)
            Routes(i).TempCost = 0
            Routes(i).TempParent = 0
        Next
        Serialize()
    End Sub



    Function Dijkstras(Start As String, MinimumIndex As Integer) As List(Of Station)
        Dim Visited As New List(Of Station)
        Dim Unvisited As List(Of Station) = Routes.ToList
        Dim CurrentStation As Station
        Dim AdjacentStation As Station

        For Each S In Routes
            S.TempCost = 1000
        Next
        Unvisited(Unvisited.FindIndex(Function(Station) Station.GetName = Start.ToUpper)).TempCost = 0
        Do
            CurrentStation = Unvisited.OrderBy(Function(Station) Station.TempCost).First
            For Each Connection In CurrentStation.GetInfo
                If Not Visited.Contains(Routes.First(Function(Station) Station.GetName = Connection(2))) Then
                    AdjacentStation = Unvisited(Unvisited.FindIndex(Function(Station) Station.GetName = Connection(2)))
                Else
                    Continue For
                End If
                If AdjacentStation.TempCost = 1000 Or AdjacentStation.TempParent = Array.IndexOf(Routes, CurrentStation) Then
                    If AdjacentStation.TempCost > Connection(MinimumIndex) Then AdjacentStation.TempCost = Connection(MinimumIndex) + CurrentStation.TempCost
                Else
                    If AdjacentStation.TempCost > CurrentStation.TempCost + Connection(MinimumIndex) Then AdjacentStation.TempCost += Connection(MinimumIndex)
                End If
                AdjacentStation.TempParent = Array.IndexOf(Routes, CurrentStation)
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
            bf.Serialize(fs, Routes)
        End Using
    End Sub

    <Serializable> Class Station
        Private Name As String
        Private ShortestRoutes As New List(Of Tuple(Of String, Integer)())
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
            If ShortestRoutes.Find(Function(S) S(0).Item1 = Station.GetName) Is Nothing Then
                Dim NewRoute(4) As Tuple(Of String, Integer)
                NewRoute(0) = New Tuple(Of String, Integer)(Station.GetName, -1)
                NewRoute(Index) = New Tuple(Of String, Integer)(Station.TempCost, Station.TempParent)
                ShortestRoutes.Add(NewRoute)
                Exit Sub
            Else
                ShortestRoutes.Find(Function(S) S(0).Item1 = Station.GetName)(Index) = New Tuple(Of String, Integer)(Station.TempCost, Station.TempParent)
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
    End Class
End Module
