Imports System.Threading
Public Class MainForm

    Private StartupControls As New StartupPanel
    Private MenuControls As New MenuPanel
    Private RouteFindControls As New RouteFindPanel
    Private CurrentControls As New UserControl

    Private Sub Startup() Handles Me.Load
        initMenu()
        initContent()
    End Sub

    Sub initMenu()
        Controls.Add(MenuControls)
        MenuControls.Location = New Point(0, 0)
        MenuControls.Visible = False
    End Sub

    Sub initContent()
        StartupControls.Location = New Point(0, 0)
        RouteFindControls.Location = New Point(0, 120)
        CurrentControls = StartupControls
        Controls.Add(CurrentControls)
    End Sub
    Public Sub switchPanels(newPanelIndex As Integer, NewPanel As Boolean)
        Controls.Remove(CurrentControls)
        Select Case newPanelIndex
            Case 0
                CurrentControls = StartupControls
                Text = "Main Menu"
            Case 1
                '  If NewPanel Then RouteFindControls = New RouteFindPanel
                CurrentControls = RouteFindControls
                Text = "Route Finder"
        End Select
        If newPanelIndex <> 0 Then MenuControls.Visible = True Else MenuControls.Visible = False
        Controls.Add(CurrentControls)
    End Sub


    Public Sub exitProgram()
        End
    End Sub

End Class