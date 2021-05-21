'Packages Imported
Imports System.Data.SqlClient
Imports System.IO
Public Class Player

    ' Variables declared for SqlConnection
    Dim connection As New SqlConnection
    Dim command As New SqlCommand
    Dim dataadapter As New SqlDataAdapter
    Dim dataset As New DataSet
    Dim datareader As SqlDataReader

    Private Sub Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ComboBox items added.
        Panel2.Visible = False
        Panel3.Visible = False
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Desktop")
        ComboBox1.Items.Add("Mobile")
        ComboBox1.Items.Add("Indoor")
        ComboBox1.Items.Add("Outdoor")

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Panel2.Visible = True
            Panel3.Visible = False
            TextBox1.Focus()
            CheckBox2.Checked = False
        Else
            Panel2.Visible = False
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        ' Display specific items when selected ComboBox
        If ComboBox1.SelectedItem = "Desktop" Then
            ComboBox2.Items.Add("Dota 2")
            ComboBox2.Items.Add("CS:GO")
        ElseIf ComboBox1.SelectedItem = "Mobile" Then
            ComboBox2.Items.Add("Injustice 2")
            ComboBox2.Items.Add("PuBG")
        ElseIf ComboBox1.SelectedItem = "Indoor" Then
            ComboBox2.Items.Add("Chess")
            ComboBox2.Items.Add("Carrom")
        ElseIf ComboBox1.SelectedItem = "Outdoor" Then
            ComboBox2.Items.Add("Football")
            ComboBox2.Items.Add("Baskteball")
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        'Clear all the data from all the textbox and combobox and focus to the first textbox.
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        PictureBox1.Image = Nothing
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Get user input of th image in the PictureBox
        OpenFileDialog1.ShowDialog()
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Panel2.Visible = False
            Panel3.Visible = True
            CheckBox1.Checked = False
            TextBox7.Focus()
        Else
            Panel3.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Get user input of the image in the PictureBox
        OpenFileDialog1.ShowDialog()
        PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        PictureBox2.Image = Nothing
        TextBox7.Focus()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox4.Items.Clear()
        If ComboBox3.SelectedItem = "Desktop" Then
            ComboBox4.Items.Add("Dota 2")
            ComboBox4.Items.Add("CS:GO")
        ElseIf ComboBox3.SelectedItem = "Mobile" Then
            ComboBox4.Items.Add("Injustice 2")
            ComboBox4.Items.Add("PuBG")
        ElseIf ComboBox3.SelectedItem = "Indoor" Then
            ComboBox4.Items.Add("Chess ")
            ComboBox4.Items.Add("Carrom")
        ElseIf ComboBox3.SelectedItem = "Outdoor" Then
            ComboBox4.Items.Add("Football")
            ComboBox4.Items.Add("Basketball")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Sql connection
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("insert into Individual(ID, Name, GName,College, City, Email, GType, Game, Image) values(@playerid,@playername,@gamename,@college,@city,@emailid,@gametype,@game,@image)", connection)
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        'Insert the data in the database from the form
        command.Parameters.Add("@playerid", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@playername", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@gamename", SqlDbType.VarChar).Value = TextBox3.Text
        command.Parameters.Add("@college", SqlDbType.VarChar).Value = TextBox4.Text
        command.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox5.Text
        command.Parameters.Add("@emailid", SqlDbType.VarChar).Value = TextBox6.Text
        command.Parameters.Add("@gametype", SqlDbType.VarChar).Value = ComboBox1.Text
        command.Parameters.Add("@game", SqlDbType.VarChar).Value = ComboBox2.Text
        command.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()
        command.ExecuteNonQuery()
        MsgBox("Successful")
        connection.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        Dim strsql As String
        strsql = "select * from Individual where ID = " + TextBox1.Text + ""
        command = New SqlCommand(strsql, connection)
        datareader = command.ExecuteReader
        datareader.Read()
        'Read all the data from the database and show it in the textbox
        TextBox2.Text = datareader("Name")
        TextBox3.Text = datareader("GName")
        TextBox4.Text = datareader("College")
        TextBox5.Text = datareader("City")
        TextBox6.Text = datareader("Email")
        ComboBox1.Text = datareader("GType")
        ComboBox2.Text = datareader("Game")
        connection.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Sql connection
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("insert into Teaminfo(ID, Name, Coach,College, City, Email, GType, Game, Image) values(@teamid,@teamname,@coachname,@college,@city,@emailid,@gametype,@game,@image)", connection)
        Dim ms As New MemoryStream
        PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
        'Insert the data in the database from the form
        command.Parameters.Add("@teamid", SqlDbType.VarChar).Value = TextBox7.Text
        command.Parameters.Add("@teamname", SqlDbType.VarChar).Value = TextBox8.Text
        command.Parameters.Add("@coachname", SqlDbType.VarChar).Value = TextBox9.Text
        command.Parameters.Add("@college", SqlDbType.VarChar).Value = TextBox10.Text
        command.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox11.Text
        command.Parameters.Add("@emailid", SqlDbType.VarChar).Value = TextBox12.Text
        command.Parameters.Add("@gametype", SqlDbType.VarChar).Value = ComboBox3.Text
        command.Parameters.Add("@game", SqlDbType.VarChar).Value = ComboBox4.Text
        command.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()
        command.ExecuteNonQuery()
        MsgBox("Successful")
        connection.Close()
    End Sub
End Class