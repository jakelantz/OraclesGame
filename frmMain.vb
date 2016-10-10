Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CardTracker.NewDeck()
        Call CardTracker.Shuffle()

        lblDirection.Show()
        lblDirection.Text = "Welcome to Oracles of Tarot!  In this game you are the ruler of a house, and conflict with your rival has escalated to war.  You are represented by the King of your house.  Good Luck!"
        btnAction1.Show()
        btnAction1.Text = "Begin Game"

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub picP1C1_Click(sender As Object, e As EventArgs) Handles picP1C1.Click
        Call Brain.Router(1, CardTracker.intP1C1)
    End Sub

    Private Sub picP1C2_Click(sender As Object, e As EventArgs) Handles picP1C2.Click
        Call Brain.Router(2, CardTracker.intP1C2)
    End Sub

    Private Sub picP1C3_Click(sender As Object, e As EventArgs) Handles picP1C3.Click
        Call Brain.Router(3, CardTracker.intP1C3)
    End Sub

    Private Sub picP1C4_Click(sender As Object, e As EventArgs) Handles picP1C4.Click
        Call Brain.Router(4, CardTracker.intP1C4)
    End Sub

    Private Sub picP1C5_Click(sender As Object, e As EventArgs) Handles picP1C5.Click
        Call Brain.Router(5, CardTracker.intP1C5)
    End Sub

    Private Sub picP1C6_Click(sender As Object, e As EventArgs) Handles picP1C6.Click
        Call Brain.Router(6, CardTracker.intP1C6)
    End Sub

    Private Sub picP1C7_Click(sender As Object, e As EventArgs) Handles picP1C7.Click
        Call Brain.Router(7, CardTracker.intP1C7)
    End Sub

    Private Sub picP1C8_Click(sender As Object, e As EventArgs) Handles picP1C8.Click
        Call Brain.Router(8, CardTracker.intP1C8)
    End Sub

    Private Sub picP1C9_Click(sender As Object, e As EventArgs) Handles picP1C9.Click
        Call Brain.Router(9, CardTracker.intP1C9)
    End Sub

    Private Sub picP1C10_Click(sender As Object, e As EventArgs) Handles picP1C10.Click
        Call Brain.Router(10, CardTracker.intP1C10)
    End Sub
    Private Sub picP2C1_Click(sender As Object, e As EventArgs) Handles picP2C1.Click
        Call Brain.Router(11, CardTracker.intP2C1)
    End Sub

    Private Sub picP2C2_Click(sender As Object, e As EventArgs) Handles picP2C2.Click
        Call Brain.Router(12, CardTracker.intP2C2)
    End Sub

    Private Sub picP2C3_Click(sender As Object, e As EventArgs) Handles picP2C3.Click
        Call Brain.Router(13, CardTracker.intP2C3)
    End Sub

    Private Sub picP2C4_Click(sender As Object, e As EventArgs) Handles picP2C4.Click
        Call Brain.Router(14, CardTracker.intP2C4)
    End Sub

    Private Sub picP2C5_Click(sender As Object, e As EventArgs) Handles picP2C5.Click
        Call Brain.Router(15, CardTracker.intP2C5)
    End Sub

    Private Sub picP2C6_Click(sender As Object, e As EventArgs) Handles picP2C6.Click
        Call Brain.Router(16, CardTracker.intP2C6)
    End Sub

    Private Sub picP2C7_Click(sender As Object, e As EventArgs) Handles picP2C7.Click
        Call Brain.Router(17, CardTracker.intP2C7)
    End Sub

    Private Sub picP2C8_Click(sender As Object, e As EventArgs) Handles picP2C8.Click
        Call Brain.Router(18, CardTracker.intP2C8)
    End Sub

    Private Sub picP2C9_Click(sender As Object, e As EventArgs) Handles picP2C9.Click
        Call Brain.Router(19, CardTracker.intP2C9)
    End Sub

    Private Sub picP2C10_Click(sender As Object, e As EventArgs) Handles picP2C10.Click
        Call Brain.Router(20, CardTracker.intP2C10)
    End Sub

    Private Sub picP1DF_Click(sender As Object, e As EventArgs) Handles picP1DF.Click
        Call Brain.Router(21, CardTracker.intP1DF)
    End Sub

    Private Sub picP1NF_Click(sender As Object, e As EventArgs) Handles picP1NF.Click
        Call Brain.Router(22, CardTracker.intP1NF)
    End Sub

    Private Sub picP1Pr_Click(sender As Object, e As EventArgs) Handles picP1Pr.Click
        Call Brain.Router(23, CardTracker.intP1Pr)
    End Sub

    Private Sub picP1RP_Click(sender As Object, e As EventArgs) Handles picP1RP.Click
        Call Brain.Router(24, CardTracker.intP1RP)
    End Sub

    Private Sub picP1DP_Click(sender As Object, e As EventArgs) Handles picP1DP.Click
        Call Brain.Router(25, CardTracker.intP1DP)
    End Sub
    Private Sub picP2DF_Click(sender As Object, e As EventArgs) Handles picP2DF.Click
        Call Brain.Router(26, CardTracker.intP2DF)
    End Sub

    Private Sub picP2NF_Click(sender As Object, e As EventArgs) Handles picP2NF.Click
        Call Brain.Router(27, CardTracker.intP2NF)
    End Sub

    Private Sub picP2Pr_Click(sender As Object, e As EventArgs) Handles PicP2Pr.Click
        Call Brain.Router(28, CardTracker.intP2Pr)
    End Sub

    Private Sub picP2RP_Click(sender As Object, e As EventArgs) Handles picP2RP.Click
        Call Brain.Router(29, CardTracker.intP2RP)
    End Sub

    Private Sub picP2DP_Click(sender As Object, e As EventArgs) Handles picP2DP.Click
        Call Brain.Router(30, CardTracker.intP2DP)
    End Sub

    Private Sub picP1O1_Click(sender As Object, e As EventArgs) Handles picP1O1.Click
        Call Brain.Router(31, CardTracker.intP1O1)
    End Sub

    Private Sub picP1O2_Click(sender As Object, e As EventArgs) Handles picP1O2.Click
        Call Brain.Router(32, CardTracker.intP1O2)
    End Sub

    Private Sub picP1O3_Click(sender As Object, e As EventArgs) Handles picP1O3.Click
        Call Brain.Router(33, CardTracker.intP1O3)
    End Sub

    Private Sub picP1O4_Click(sender As Object, e As EventArgs) Handles picP1O4.Click
        Call Brain.Router(34, CardTracker.intP1O4)
    End Sub
    Private Sub picP2O1_Click(sender As Object, e As EventArgs) Handles picP2O1.Click
        Call Brain.Router(35, CardTracker.intP2O1)
    End Sub

    Private Sub picP2O2_Click(sender As Object, e As EventArgs) Handles picP2O2.Click
        Call Brain.Router(36, CardTracker.intP2O2)
    End Sub

    Private Sub picP2O3_Click(sender As Object, e As EventArgs) Handles picP2O3.Click
        Call Brain.Router(37, CardTracker.intP2O3)
    End Sub

    Private Sub picP2O4_Click(sender As Object, e As EventArgs) Handles picP2O4.Click
        Call Brain.Router(38, CardTracker.intP2O4)
    End Sub

    Private Sub picP1F1_Click(sender As Object, e As EventArgs) Handles picP1F1.Click
        Call Brain.Router(39, CardTracker.intP1F1)
    End Sub

    Private Sub picP1F2_Click(sender As Object, e As EventArgs) Handles picP1F2.Click
        Call Brain.Router(40, CardTracker.intP1F2)
    End Sub

    Private Sub picP1F3_Click(sender As Object, e As EventArgs) Handles picP1F3.Click
        Call Brain.Router(41, CardTracker.intP1F3)
    End Sub

    Private Sub picP1F4_Click(sender As Object, e As EventArgs) Handles picP1F4.Click
        Call Brain.Router(42, CardTracker.intP1F4)
    End Sub

    Private Sub picP2F1_Click(sender As Object, e As EventArgs) Handles picP2F1.Click
        Call Brain.Router(43, CardTracker.intP2F1)
    End Sub

    Private Sub picP2F2_Click(sender As Object, e As EventArgs) Handles picP2F2.Click
        Call Brain.Router(44, CardTracker.intP2F2)
    End Sub

    Private Sub picP2F3_Click(sender As Object, e As EventArgs) Handles picP2F3.Click
        Call Brain.Router(45, CardTracker.intP2F3)
    End Sub

    Private Sub picP2F4_Click(sender As Object, e As EventArgs) Handles picP2F4.Click
        Call Brain.Router(46, CardTracker.intP2F4)
    End Sub

    Private Sub picP1N2_Click(sender As Object, e As EventArgs) Handles picP1N2.Click
        Call Brain.Router(47, CardTracker.intp1N2)
    End Sub

    Private Sub picP1N3_Click(sender As Object, e As EventArgs) Handles picP1N3.Click
        Call Brain.Router(48, CardTracker.intp1N3)
    End Sub

    Private Sub picP1N4_Click(sender As Object, e As EventArgs) Handles picP1N4.Click
        Call Brain.Router(49, CardTracker.intp1N4)
    End Sub
    Private Sub picP2N2_Click(sender As Object, e As EventArgs) Handles picP2N2.Click
        Call Brain.Router(50, CardTracker.intp2N2)
    End Sub

    Private Sub picP2N3_Click(sender As Object, e As EventArgs) Handles picP2N3.Click
        Call Brain.Router(51, CardTracker.intp2N3)
    End Sub

    Private Sub picP2N4_Click(sender As Object, e As EventArgs) Handles picP2N4.Click
        Call Brain.Router(52, CardTracker.intp2N4)
    End Sub

    Private Sub picP1H1_Click(sender As Object, e As EventArgs) Handles picP1H1.Click
        Call Brain.Router(53, CardTracker.intp1H1)
    End Sub

    Private Sub picP1H2_Click(sender As Object, e As EventArgs) Handles picP1H2.Click
        Call Brain.Router(54, CardTracker.intp1H2)
    End Sub

    Private Sub picP1H3_Click(sender As Object, e As EventArgs) Handles picP1H3.Click
        Call Brain.Router(55, CardTracker.intp1H3)
    End Sub

    Private Sub picP2H1_Click(sender As Object, e As EventArgs) Handles picP2H1.Click
        Call Brain.Router(56, CardTracker.intp2H1)
    End Sub

    Private Sub picP2H2_Click(sender As Object, e As EventArgs) Handles picP2H2.Click
        Call Brain.Router(57, CardTracker.intp2H2)
    End Sub

    Private Sub picP2H3_Click(sender As Object, e As EventArgs) Handles picP2H3.Click
        Call Brain.Router(58, CardTracker.intp2H3)
    End Sub


    Private Sub btnAction1_Click(sender As Object, e As EventArgs) Handles btnAction1.Click
        Call Brain.Router(59, 0)
    End Sub

    Private Sub btnAction2_Click(sender As Object, e As EventArgs) Handles btnAction2.Click
        Call Brain.Router(60, 0)
    End Sub

    Private Sub btnAction3_Click(sender As Object, e As EventArgs) Handles btnAction3.Click
        Call Brain.Router(61, 0)
    End Sub

    Private Sub picP1N1_Click(sender As Object, e As EventArgs) Handles picP1N1.Click
        lblDirection.Text = "King of Sword, representing Player 1.  This card can never be removed or moved."
    End Sub

    Private Sub picP2N1_Click(sender As Object, e As EventArgs) Handles picP2N1.Click
        lblDirection.Text = "King of Wands, representing Player 2.  This card can never be removed or moved."
    End Sub

    Public Sub CardDiscription(i As Integer)
        If i = 1 Then
            lblDirection.Text = "The Ace of Cups, representing the Hand of God and one facet of Divine Provedence.  In the Fortune pile, adds 3 Static Fortune that doesn't have to be spent to use. Collect all four Aces to win the game."
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play A Cups"
            End If
        ElseIf i = 2 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 2 Cups"
            End If
            lblDirection.Text = "2 of Cups, in the Fortune pile, adds 2 Fortune that must be discarded to spend."
        ElseIf i = 3 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 3 Cups"
            End If
            lblDirection.Text = "3 of Cups, in the Fortune pile, adds 3 Fortune that must be discarded to spend."
        ElseIf i = 4 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 4 Cups"
            End If
            lblDirection.Text = "4 of Cups, in the Fortune pile, adds 4 Fortune that must be discarded to spend."
        ElseIf i = 5 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 5 Cups"
            End If
            lblDirection.Text = "5 of Cups, in the Fortune pile, adds 5 Fortune that must be discarded to spend."
        ElseIf i = 6 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 6 Cups"
            End If
            lblDirection.Text = "6 of Cups, in the Fortune pile, adds 6 Fortune that must be discarded to spend."
        ElseIf i = 7 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 7 Cups"
            End If
            lblDirection.Text = "7 of Cups, in the Fortune pile, adds 7 Fortune that must be discarded to spend."
        ElseIf i = 8 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 8 Cups"
            End If
            lblDirection.Text = "8 of Cups, in the Fortune pile, adds 8 Fortune that must be discarded to spend."
        ElseIf i = 9 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 9 Cups"
            End If
            lblDirection.Text = "9 of Cups, in the Fortune pile, adds 9 Fortune that must be discarded to spend."
        ElseIf i = 10 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 10 Cups"
            End If
            lblDirection.Text = "10 of Cups, in the Fortune pile, adds 10 Fortune that must be discarded to spend."
        ElseIf i = 11 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play A Pentacles"
            End If
            lblDirection.Text = "The Ace of Pentacles, representing the Hand of God and one facet of Divine Provedence.  In the Fortune pile, adds 3 Static Fortune that doesn't have to be spent to use. Collect all four Aces to win the game."
        ElseIf i = 12 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 2 Pentacles"
            End If
            lblDirection.Text = "2 of Pentacles, in the Fortune pile, adds 2 Fortune that must be discarded to spend."
        ElseIf i = 13 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 3 Pentacles"
            End If
            lblDirection.Text = "3 of Pentacles, in the Fortune pile, adds 3 Fortune that must be discarded to spend."
        ElseIf i = 14 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 4 Pentacles"
            End If
            lblDirection.Text = "4 of Pentacles, in the Fortune pile, adds 4 Fortune that must be discarded to spend."
        ElseIf i = 15 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 5 Pentacles"
            End If
            lblDirection.Text = "5 of Pentacles, in the Fortune pile, adds 5 Fortune that must be discarded to spend."
        ElseIf i = 16 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 6 Pentacles"
            End If
            lblDirection.Text = "6 of Pentacles, in the Fortune pile, adds 6 Fortune that must be discarded to spend."
        ElseIf i = 17 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 7 Pentacles"
            End If
            lblDirection.Text = "7 of Pentacles, in the Fortune pile, adds 7 Fortune that must be discarded to spend."
        ElseIf i = 18 Then
            If Brain.bolPlayACard = "Play 8 Pentacles" Then
            End If
            lblDirection.Text = "8 of Pentacles, in the Fortune pile, adds 8 Fortune that must be discarded to spend."
        ElseIf i = 19 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 9 Pentacles"
            End If
            lblDirection.Text = "9 of Pentacles, in the Fortune pile, adds 9 Fortune that must be discarded to spend."
        ElseIf i = 20 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 10 Pentacles"
            End If
            lblDirection.Text = "10 of Pentacles, in the Fortune pile, adds 10 Fortune that must be discarded to spend."
        ElseIf i = 21 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play A Swords"
            End If
            lblDirection.Text = "The Ace of Swords, representing the Hand of God and one facet of Divine Provedence.  In the Fortune pile, adds 3 Static Fortune that doesn't have to be spent to use. Collect all four Aces to win the game."
        ElseIf i = 22 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 2 Swords"
            End If
            lblDirection.Text = "2 of Swords, in the Fortune pile, adds 2 Fortune that must be discarded to spend."
        ElseIf i = 23 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 3 Swords"
            End If
            lblDirection.Text = "3 of Swords, in the Fortune pile, adds 3 Fortune that must be discarded to spend."
        ElseIf i = 24 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 4 Swords"
            End If
            lblDirection.Text = "4 of Swords, in the Fortune pile, adds 4 Fortune that must be discarded to spend."
        ElseIf i = 25 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 5 Swords"
            End If
            lblDirection.Text = "5 of Swords, in the Fortune pile, adds 5 Fortune that must be discarded to spend."
        ElseIf i = 26 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 6 Swords"
            End If
            lblDirection.Text = "6 of Swords, in the Fortune pile, adds 6 Fortune that must be discarded to spend."
        ElseIf i = 27 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 7 Swords"
            End If
            lblDirection.Text = "7 of Swords, in the Fortune pile, adds 7 Fortune that must be discarded to spend."
        ElseIf i = 28 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 8 Swords"
            End If
            lblDirection.Text = "8 of Swords, in the Fortune pile, adds 8 Fortune that must be discarded to spend."
        ElseIf i = 29 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 9 Swords"
            End If
            lblDirection.Text = "9 of Swords, in the Fortune pile, adds 9 Fortune that must be discarded to spend."
        ElseIf i = 30 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 10 Swords"
            End If
            lblDirection.Text = "10 of Swords, in the Fortune pile, adds 10 Fortune that must be discarded to spend."
        ElseIf i = 31 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play A Wands"
            End If
            lblDirection.Text = "The Ace of Wands, representing the Hand of God and one facet of Divine Provedence.  In the Fortune pile, adds 3 Static Fortune that doesn't have to be spent to use. Collect all four Aces to win the game."
        ElseIf i = 32 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 2 Wands"
            End If
            lblDirection.Text = "2 of Wands, in the Fortune pile, adds 2 Fortune that must be discarded to spend."
        ElseIf i = 33 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 3 Wands"
            End If
            lblDirection.Text = "3 of Wands, in the Fortune pile, adds 3 Fortune that must be discarded to spend."
        ElseIf i = 34 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 4 Wands"
            End If
            lblDirection.Text = "4 of Wands, in the Fortune pile, adds 4 Fortune that must be discarded to spend."
        ElseIf i = 35 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 5 Wands"
            End If
            lblDirection.Text = "5 of Wands, in the Fortune pile, adds 5 Fortune that must be discarded to spend."
        ElseIf i = 36 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 6 Wands"
            End If
            lblDirection.Text = "6 of Wands, in the Fortune pile, adds 6 Fortune that must be discarded to spend."
        ElseIf i = 37 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 7 Wands"
            End If
            lblDirection.Text = "7 of Wands, in the Fortune pile, adds 7 Fortune that must be discarded to spend."
        ElseIf i = 38 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 8 Wands"
            End If
            lblDirection.Text = "8 of Wands, in the Fortune pile, adds 8 Fortune that must be discarded to spend."
        ElseIf i = 39 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 9 Wands"
            End If
            lblDirection.Text = "9 of Wands, in the Fortune pile, adds 9 Fortune that must be discarded to spend."
        ElseIf i = 40 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play 10 Wands"
            End If
            lblDirection.Text = "10 of Wands, in the Fortune pile, adds 10 Fortune that must be discarded to spend."
        ElseIf i = 41 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Page Cups"
            End If
            lblDirection.Text = "The Page of Cups, a member of a disgraced House.  Once per turn, you may exile one Noble from House Cups or Pentacles from the game to draw 2 cards."
        ElseIf i = 42 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Knight Cups"
            End If
            lblDirection.Text = "The Knight of Cups, a member of a disgraced House.  Once per turn, you may exile one Noble from House Cups or Pentacles from the game to draw 2 cards."
        ElseIf i = 43 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Queen Cups"
            End If
            lblDirection.Text = "The Queen of Cups, a member of a disgraced House.  Once per turn, you may exile one Noble from House Cups or Pentacles from the game to draw 2 cards."
        ElseIf i = 44 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play King Cups"
            End If
            lblDirection.Text = "The King of Cups, a member of a disgraced House.  Once per turn, you may exile one Noble from House Cups or Pentacles from the game to draw 2 cards."
        ElseIf i = 45 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Page Pentacles"
            End If
            lblDirection.Text = "The Page of Pentacles, a member of a disgraced House.  Once per turn, you may exile one Noble from House Cups or Pentacles from the game to draw 2 cards."
        ElseIf i = 46 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Knight Pentacles"
            End If
            lblDirection.Text = "The Knight of Pentacles, a member of a disgraced House.  Once per turn, you may exile one Noble from House Cups or Pentacles from the game to draw 2 cards."
        ElseIf i = 47 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Queen Pentacles"
            End If
            lblDirection.Text = "The Queen of Pentacles, a member of a disgraced House.  Once per turn, you may exile one Noble from House Cups or Pentacles from the game to draw 2 cards."
        ElseIf i = 48 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play King Pentacles"
            End If
            lblDirection.Text = "The King of Pentacles, a member of a disgraced House.  Once per turn, you may exile one Noble from House Cups or Pentacles from the game to draw 2 cards."
        ElseIf i = 49 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Page Swords"
            End If
            If Brain.bolTurn = 0 Then
                lblDirection.Text = "The Page of Swords, a member of your Court. In the Court pile, adds 1 card to your Hand Size.  Assemble all 4 your court to win the game."
            Else
                lblDirection.Text = "The Page of Swords, a member of your rival's Court. In the Hostage pile, adds 2 Static Fortune that doesn't have to be spent to use."
            End If
        ElseIf i = 50 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Knight Swords"
            End If
            If Brain.bolTurn = 0 Then
                lblDirection.Text = "The Knight of Swords, a member of your Court. In the Court pile, adds 1 card to your Hand Size.  Assemble all 4 your court to win the game."
            Else
                lblDirection.Text = "The Knight of Swords, a member of your rival's Court. In the Hostage pile, adds 2 Static Fortune that doesn't have to be spent to use."
            End If
        ElseIf i = 51 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Queen Swords"
            End If
            lblDirection.Text = "qs"
            If Brain.bolTurn = 0 Then
                lblDirection.Text = "The Queen of Swords, a member of your Court. In the Court pile, adds 1 card to your Hand Size.  Assemble all 4 your court to win the game."
            Else
                lblDirection.Text = "The Queen of Swords, a member of your rival's Court. In the Hostage pile, adds 2 Static Fortune that doesn't have to be spent to use."
            End If
        ElseIf i = 52 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Page Wands"
            End If
            If Brain.bolTurn = 1 Then
                lblDirection.Text = "The Page of Wands, a member of your Court. In the Court pile, adds 1 card to your Hand Size.  Assemble all 4 your court to win the game."
            Else
                lblDirection.Text = "The Page of Wands, a member of your rival's Court. In the Hostage pile, adds 2 Static Fortune that doesn't have to be spent to use."
            End If
        ElseIf i = 53 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Knight Wands"
            End If
            If Brain.bolTurn = 1 Then
                lblDirection.Text = "The Knight of Wands, a member of your Court. In the Court pile, adds 1 card to your Hand Size.  Assemble all 4 your court to win the game."
            Else
                lblDirection.Text = "The Knight of Wands, a member of your rival's Court. In the Hostage pile, adds 2 Static Fortune that doesn't have to be spent to use."
            End If
        ElseIf i = 54 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Queen Wands"
            End If
            If Brain.bolTurn = 1 Then
                lblDirection.Text = "The Queen of Wands, a member of your Court. In the Court pile, adds 1 card to your Hand Size.  Assemble all 4 your court to win the game."
            Else
                lblDirection.Text = "The Queen of Wands, a member of your rival's Court. In the Hostage pile, adds 2 Static Fortune that doesn't have to be spent to use."
            End If
        ElseIf i = 55 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Fool"
            End If
            lblDirection.Text = "The Fool: When The Fool reaches the present, you may discard any Major Arcana in play and replace it with The Fool"
        ElseIf i = 56 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Magician"
            End If
            lblDirection.Text = "The Magician: When The Magician reaches the present, look at your rival's hand and discard one card of your choice."
        ElseIf i = 57 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The High Priestess"
            End If
            lblDirection.Text = "The High Priestess: When The High Priestess is played in the Distant Future, Choose 1 card on your rival's Wheel and turn it face down."
        ElseIf i = 58 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Empress"
            End If
            lblDirection.Text = "The Empress: When The Empress reaches the present, draw 1 card.  You may play 1 Hostage from your hand to your Hostage Pile, or 1 Court to your Court Pile, or exile one Noble of House Cups or House Pentacles to draw 2 cards. You may also play 1 Fortune card from your hand to your Fortune Pile. "
        ElseIf i = 59 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "The Emperor"
            End If
            lblDirection.Text = "The Emperor: When The Emperor reaches the present, choose 1 Court card in your rival's Court Pile or 1 Hostage card in your rival's Hostage Pile and discard it. You may also choose 1 Fortune card in your rival's Fortune Pile and discard it."
        ElseIf i = 60 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Hierophant"
            End If
            lblDirection.Text = "The Hierophant: When The Hierophant reaches the present, choose 1 Fortune card in your rival's Fortune Pile and place it in your Fortune Pile"
        ElseIf i = 61 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play he Lovers"
            End If
            lblDirection.Text = "The Lovers: When The Lovers reach the present, choose 1 Court card in your rival's Court Pile and place it in your Hostage Pile or 1 Hostage card in your rival's Hostage Pile and and place it in your Court Pile"
        ElseIf i = 62 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Chariot"
            End If
            lblDirection.Text = "The Chariot: When The Chariot reaches the present, draw 2 cards.  You may play up to 3 cards in your hand to your Fortune Pile"
        ElseIf i = 63 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Strength"
            End If
            lblDirection.Text = "Strength: When Strength reaches the present, discard the deck.  Choose any Major Arcana card with Fate Value less than 15 and place it in your hand."
        ElseIf i = 64 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Hermit"
            End If
            lblDirection.Text = "The Hermit: When The Hermit reaches the present, choose any card in play and discard it."
        ElseIf i = 65 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Wheel of Fortune"
            End If
            lblDirection.Text = "Wheel of Fortune: When The Wheel of Fortune reaches the present, Draw a card and immediately resolve it."
        ElseIf i = 66 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Justice"
            End If
            lblDirection.Text = "Justice: When Justice reaches the present, choose any Major Arcana card in your rival's Fate pile and resolve it."
        ElseIf i = 67 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "The Hanged Man"
            End If
            lblDirection.Text = "The Hanged Man: While the Hanged Man is in the Near Future, Present, or Recent Past no cards may resolve."
        ElseIf i = 68 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Death"
            End If
            lblDirection.Text = "Death: When The Death reaches the present, discard all cards in either your rival's Court Pile or Hostage Pile."
        ElseIf i = 69 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Temperance"
            End If
            lblDirection.Text = "Temperance: When Temperance reaches the present, discard all cards in your rival's Fortune Pile"
        ElseIf i = 70 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Devil"
            End If
            lblDirection.Text = "The Devil: When The Devil reaches the present, Choose any Major Arcana card in play and resolve it. Then your rival may place The Devil in thier Fate Pile."
        ElseIf i = 71 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Tower"
            End If
            lblDirection.Text = "The Tower: When The Tower reaches the present, Choose 1 Noble in your rival's Court or Hostage Pile, 1 Fortune card in your rival's Fortune Pile and 1 Major Arcana card in your rival's Fate pile and discard them."
        ElseIf i = 72 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Star"
            End If
            lblDirection.Text = "The Star: When The Star reaches the present, discard the deck.  Choose any Major Arcana card with Fate Value less than 17 or any Fortune or Noble card and place it in the Distant Future."
        ElseIf i = 73 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Moon"
            End If
            lblDirection.Text = "The Moon: When you play Te Moon into the Distant Future, draw a card and place any card in your hand under The Moon.  When The Moon reaches the present, reveal the hidden cand and resolve it.  If it is a Major Arcana card you must choose to discard it or The Moon."
        ElseIf i = 74 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The Sun"
            End If
            lblDirection.Text = "The Sun: When The Sun reaches the present, place it in your Fate pile.  Take another turn after this one."
        ElseIf i = 75 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play Judgment"
            End If
            lblDirection.Text = "Judgment: When Judgment reaches the present, you rival reveals thier hand.  Choose any 2 card in play or in your rival's hand and discard them."
        ElseIf i = 76 Then
            If Brain.bolPlayACard = True Then
                btnAction1.Text = "Play The World"
            End If
            lblDirection.Text = "The World: When The World reaches the Fate Pile the game ends.  The player with the highest accumulated Fate wins."

        End If



    End Sub
End Class
