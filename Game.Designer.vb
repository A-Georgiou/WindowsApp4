<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.rollDice = New System.Windows.Forms.Button()
        Me.playerPosition = New System.Windows.Forms.Label()
        Me.rollsText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rollDice
        '
        Me.rollDice.BackColor = System.Drawing.Color.MidnightBlue
        Me.rollDice.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rollDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rollDice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollDice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rollDice.Location = New System.Drawing.Point(48, 12)
        Me.rollDice.Name = "rollDice"
        Me.rollDice.Size = New System.Drawing.Size(127, 50)
        Me.rollDice.TabIndex = 0
        Me.rollDice.Text = "Roll Dice"
        Me.rollDice.UseVisualStyleBackColor = False
        '
        'playerPosition
        '
        Me.playerPosition.AutoSize = True
        Me.playerPosition.BackColor = System.Drawing.Color.Transparent
        Me.playerPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerPosition.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.playerPosition.Location = New System.Drawing.Point(24, 69)
        Me.playerPosition.Name = "playerPosition"
        Me.playerPosition.Size = New System.Drawing.Size(132, 20)
        Me.playerPosition.TabIndex = 1
        Me.playerPosition.Text = "Player Position:"
        '
        'rollsText
        '
        Me.rollsText.BackColor = System.Drawing.Color.CornflowerBlue
        Me.rollsText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rollsText.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollsText.Location = New System.Drawing.Point(12, 92)
        Me.rollsText.Multiline = True
        Me.rollsText.Name = "rollsText"
        Me.rollsText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.rollsText.Size = New System.Drawing.Size(194, 293)
        Me.rollsText.TabIndex = 2
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(218, 397)
        Me.Controls.Add(Me.rollsText)
        Me.Controls.Add(Me.playerPosition)
        Me.Controls.Add(Me.rollDice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Game"
        Me.Text = "Snake & Ladders game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rollDice As Button
    Friend WithEvents playerPosition As Label
    Friend WithEvents rollsText As TextBox
End Class
