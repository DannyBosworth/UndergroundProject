<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RouteDisplay
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
        Me.NextPageButton = New System.Windows.Forms.Button()
        Me.PrevPageButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NextPageButton
        '
        Me.NextPageButton.BackColor = System.Drawing.Color.Transparent
        Me.NextPageButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextPageButton.FlatAppearance.BorderSize = 0
        Me.NextPageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.NextPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextPageButton.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextPageButton.Location = New System.Drawing.Point(882, 225)
        Me.NextPageButton.Name = "NextPageButton"
        Me.NextPageButton.Size = New System.Drawing.Size(115, 34)
        Me.NextPageButton.TabIndex = 7
        Me.NextPageButton.Text = "Next Page"
        Me.NextPageButton.UseVisualStyleBackColor = False
        Me.NextPageButton.Visible = False
        '
        'PrevPageButton
        '
        Me.PrevPageButton.BackColor = System.Drawing.Color.Transparent
        Me.PrevPageButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrevPageButton.FlatAppearance.BorderSize = 0
        Me.PrevPageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.PrevPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrevPageButton.Font = New System.Drawing.Font("London Tube", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevPageButton.Location = New System.Drawing.Point(3, 225)
        Me.PrevPageButton.Name = "PrevPageButton"
        Me.PrevPageButton.Size = New System.Drawing.Size(138, 34)
        Me.PrevPageButton.TabIndex = 8
        Me.PrevPageButton.Text = "Previous Page"
        Me.PrevPageButton.UseVisualStyleBackColor = False
        Me.PrevPageButton.Visible = False
        '
        'RouteDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.PrevPageButton)
        Me.Controls.Add(Me.NextPageButton)
        Me.Name = "RouteDisplay"
        Me.Size = New System.Drawing.Size(1000, 262)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NextPageButton As Button
    Friend WithEvents PrevPageButton As Button
End Class
