<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPanel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.RouteFindButton = New System.Windows.Forms.Button()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.ContentPanel)
        Me.Panel1.Controls.Add(Me.RouteFindButton)
        Me.Panel1.Controls.Add(Me.MenuButton)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 120)
        Me.Panel1.TabIndex = 10
        '
        'ContentPanel
        '
        Me.ContentPanel.Location = New System.Drawing.Point(0, 116)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(986, 407)
        Me.ContentPanel.TabIndex = 8
        '
        'RouteFindButton
        '
        Me.RouteFindButton.BackColor = System.Drawing.Color.Transparent
        Me.RouteFindButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RouteFindButton.FlatAppearance.BorderSize = 0
        Me.RouteFindButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.RouteFindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RouteFindButton.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RouteFindButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RouteFindButton.Location = New System.Drawing.Point(152, 50)
        Me.RouteFindButton.Name = "RouteFindButton"
        Me.RouteFindButton.Size = New System.Drawing.Size(100, 60)
        Me.RouteFindButton.TabIndex = 3
        Me.RouteFindButton.Text = "Route Finder"
        Me.RouteFindButton.UseVisualStyleBackColor = False
        '
        'MenuButton
        '
        Me.MenuButton.BackColor = System.Drawing.Color.Transparent
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.FlatAppearance.BorderSize = 0
        Me.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuButton.Location = New System.Drawing.Point(750, 50)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(100, 60)
        Me.MenuButton.TabIndex = 7
        Me.MenuButton.Text = "Return to Menu"
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(350, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 60)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(550, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 60)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MenuPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MenuPanel"
        Me.Size = New System.Drawing.Size(1000, 120)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ContentPanel As Panel
    Friend WithEvents RouteFindButton As Button
    Friend WithEvents MenuButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
