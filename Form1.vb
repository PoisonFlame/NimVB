Public Class Form1
    Dim totalStones As Integer = 21
    Dim gameOver As Boolean
    Dim PlayerTurn As Boolean
    Dim timeTook As Integer
    Dim pickedup As Integer
    Dim ComputersPick As Integer
    Dim subs As Integer = 0
    Dim mode As Integer         ' 1 = Easy  , 2 = Hard 3 = Medium
    Dim lastpick As Integer     ' 1 = Player, 2 = Computer
    Dim firstmove As Integer    ' 1 = Player, 2 = Computer

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then

            btnPickStones.PerformClick()
            e.Handled = True
            txtStones.Focus()
        End If

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KeyPreview = True
        picEndGame.Image = My.Resources.fireworksGIF
        picEndGame.BringToFront()
        btnPlay.BringToFront()
    End Sub
    Public Sub computerTurn()
        Randomize()

        'If PlayerTurn = False Then
        PlayerTurn = False
        lastpick = 2
        tmrShowUp.Start()
        'Dim ComputersPick As Integer ' = 2 * Rnd() + 1

        ' If totalStones = 1 Then
        'ComputersPick = 1
        'ElseIf totalStones = 2 Then
        'ComputersPick = 2
        'ElseIf totalStones = 3 Then
        'ComputersPick = 3
        'End If


        If mode = 2 And firstmove = 2 Then

            Select Case totalStones
                Case 21

                    '    totalStones -= 1
                    ComputersPick = 1
                Case 20

                    '     totalStones -= 2
                    ComputersPick = 2
                Case 19

                    '     totalStones -= 3
                    ComputersPick = 3
                Case 18

                    ' totalStones -= 2
                    ComputersPick = 2
                Case 17

                    ' totalStones -= 1
                    ComputersPick = 1
                Case 16

                    ' totalStones -= 2
                    ComputersPick = 2
                Case 15

                    'totalStones -= 3
                    ComputersPick = 3
                Case 14

                    ' totalStones -= 2
                    ComputersPick = 2
                Case 13

                    ' totalStones -= 1
                    ComputersPick = 1
                Case 12

                    ' totalStones -= 3
                    ComputersPick = 3
                Case 11

                    ' totalStones -= 3
                    ComputersPick = 3
                Case 10

                    ' totalStones -= 2
                    ComputersPick = 2
                Case 9

                    ' totalStones -= 1
                    ComputersPick = 1
                Case 8

                    ' totalStones -= 3
                    ComputersPick = 3
                Case 7

                    'totalStones -= 3
                    ComputersPick = 3
                Case 6

                    ' totalStones -= 2
                    ComputersPick = 2
                Case 5

                    '  totalStones -= 1
                    ComputersPick = 1
                Case 4

                    ' totalStones -= 1
                    ComputersPick = 1
                Case 3

                    '  totalStones -= 3
                    ComputersPick = 3
                Case 2

                    '  totalStones -= 2
                    ComputersPick = 2
                Case 1

                    ' totalStones -= 1
                    ComputersPick = 1
            End Select
        ElseIf mode = 2 And firstmove = 1 Then

            PlayerTurn = True
            firstmove = 2 ' Resetting back to 2 So computer can take turns.
        ElseIf mode = 1 Then

            ComputersPick = 2 * Rnd() + 1
            'totalStones -= ComputersPick
        ElseIf mode = 3 Then

            ' Play Medium.
            Randomize()

            Select Case totalStones
                Case 21
                    ComputersPick = 1 * Rnd() + 1
                    ' totalStones -= ComputersPick

                Case 20
                    ComputersPick = 2 * Rnd() + 1
                    ' totalStones -= ComputersPick

                Case 19
                    ComputersPick = 3
                    ' totalStones -= ComputersPick

                Case 18
                    ComputersPick = 1 * Rnd() + 1
                    'totalStones -= ComputersPick

                Case 17
                    ComputersPick = 1
                    ' totalStones -= ComputersPick

                Case 16
                    ComputersPick = 2
                    '  totalStones -= ComputersPick

                Case 15
                    ComputersPick = 3
                    '  totalStones -= ComputersPick

                Case 14
                    ComputersPick = 2 * Rnd() + 1
                    '   totalStones -= ComputersPick

                Case 13
                    ComputersPick = 1
                    '   totalStones -= ComputersPick

                Case 12
                    ComputersPick = 2 * Rnd() + 1
                    '  totalStones -= ComputersPick

                Case 11
                    ComputersPick = 2 * Rnd() + 1
                    '   totalStones -= ComputersPick

                Case 10
                    ComputersPick = 2
                    '   totalStones -= ComputersPick

                Case 9
                    ComputersPick = 1
                    '   totalStones -= ComputersPick

                Case 8
                    ComputersPick = 3
                    '   totalStones -= ComputersPick

                Case 7
                    ComputersPick = 2 * Rnd() + 1
                    '    totalStones -= ComputersPick

                Case 6
                    ComputersPick = 2
                    '  totalStones -= ComputersPick

                Case 5
                    ComputersPick = 1
                    '  totalStones -= ComputersPick

                Case 4
                    ComputersPick = 1
                    '   totalStones -= ComputersPick

                Case 3
                    ComputersPick = 3
                    ' totalStones -= ComputersPick

                Case 2
                    ComputersPick = 1 * Rnd() + 1
                    '   totalStones -= ComputersPick

                Case 1
                    ComputersPick = 1
                    '  totalStones -= ComputersPick

            End Select

        End If

        If lblCompPick.Text = Nothing Then

            lblCompPick.Text = lblCompPick.Text & "" & ComputersPick
        Else

            lblCompPick.Text = lblCompPick.Text & "," & ComputersPick

        End If

        'lblCompPick.Text = lblCompPick.Text & " " & ComputersPick




        lblComp.Visible = True
        'End If  
        If ComputersPick > 1 Then

            lblComp.Text = "Computer takes " & ComputersPick & " stones"

        Else

            lblComp.Text = "Computer takes " & ComputersPick & " stone"

        End If



    End Sub
    Public Sub minigame()

        Dim PlayerGuess As String = InputBox("Please Enter a Number Between 1-10." & vbCrLf &
                                                 "Computer will randomly pick after you." & vbCrLf &
                                                 "Whoever is closer or equal to the Secret Number will get to go first." & vbCrLf &
                                                 "If There is the same difference between numbers, then Computer will go first." & vbCrLf &
                                                 "Note: This only applies to Hard Mode.", "Enter a number from 1-10")
        'Do While IsNumeric(PlayerGuess) = False
        Randomize()
        Dim secretnum As Integer = 9 * Rnd() + 1

        'PlayerGuess = InputBox("Please Enter a Number Between 1-10." & vbCrLf &
        '                                      "Computer will randomly pick after you." & vbCrLf &
        '                                      "Whoever is closer or equal to the Secret Number will get to go first." & vbCrLf &
        '                                      "Note: This only applies to Hard Mode.", "Enter a number from 1-10")







        'Loop


        If Not IsNumeric(PlayerGuess) Then

            MsgBox("Please Enter a Number between 1-10")


            minigame()
        ElseIf PlayerGuess > 10 Or PlayerGuess < 1 Then

            MsgBox("Please Enter a Number between 1-10")

            minigame()

        Else
            Randomize()
            Dim ComputerGuess As Integer = 9 * Rnd() + 1
            MsgBox("Computer Guess: " & ComputerGuess & vbCrLf & "Your Guess: " & PlayerGuess & vbCrLf & "Secret Number: " & secretnum)

            If ComputerGuess = PlayerGuess Then

                MsgBox("You both guessed the same thing, Please guess another number.")
                Exit Sub
                minigame()
                ' minigame()
            End If

            'Dim PlayerDis As Integer = secretnum - PlayerGuess
            'Dim ComputerDis As Integer = secretnum - ComputerGuess

            Dim PlayerDis As Integer = Math.Abs(PlayerGuess - secretnum) '(2) - (9)
            Dim ComputerDis As Integer = Math.Abs(ComputerGuess - secretnum) ' (5)  - (9)




            '   MsgBox("Comp: " & ComputerDis & "Player: " & PlayerDis)

            ' 1 = Player, 2 = Computer
            If PlayerDis < ComputerDis Then

                firstmove = 1
                MsgBox("Player Goes First")
                ' PlayerTurn = True
            Else

                firstmove = 2
                MsgBox("Computer Goes First")
                '  PlayerTurn = False
                computerTurn()
            End If

        End If



    End Sub
    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Randomize()
        Dim aRandomNumber As Integer = 2 * Rnd() + 1
        Dim Inputmode As String

        If gameOver = True Then

            Application.Restart()
            Exit Sub
        End If

        If aRandomNumber = 1 Then

            Inputmode = "easy"

        ElseIf aRandomNumber = 2 Then

            Inputmode = "medium"

        ElseIf aRandomNumber = 3 Then

            Inputmode = "hard"

        End If

        Dim qq As String = InputBox("Enter Easy, Medium, or Hard to play each mode. If you enter something else, the game wont start. A random mode will be typed to start you off. Typing Exit will Quit the game.", "Choose Mode", Inputmode).ToLower



        If qq = "exit" Then

            Me.Close()

        End If


        If qq = "easy" Or qq = "hard" Or qq = "medium" Then

            If qq = "easy" Then

                mode = 1

            ElseIf qq = "hard" Then

                mode = 2
                minigame()
            ElseIf qq = "medium" Then

                mode = 3
            End If

            btnPlay.Visible = False
            totalStones = 21
            txtStones.Text = Nothing
            btnPickStones.Visible = True
            lblCompPick.Text = Nothing
            lblYourPick.Text = Nothing
            lblStones.Visible = True
            txtStones.Visible = True
            picEndGame.Visible = False
            captYou.Visible = True
            timeTook = 0
            tmrTime.Start()
            captComp.Visible = True
            tmrUpdate.Start()
            gameOver = False
            lblMode.Visible = True
            lblGameover.Visible = False
            lblTitle.Visible = False
            lblInstructions.Visible = False
            captHTP.Visible = False
            txtStones.Focus()
            tmrShowUp.Stop()
            computerTurn()
        Else

            Dim a As Integer = MsgBox("Failed to Start, do you want to Retry?", MsgBoxStyle.RetryCancel, "Error")

            If a = vbRetry Then
                btnPlay.PerformClick()
                ' qq = InputBox("Enter Easy, Medium, or Hard to play each mode. If you enter something else, the game wont start. A random mode will be typed to start you off. Typing Exit will Quit the game.", "Choose Mode", Inputmode).ToLower
            ElseIf a = vbCancel Then

                MsgBox("Try again later.")

            End If


        End If

    End Sub

    Public Sub btnPickStones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickStones.Click
        txtStones.Enabled = False   '  If PlayerTurn = True Then
        '  Dim pickedup As Integer = Val(InputBox("Pickup a minimum of 1 stone and a maximum of 3 stones.", "Enter A Value"))
        PlayerTurn = True
        lastpick = 1
        'Do While totalStones <> 0 And totalStones >= 0

        pickedup = Val(txtStones.Text)
        'Val(InputBox("Pickup a minimum of 1 stone and a maximum of 3 stones.", "Enter A Value"))

        If pickedup < 1 Or pickedup > 3 Then

            MsgBox("Pick A Number More Than 1 And Less Than 3. Only Choices: 1,2,3")
            txtStones.Text = Nothing
            txtStones.Enabled = True
        Else

            totalStones -= pickedup
            If totalStones <= 0 Then

                gameOver = True
            Else

                computerTurn()

            End If

            lblStones.Text = totalStones
            If lblYourPick.Text = Nothing Then

                lblYourPick.Text = lblYourPick.Text & "" & pickedup
            Else

                lblYourPick.Text = lblYourPick.Text & "," & pickedup

            End If
            'lblYourPick.Text = lblYourPick.Text & "," & pickedup
            lblYou.Visible = True
            If pickedup > 1 Then

                lblYou.Text = "You take " & pickedup & " stones"

            Else

                lblYou.Text = "You take " & pickedup & " stone"

            End If

            txtStones.Text = Nothing
        End If



        ' Loop




        'End If
    End Sub

    Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
        lblStones.Text = totalStones

        If totalStones <= 0 Then

            gameOver = True

        End If


        If gameOver = True And lastpick = 1 Then    'PlayerTurn = False Then

            lblStones.Text = 0

            btnPickStones.Visible = False
            btnPlay.Visible = True
            txtStones.Visible = False
            tmrUpdate.Enabled = False
            lblComp.Visible = False
            lblYou.Visible = False

            MsgBox("You Win.")
            lblGameover.Text = "You WON!!!" & vbCrLf & "It Only Took You " & timeTook & " Seconds!"
            tmrTime.Stop()
            lblGameover.BackColor = Color.Transparent
            lblGameover.Image = My.Resources.fireworksGIF
            lblGameover.BringToFront()
            btnPlay.BringToFront()
            lblGameover.Visible = True
            tmrShowUp.Stop()
            picEndGame.Visible = True
            firstmove = 0
            mode = 0
        ElseIf gameOver = True And lastpick = 2 Then 'PlayerTurn = True Then

            lblStones.Text = 0
            btnPickStones.Visible = False
            btnPlay.Visible = True
            txtStones.Visible = False
            tmrUpdate.Enabled = False
            lblComp.Visible = False
            lblYou.Visible = False
            tmrShowUp.Stop()

            MsgBox("Gameover. Computer Won.")
            lblGameover.Text = " " '"GAME OVER"
            tmrTime.Stop()
            lblGameover.Image = My.Resources.gameover
            lblGameover.SendToBack()
            picEndGame.Image = My.Resources.gameover
            picEndGame.SizeMode = PictureBoxSizeMode.StretchImage
            picEndGame.Visible = True
            lblGameover.Visible = True
            firstmove = 0
            mode = 0
        End If


        If txtStones.Text = Nothing Then
            btnPickStones.Enabled = False
        Else
            btnPickStones.Enabled = True
        End If


        If mode = 1 Then
            lblMode.Text = "Mode: Easy"
        ElseIf mode = 2 Then
            lblMode.Text = "Mode: Hard"
        ElseIf mode = 3 Then
            lblMode.Text = "Mode: Medium"
        End If



    End Sub

    Private Sub txtStones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStones.KeyPress
        If e.KeyChar = Chr(13) Then e.Handled = True
    End Sub

    Private Sub txtStones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStones.TextChanged
        If Not IsNumeric(txtStones.Text) Then

            txtStones.Text = Nothing

            If Val(txtStones.Text) < 3 And Val(txtStones.Text) < 1 And Not txtStones.Text = Nothing Then

                '  txtStones.Text = Nothing
                MsgBox("NO!")
            End If

        End If
    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        timeTook += 1

      

    End Sub

    Private Sub tmrShowUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShowUp.Tick

        'Do While subs <> ComputersPick

        '    totalStones -= 1
        '    subs += 1

        '
        txtStones.Enabled = False

        If subs <> ComputersPick Then

            totalStones -= 1
            subs += 1

        End If

        'tmrShowUp.Stop()

        If subs = ComputersPick Then

            subs = 0

            tmrShowUp.Stop()
            txtStones.Enabled = True
            txtStones.Focus()
        End If

       

    End Sub
End Class
