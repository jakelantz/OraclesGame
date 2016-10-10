Module CardTracker

    Private intCardToPic As Integer

    Private intCardSlot As Integer

    Public intDeck(76)
    Public intDiscard(76)


    Public intDiscardSize As Integer
    Public intDeckSize As Integer



    Public strCard As String
    Public intP1HandSize As Integer
    Public intP2HandSize As Integer
    Public intP1MaxHandSize As Integer = 5
    Public intP2MaxHandSize As Integer = 5

    Public intP1C1 As Integer
    Public intP1C2 As Integer
    Public intP1C3 As Integer
    Public intP1C4 As Integer
    Public intP1C5 As Integer
    Public intP1C6 As Integer
    Public intP1C7 As Integer
    Public intP1C8 As Integer
    Public intP1C9 As Integer
    Public intP1C10 As Integer


    Public intP2C1 As Integer
    Public intP2C2 As Integer
    Public intP2C3 As Integer
    Public intP2C4 As Integer
    Public intP2C5 As Integer
    Public intP2C6 As Integer
    Public intP2C7 As Integer
    Public intP2C8 As Integer
    Public intP2C9 As Integer
    Public intP2C10 As Integer


    Public bolP1DFDown As Boolean
    Public bolP1NFDown As Boolean
    Public bolP1PrDown As Boolean
    Public bolP1RPDown As Boolean
    Public bolP1DPDown As Boolean
    Public bolP2DFDown As Boolean
    Public bolP2NFDown As Boolean
    Public bolP2PrDown As Boolean
    Public bolP2RPDown As Boolean
    Public bolP2DPDown As Boolean

    Public intP1DF As Integer
    Public intP1NF As Integer
    Public intP1Pr As Integer
    Public intP1RP As Integer
    Public intP1DP As Integer
    Public intP1F1 As Integer
    Public intP1F2 As Integer
    Public intP1F3 As Integer
    Public intP1F4 As Integer
    Public intP1O1 As Integer
    Public intP1O2 As Integer
    Public intP1O3 As Integer
    Public intP1O4 As Integer

    Public intP2DF As Integer
    Public intP2NF As Integer
    Public intP2Pr As Integer
    Public intP2RP As Integer
    Public intP2DP As Integer
    Public intP2F1 As Integer
    Public intP2F2 As Integer
    Public intP2F3 As Integer
    Public intP2F4 As Integer
    Public intP2O1 As Integer
    Public intP2O2 As Integer
    Public intP2O3 As Integer
    Public intP2O4 As Integer

    Public intp1N2 As Integer
    Public intp1N3 As Integer
    Public intp1N4 As Integer
    Public intp1H2 As Integer
    Public intp1H3 As Integer
    Public intp1H1 As Integer
    Public intp2N2 As Integer
    Public intp2N3 As Integer
    Public intp2N4 As Integer
    Public intp2H2 As Integer
    Public intp2H3 As Integer
    Public intp2H1 As Integer



    Private intUnknownNumber As Integer = 76



    Public Sub NewDeck()
        For i = 1 To 76
            intDiscard(i) = i
            intDiscardSize = intDiscardSize + 1
        Next

        Call Shuffle()
    End Sub

    Public Sub Shuffle()
        Randomize()

        For i = 1 To intDiscardSize
            intCardSlot = CInt(Int((intDiscardSize * Rnd()) + 1))
            intDeck(i) = intDiscard(intCardSlot)
            intDiscardSize = intDiscardSize - 1
            intDeckSize = intDeckSize + 1
            For j = intCardSlot To (intDiscardSize)
                intDiscard(j) = intDiscard(j + 1)

            Next
        Next

    End Sub

    Public Sub DrawCard(i As Integer)

        If i = 1 Then
            strCard = "_1c"

        ElseIf i = 2 Then
            strCard = "_2c"
        ElseIf i = 3 Then
            strCard = "_3c"
        ElseIf i = 4 Then
            strCard = "_4c"
        ElseIf i = 5 Then
            strCard = "_5c"
        ElseIf i = 6 Then
            strCard = "_6c"
        ElseIf i = 7 Then
            strCard = "_7c"
        ElseIf i = 8 Then
            strCard = "_8c"
        ElseIf i = 9 Then
            strCard = "_9c"
        ElseIf i = 10 Then
            strCard = "_10c"
        ElseIf i = 11 Then
            strCard = "_1p"
        ElseIf i = 12 Then
            strCard = "_2p"
        ElseIf i = 13 Then
            strCard = "_3p"
        ElseIf i = 14 Then
            strCard = "_4p"
        ElseIf i = 15 Then
            strCard = "_5p"
        ElseIf i = 16 Then
            strCard = "_6p"
        ElseIf i = 17 Then
            strCard = "_7p"
        ElseIf i = 18 Then
            strCard = "_8p"
        ElseIf i = 19 Then
            strCard = "_9p"
        ElseIf i = 20 Then
            strCard = "_10p"
        ElseIf i = 21 Then
            strCard = "_1s"
        ElseIf i = 22 Then
            strCard = "_2s"
        ElseIf i = 23 Then
            strCard = "_3s"
        ElseIf i = 24 Then
            strCard = "_4s"
        ElseIf i = 25 Then
            strCard = "_5s"
        ElseIf i = 26 Then
            strCard = "_6s"
        ElseIf i = 27 Then
            strCard = "_7s"
        ElseIf i = 28 Then
            strCard = "_8s"
        ElseIf i = 29 Then
            strCard = "_9s"
        ElseIf i = 30 Then
            strCard = "_10s"
        ElseIf i = 31 Then
            strCard = "_1w"
        ElseIf i = 32 Then
            strCard = "_2w"
        ElseIf i = 33 Then
            strCard = "_3w"
        ElseIf i = 34 Then
            strCard = "_4w"
        ElseIf i = 35 Then
            strCard = "_5w"
        ElseIf i = 36 Then
            strCard = "_6w"
        ElseIf i = 37 Then
            strCard = "_7w"
        ElseIf i = 38 Then
            strCard = "_8w"
        ElseIf i = 39 Then
            strCard = "_9w"
        ElseIf i = 40 Then
            strCard = "_10w"
        ElseIf i = 41 Then
            strCard = "pc"
        ElseIf i = 42 Then
            strCard = "kc"
        ElseIf i = 43 Then
            strCard = "qc"
        ElseIf i = 44 Then
            strCard = "kic"
        ElseIf i = 45 Then
            strCard = "pp"
        ElseIf i = 46 Then
            strCard = "kp"
        ElseIf i = 47 Then
            strCard = "qp"
        ElseIf i = 48 Then
            strCard = "kip"
        ElseIf i = 49 Then
            strCard = "ps"
        ElseIf i = 50 Then
            strCard = "ks"
        ElseIf i = 51 Then
            strCard = "qs"
        ElseIf i = 52 Then
            strCard = "pw"
        ElseIf i = 53 Then
            strCard = "kw"
        ElseIf i = 54 Then
            strCard = "qw"
        ElseIf i = 55 Then
            strCard = "_0"
        ElseIf i = 56 Then
            strCard = "i"
        ElseIf i = 57 Then
            strCard = "ii"
        ElseIf i = 58 Then
            strCard = "iii"
        ElseIf i = 59 Then
            strCard = "iv"
        ElseIf i = 60 Then
            strCard = "v"
        ElseIf i = 61 Then
            strCard = "vi"
        ElseIf i = 62 Then
            strCard = "vii"
        ElseIf i = 63 Then
            strCard = "viii"
        ElseIf i = 64 Then
            strCard = "ix"
        ElseIf i = 65 Then
            strCard = "x"
        ElseIf i = 66 Then
            strCard = "xi"
        ElseIf i = 67 Then
            strCard = "xii"
        ElseIf i = 68 Then
            strCard = "xiii"
        ElseIf i = 69 Then
            strCard = "xiv"
        ElseIf i = 70 Then
            strCard = "xv"
        ElseIf i = 71 Then
            strCard = "xvi"
        ElseIf i = 72 Then
            strCard = "xvii"
        ElseIf i = 73 Then
            strCard = "xviii"
        ElseIf i = 74 Then
            strCard = "xix"
        ElseIf i = 75 Then
            strCard = "xx"
        ElseIf i = 76 Then
            strCard = "xxi"

        End If


    End Sub






    Public Sub P1DrawHand()
        ' draw a whole hand of cards
        Do Until intP1HandSize = intP1MaxHandSize
            Call P1DrawCard()
        Loop

    End Sub

    Public Sub P1GetCardImage()

        If Main.picP1C1.Image Is Nothing Then
            Main.picP1C1.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP1C1 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP1C2.Image Is Nothing Then
            Main.picP1C2.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP1C2 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP1C3.Image Is Nothing Then
            Main.picP1C3.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP1C3 = intDeck(intDeckSize)
        ElseIf Main.picP1C4.Image Is Nothing Then
            Main.picP1C4.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP1C4 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP1C5.Image Is Nothing Then
            Main.picP1C5.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP1C5 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP1C6.Image Is Nothing Then
            Main.picP1C6.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP1C6 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP1C7.Image Is Nothing Then
            Main.picP1C7.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP1C7 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP1C8.Image Is Nothing Then
            Main.picP1C8.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP1C8 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP1C9.Image Is Nothing Then
            Main.picP1C9.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP1C9 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP1C10.Image Is Nothing Then
            Main.picP1C10.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP1C10 = intDeck(intDeckSize)
            Exit Sub
        End If
    End Sub

    Public Sub P2DrawHand()
        ' draw a whole hand of cards
        Do Until intP2HandSize = intP2MaxHandSize
            Call P2DrawCard()
        Loop

    End Sub

    Public Sub P2GetCardImage()

        If Main.picP2C1.Image Is Nothing Then
            Main.picP2C1.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP2C1 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP2C2.Image Is Nothing Then
            Main.picP2C2.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP2C2 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP2C3.Image Is Nothing Then
            Main.picP2C3.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP2C3 = intDeck(intDeckSize)
        ElseIf Main.picP2C4.Image Is Nothing Then
            Main.picP2C4.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP2C4 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP2C5.Image Is Nothing Then
            Main.picP2C5.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP2C5 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP2C6.Image Is Nothing Then
            Main.picP2C6.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP2C6 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP2C7.Image Is Nothing Then
            Main.picP2C7.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP2C7 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP2C8.Image Is Nothing Then
            Main.picP2C8.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP2C8 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP2C9.Image Is Nothing Then
            Main.picP2C9.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP2C9 = intDeck(intDeckSize)
            Exit Sub
        ElseIf Main.picP2C10.Image Is Nothing Then
            Main.picP2C10.Image = My.Resources.ResourceManager.GetObject(strCard)
            intP2C10 = intDeck(intDeckSize)
            Exit Sub
        End If
    End Sub
    Public Sub P1DrawCard()
        If intDeckSize = 0 Then
            Call Shuffle()
        End If
        ' Call P1DrawCard()
        intCardToPic = (intDeck(intDeckSize))
        Call DrawCard(intCardToPic)
        Call P1GetCardImage()
        intP1HandSize = intP1HandSize + 1

        intDeckSize = intDeckSize - 1


    End Sub

    Public Sub P2DrawCard()
        If intDeckSize = 0 Then
            Call Shuffle()
        End If
        ' Call P2DrawCard()
        intCardToPic = (intDeck(intDeckSize))
        Call DrawCard(intCardToPic)
        Call P2GetCardImage()
        intP2HandSize = intP2HandSize + 1

        intDeckSize = intDeckSize - 1

    End Sub
    Public Sub Discard(intCard As Integer)

        For i = 1 To 76
            If intDiscard(i) <> 0 Then
                intDiscard(i) = intCard
                Exit Sub
            End If
        Next



    End Sub

    Public Sub p1ReplaceFate(CardToReplace As Integer)
        Select Case CardToReplace
            Case 0
                Main.lblDirection.Text = "Player 1, choose a card in your Fate Pile to replace."
                Brain.bolReplaceFate = True
                Main.btnAction1.Text = "Cancel"
                Exit Sub
            Case 1
                Call CardTracker.Discard(intP1O1)
                intP1O1 = intP1DP
            Case 2
                Call CardTracker.Discard(intP1O2)
                intP1O2 = intP1DP
            Case 3
                Call CardTracker.Discard(intP1O3)
                intP1O3 = intP1DP
            Case 4
                Call CardTracker.Discard(intP1O4)
                intP1O4 = intP1DP

        End Select


    End Sub

    Public Sub P1PlayACard(intLoc As Integer, intCard As Integer)

        Main.btnAction1.Show()







        Select Case intCard
            Case 1 - 40

            Case 41 - 48

            Case 49 - 54

            Case 55 - 76


        End Select

        Select Case intLoc
            Case 1
                Main.picP1DF.Image = Main.picP1C1.Image
                Main.picP1C1.Image = Nothing
                CardTracker.intP1DF = CardTracker.intP1C1

            Case 2
                Main.picP1DF.Image = Main.picP1C2.Image
                Main.picP1C2.Image = Nothing
                CardTracker.intP1DF = CardTracker.intP1C2
            Case 3
                Main.picP1DF.Image = Main.picP1C3.Image
                Main.picP1C3.Image = Nothing
                CardTracker.intP1DF = CardTracker.intP1C3
            Case 4
                Main.picP1DF.Image = Main.picP1C4.Image
                Main.picP1C4.Image = Nothing
                CardTracker.intP1DF = CardTracker.intP1C4
            Case 5
                Main.picP1DF.Image = Main.picP1C5.Image
                Main.picP1C5.Image = Nothing
                CardTracker.intP1DF = CardTracker.intP1C5
            Case 6
                Main.picP1DF.Image = Main.picP1C6.Image
                Main.picP1C6.Image = Nothing
                CardTracker.intP1DF = CardTracker.intP1C6
            Case 7
                Main.picP1DF.Image = Main.picP1C7.Image
                Main.picP1C7.Image = Nothing
                CardTracker.intP1DF = CardTracker.intP1C7
            Case 8
                Main.picP1DF.Image = Main.picP1C8.Image
                Main.picP1C8.Image = Nothing
                CardTracker.intP1DF = CardTracker.intP1C8
            Case 9
                Main.picP1DF.Image = Main.picP1C9.Image
                Main.picP1C9.Image = Nothing
                CardTracker.intP1DF = CardTracker.intP1C9
            Case 10
                Main.picP1DF.Image = Main.picP1C10.Image
                Main.picP1C10.Image = Nothing
                CardTracker.intP1DF = CardTracker.intP1C10
        End Select

    End Sub

End Module



