<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RouteFindPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.StartStationBox = New System.Windows.Forms.ComboBox()
        Me.EndStationBox = New System.Windows.Forms.ComboBox()
        Me.FromLabel = New System.Windows.Forms.Label()
        Me.ToLabel = New System.Windows.Forms.Label()
        Me.FindRouteButton = New System.Windows.Forms.Button()
        Me.DistanceButton = New System.Windows.Forms.Button()
        Me.PeakTimeButton = New System.Windows.Forms.Button()
        Me.OffPeakTimeButton = New System.Windows.Forms.Button()
        Me.IdealTimeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartStationBox
        '
        Me.StartStationBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.StartStationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StartStationBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartStationBox.Font = New System.Drawing.Font("London Tube", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartStationBox.FormattingEnabled = True
        Me.StartStationBox.Location = New System.Drawing.Point(20, 60)
        Me.StartStationBox.Name = "StartStationBox"
        Me.StartStationBox.Size = New System.Drawing.Size(300, 27)
        Me.StartStationBox.TabIndex = 0
        '
        'EndStationBox
        '
        Me.EndStationBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.EndStationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EndStationBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EndStationBox.Font = New System.Drawing.Font("London Tube", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndStationBox.FormattingEnabled = True
        Me.EndStationBox.Location = New System.Drawing.Point(680, 60)
        Me.EndStationBox.Name = "EndStationBox"
        Me.EndStationBox.Size = New System.Drawing.Size(300, 27)
        Me.EndStationBox.TabIndex = 1
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = True
        Me.FromLabel.Font = New System.Drawing.Font("London Tube", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromLabel.Location = New System.Drawing.Point(15, 21)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.Size = New System.Drawing.Size(62, 26)
        Me.FromLabel.TabIndex = 2
        Me.FromLabel.Text = "From"
        '
        'ToLabel
        '
        Me.ToLabel.AutoSize = True
        Me.ToLabel.Font = New System.Drawing.Font("London Tube", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToLabel.Location = New System.Drawing.Point(942, 21)
        Me.ToLabel.Name = "ToLabel"
        Me.ToLabel.Size = New System.Drawing.Size(38, 26)
        Me.ToLabel.TabIndex = 3
        Me.ToLabel.Text = "To"
        '
        'FindRouteButton
        '
        Me.FindRouteButton.BackColor = System.Drawing.Color.Transparent
        Me.FindRouteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FindRouteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.FindRouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindRouteButton.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindRouteButton.Location = New System.Drawing.Point(450, 44)
        Me.FindRouteButton.Name = "FindRouteButton"
        Me.FindRouteButton.Size = New System.Drawing.Size(100, 60)
        Me.FindRouteButton.TabIndex = 5
        Me.FindRouteButton.Text = "Find Route"
        Me.FindRouteButton.UseVisualStyleBackColor = False
        '
        'DistanceButton
        '
        Me.DistanceButton.BackColor = System.Drawing.Color.Transparent
        Me.DistanceButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DistanceButton.FlatAppearance.BorderSize = 0
        Me.DistanceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.DistanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DistanceButton.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistanceButton.Location = New System.Drawing.Point(260, 124)
        Me.DistanceButton.Name = "DistanceButton"
        Me.DistanceButton.Size = New System.Drawing.Size(95, 30)
        Me.DistanceButton.TabIndex = 6
        Me.DistanceButton.Text = "Distance"
        Me.DistanceButton.UseVisualStyleBackColor = False
        '
        'PeakTimeButton
        '
        Me.PeakTimeButton.BackColor = System.Drawing.Color.Transparent
        Me.PeakTimeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PeakTimeButton.FlatAppearance.BorderSize = 0
        Me.PeakTimeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.PeakTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PeakTimeButton.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeakTimeButton.Location = New System.Drawing.Point(483, 124)
        Me.PeakTimeButton.Name = "PeakTimeButton"
        Me.PeakTimeButton.Size = New System.Drawing.Size(109, 30)
        Me.PeakTimeButton.TabIndex = 7
        Me.PeakTimeButton.Text = "Peak Time"
        Me.PeakTimeButton.UseVisualStyleBackColor = False
        '
        'OffPeakTimeButton
        '
        Me.OffPeakTimeButton.BackColor = System.Drawing.Color.Transparent
        Me.OffPeakTimeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OffPeakTimeButton.FlatAppearance.BorderSize = 0
        Me.OffPeakTimeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.OffPeakTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OffPeakTimeButton.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OffPeakTimeButton.Location = New System.Drawing.Point(598, 124)
        Me.OffPeakTimeButton.Name = "OffPeakTimeButton"
        Me.OffPeakTimeButton.Size = New System.Drawing.Size(150, 30)
        Me.OffPeakTimeButton.TabIndex = 8
        Me.OffPeakTimeButton.Text = "Off-Peak Time"
        Me.OffPeakTimeButton.UseVisualStyleBackColor = False
        '
        'IdealTimeButton
        '
        Me.IdealTimeButton.BackColor = System.Drawing.Color.Transparent
        Me.IdealTimeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IdealTimeButton.FlatAppearance.BorderSize = 0
        Me.IdealTimeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.IdealTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IdealTimeButton.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdealTimeButton.Location = New System.Drawing.Point(361, 124)
        Me.IdealTimeButton.Name = "IdealTimeButton"
        Me.IdealTimeButton.Size = New System.Drawing.Size(116, 30)
        Me.IdealTimeButton.TabIndex = 9
        Me.IdealTimeButton.Text = "Ideal Time"
        Me.IdealTimeButton.UseVisualStyleBackColor = False
        '
        'RouteFindPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.IdealTimeButton)
        Me.Controls.Add(Me.OffPeakTimeButton)
        Me.Controls.Add(Me.PeakTimeButton)
        Me.Controls.Add(Me.DistanceButton)
        Me.Controls.Add(Me.FindRouteButton)
        Me.Controls.Add(Me.ToLabel)
        Me.Controls.Add(Me.FromLabel)
        Me.Controls.Add(Me.EndStationBox)
        Me.Controls.Add(Me.StartStationBox)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "RouteFindPanel"
        Me.Size = New System.Drawing.Size(1000, 442)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartStationBox As ComboBox
    Friend WithEvents EndStationBox As ComboBox
    Friend WithEvents FromLabel As Label
    Friend WithEvents ToLabel As Label
    Friend WithEvents FindRouteButton As Button
    Friend WithEvents DistanceButton As Button
    Friend WithEvents PeakTimeButton As Button
    Friend WithEvents OffPeakTimeButton As Button
    Friend WithEvents IdealTimeButton As Button
End Class
