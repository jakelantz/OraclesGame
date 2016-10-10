Public Class frmChooseAvatar


    'Private Sub picKingSwords_Click(sender As Object, e As EventArgs) Handles picKingSwords.Click
    '    Main.btn1P.Visible = False
    '    Main.btn2P.Visible = False
    '    'If Main.bolNumPlayers = True Then
    '    If Main.strP1Avatar = "" Then
    '            Main.picP1N1.Image = My.Resources.kis
    '            CardTracker.intDeckSize = CardTracker.intDeckSize - 1
    '            CardTracker.intKiS = 1
    '            picKingSwords.Visible = False

    '            CardTracker.bolSwords = True
    '            CardTracker.bolP1Swords = True
    '            Main.strP1Avatar = "Picked"
    '        lblAvaterMsg.Text = "Player 2, Choose your Oracle!"

    '    Else

    '            Main.picP2N1.Image = My.Resources.kis
    '            CardTracker.intDeckSize = CardTracker.intDeckSize - 1
    '        CardTracker.intKiS = 1
    '        Main.Show()
    '        CardTracker.bolSwords = True
    '        CardTracker.bolP2Swords = True
    '        Me.Close()
    '            Call CardTracker.P1DrawHand()
    '            Call CardTracker.P2DrawHand()
    '        '   Call CardTracker.DealWheel()
    '        CardTracker.bolSwords = True
    '            CardTracker.bolP2Swords = True
    '            Main.btnBeginTurn.Visible = True


    '    End If
    '    'Else

    '    'CardTracker.intKiS = 1
    '    'Main.picP1N1.Image = My.Resources.kis
    '    ' CardTracker.intDeckSize = CardTracker.intDeckSize - 2
    '    '  Me.Close()
    '    '   Call CardTracker.P1DrawHand()
    '    '   Call CardTracker.P2DrawHand()
    '    '   Call CardTracker.DealWheel()
    '    '   CardTracker.bolSwords = True
    '    '    CardTracker.bolP1Swords = True

    '    '   Main.btnBeginTurn.Visible = True

    '    '   Main.picP2N1.Image = My.Resources.kic
    '    '  CardTracker.bolCups = True
    '    '   CardTracker.bolP2Cups = True
    '    '     CardTracker.intKiC = 1





    '    '   End If



    'End Sub



    'Private Sub picKingCups_Click(sender As Object, e As EventArgs) Handles picKingCups.Click
    '    Main.btn1P.Visible = False
    '    Main.btn2P.Visible = False
    '    ' If Main.bolNumPlayers = True Then
    '    If Main.strP1Avatar = "" Then
    '            picKingCups.Visible = False

    '            CardTracker.intKiC = 1
    '            Main.picP1N1.Image = My.Resources.kic
    '            CardTracker.intDeckSize = CardTracker.intDeckSize - 1
    '            CardTracker.bolCups = True
    '            CardTracker.bolP1Cups = True

    '        lblAvaterMsg.Text = "Player 2, Choose your Oracle!"
    '        Main.strP1Avatar = "Picked"
    '        Else

    '            Main.picP2N1.Image = My.Resources.kic
    '            CardTracker.intDeckSize = CardTracker.intDeckSize - 1
    '        CardTracker.intKiC = 1
    '        Main.Show()
    '        CardTracker.bolCups = True
    '        CardTracker.bolP2Cups = True
    '        Me.Close()
    '            Call CardTracker.P1DrawHand()
    '            Call CardTracker.P2DrawHand()

    '        Main.btnBeginTurn.Visible = True
    '        ' Call CardTracker.DealWheel()


    '    End If
    '    '  Else

    '    '   Main.picP1N1.Image = My.Resources.kic
    '    '      CardTracker.intDeckSize = CardTracker.intDeckSize - 2
    '    ' CardTracker.intKiC = 1
    '    '   Me.Close()
    '    '    Call CardTracker.P1DrawHand()
    '    '       Call CardTracker.P2DrawHand()
    '    '      Call CardTracker.DealWheel()
    '    '       CardTracker.bolCups = True
    '    '       CardTracker.bolP1Cups = True

    '    '       Main.picP2N1.Image = My.Resources.kis
    '    '     CardTracker.bolSwords = True
    '    '     CardTracker.bolP2Swords = True
    '    '      CardTracker.intKiS = 1


    '    '      Main.btnBeginTurn.Visible = True

    '    '  End If

    'End Sub



    'Private Sub picKingWands_Click(sender As Object, e As EventArgs) Handles picKingWands.Click
    '    Main.btn1P.Visible = False
    '    Main.btn2P.Visible = False
    '    '    If Main.bolNumPlayers = True Then
    '    If Main.strP1Avatar = "" Then

    '            CardTracker.intKiW = 1
    '            Main.picP1N1.Image = My.Resources.kiw
    '            CardTracker.intDeckSize = CardTracker.intDeckSize - 1
    '            picKingWands.Visible = False
    '            CardTracker.bolWands = True
    '            CardTracker.bolP1Wands = True


    '        lblAvaterMsg.Text = "Player 2, Choose your Oracle!"
    '        Main.strP1Avatar = "Picked"
    '        Else
    '            CardTracker.intKiW = 1

    '            Main.picP2N1.Image = My.Resources.kiw
    '        CardTracker.intDeckSize = CardTracker.intDeckSize - 1
    '        Main.Show()
    '        CardTracker.bolWands = True
    '        CardTracker.bolP2Wands = True
    '        Me.Close()
    '            Call CardTracker.P1DrawHand()
    '            Call CardTracker.P2DrawHand()
    '        '   Call CardTracker.DealWheel()

    '        Main.btnBeginTurn.Visible = True

    '    End If
    '    '    Else
    '    '    CardTracker.intKiW = 1
    '    '   Main.picP1N1.Image = My.Resources.kiw
    '    '   CardTracker.intDeckSize = CardTracker.intDeckSize - 2
    '    '    Me.Close()
    '    '    Call CardTracker.P1DrawHand()
    '    '     Call CardTracker.P2DrawHand()
    '    '   Call CardTracker.DealWheel()
    '    '     CardTracker.bolWands = True
    '    '     CardTracker.bolP1Wands = True
    '    '    Main.btnBeginTurn.Visible = True
    '    '    Main.picP2N1.Image = My.Resources.kis
    '    '    CardTracker.bolSwords = True
    '    '    CardTracker.bolP2Swords = True
    '    '     CardTracker.intKiS = 1

    '    '      End If

    'End Sub



    'Private Sub picKingPentacles_Click(sender As Object, e As EventArgs) Handles picKingPentacles.Click
    '    Main.btn1P.Visible = False
    '    Main.btn2P.Visible = False
    '    '   If Main.bolNumPlayers = True Then
    '    If Main.strP1Avatar = "" Then
    '            CardTracker.intKiP = 1
    '            Main.picP1N1.Image = My.Resources.kip
    '            CardTracker.intDeckSize = CardTracker.intDeckSize - 1

    '            picKingPentacles.Visible = False
    '            CardTracker.bolPentacles = True
    '            CardTracker.bolP1Pentacles = True

    '        lblAvaterMsg.Text = "Player 2, Choose your Oracle!"
    '        Main.strP1Avatar = "Picked"
    '        Else
    '            CardTracker.intKiP = 1

    '            Main.picP2N1.Image = My.Resources.kip
    '        CardTracker.intDeckSize = CardTracker.intDeckSize - 1

    '        Main.Show()
    '        CardTracker.bolPentacles = True
    '        CardTracker.bolP2Pentacles = True
    '        Me.Close()
    '            Call CardTracker.P1DrawHand()
    '            Call CardTracker.P2DrawHand()
    '        '    Call CardTracker.DealWheel()

    '        Main.btnBeginTurn.Visible = True

    '    End If
    '    '   Else
    '    '  CardTracker.intKiP = 1
    '    '    Main.picP1N1.Image = My.Resources.kip
    '    '     CardTracker.intDeckSize = CardTracker.intDeckSize - 2

    '    '      Me.Close()
    '    '       Call CardTracker.P1DrawHand()
    '    '        Call CardTracker.P2DrawHand()
    '    '      Call CardTracker.DealWheel()
    '    '       CardTracker.bolPentacles = True
    '    '      CardTracker.bolP1Pentacles = True
    '    '       Main.btnBeginTurn.Visible = True
    '    '          Main.picP2N1.Image = My.Resources.kis
    '    '     CardTracker.bolSwords = True
    '    '     CardTracker.bolP2Swords = True
    '    '     CardTracker.intKiS = 1

    '    '  End If

    'End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    'End Sub
End Class