Public Class frmFortune
    '    Public Sub ClearReplaceFate()

    '        CardTracker.intReplaceFateType = 0
    '        CardTracker.strReplaceFate = ""
    '        CardTracker.intReplaceStaticFortune = 0
    '        CardTracker.intReplaceFateValue = 0
    '    End Sub

    '    Public Sub ClearReplaceFortune()

    '        CardTracker.intReplaceFortuneType = 0
    '        CardTracker.intReplaceFortuneValue = 0
    '        CardTracker.strReplaceFortune = ""
    '        CardTracker.intReplaceStaticFortune = 0

    '    End Sub


    '    Private Sub picPic1_Click(sender As Object, e As EventArgs) Handles picPic1.Click


    '        If TurnHandler.intPlayerTurn = 0 Then
    '            Call CardTracker.DiscardCard(CardTracker.strP1F1Card)
    '            CardTracker.intP1F1StaticFortune = CardTracker.intReplaceStaticFortune
    '            CardTracker.intP1F1Fortune = intReplaceFortuneValue
    '            CardTracker.strP1F1Card = strReplaceFortune
    '            Main.picP1F1.Image = picReplace.Image
    '            Call ClearReplaceFortune()
    '            Call TurnHandler.CountFortune()
    '            Me.Close()
    '        Else
    '            Call CardTracker.DiscardCard(CardTracker.strP2F1Card)
    '                CardTracker.intP2F1StaticFortune = CardTracker.intReplaceStaticFortune
    '            CardTracker.intP2F1Fortune = intReplaceFortuneValue
    '            CardTracker.strP2F1Card = strReplaceFortune
    '            Main.picP2F1.Image = picReplace.Image
    '            Call ClearReplaceFortune()
    '            Call TurnHandler.CountFortune()
    '                Me.Close()
    '            End If
    '        Call CountFortune()
    '        Call CountFate()
    '        Main.btnBeginTurn.Visible = True


    '    End Sub


    '    Private Sub picPic2_Click(sender As Object, e As EventArgs) Handles picPic2.Click



    '        If TurnHandler.intPlayerTurn = 0 Then
    '            Call CardTracker.DiscardCard(CardTracker.strP1F1Card)
    '            CardTracker.intP1F2StaticFortune = CardTracker.intReplaceStaticFortune
    '            CardTracker.intP1F2Fortune = intReplaceFortuneValue
    '            CardTracker.strP1F2Card = strReplaceFortune
    '            Main.picP1F2.Image = picReplace.Image
    '            Call ClearReplaceFortune()
    '            Call TurnHandler.CountFortune()
    '            Me.Close()
    '        Else
    '            Call CardTracker.DiscardCard(CardTracker.strP2F1Card)
    '            CardTracker.intP2F2StaticFortune = CardTracker.intReplaceStaticFortune
    '            CardTracker.intP2F2Fortune = intReplaceFortuneValue
    '            CardTracker.strP2F2Card = strReplaceFortune
    '            Main.picP2F2.Image = picReplace.Image
    '            Call ClearReplaceFortune()
    '            Call TurnHandler.CountFortune()
    '            Me.Close()
    '        End If

    '        Call CountFortune()
    '        Call CountFate()
    '        Main.btnBeginTurn.Visible = True

    '    End Sub
    '    Private Sub picPic3_Click(sender As Object, e As EventArgs) Handles picPic3.Click





    '        If TurnHandler.intPlayerTurn = 0 Then
    '            Call CardTracker.DiscardCard(CardTracker.strP1F1Card)
    '            CardTracker.intP1F3StaticFortune = CardTracker.intReplaceStaticFortune
    '            CardTracker.intP1F3Fortune = intReplaceFortuneValue
    '            CardTracker.strP1F3Card = strReplaceFortune
    '            Main.picP1F3.Image = picReplace.Image
    '            Call ClearReplaceFortune()
    '            Call TurnHandler.CountFortune()
    '            Me.Close()
    '        Else
    '            Call CardTracker.DiscardCard(CardTracker.strP2F1Card)
    '            CardTracker.intP2F3StaticFortune = CardTracker.intReplaceStaticFortune
    '            CardTracker.intP2F3Fortune = intReplaceFortuneValue
    '            CardTracker.strP2F3Card = strReplaceFortune
    '            Main.picP2F3.Image = picReplace.Image
    '            Call ClearReplaceFortune()
    '            Call TurnHandler.CountFortune()
    '            Me.Close()
    '        End If

    '        Call CountFortune()
    '        Call CountFate()
    '        Main.btnBeginTurn.Visible = True


    '    End Sub
    '    Private Sub picPic4_Click(sender As Object, e As EventArgs) Handles picPic4.Click





    '        If TurnHandler.intPlayerTurn = 0 Then
    '            Call CardTracker.DiscardCard(CardTracker.strP1F1Card)
    '            CardTracker.intP1F4StaticFortune = CardTracker.intReplaceStaticFortune
    '            CardTracker.intP1F4Fortune = intReplaceFortuneValue
    '            CardTracker.strP1F4Card = strReplaceFortune
    '            Main.picP1F4.Image = picReplace.Image
    '            Call ClearReplaceFortune()
    '            Call TurnHandler.CountFortune()
    '            Me.Close()
    '        Else
    '            Call CardTracker.DiscardCard(CardTracker.strP2F1Card)
    '            CardTracker.intP2F4StaticFortune = CardTracker.intReplaceStaticFortune
    '            CardTracker.intP2F4Fortune = intReplaceFortuneValue
    '            CardTracker.strP2F4Card = strReplaceFortune
    '            Main.picP2F4.Image = picReplace.Image
    '            Call ClearReplaceFortune()
    '            Call TurnHandler.CountFortune()
    '            Me.Close()
    '        End If

    '        Call CountFortune()
    '        Call CountFate()
    '        Main.btnBeginTurn.Visible = True

    '    End Sub

    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '        Call CardTracker.DiscardCard(CardTracker.strReplaceFortune)
    '        Call ClearReplaceFortune()
    '        Call TurnHandler.CountFortune()
    '        Me.Close()
    '        Call CountFortune()
    '        Call CountFate()
    '        Main.btnBeginTurn.Visible = True

    '    End Sub

    '    Private Sub lblAvaterMsg_Click(sender As Object, e As EventArgs) Handles lblMsg.Click

    '    End Sub

    '    Private Sub picReplace_Click(sender As Object, e As EventArgs) Handles picReplace.Click

    '    End Sub
End Class