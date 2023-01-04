Public Class StartupPanel
    Private Sub NewPanel() Handles Me.Load
        AddHandler QuitButton.Click, AddressOf MyMainForm.exitProgram
    End Sub

    Private Sub RouteFindButton_Click(sender As Object, e As EventArgs) Handles RouteFindButton.Click
        MyMainForm.switchPanels(1, True)
    End Sub

End Class
