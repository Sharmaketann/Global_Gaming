Imports System.Data.SqlClient

Public Class Teamscoreboard
    Dim connection As New SqlConnection
    Dim command As New SqlCommand
    Dim dataadapter As SqlDataAdapter
    Dim dataset As DataSet
    Dim datareader As SqlDataReader


    Private Sub Desktopscoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("insert into TeamScoreboard values(" + ComboBox1.Text + ",'" + ComboBox2.Text + "','" + TextBox1.Text + "'," + TextBox2.Text + "," + TextBox3.Text + "," + TextBox4.Text + "," + TextBox5.Text + "," + TextBox6.Text + ")", connection)
        command.ExecuteNonQuery()
        MsgBox("Records Saved")
        connection.Close()
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        command = New SqlCommand("select ID,Name from Teaminfo", connection)
        datareader = command.ExecuteReader
        While datareader.Read
            ComboBox1.Items.Add(datareader("ID").ToString())
            ComboBox2.Items.Add(datareader("Name").ToString())
        End While
        connection.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmb As String
        cmb = ComboBox1.Text
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("select Name from Teaminfo where ID = '" + cmb + "'", connection)
        datareader = command.ExecuteReader
        While datareader.Read
            ComboBox2.Text = (datareader("Name").ToString())
        End While
        connection.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        TextBox5.Text = TextBox2.Text * 2
        TextBox6.Text = TextBox2.Text * 5
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As String
        x = InputBox("Enter Team Id to delete the record")
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("delete from TeamScoreboard where ID = " + x + "", connection)
        command.ExecuteNonQuery()
        MsgBox("Records Deleted")
        connection.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("select * from TeamScoreboard where ID =" + ComboBox1.Text + "", connection)
        Dim datareader As SqlDataReader
        datareader = command.ExecuteReader
        datareader.Read()
        Try
            TextBox1.Text = datareader("Games")
            TextBox2.Text = datareader("Wins")
            TextBox3.Text = datareader("Draw")
            TextBox4.Text = datareader("Losses")
            TextBox5.Text = datareader("Score")
            TextBox6.Text = datareader("Points")
            connection.Close()
        Catch dr As Exception
            MsgBox("Record not found")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim u As String
        u = ComboBox1.Text
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("update TeamScoreboard set ID = " + ComboBox1.Text + ",Name = '" + ComboBox2.Text + "',Games = " + TextBox1.Text + ",Wins =" + TextBox2.Text + ",Draw = " + TextBox3.Text + ",Losses = " + TextBox4.Text + ",Score =" + TextBox5.Text + ",Points = " + TextBox6.Text + "where ID = " + u + "", connection)
        command.ExecuteNonQuery()
        MsgBox("Records Updated", MsgBoxStyle.Information)
        connection.Close()
    End Sub
End Class