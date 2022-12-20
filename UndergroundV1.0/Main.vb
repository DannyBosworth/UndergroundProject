Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Reflection.Assembly
Imports System.Reflection

Module Main
    Sub Main()
        Dim bf As New BinaryFormatter
        Console.WriteLine("Choose a Station")
        Dim Station = Console.ReadLine()
        Using ms As New MemoryStream(My.Resources.ACTON_TOWN)
            For Each l In bf.Deserialize(ms)
                Console.WriteLine(l)
            Next
        End Using
    End Sub
End Module
