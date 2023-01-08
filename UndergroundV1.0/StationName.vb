Public Class StationName
    Sub init(Station As String, Line As String, Index As Point)
        NameBox.Text = Station
        Select Case Line
            Case "Bakerloo" : NameBox.ForeColor = ColorTranslator.FromHtml("#B36305")
            Case "Central" : NameBox.ForeColor = ColorTranslator.FromHtml("#E32017")
            Case "Victoria" : NameBox.ForeColor = ColorTranslator.FromHtml("#0098D4")
            Case "Waterloo & City" : NameBox.ForeColor = ColorTranslator.FromHtml("#95CDBA")
            Case "Jubilee" : NameBox.ForeColor = ColorTranslator.FromHtml("#A0A5A9")
            Case "Piccadilly" : NameBox.ForeColor = ColorTranslator.FromHtml("#003688")
            Case "Metropolitan" : NameBox.ForeColor = ColorTranslator.FromHtml("#9B0056")
            Case "H & C" : NameBox.ForeColor = ColorTranslator.FromHtml("#F3A9BB")
            Case "Circle" : NameBox.ForeColor = ColorTranslator.FromHtml("#FFD300")
            Case "District" : NameBox.ForeColor = ColorTranslator.FromHtml("#00782A")
            Case "East London" : NameBox.ForeColor = ColorTranslator.FromHtml("#EC9E00")
            Case "Northern" : NameBox.ForeColor = ColorTranslator.FromHtml("#000000")
        End Select
        Location = New Point(28 + Index.X * 237, 3 + Index.Y * 60)
    End Sub
End Class
