Public Class Form1

    'Declare global variables'
    Dim g As Game
    Dim counter As Integer = 1
    Dim snakeFinalPos, ladderFinalPos As Integer

    'Create empty 100 integer array'
    Public snakeLadder() As Integer = New Integer(100) {}

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    'Follows the event of an input value being entered'
    Private Sub InputVal_Cick(ByVal sender As Object, ByVal e As EventArgs) Handles inputVal.Click

        'Check the input is not empty'
        If ValidInput() = True Then

            'Check if the max number of snake/ladders has been reached and make sure they dont go off the board'
            If counter < 10 And CheckPosition() = 0 Then

                SubmitSnakeLadder()
                counter = counter + 1
                inputSnake.Text = "Input snake position [" + counter.ToString + "]:"
                inputLadder.Text = "Input ladder position [" + counter.ToString + "]:"

            ElseIf counter > 9 Then

                'Start game once all snakes/ladders entered'
                g = New Game
                g.ShowDialog()
                Me.Close()

            End If
        End If

    End Sub

    Public Sub SubmitSnakeLadder()

        'set the ladders an snakes in the array'
        snakeLadder(Integer.Parse(snakePos.Text)) = -Integer.Parse(snakeSend.Text)
        snakeLadder(Integer.Parse(ladderPos.Text)) = Integer.Parse(ladderSend.Text)

    End Sub

    'Check combo boxes are not left empty'
    Public Function ValidInput() As Boolean

        If inputLadder.Text = "" Or inputSnake.Text = "" Or snakeSend.Text = "" Or ladderSend.Text = "" Then
            MessageBox.Show("Input cannot be empty please select a value")
            Return False
        Else
            Return True
        End If

    End Function

    'Function checks the position of the snake/ladder does not leave the board'
    Public Function CheckPosition() As Integer
        snakeFinalPos = Integer.Parse(snakePos.Text) - Integer.Parse(snakeSend.Text)
        ladderFinalPos = Integer.Parse(ladderPos.Text) + Integer.Parse(ladderSend.Text)

        'output what item leaves the board, if none return 0'
        If (snakeFinalPos < 1) Then

            MessageBox.Show("Snake cannot take player off the board. Try Again.")
            Return -1

        End If

        If (ladderFinalPos > 99) Then

            MessageBox.Show("Ladder cannot take player off the board. Try Again.")
            Return -1

        End If

        Return 0

    End Function

End Class
