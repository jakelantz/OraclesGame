Public Class frmFate


    '    Private Sub Button1_Click(sender As Object, e As EventArgs)

    '    End Sub

    '    Private Sub picPic1_Click(sender As Object, e As EventArgs) Handles picPic1.Click
    '        If TurnHandler.intPlayerTurn = 0 Then
    '            Call CardTracker.DiscardCard(CardTracker.strP1O1Card)
    '            CardTracker.intP1O1Fate = intReplaceFateValue
    '            CardTracker.strP1O1Card = strReplaceFate
    '            Main.picP1O1.Image = picReplace.Image
    '            If CardTracker.strP1O1Card = "xxi" Then
    '                Call WorldEnd()
    '                Exit Sub
    '            End If
    '            If MajorArcana.bolSun = False Then
    '                Call TurnHandler.P1RotateCards()
    '            Else
    '                MajorArcana.bolSun = False
    '            End If
    '        Else
    '                Call CardTracker.DiscardCard(CardTracker.strP2O1Card)
    '            CardTracker.intP2O1Fate = intReplaceFateValue
    '            CardTracker.strP2O1Card = strReplaceFate
    '            Main.picP2O1.Image = picReplace.Image
    '            If CardTracker.strP2O1Card = "xxi" Then
    '                Call WorldEnd()
    '                Exit Sub
    '            End If
    '            If MajorArcana.bolSun = False Then
    '                Call TurnHandler.P2RotateCards()
    '            Else
    '                MajorArcana.bolSun = False
    '            End If
    '        End If
    '        Call frmFortune.ClearReplaceFate()
    '        TurnHandler.bolFateToFortune = False
    '        Me.Close()
    '        Call TurnHandler.CountFate()
    '        Exit Sub
    '    End Sub

    '    Private Sub picPic2_Click(sender As Object, e As EventArgs) Handles picPic2.Click
    '        If TurnHandler.intPlayerTurn = 0 Then
    '            Call CardTracker.DiscardCard(CardTracker.strP1O2Card)
    '            CardTracker.intP1O2Fate = intReplaceFateValue
    '            CardTracker.strP1O2Card = strReplaceFate
    '            Main.picP1O2.Image = picReplace.Image
    '            If CardTracker.strP1O2Card = "xxi" Then
    '                Call WorldEnd()
    '                Exit Sub
    '            End If
    '            If MajorArcana.bolSun = False Then
    '                Call TurnHandler.P1RotateCards()
    '            Else
    '                MajorArcana.bolSun = False
    '            End If
    '        Else
    '            Call CardTracker.DiscardCard(CardTracker.strP2O2Card)
    '            CardTracker.intP2O2Fate = intReplaceFateValue
    '            CardTracker.strP2O2Card = strReplaceFate
    '            Main.picP2O2.Image = picReplace.Image
    '            If CardTracker.strP2O2Card = "xxi" Then
    '                Call WorldEnd()
    '                Exit Sub
    '            End If
    '            If MajorArcana.bolSun = False Then
    '                Call TurnHandler.P2RotateCards()
    '            Else
    '                MajorArcana.bolSun = False
    '            End If
    '        End If
    '        Call frmFortune.ClearReplaceFate()
    '        TurnHandler.bolFateToFortune = False
    '        Me.Close()
    '        Call TurnHandler.CountFate()
    '        Exit Sub
    '    End Sub

    '    Private Sub picPic3_Click(sender As Object, e As EventArgs) Handles picPic3.Click
    '        If TurnHandler.intPlayerTurn = 0 Then
    '            Call CardTracker.DiscardCard(CardTracker.strP1O3Card)
    '            CardTracker.intP1O3Fate = intReplaceFateValue
    '            CardTracker.strP1O3Card = strReplaceFate
    '            Main.picP1O3.Image = picReplace.Image
    '            If CardTracker.strP1O3Card = "xxi" Then
    '                Call WorldEnd()
    '                Exit Sub
    '            End If
    '            If MajorArcana.bolSun = False Then
    '                Call TurnHandler.P1RotateCards()
    '            Else
    '                MajorArcana.bolSun = False
    '            End If
    '        Else
    '            Call CardTracker.DiscardCard(CardTracker.strP2O3Card)
    '            CardTracker.intP2O3Fate = intReplaceFateValue
    '            CardTracker.strP2O3Card = strReplaceFate
    '            Main.picP2O3.Image = picReplace.Image
    '            If CardTracker.strP2O3Card = "xxi" Then
    '                Call WorldEnd()
    '                Exit Sub
    '            End If
    '            If MajorArcana.bolSun = False Then
    '                Call TurnHandler.P2RotateCards()
    '            Else
    '                MajorArcana.bolSun = False
    '            End If
    '        End If
    '        Call frmFortune.ClearReplaceFate()
    '        TurnHandler.bolFateToFortune = False
    '        Me.Close()
    '        Call TurnHandler.CountFate()
    '        Exit Sub
    '    End Sub

    '    Private Sub picPic4_Click(sender As Object, e As EventArgs) Handles picPic4.Click
    '        If TurnHandler.intPlayerTurn = 0 Then
    '            Call CardTracker.DiscardCard(CardTracker.strP1O4Card)
    '            CardTracker.intP1O4Fate = intReplaceFateValue
    '            CardTracker.strP1O4Card = strReplaceFate
    '            Main.picP1O4.Image = picReplace.Image
    '            If CardTracker.strP1O4Card = "xxi" Then
    '                Call WorldEnd()
    '                Exit Sub
    '            End If
    '            If MajorArcana.bolSun = False Then
    '                Call TurnHandler.P1RotateCards()
    '            Else
    '                MajorArcana.bolSun = False
    '            End If
    '        Else
    '            Call CardTracker.DiscardCard(CardTracker.strP2O4Card)
    '            CardTracker.intP2O4Fate = intReplaceFateValue
    '            CardTracker.strP2O4Card = strReplaceFate
    '            Main.picP2O4.Image = picReplace.Image
    '            If CardTracker.strP2O4Card = "xxi" Then
    '                Call WorldEnd()
    '                Exit Sub
    '            End If
    '            If MajorArcana.bolSun = False Then
    '                Call TurnHandler.P2RotateCards()
    '            Else
    '                MajorArcana.bolSun = False
    '            End If
    '        End If
    '        Call frmFortune.ClearReplaceFate()
    '        TurnHandler.bolFateToFortune = False
    '        Me.Close()
    '        Call TurnHandler.CountFate()
    '        Exit Sub
    '    End Sub

    '    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
    '        Call CardTracker.DiscardCard(CardTracker.strReplaceFate)
    '        Call frmFortune.ClearReplaceFate()
    '        Call TurnHandler.CountFortune()
    '        Me.Close()
    '        If TurnHandler.intPlayerTurn = 0 Then
    '            If MajorArcana.bolSun = False Then
    '                Call TurnHandler.P1RotateCards()
    '            Else
    '                MajorArcana.bolSun = False
    '            End If
    '        Else
    '            If MajorArcana.bolSun = False Then
    '                Call TurnHandler.P2RotateCards()
    '            Else
    '                MajorArcana.bolSun = False
    '            End If

    '        End If
    '        Call TurnHandler.CountFate()
    '    End Sub
End Class