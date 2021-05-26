Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class SearchList
    Dim con As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
    Private Sub Combo1()

        con.Open()
        Dim strsql As New SqlCommand("select distinct GType from Individual", con)

        Dim myreader As SqlClient.SqlDataReader = strsql.ExecuteReader

        ComboBox1.Items.Clear()
        While myreader.Read()

            ComboBox1.Items.Add(myreader("GType"))
        End While

        con.Close()
    End Sub

    Private Sub Display()
        con.Open()
        Dim cmd1 As New SqlCommand("select ID,Name, Game, College from Individual where GType like '%" + ComboBox1.Text + "%'", con)
        Dim da1 As New SqlDataAdapter
        Dim dt1 As New DataTable

        da1.SelectCommand = cmd1

        dt1.Clear()

        da1.Fill(dt1)

        DataGridView1.DataSource = dt1

        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Display()
    End Sub

    Private Sub SearchList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Combo1()
        Display()
        Display1()
        Combo2()
    End Sub

    Private Sub Display1()
        con.Open()
        Dim cmd2 As New SqlCommand("select ID,Name, Game, College from Individual where College like '%" + ComboBox2.Text + "%'", con)
        Dim da2 As New SqlDataAdapter
        Dim dt2 As New DataTable

        da2.SelectCommand = cmd2
        dt2.Clear()
        da2.Fill(dt2)
        DataGridView1.DataSource = dt2
        con.Close()

    End Sub

    Private Sub Combo2()
        con.Open()
        Dim strsql As New SqlCommand("select distinct College from Individual", con)

        Dim myreader As SqlClient.SqlDataReader = strsql.ExecuteReader

        ComboBox2.Items.Clear()
        While myreader.Read()

            ComboBox2.Items.Add(myreader("College"))
        End While

        con.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Display1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Sort(DataGridView1.Columns(1), ListSortDirection.Ascending)
    End Sub
End Class