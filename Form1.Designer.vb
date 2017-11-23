<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.snakePos = New System.Windows.Forms.ComboBox()
        Me.ladderSend = New System.Windows.Forms.ComboBox()
        Me.ladderPos = New System.Windows.Forms.ComboBox()
        Me.snakeSend = New System.Windows.Forms.ComboBox()
        Me.inputSnake = New System.Windows.Forms.Label()
        Me.inputLadder = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inputVal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'snakePos
        '
        Me.snakePos.BackColor = System.Drawing.Color.LightGray
        Me.snakePos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.snakePos.DropDownWidth = 40
        Me.snakePos.FormattingEnabled = True
        Me.snakePos.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.snakePos.Location = New System.Drawing.Point(191, 11)
        Me.snakePos.Name = "snakePos"
        Me.snakePos.Size = New System.Drawing.Size(40, 21)
        Me.snakePos.TabIndex = 0
        '
        'ladderSend
        '
        Me.ladderSend.BackColor = System.Drawing.Color.LightGray
        Me.ladderSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ladderSend.DropDownWidth = 40
        Me.ladderSend.FormattingEnabled = True
        Me.ladderSend.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.ladderSend.Location = New System.Drawing.Point(191, 91)
        Me.ladderSend.Name = "ladderSend"
        Me.ladderSend.Size = New System.Drawing.Size(40, 21)
        Me.ladderSend.TabIndex = 1
        '
        'ladderPos
        '
        Me.ladderPos.BackColor = System.Drawing.Color.LightGray
        Me.ladderPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ladderPos.DropDownWidth = 40
        Me.ladderPos.FormattingEnabled = True
        Me.ladderPos.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.ladderPos.Location = New System.Drawing.Point(191, 64)
        Me.ladderPos.Name = "ladderPos"
        Me.ladderPos.Size = New System.Drawing.Size(40, 21)
        Me.ladderPos.TabIndex = 2
        '
        'snakeSend
        '
        Me.snakeSend.BackColor = System.Drawing.Color.LightGray
        Me.snakeSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.snakeSend.DropDownWidth = 40
        Me.snakeSend.FormattingEnabled = True
        Me.snakeSend.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.snakeSend.Location = New System.Drawing.Point(191, 37)
        Me.snakeSend.Name = "snakeSend"
        Me.snakeSend.Size = New System.Drawing.Size(40, 21)
        Me.snakeSend.TabIndex = 3
        '
        'inputSnake
        '
        Me.inputSnake.AutoSize = True
        Me.inputSnake.BackColor = System.Drawing.Color.Transparent
        Me.inputSnake.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputSnake.ForeColor = System.Drawing.Color.Transparent
        Me.inputSnake.Location = New System.Drawing.Point(11, 11)
        Me.inputSnake.Name = "inputSnake"
        Me.inputSnake.Size = New System.Drawing.Size(169, 18)
        Me.inputSnake.TabIndex = 4
        Me.inputSnake.Text = "Input snake position [1]:"
        '
        'inputLadder
        '
        Me.inputLadder.AutoSize = True
        Me.inputLadder.BackColor = System.Drawing.Color.Transparent
        Me.inputLadder.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLadder.ForeColor = System.Drawing.Color.Transparent
        Me.inputLadder.Location = New System.Drawing.Point(10, 65)
        Me.inputLadder.Name = "inputLadder"
        Me.inputLadder.Size = New System.Drawing.Size(170, 18)
        Me.inputLadder.TabIndex = 5
        Me.inputLadder.Text = "Input ladder position [1]:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Send player backwards:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Send player forward:"
        '
        'inputVal
        '
        Me.inputVal.BackColor = System.Drawing.Color.MidnightBlue
        Me.inputVal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inputVal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.inputVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inputVal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputVal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.inputVal.Location = New System.Drawing.Point(65, 129)
        Me.inputVal.Margin = New System.Windows.Forms.Padding(5)
        Me.inputVal.Name = "inputVal"
        Me.inputVal.Size = New System.Drawing.Size(115, 48)
        Me.inputVal.TabIndex = 4
        Me.inputVal.Text = "Submit Value"
        Me.inputVal.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(243, 191)
        Me.Controls.Add(Me.inputVal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputLadder)
        Me.Controls.Add(Me.inputSnake)
        Me.Controls.Add(Me.snakeSend)
        Me.Controls.Add(Me.ladderPos)
        Me.Controls.Add(Me.ladderSend)
        Me.Controls.Add(Me.snakePos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Snakes/Ladders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents snakePos As ComboBox
    Friend WithEvents ladderSend As ComboBox
    Friend WithEvents ladderPos As ComboBox
    Friend WithEvents snakeSend As ComboBox
    Friend WithEvents inputSnake As Label
    Friend WithEvents inputLadder As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents inputVal As Button
End Class
