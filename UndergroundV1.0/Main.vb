Imports System.IO
Imports System.Threading

Module Main

    Public th As New Thread(New ThreadStart(AddressOf getRoutesFromFile))
    Public MyMainForm As New MainForm

    Sub Main()

        th.Start()
        Application.Run(MyMainForm)
        ' getRoutesFromDijkstras()
    End Sub
End Module
