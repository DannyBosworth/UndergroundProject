Public Class MenuPanel
    Private Sub MenuButton_Click(sender As Object, e As MouseEventArgs) Handles MenuButton.Click
        MyMainForm.switchPanels(0, False)
    End Sub

    Private Sub RouteFindButton_Click(sender As Object, e As MouseEventArgs) Handles RouteFindButton.MouseDown
        If e.Button = MouseButtons.Left Then
            MyMainForm.switchPanels(1, False)
        ElseIf e.Button = MouseButtons.Right Then
            MyMainForm.switchPanels(1, True)
        End If
    End Sub
End Class
