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
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
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

    End Sub

    Private Sub DataReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataReportToolStripMenuItem.Click
        Playerreport.TopLevel = False
        Playerreport.TopMost = True
        Panel2.Controls.Add(Playerreport)
        Playerreport.Show()
    End Sub
End Class