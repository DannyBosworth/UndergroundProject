Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Reflection.Assembly
Imports System.Reflection

Module Main

    Sub Main()
    End Sub
    Sub shortestRoute()
        Console.WriteLine("Enter a Start Station: ")
        Dim Start = Console.ReadLine
        Console.WriteLine("Enter a Finish Station")
        Dim Finish = Console.ReadLine
        Dim ShortestRoutes As Dictionary(Of Integer, DijkNode) = Deserialize(Start.Replace(" ", "_").ToUpper)
        Console.WriteLine("The shortest distance from " & Start & " to " & Finish & " is " & ShortestRoutes.First(Function(x) x.Value.Name.Replace("_", " ").ToUpper = Finish.ToUpper).Value.Distance & "km")
    End Sub

    Function Deserialize(Name As String) As Dictionary(Of Integer, DijkNode)
        Using ms = New MemoryStream(CType(My.Resources.ResourceManager.GetObject(Name), Byte()))
            Dim bf As New BinaryFormatter()
            Return bf.Deserialize(ms)
        End Using
    End Function
    <Serializable> Class DijkNode ' structure used to store stations for use in dijkstras algorithm
        Public Name As String
        Public Cost As Decimal
        Public Distance As Decimal
        Public IdealTime As Decimal
        Public PeakTime As Decimal
        Public OffPeakTime As Decimal
        Public Prev As Integer
    End Class
End Module
