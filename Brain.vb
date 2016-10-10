Module Brain
    Public bolTurn As Boolean
    Public bolReplaceFate As Boolean
    Public bolPlayACard As Boolean
    Public intCardClicked As Integer
    Public intSlotClicked As Integer



    Public Sub Router(i As Integer, intCardValue As Integer)

        'i = 1-10: P1 cards in hand 1-10
        'i = 11-20: P2 cards in hand 1-10
        'i = 21 P1DF
        'i = 22 P1NF
        'i = 23 P1Pr
        'i = 24 P1RP
        'i = 25 P1DP
        'i = 26 P2DF
        'i = 27 P2NF
        'i = 28 P2Pr
        'i = 29 P2RP
        'i = 30 P2DP
        'i = 31-34 P1O1-4
        'i = 35-38 P2O1-4
        'i = 39-42 P1F1-4
        'i = 43-46 P2F1-4
        'i = 47-49 P1N2-4
        'i = 50-52 P1N2-4
        'i = 53-55 P1H1-3
        'i = 56-58 P2H2 1 -3
        'i = 59-61 btnAction 1-3
        intSlotClicked = i
        intCardClicked = intCardValue
        If bolPlayACard = True Then
            Main.btnAction1.Show()
        Else
            Call Main.CardDiscription(intCardValue)

        End If
        Main.picHolder.Show()

        Select Case i
            Case 1
                'P1C1
                Main.picHolder.Image = Main.picP1C1.Image
                If bolPlayACard = True Then
                    Call Main.CardDiscription(intCardValue)
                End If
            Case 2
                'P1C2
                If bolPlayACard = True Then
                    Main.picHolder.Image = Main.picP1C2.Image
                    Call Main.CardDiscription(intCardValue)
                End If
            Case 3
                'P1C3
                If bolPlayACard = True Then
                    Main.picHolder.Image = Main.picP1C3.Image
                    Call Main.CardDiscription(intCardValue)
                End If
            Case 4
                'P1C4
                If bolPlayACard = True Then
                    Main.picHolder.Image = Main.picP1C4.Image
                    Call Main.CardDiscription(intCardValue)
                End If
            Case 5
                'P1C5
                If bolPlayACard = True Then
                    Main.picHolder.Image = Main.picP1C5.Image
                    Call Main.CardDiscription(intCardValue)
                End If
            Case 6
                'P1C6
                If bolPlayACard = True Then
                    Main.picHolder.Image = Main.picP1C6.Image
                    Call Main.CardDiscription(intCardValue)
                End If
            Case 7
                'P1C7
                If bolPlayACard = True Then
                    Main.picHolder.Image = Main.picP1C7.Image
                    Call Main.CardDiscription(intCardValue)
                End If
            Case 8
                'P1C8
                If bolPlayACard = True Then
                    Main.picHolder.Image = Main.picP1C8.Image
                    Call Main.CardDiscription(intCardValue)
                End If
            Case 9
                'P1C9
                If bolPlayACard = True Then
                    Main.picHolder.Image = Main.picP1C9.Image
                    Call Main.CardDiscription(intCardValue)
                End If
            Case 10
                'P1C10
                If bolPlayACard = True Then
                    Main.picHolder.Image = Main.picP1C10.Image
                    Call Main.CardDiscription(intCardValue)
                End If
            Case 11
                'P2C1
            Case 12
                'P2C2
            Case 13
                'P2C3
            Case 14
                'P2C4
            Case 15
                'P2C5
            Case 16
                'P2C6
            Case 17
                'P2C7
            Case 18
                'P2C8
            Case 19
                'P2C9
            Case 20
                'P2C10
            Case 21
                'P1DF
            Case 22
                'P1NF
            Case 23
                'P1Pr
            Case 24
                'P1RP
            Case 25
                'P1DP
            Case 26
                'P2DF
            Case 27
                'P2NF
            Case 28
                'P2Pr
            Case 29
                'P2RP
            Case 30
                'P2DP
            Case 31
                'P1O1
                If bolReplaceFate = True Then
                    If bolTurn = 0 Then
                        Call CardTracker.p1ReplaceFate(1)
                    End If
                End If
            Case 32
                'P1O2
                If bolReplaceFate = True Then
                    If bolTurn = 0 Then
                        Call CardTracker.p1ReplaceFate(2)
                    End If
                End If
            Case 33
                'P1O3
                If bolReplaceFate = True Then
                    If bolTurn = 0 Then
                        Call CardTracker.p1ReplaceFate(3)
                    End If
                End If
            Case 34
                'P1O4
                If bolReplaceFate = True Then
                    If bolTurn = 0 Then
                        Call CardTracker.p1ReplaceFate(4)
                    End If
                End If
            Case 35
                'P2O1
            Case 36
                'P2O2
            Case 37
                'P2O3
            Case 38
                'P2O4
            Case 39
                'P1F1
            Case 40
                'P1F2
            Case 41
                'P1F3
            Case 42
                'P1F4
            Case 43
                'P2F1
            Case 44
                'P2F2
            Case 45
                'P2F3
            Case 46
                'P2F4
            Case 47
                'P1N2
            Case 48
                'P1N3
            Case 49
                'P1N4
            Case 50
                'P2N2
            Case 51
                'P2N3
            Case 52
                'P2N4
            Case 53
                'P1H1
            Case 54
                'P1H2
            Case 55
                'P1H3
            Case 56
                'P1H1
            Case 57
                'P1H2
            Case 58
                'P1H3
            Case 59
                'btnAction1
                Call HandleAction1()


            Case 60
                'btnAction2
            Case 61
                'btnAction3
        End Select

    End Sub


    Private Sub HandleAction1()
        If Main.btnAction1.Text = "Begin Game" Then
            Call CardTracker.P1DrawHand()
            Call CardTracker.P2DrawHand()
            Call TurnHandler.P1BeginTurn()
            Exit Sub
        End If

        If bolPlayACard = True Then
            Select Case intCardClicked
                Case 1 - 40

                    Call P1PlayFortune()
                Case 49 - 54
                    Call P1PlayNoble()
                Case 55 - 76
                    Call P1PlayMajor()
            End Select

        End If





    End Sub


    Private Sub P1PlayFortune()

        Main.picP1DF.Image = Main.picHolder.Image
            CardTracker.intP1DF = intCardClicked
            Call ClearSlot(intSlotClicked)


    End Sub


    Private Sub P1PlayNoble()


    End Sub

    Private Sub P1PlayMajor()



    End Sub

    Public Sub ClearSlot(i As Integer)
        Select Case i
            Case 1
                'P1C1
                Main.picP1C1.Image = Nothing
                CardTracker.intP1C1 = 0
            Case 2
                'P1C2
                Main.picP1C2.Image = Nothing
                CardTracker.intP1C2 = 0
            Case 3
                'P1C3
                Main.picP1C3.Image = Nothing
                CardTracker.intP1C3 = 0
            Case 4
                'P1C4
                Main.picP1C4.Image = Nothing
                CardTracker.intP1C4 = 0
            Case 5
                'P1C5
                Main.picP1C5.Image = Nothing
                CardTracker.intP1C5 = 0
            Case 6
                'P1C6
                Main.picP1C6.Image = Nothing
                CardTracker.intP1C6 = 0
            Case 7
                'P1C7
                Main.picP1C7.Image = Nothing
                CardTracker.intP1C7 = 0
            Case 8
                'P1C8
                Main.picP1C8.Image = Nothing
                CardTracker.intP1C8 = 0
            Case 9
                'P1C9
                Main.picP1C9.Image = Nothing
                CardTracker.intP1C9 = 0
            Case 10
                'P1C10
                Main.picP1C10.Image = Nothing
                CardTracker.intP1C10 = 0
            Case 11
                'P2C1
                Main.picP2C1.Image = Nothing
                CardTracker.intP2C1 = 0
            Case 12
                'P2C2
                Main.picP2C2.Image = Nothing
                CardTracker.intP2C2 = 0
            Case 13
                'P2C3
                Main.picP2C3.Image = Nothing
                CardTracker.intP2C3 = 0
            Case 14
                'P2C4
                Main.picP2C4.Image = Nothing
                CardTracker.intP2C4 = 0
            Case 15
                'P2C5
                Main.picP2C5.Image = Nothing
                CardTracker.intP2C5 = 0
            Case 16
                'P2C6
                Main.picP2C6.Image = Nothing
                CardTracker.intP2C6 = 0
            Case 17
                'P2C7
                Main.picP2C7.Image = Nothing
                CardTracker.intP2C7 = 0
            Case 18
                'P2C8
                Main.picP2C8.Image = Nothing
                CardTracker.intP2C8 = 0
            Case 19
                'P2C9
                Main.picP2C9.Image = Nothing
                CardTracker.intP2C9 = 0
            Case 20
                'P2C10
                Main.picP2C10.Image = Nothing
                CardTracker.intP2C10 = 0

            Case 21
                'P1DF
                Main.picP1DF.Image = Nothing
                CardTracker.intP1DF = 0
            Case 22
                'P1NF
                Main.picP1NF.Image = Nothing
                CardTracker.intP1NF = 0
            Case 23
                'P1Pr
                Main.picP1Pr.Image = Nothing
                CardTracker.intP1Pr = 0
            Case 24
                'P1RP
                Main.picP1RP.Image = Nothing
                CardTracker.intP1RP = 0
            Case 25
                'P1DP
                Main.picP1DP.Image = Nothing
                CardTracker.intP1DP = 0
            Case 26
                'P2DF
                Main.picP2DF.Image = Nothing
                CardTracker.intP2DF = 0
            Case 27
                'P2NF
                Main.picP2NF.Image = Nothing
                CardTracker.intP2NF = 0
            Case 28
                'P2Pr
                Main.PicP2Pr.Image = Nothing
                CardTracker.intP2Pr = 0
            Case 29
                'P2RP
                Main.picP2RP.Image = Nothing
                CardTracker.intP2RP = 0
            Case 30
                'P2DP
                Main.picP2DP.Image = Nothing
                CardTracker.intP2DP = 0
            Case 31
                'P1O1
                Main.picP1O1.Image = Nothing
                CardTracker.intP1O1 = 0
            Case 32
                'P1O2
                Main.picP1O2.Image = Nothing
                CardTracker.intP1O2 = 0
            Case 33
                'P1O3
                Main.picP1O3.Image = Nothing
                CardTracker.intP1O3 = 0
            Case 34
                'P1O4
                Main.picP1O4.Image = Nothing
                CardTracker.intP1O4 = 0
            Case 35
                'P2O1
                Main.picP2O1.Image = Nothing
                CardTracker.intP2O1 = 0
            Case 36
                'P2O2
                Main.picP2O2.Image = Nothing
                CardTracker.intP2O2 = 0
            Case 37
                'P2O3
                Main.picP2O3.Image = Nothing
                CardTracker.intP2O3 = 0
            Case 38
                'P2O4
                Main.picP2O4.Image = Nothing
                CardTracker.intP2O4 = 0
            Case 39
                'P1F1
                Main.picP1F1.Image = Nothing
                CardTracker.intP1F1 = 0
            Case 40
                'P1F2
                Main.picP1F2.Image = Nothing
                CardTracker.intP1F2 = 0
            Case 41
                'P1F3
                Main.picP1F3.Image = Nothing
                CardTracker.intP1F3 = 0
            Case 42
                'P1F4
                Main.picP1F4.Image = Nothing
                CardTracker.intP1F4 = 0
            Case 43
                'P2F1
                Main.picP2F1.Image = Nothing
                CardTracker.intP2F1 = 0
            Case 44
                'P2F2
                Main.picP2F2.Image = Nothing
                CardTracker.intP2F2 = 0
            Case 45
                'P2F3
                Main.picP2F3.Image = Nothing
                CardTracker.intP2F3 = 0
            Case 46
                'P2F4
                Main.picP2F4.Image = Nothing
                CardTracker.intP2F4 = 0
            Case 47
                'P1N2
                Main.picP1N2.Image = Nothing
                CardTracker.intp1N2 = 0
            Case 48
                'P1N3
                Main.picP1N3.Image = Nothing
                CardTracker.intp1N3 = 0
            Case 49
                'P1N4
                Main.picP1N4.Image = Nothing
                CardTracker.intp1N4 = 0
            Case 50
                'P2N2
                Main.picP2N2.Image = Nothing
                CardTracker.intp2N2 = 0
            Case 51
                'P2N3
                Main.picP2N3.Image = Nothing
                CardTracker.intp2N3 = 0
            Case 52
                'P2N4
                Main.picP2N4.Image = Nothing
                CardTracker.intp2N4 = 0
            Case 53
                'P1H1
                Main.picP1H1.Image = Nothing
                CardTracker.intp1H1 = 0
            Case 54
                'P1H2
                Main.picP1H2.Image = Nothing
                CardTracker.intp1H2 = 0
            Case 55
                'P1H3
                Main.picP1H3.Image = Nothing
                CardTracker.intp1H3 = 0
            Case 56
                'P1H1
                Main.picP2H1.Image = Nothing
                CardTracker.intp2H1 = 0
            Case 57
                'P1H2
                Main.picP2H2.Image = Nothing
                CardTracker.intp2H2 = 0
            Case 58
                'P1H3
                Main.picP2H3.Image = Nothing
                CardTracker.intp2H3 = 0
        End Select
    End Sub







End Module
