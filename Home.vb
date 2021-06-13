Public Class Home
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        Me.WindowState = WindowState.Minimized
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        If Me.WindowState = WindowState.Normal Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
            Me.WindowState = WindowState.Maximized
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        ElseIf Me.WindowState = WindowState.Maximized Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
            Me.WindowState = WindowState.Normal
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        End If
    End Sub

    Private Sub PlayerEntryInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayerEntryInformationToolStripMenuItem.Click
        IndividualList.Hide()
        IndividualScoreboard.Hide()
        Intercolliegate.Hide()
        Player.Hide()
        Desktop.Hide()
        Playerreport.Hide()
        SearchList.Hide()
        TeamList.Hide()
        Teamreport.Hide()
        Teamscoreboard.Hide()
        Teamreport.Hide()
        Playerreport.Hide()
        Payments.Hide()
        Paymentreport.Hide()
        Panel2.Show()
        PictureBox3.Visible = True
        Panel7.Visible = True
        Label13.Visible = True
        Label16.Visible = True
        Panel8.Visible = True
    End Sub

    'Individual Player Search Section

    Private Sub IndiviualPlayerListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndiviualPlayerListToolStripMenuItem.Click
        'Show the other form inside the panel of the MDI Form
        IndividualList.TopLevel = False
        IndividualList.TopMost = True
        Panel2.Controls.Add(IndividualList)
        IndividualList.Show()
        Player.Hide()
        Desktop.Hide()
        Intercolliegate.Hide()
        SearchList.Hide()
        TeamList.Hide()
        Payments.Hide()
        Paymentreport.Hide()
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

    'Team Applicatoin Player Search Section.

    Private Sub TeamApplicationListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeamApplicationListToolStripMenuItem.Click
        TeamList.TopLevel = False
        TeamList.TopMost = True
        Panel2.Controls.Add(TeamList)
        TeamList.Show()
        Player.Hide()
        Desktop.Hide()
        IndividualList.Hide()
        SearchList.Hide()
        Intercolliegate.Hide()
        Paymentreport.Hide()
        Payments.Hide()
        PictureBox3.Visible = False
        Panel7.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
        Panel8.Visible = False
    End Sub

    'Individual Player and Team Application Registration Section

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        'Show the other form inside the panel of the MDI Form
        Player.TopLevel = False
        Player.TopMost = True
        Panel2.Controls.Add(Player)
        Player.Show()
        IndividualList.Hide()
        Desktop.Hide()
        Teamscoreboard.Hide()
        Intercolliegate.Hide()
        SearchList.Hide()
        Payments.Hide()
        Paymentreport.Hide()
        PictureBox3.Visible = False
        Panel7.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
        Panel8.Visible = False
    End Sub

    'Search List based on GamesType and College.

    Private Sub SearchListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchListToolStripMenuItem.Click
        SearchList.TopLevel = False
        SearchList.TopMost = True
        Panel2.Controls.Add(SearchList)
        SearchList.Show()
        IndividualList.Hide()
        TeamList.Hide()
        Player.Hide()
        Desktop.Hide()
        Intercolliegate.Hide()
        Paymentreport.Hide()
        Payments.Hide()
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

    'Tournament Entry Games Detail Section 

    Private Sub DesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesktopToolStripMenuItem.Click
        Desktop.TopLevel = False
        Desktop.TopMost = True
        Panel2.Controls.Add(Desktop)
        Desktop.Show()
        SearchList.Hide()
        IndividualList.Hide()
        Player.Hide()
        TeamList.Hide()
        Payments.Hide()
        Paymentreport.Hide()
        PictureBox3.Visible = False
        Panel7.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
    End Sub


    'View Tournament Section

    Private Sub IntercolliegateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercolliegateToolStripMenuItem.Click
        Intercolliegate.TopLevel = False
        Intercolliegate.TopMost = True
        Panel2.Controls.Add(Intercolliegate)
        Intercolliegate.Show()
        Desktop.Hide()
        Player.Hide()
        TeamList.Hide()
        SearchList.Hide()
        Teamscoreboard.Hide()
        Paymentreport.Hide()
        Payments.Hide()
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

    'Scoreboard Team Score Section

    Private Sub TeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeamToolStripMenuItem.Click
        Teamscoreboard.TopLevel = False
        Teamscoreboard.TopMost = True
        Panel2.Controls.Add(Teamscoreboard)
        Teamscoreboard.Show()
        Desktop.Hide()
        IndividualList.Hide()
        Player.Hide()
        TeamList.Hide()
        SearchList.Hide()
        Intercolliegate.Hide()
        IndividualScoreboard.Hide()
        Payments.Hide()
        Paymentreport.Hide()
        PictureBox3.Visible = False
        Panel7.Visible = False
        Panel8.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
        Label13.Hide()
        Label16.Hide()
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    'Scoreboard Individual Score Section

    Private Sub IndividualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndividualToolStripMenuItem.Click
        IndividualScoreboard.TopLevel = False
        IndividualScoreboard.TopMost = True
        Panel2.Controls.Add(IndividualScoreboard)
        IndividualScoreboard.Show()
        Teamscoreboard.Hide()
        Desktop.Hide()
        IndividualList.Hide()
        TeamList.Hide()
        SearchList.Hide()
        Player.Hide()
        Intercolliegate.Hide()
        IndividualStanding.Hide()
        PictureBox3.Visible = False
        Panel7.Visible = False
        Panel8.Visible = False
        Label13.Hide()
        Label16.Hide()
        Timer2.Stop()
        Timer1.Stop()
    End Sub

    'DataReport Individual Report Section
    Private Sub IndividualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IndividualToolStripMenuItem1.Click
        Playerreport.TopLevel = False
        Playerreport.TopMost = True
        Panel2.Controls.Add(Playerreport)
        Playerreport.Show()
        Teamreport.Hide()
        PictureBox3.Visible = False
        Panel7.Hide()
        Label13.Visible = False
        Label16.Visible = False
        Panel8.Visible = False
        Timer1.Stop()
    End Sub

    'DataReport Team Report Section
    Private Sub TeamToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TeamToolStripMenuItem1.Click
        Teamreport.TopLevel = False
        Teamreport.TopMost = True
        Panel2.Controls.Add(Teamreport)
        Teamreport.Show()
        Playerreport.Hide()
        PictureBox3.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
        Panel7.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        PictureBox3.Visible = True
        Panel7.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        IndividualList.Hide()
        IndividualScoreboard.Hide()
        Intercolliegate.Hide()
        Player.Hide()
        Desktop.Hide()
        Playerreport.Hide()
        SearchList.Hide()
        TeamList.Hide()
        Teamreport.Hide()
        Teamscoreboard.Hide()
        Scoreboardreport.Hide()
        Panel2.Show()
        PictureBox3.Visible = True
        Panel7.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayerEntryInformationToolStripMenuItem.DropDown.Show()
        Me.PlayerEntryInformationToolStripMenuItem.DropDown.Location = New System.Drawing.Point(4, 3)
        Panel3.Show()
        Timer1.Stop()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TournamentGamesToolStripMenuItem.DropDown.Show()
        Me.TournamentGamesToolStripMenuItem.DropDown.Location = New System.Drawing.Point(186, 3)
        Panel3.Hide()
        Panel4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ScoreboardToolStripMenuItem.DropDown.Show()
        Me.ScoreboardToolStripMenuItem.DropDown.Location = New System.Drawing.Point(322, 3)
        Panel4.Hide()
        Panel5.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TournamentEntryToolStripMenuItem.DropDown.Show()
        Me.TournamentEntryToolStripMenuItem.DropDown.Location = New System.Drawing.Point(444, 3)
        Panel5.Hide()
        Panel6.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel6.Hide()
        Timer1.Start()
    End Sub

    Private Sub ScoreBoardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ScoreBoardToolStripMenuItem1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel7.Visible = True Then
            Panel7.Visible = False
        Else
            Panel7.Visible = True
        End If

    End Sub


    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        Panel7.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label13.Text = Date.Now.ToString("dd-MMM-yyyy")
        Label16.Text = Date.Now.ToString("H:mm:ss")
    End Sub

    Private Sub TournamentGamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TournamentGamesToolStripMenuItem.Click

    End Sub

    'Scoreboard/ Individual Scoreboard Section

    Private Sub IndividualToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles IndividualToolStripMenuItem2.Click
        Scoreboardreport.TopLevel = False
        Scoreboardreport.TopMost = True
        Panel2.Controls.Add(Scoreboardreport)
        Scoreboardreport.Show()
        PictureBox3.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
        Teamscoreboard.Hide()
        Teamreport.Hide()
        TeamList.Hide()
        SearchList.Hide()
        Playerreport.Hide()
        Player.Hide()
        Intercolliegate.Hide()
        IndividualScoreboard.Hide()
        IndividualList.Hide()
        Desktop.Hide()
        Payments.Hide()
        Paymentreport.Hide()
    End Sub

    'Placement Individual Standing Section

    Private Sub IndividualToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles IndividualToolStripMenuItem3.Click
        IndividualStanding.TopLevel = False
        IndividualStanding.TopMost = True
        Panel2.Controls.Add(IndividualStanding)
        IndividualStanding.Show()
        PictureBox3.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
        Panel7.Hide()
        Panel8.Hide()
        Desktop.Hide()
        IndividualList.Hide()
        IndividualScoreboard.Hide()
        Intercolliegate.Hide()
        Player.Hide()
        Playerreport.Hide()
        Scoreboardreport.Hide()
        SearchList.Hide()
        TeamList.Hide()
        Teamreport.Hide()
        Teamscoreboard.Hide()
        TeamStanding.Hide()
        Payments.Hide()
        Paymentreport.Hide()
    End Sub

    'Placement Team Standing Section

    Private Sub TeamToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles TeamToolStripMenuItem3.Click
        TeamStanding.TopLevel = False
        TeamStanding.TopMost = True
        Panel2.Controls.Add(TeamStanding)
        TeamStanding.Show()
        PictureBox3.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
        Panel7.Hide()
        Panel8.Hide()
        Desktop.Hide()
        IndividualList.Hide()
        IndividualScoreboard.Hide()
        Intercolliegate.Hide()
        Player.Hide()
        Playerreport.Hide()
        Scoreboardreport.Hide()
        SearchList.Hide()
        TeamList.Hide()
        Teamreport.Hide()
        Teamscoreboard.Hide()
        IndividualStanding.Hide()
        Payments.Hide()
        Paymentreport.Hide()
    End Sub

    'Individual Payment Section

    Private Sub IndividualToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles IndividualToolStripMenuItem4.Click
        Payments.TopLevel = False
        Payments.TopMost = True
        Panel2.Controls.Add(Payments)
        Payments.Show()
        PictureBox3.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
        Panel7.Hide()
        Panel8.Hide()
        Desktop.Hide()
        IndividualList.Hide()
        IndividualScoreboard.Hide()
        Intercolliegate.Hide()
        Player.Hide()
        Playerreport.Hide()
        Scoreboardreport.Hide()
        SearchList.Hide()
        TeamList.Hide()
        Teamreport.Hide()
        Teamscoreboard.Hide()
        IndividualStanding.Hide()
        TeamStanding.Hide()
        Paymentreport.Hide()
    End Sub

    'Scoreboard Team Scoreboard Section

    Private Sub TeamToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TeamToolStripMenuItem2.Click

    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        Paymentreport.TopLevel = "False"
        Paymentreport.TopMost = "true"
        Panel2.Controls.Add(Paymentreport)
        Paymentreport.Show()
        Payments.Hide()
        PictureBox3.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
        Panel7.Hide()
        Panel8.Hide()
        Desktop.Hide()
        IndividualList.Hide()
        IndividualScoreboard.Hide()
        Intercolliegate.Hide()
        Player.Hide()
        Playerreport.Hide()
        Scoreboardreport.Hide()
        SearchList.Hide()
        TeamList.Hide()
        Teamreport.Hide()
        Teamscoreboard.Hide()
        IndividualStanding.Hide()
        TeamStanding.Hide()
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentsToolStripMenuItem.Click

    End Sub
End Class