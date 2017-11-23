Public Class Game

    'Declare global variables'
    Inherits Form
    Dim roll As Integer
    Dim playerPos As Integer = 1
    Dim snakeLad As Integer() = Form1.snakeLadder
    Dim rollCounter As Integer = 0


    Private Sub Game_Load(sender As Object, e As EventArgs)

    End Sub

    'When roll dice button is clicked'
    Private Sub rollDice_Click(sender As Object, e As EventArgs) Handles rollDice.Click

        'Number of rolls performed is one greater'
        rollCounter = rollCounter + 1
        PlayerRoll()


    End Sub

    'Check if the player is in the win position'
    Private Function CheckWin() As Integer

        If playerPos = 100 Then

            Return 1

        End If

        Return 0

    End Function

    Private Sub PlayerRoll()

        'Create new seed for random values'
        Randomize()
        roll = Int(6 * Rnd()) + 1 'multiply random value by 6, then round down and +1'
        rollsText.AppendText("[" + playerPos.ToString + "] You rolled a " + roll.ToString + vbLf)


        'Make sure roll doesnt put player off board'
        If playerPos + roll <= 100 Then

            playerPos = playerPos + roll

        End If

        'if they havent won see if there is a snake or ladder, otherwise they have won'
        If CheckWin() <> 1 Then

            CheckSnakeOrLadder()

        Else

            rollsText.AppendText("YOU WON IN " + rollCounter.ToString + " MOVES!")
            rollDice.Visible = False

        End If

        playerPosition.Text = "Player Position: " + playerPos.ToString

    End Sub

    'See if the players position is the snake as a snake or a ladder'
    Private Sub CheckSnakeOrLadder()

        'if it moves them forward its a ladder, backwards a snake'
        If snakeLad(playerPos) > 0 Then

            rollsText.AppendText("[" + playerPos.ToString + "] Ladder: move forward +" + snakeLad(playerPos).ToString + " spaces" & vbLf)

        ElseIf snakeLad(playerPos) < 0 Then

            rollsText.AppendText("[" + playerPos.ToString + "] Snake: move back " + snakeLad(playerPos).ToString + " spaces" & vbLf)

        End If

        'move player however the ladder/snake decides'
        playerPos = playerPos + snakeLad(playerPos)

    End Sub

End Class