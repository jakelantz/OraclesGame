Public Class frmBuyACard
    '    Public intP1Payed As Integer
    '    Public intP2Payed As Integer
    '    Public intP1Payup As Integer
    '    Public intP2Payup As Integer
    '    Private Sub picPic1_Click(sender As Object, e As EventArgs) Handles picPic1.Click
    '        If frmPlayerHand.bolPlayMajor = True Then
    '            picPic1.Visible = False


    '            If TurnHandler.intPlayerTurn = 0 Then

    '                ' frmPlayerHand.intFortuneToPay = frmPlayerHand.intFortuneToPay - CardTracker.intP1F1Fortune
    '                Call CardTracker.DiscardCard(CardTracker.strP1F1Card)
    '                Call frmPlayerHand.SpendableFortune()
    '                intP1Payed = intP1Payed + CardTracker.intP1F1Fortune
    '                intP1Payup = CardTracker.intReplaceFateValue - frmPlayerHand.intStaticFortune
    '                intP1Payup = intP1Payup - intP1Payed
    '                Main.picP1F1.Image = Nothing
    '                CardTracker.strP1F1Card = ""
    '                CardTracker.intP1F1Fortune = 0
    '                frmPlayerHand.lblPMessage.Text = "Player 1, Discard a Card"
    '                lblMsg.Text = "Pay " & intP1Payup
    '                Call TurnHandler.CountFortune()

    '                If intP1Payup <= 0 Then
    '                    CardTracker.P1HandSize = CardTracker.P1HandSize - 1
    '                    Main.picP1DF.Image = picReplace.Image
    '                    intP1Payed = 0
    '                    CardTracker.intP1DFCardType = 3
    '                    CardTracker.strP1DFCard = CardTracker.strReplaceFate
    '                    CardTracker.intP1DFFate = CardTracker.intReplaceFateValue
    '                    Me.Close()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    frmPlayerHand.Visible = True
    '                    Call frmFortune.ClearReplaceFate()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    TurnHandler.bolDiscardTime = True
    '                    If CardTracker.strP1DFCard = "ii" Then
    '                        Call MajorArcana.MAHighPriestess()
    '                    End If





    '                End If

    '            Else
    '                ' frmPlayerHand.intFortuneToPay = frmPlayerHand.intFortuneToPay - CardTracker.intP2F1Fortune
    '                Call CardTracker.DiscardCard(CardTracker.strP2F1Card)
    '                Call frmPlayerHand.SpendableFortune()
    '                intP2Payed = intP2Payed + CardTracker.intP2F1Fortune
    '                intP2Payup = CardTracker.intReplaceFateValue - frmPlayerHand.intStaticFortune
    '                intP2Payup = intP2Payup - intP2Payed
    '                Main.picP2F1.Image = Nothing
    '                CardTracker.strP2F1Card = ""
    '                CardTracker.intP2F1Fortune = 0
    '                frmPlayerHand.lblPMessage.Text = "Player 1, Discard a Card"
    '                lblMsg.Text = "Pay " & intP2Payup
    '                Call TurnHandler.CountFortune()

    '                If intP2Payup <= 0 Then
    '                    CardTracker.P2HandSize = CardTracker.P2HandSize - 1
    '                    Main.picP2DF.Image = picReplace.Image
    '                    intP2Payed = 0
    '                    CardTracker.intP2DFCardType = 3
    '                    CardTracker.strP2DFCard = CardTracker.strReplaceFate
    '                    CardTracker.intP2DFFate = CardTracker.intReplaceFateValue
    '                    Me.Close()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    frmPlayerHand.Visible = True
    '                    Call frmFortune.ClearReplaceFate()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    TurnHandler.bolDiscardTime = True
    '                    If CardTracker.strP2DFCard = "ii" Then
    '                        Call MajorArcana.MAHighPriestess()
    '                    End If
    '                End If


    '            End If
    '        End If

    '    End Sub

    '    Private Sub picPic2_Click(sender As Object, e As EventArgs) Handles picPic2.Click
    '        If frmPlayerHand.bolPlayMajor = True Then
    '            picPic2.Visible = False


    '            If TurnHandler.intPlayerTurn = 0 Then

    '                ' frmPlayerHand.intFortuneToPay = frmPlayerHand.intFortuneToPay - CardTracker.intP1F2Fortune
    '                Call CardTracker.DiscardCard(CardTracker.strP1F2Card)
    '                Call frmPlayerHand.SpendableFortune()
    '                intP1Payed = intP1Payed + CardTracker.intP1F2Fortune
    '                intP1Payup = CardTracker.intReplaceFateValue - frmPlayerHand.intStaticFortune
    '                intP1Payup = intP1Payup - intP1Payed
    '                Main.picP1F2.Image = Nothing
    '                CardTracker.strP1F2Card = ""
    '                CardTracker.intP1F2Fortune = 0
    '                frmPlayerHand.lblPMessage.Text = "Player 1, Discard a Card"
    '                lblMsg.Text = "Pay " & intP1Payup
    '                Call TurnHandler.CountFortune()

    '                If intP1Payup <= 0 Then
    '                    CardTracker.P1HandSize = CardTracker.P1HandSize - 1
    '                    Main.picP1DF.Image = picReplace.Image
    '                    intP1Payed = 0
    '                    CardTracker.intP1DFCardType = 3
    '                    CardTracker.strP1DFCard = CardTracker.strReplaceFate
    '                    CardTracker.intP1DFFate = CardTracker.intReplaceFateValue
    '                    Me.Close()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    frmPlayerHand.Visible = True
    '                    Call frmFortune.ClearReplaceFate()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    TurnHandler.bolDiscardTime = True
    '                    If CardTracker.strP1DFCard = "ii" Then
    '                        Call MajorArcana.MAHighPriestess()
    '                    End If
    '                End If

    '            Else
    '                ' frmPlayerHand.intFortuneToPay = frmPlayerHand.intFortuneToPay - CardTracker.intP2F2Fortune
    '                Call CardTracker.DiscardCard(CardTracker.strP2F2Card)
    '                Call frmPlayerHand.SpendableFortune()
    '                intP2Payed = intP2Payed + CardTracker.intP2F2Fortune
    '                intP2Payup = CardTracker.intReplaceFateValue - frmPlayerHand.intStaticFortune
    '                intP2Payup = intP2Payup - intP2Payed
    '                Main.picP2F2.Image = Nothing
    '                CardTracker.strP2F2Card = ""
    '                CardTracker.intP2F2Fortune = 0
    '                frmPlayerHand.lblPMessage.Text = "Player 1, Discard a Card"
    '                lblMsg.Text = "Pay " & intP2Payup
    '                Call TurnHandler.CountFortune()

    '                If intP2Payup <= 0 Then
    '                    CardTracker.P2HandSize = CardTracker.P2HandSize - 1
    '                    Main.picP2DF.Image = picReplace.Image
    '                    intP2Payed = 0
    '                    CardTracker.intP2DFCardType = 3
    '                    CardTracker.strP2DFCard = CardTracker.strReplaceFate
    '                    CardTracker.intP2DFFate = CardTracker.intReplaceFateValue
    '                    Me.Close()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    frmPlayerHand.Visible = True
    '                    Call frmFortune.ClearReplaceFate()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    TurnHandler.bolDiscardTime = True
    '                    If CardTracker.strP2DFCard = "ii" Then
    '                        Call MajorArcana.MAHighPriestess()
    '                    End If
    '                End If


    '            End If
    '        End If

    '    End Sub

    '    Private Sub picPic3_Click(sender As Object, e As EventArgs) Handles picPic3.Click
    '        If frmPlayerHand.bolPlayMajor = True Then
    '            picPic3.Visible = False


    '            If TurnHandler.intPlayerTurn = 0 Then

    '                ' frmPlayerHand.intFortuneToPay = frmPlayerHand.intFortuneToPay - CardTracker.intP1F3Fortune
    '                Call CardTracker.DiscardCard(CardTracker.strP1F3Card)
    '                Call frmPlayerHand.SpendableFortune()
    '                intP1Payed = intP1Payed + CardTracker.intP1F3Fortune
    '                intP1Payup = CardTracker.intReplaceFateValue - frmPlayerHand.intStaticFortune
    '                intP1Payup = intP1Payup - intP1Payed
    '                Main.picP1F3.Image = Nothing
    '                CardTracker.strP1F3Card = ""
    '                CardTracker.intP1F3Fortune = 0
    '                frmPlayerHand.lblPMessage.Text = "Player 1, Discard a Card"
    '                lblMsg.Text = "Pay " & intP1Payup
    '                Call TurnHandler.CountFortune()

    '                If intP1Payup <= 0 Then
    '                    CardTracker.P1HandSize = CardTracker.P1HandSize - 1
    '                    Main.picP1DF.Image = picReplace.Image
    '                    intP1Payed = 0
    '                    CardTracker.intP1DFCardType = 3
    '                    CardTracker.strP1DFCard = CardTracker.strReplaceFate
    '                    CardTracker.intP1DFFate = CardTracker.intReplaceFateValue
    '                    Me.Close()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    frmPlayerHand.Visible = True
    '                    Call frmFortune.ClearReplaceFate()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    TurnHandler.bolDiscardTime = True
    '                    If CardTracker.strP1DFCard = "ii" Then
    '                        Call MajorArcana.MAHighPriestess()
    '                    End If
    '                End If

    '            Else
    '                ' frmPlayerHand.intFortuneToPay = frmPlayerHand.intFortuneToPay - CardTracker.intP2F3Fortune
    '                Call CardTracker.DiscardCard(CardTracker.strP2F3Card)
    '                Call frmPlayerHand.SpendableFortune()
    '                intP2Payed = intP2Payed + CardTracker.intP2F3Fortune
    '                intP2Payup = CardTracker.intReplaceFateValue - frmPlayerHand.intStaticFortune
    '                intP2Payup = intP2Payup - intP2Payed
    '                Main.picP2F3.Image = Nothing
    '                CardTracker.strP2F3Card = ""
    '                CardTracker.intP2F3Fortune = 0
    '                frmPlayerHand.lblPMessage.Text = "Player 1, Discard a Card"
    '                lblMsg.Text = "Pay " & intP2Payup
    '                Call TurnHandler.CountFortune()

    '                If intP2Payup <= 0 Then
    '                    CardTracker.P2HandSize = CardTracker.P2HandSize - 1
    '                    Main.picP2DF.Image = picReplace.Image
    '                    intP2Payed = 0
    '                    CardTracker.intP2DFCardType = 3
    '                    CardTracker.strP2DFCard = CardTracker.strReplaceFate
    '                    CardTracker.intP2DFFate = CardTracker.intReplaceFateValue
    '                    Me.Close()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    frmPlayerHand.Visible = True
    '                    Call frmFortune.ClearReplaceFate()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    TurnHandler.bolDiscardTime = True
    '                    If CardTracker.strP2DFCard = "ii" Then
    '                        Call MajorArcana.MAHighPriestess()
    '                    End If
    '                End If


    '            End If
    '        End If

    '    End Sub

    '    Private Sub picPic4_Click(sender As Object, e As EventArgs) Handles picPic4.Click
    '        If frmPlayerHand.bolPlayMajor = True Then
    '            picPic4.Visible = False


    '            If TurnHandler.intPlayerTurn = 0 Then

    '                ' frmPlayerHand.intFortuneToPay = frmPlayerHand.intFortuneToPay - CardTracker.intP1F4Fortune
    '                Call CardTracker.DiscardCard(CardTracker.strP1F4Card)
    '                Call frmPlayerHand.SpendableFortune()
    '                intP1Payed = intP1Payed + CardTracker.intP1F4Fortune
    '                intP1Payup = CardTracker.intReplaceFateValue - frmPlayerHand.intStaticFortune
    '                intP1Payup = intP1Payup - intP1Payed
    '                Main.picP1F4.Image = Nothing
    '                CardTracker.strP1F4Card = ""
    '                CardTracker.intP1F4Fortune = 0
    '                frmPlayerHand.lblPMessage.Text = "Player 1, Discard a Card"
    '                lblMsg.Text = "Pay " & intP1Payup
    '                Call TurnHandler.CountFortune()

    '                If intP1Payup <= 0 Then
    '                    CardTracker.P1HandSize = CardTracker.P1HandSize - 1
    '                    Main.picP1DF.Image = picReplace.Image
    '                    intP1Payed = 0
    '                    CardTracker.intP1DFCardType = 3
    '                    CardTracker.strP1DFCard = CardTracker.strReplaceFate
    '                    CardTracker.intP1DFFate = CardTracker.intReplaceFateValue
    '                    Me.Close()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    frmPlayerHand.Visible = True
    '                    Call frmFortune.ClearReplaceFate()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    TurnHandler.bolDiscardTime = True
    '                    If CardTracker.strP1DFCard = "ii" Then
    '                        Call MajorArcana.MAHighPriestess()
    '                    End If
    '                End If

    '            Else
    '                ' frmPlayerHand.intFortuneToPay = frmPlayerHand.intFortuneToPay - CardTracker.intP2F4Fortune
    '                Call CardTracker.DiscardCard(CardTracker.strP2F4Card)
    '                Call frmPlayerHand.SpendableFortune()
    '                intP2Payed = intP2Payed + CardTracker.intP2F4Fortune
    '                intP2Payup = CardTracker.intReplaceFateValue - frmPlayerHand.intStaticFortune
    '                intP2Payup = intP2Payup - intP2Payed
    '                Main.picP2F4.Image = Nothing
    '                CardTracker.strP2F4Card = ""
    '                CardTracker.intP2F4Fortune = 0
    '                frmPlayerHand.lblPMessage.Text = "Player 1, Discard a Card"
    '                lblMsg.Text = "Pay " & intP2Payup
    '                Call TurnHandler.CountFortune()

    '                If intP2Payup <= 0 Then
    '                    CardTracker.P2HandSize = CardTracker.P2HandSize - 1
    '                    Main.picP2DF.Image = picReplace.Image
    '                    intP2Payed = 0
    '                    CardTracker.intP2DFCardType = 3
    '                    CardTracker.strP2DFCard = CardTracker.strReplaceFate
    '                    CardTracker.intP2DFFate = CardTracker.intReplaceFateValue
    '                    Me.Close()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    frmPlayerHand.Visible = True
    '                    Call frmFortune.ClearReplaceFate()
    '                    frmPlayerHand.bolPlayMajor = False
    '                    TurnHandler.bolDiscardTime = True
    '                    If CardTracker.strP2DFCard = "ii" Then
    '                        Call MajorArcana.MAHighPriestess()
    '                    End If
    '                End If


    '            End If
    '        End If
    '    End Sub

End Class