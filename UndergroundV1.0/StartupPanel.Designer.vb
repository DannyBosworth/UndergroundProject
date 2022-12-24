<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartupPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartupPanel))
        Me.Welcome1 = New System.Windows.Forms.Label()
        Me.Welcome2 = New System.Windows.Forms.PictureBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RouteFindButton = New System.Windows.Forms.Button()
        CType(Me.Welcome2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Welcome1
        '
        Me.Welcome1.BackColor = System.Drawing.Color.Transparent
        Me.Welcome1.Font = New System.Drawing.Font("London Tube", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome1.Location = New System.Drawing.Point(300, 120)
        Me.Welcome1.Name = "Welcome1"
        Me.Welcome1.Size = New System.Drawing.Size(400, 50)
        Me.Welcome1.TabIndex = 1
        Me.Welcome1.Text = "Welcome To The"
        '
        'Welcome2
        '
        Me.Welcome2.BackColor = System.Drawing.Color.Transparent
        Me.Welcome2.Image = CType(resources.GetObject("Welcome2.Image"), System.Drawing.Image)
        Me.Welcome2.Location = New System.Drawing.Point(350, 220)
        Me.Welcome2.Name = "Welcome2"
        Me.Welcome2.Size = New System.Drawing.Size(300, 257)
        Me.Welcome2.TabIndex = 3
        Me.Welcome2.TabStop = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.Transparent
        Me.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QuitButton.FlatAppearance.BorderSize = 0
        Me.QuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitButton.Font = New System.Drawing.Font("London Tube", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.QuitButton.Location = New System.Drawing.Point(730, 329)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(150, 90)
        Me.QuitButton.TabIndex = 4
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("London Tube", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(730, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 90)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Route Finder"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("London Tube", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(120, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 90)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Route Finder"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'RouteFindButton
        '
        Me.RouteFindButton.BackColor = System.Drawing.Color.Transparent
        Me.RouteFindButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RouteFindButton.FlatAppearance.BorderSize = 0
        Me.RouteFindButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.RouteFindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RouteFindButton.Font = New System.Drawing.Font("London Tube", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RouteFindButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RouteFindButton.Location = New System.Drawing.Point(120, 142)
        Me.RouteFindButton.Name = "RouteFindButton"
        Me.RouteFindButton.Size = New System.Drawing.Size(150, 90)
        Me.RouteFindButton.TabIndex = 7
        Me.RouteFindButton.Text = "Route Finder"
        Me.RouteFindButton.UseVisualStyleBackColor = False
        '
        'StartupPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.RouteFindButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Welcome2)
        Me.Controls.Add(Me.Welcome1)
        Me.Name = "StartupPanel"
        Me.Size = New System.Drawing.Size(1000, 562)
        CType(Me.Welcome2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Welcome1 As Label
    Friend WithEvents Welcome2 As PictureBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RouteFindButton As Button
End Class
