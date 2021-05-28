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
        Panel2.Show()
        PictureBox3.Visible = True
        Panel7.Visible = True
    End Sub

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
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

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
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

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
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

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
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub DesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesktopToolStripMenuItem.Click
        Desktop.TopLevel = False
        Desktop.TopMost = True
        Panel2.Controls.Add(Desktop)
        Desktop.Show()
        SearchList.Hide()
        IndividualList.Hide()
        Player.Hide()
        TeamList.Hide()
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub





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
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

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
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

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
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub IndividualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IndividualToolStripMenuItem1.Click
        Playerreport.TopLevel = False
        Playerreport.TopMost = True
        Panel2.Controls.Add(Playerreport)
        Playerreport.Show()
        Teamreport.Hide()
        PictureBox3.Visible = False
        Panel7.Visible = False
    End Sub

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
        Panel2.Show()
        PictureBox3.Visible = True
        Panel7.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Show()
        Timer1.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel3.Hide()
        Panel4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel4.Hide()
        Panel5.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel5.Hide()
        Panel6.show
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel6.Hide()
        Timer1.Start()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ScoreBoardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ScoreBoardToolStripMenuItem1.Click
        PictureBox3.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Button1.Visible = False
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


End Class