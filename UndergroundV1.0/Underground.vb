Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.Encoding
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Module Underground

    Public Stations(271) As Station

    Sub getRoutesFromFile()
        Stations = Deserialize()
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
                For Each Node In Dijkstras(Stations(i), j)
                    Stations(i).addShortestRoute(Node, j - 2)
                Next
            Next
            Console.WriteLine(i)
            Stations(i).TempCost = 0
            Stations(i).TempParent = 0
        Next
        Serialize()
    End Sub



    Function Dijkstras(Start As Station, MinimumIndex As Integer) As List(Of Node)
        Dim Visited As New List(Of Node)
        Dim Unvisited As New List(Of Node)
        Dim CurrentNode As Node
        Dim AdjacentNode As Node

        For Each S In Stations
            If S Is Start Then Unvisited.Add(New Node(S.GetName, True, S.GetInfo)) Else Unvisited.Add(New Node(S.GetName, False, S.GetInfo))
        Next
        Do
            CurrentNode = Unvisited.OrderBy(Function(Node) Node.GetCost).First
            For Each Connection In CurrentNode.GetAdjacents
                If Unvisited.Find(Function(N) N.GetName = Connection(2)) IsNot Nothing Then
                    AdjacentNode = Unvisited(Unvisited.FindIndex(Function(Node) Node.GetName = Connection(2)))
                Else
                    Continue For
                End If
                If AdjacentNode.GetCost > CurrentNode.GetCost + Connection(MinimumIndex) Then
                    AdjacentNode.newCost(CurrentNode.GetCost + Connection(MinimumIndex))
                    AdjacentNode.addParent(Visited.Count, Connection(MinimumIndex), Connection(0))
                End If
            Next
            Unvisited.Remove(CurrentNode)
            Visited.Add(CurrentNode)
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

        Sub addShortestRoute(Node As Node, Index As Integer)
            If ShortestRoutes.Find(Function(S As Route) S.GetName = Node.GetName) Is Nothing Then
                Dim NewRoute As New Route(Node.GetName)
                NewRoute.addConnection(Index, Node)
                ShortestRoutes.Add(NewRoute)
                Exit Sub
            Else
                ShortestRoutes.Find(Function(S As Route) S.GetName = Node.GetName).addConnection(Index, Node)
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

    <Serializable> Class Node
        Private Name As String
        Private Cost As Decimal
        Private Parent As Integer
        Private CostToParent As Decimal
        Private LineToParent As String
        Private Connections As List(Of List(Of String))

        Sub New(n As String, Start As Boolean, Adjacents As List(Of List(Of String)))
            Name = n
            If Start Then Cost = 0 Else Cost = 1000
            Connections = Adjacents
        End Sub

        Sub newCost(NewCost As Decimal)
            Cost = NewCost
        End Sub

        Sub addParent(Index As Integer, ParentCost As Decimal, Line As String)
            Parent = Index
            CostToParent = ParentCost
            LineToParent = Line
        End Sub

        ReadOnly Property GetCostToParent As Decimal
            Get
                Return CostToParent
            End Get
        End Property

        ReadOnly Property GetParent As Integer
            Get
                Return Parent
            End Get
        End Property

        ReadOnly Property GetCost As Decimal
            Get
                Return Cost
            End Get
        End Property

        ReadOnly Property GetAdjacents As List(Of List(Of String))
            Get
                Return Connections
            End Get
        End Property

        ReadOnly Property GetName As String
            Get
                Return Name
            End Get
        End Property

        ReadOnly Property GetLine As String
            Get
                Return LineToParent
            End Get
        End Property
    End Class

    <Serializable> Class Route
        Private StationName As String
        Private Distance() As String
        Private IdealTime() As String
        Private PeakTime() As String
        Private OffPeaktime() As String

        Sub New(Name As String)
            StationName = Name
        End Sub

        Sub addConnection(Index As Integer, Node As Node)
            Select Case Index
                Case 1 : Distance = {Node.GetCost, Node.GetParent, Node.GetLine}
                Case 2 : IdealTime = {Node.GetCost, Node.GetParent, Node.GetLine}
                Case 3 : PeakTime = {Node.GetCost, Node.GetParent, Node.GetLine}
                Case 4 : OffPeaktime = {Node.GetCost, Node.GetParent, Node.GetLine}
            End Select
        End Sub

        ReadOnly Property GetName As String
            Get
                Return StationName
            End Get
        End Property

        ReadOnly Property GetRoute(Index As Integer) As String()
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
