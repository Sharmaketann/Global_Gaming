<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlayerEntryInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndiviualPlayerListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamApplicationListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TournamentGamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MobileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndoorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutdoorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.ScoreboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MobileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndoorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutdoorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.picClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 27)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(507, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "GLOBAL GAMING TOURNAMENT MANAGEMENT SYSTEM"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayerEntryInformationToolStripMenuItem, Me.TournamentGamesToolStripMenuItem, Me.ScoreboardToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 27)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 26)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlayerEntryInformationToolStripMenuItem
        '
        Me.PlayerEntryInformationToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PlayerEntryInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.IndiviualPlayerListToolStripMenuItem, Me.TeamApplicationListToolStripMenuItem, Me.SearchListToolStripMenuItem})
        Me.PlayerEntryInformationToolStripMenuItem.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerEntryInformationToolStripMenuItem.Name = "PlayerEntryInformationToolStripMenuItem"
        Me.PlayerEntryInformationToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PlayerEntryInformationToolStripMenuItem.Text = "Player Entry Information"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'IndiviualPlayerListToolStripMenuItem
        '
        Me.IndiviualPlayerListToolStripMenuItem.Name = "IndiviualPlayerListToolStripMenuItem"
        Me.IndiviualPlayerListToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.IndiviualPlayerListToolStripMenuItem.Text = "Indiviual Player List"
        '
        'TeamApplicationListToolStripMenuItem
        '
        Me.TeamApplicationListToolStripMenuItem.Name = "TeamApplicationListToolStripMenuItem"
        Me.TeamApplicationListToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.TeamApplicationListToolStripMenuItem.Text = "Team Application List"
        '
        'SearchListToolStripMenuItem
        '
        Me.SearchListToolStripMenuItem.Name = "SearchListToolStripMenuItem"
        Me.SearchListToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.SearchListToolStripMenuItem.Text = "Search List"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 661)
        Me.Panel2.TabIndex = 4
        '
        'TournamentGamesToolStripMenuItem
        '
        Me.TournamentGamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesktopToolStripMenuItem, Me.MobileToolStripMenuItem, Me.IndoorToolStripMenuItem, Me.OutdoorToolStripMenuItem})
        Me.TournamentGamesToolStripMenuItem.Name = "TournamentGamesToolStripMenuItem"
        Me.TournamentGamesToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TournamentGamesToolStripMenuItem.Text = "Tournament Games"
        '
        'DesktopToolStripMenuItem
        '
        Me.DesktopToolStripMenuItem.Name = "DesktopToolStripMenuItem"
        Me.DesktopToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DesktopToolStripMenuItem.Text = "Desktop"
        '
        'MobileToolStripMenuItem
        '
        Me.MobileToolStripMenuItem.Name = "MobileToolStripMenuItem"
        Me.MobileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MobileToolStripMenuItem.Text = "Mobile"
        '
        'IndoorToolStripMenuItem
        '
        Me.IndoorToolStripMenuItem.Name = "IndoorToolStripMenuItem"
        Me.IndoorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IndoorToolStripMenuItem.Text = "Indoor"
        '
        'OutdoorToolStripMenuItem
        '
        Me.OutdoorToolStripMenuItem.Name = "OutdoorToolStripMenuItem"
        Me.OutdoorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OutdoorToolStripMenuItem.Text = "Outdoor"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(52, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(28, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Location = New System.Drawing.Point(4, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(18, 18)
        Me.picClose.TabIndex = 16
        Me.picClose.TabStop = False
        '
        'ScoreboardToolStripMenuItem
        '
        Me.ScoreboardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesktopToolStripMenuItem1, Me.MobileToolStripMenuItem1, Me.IndoorToolStripMenuItem1, Me.OutdoorToolStripMenuItem1})
        Me.ScoreboardToolStripMenuItem.Name = "ScoreboardToolStripMenuItem"
        Me.ScoreboardToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ScoreboardToolStripMenuItem.Text = "Scoreboard"
        '
        'DesktopToolStripMenuItem1
        '
        Me.DesktopToolStripMenuItem1.Name = "DesktopToolStripMenuItem1"
        Me.DesktopToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DesktopToolStripMenuItem1.Text = "Desktop"
        '
        'MobileToolStripMenuItem1
        '
        Me.MobileToolStripMenuItem1.Name = "MobileToolStripMenuItem1"
        Me.MobileToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.MobileToolStripMenuItem1.Text = "Mobile"
        '
        'IndoorToolStripMenuItem1
        '
        Me.IndoorToolStripMenuItem1.Name = "IndoorToolStripMenuItem1"
        Me.IndoorToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.IndoorToolStripMenuItem1.Text = "Indoor"
        '
        'OutdoorToolStripMenuItem1
        '
        Me.OutdoorToolStripMenuItem1.Name = "OutdoorToolStripMenuItem1"
        Me.OutdoorToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.OutdoorToolStripMenuItem1.Text = "Outdoor"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 714)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PlayerEntryInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IndiviualPlayerListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeamApplicationListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TournamentGamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MobileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndoorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutdoorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScoreboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MobileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IndoorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OutdoorToolStripMenuItem1 As ToolStripMenuItem
End Class
