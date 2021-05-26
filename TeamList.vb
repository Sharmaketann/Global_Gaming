Imports System.Data.SqlClient
Imports System.IO

Public Class TeamList
    Dim connection As New SqlConnection
    Dim command As New SqlCommand
    Dim dataadapter As New SqlDataAdapter
    Dim dataset As DataSet
    Dim datareader As SqlDataReader

    Private Sub TeamList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        dataadapter = New SqlDataAdapter("select * from Teaminfo", connection)
        dataset = New DataSet
        dataadapter.Fill(dataset)
        DataGridView1.DataSource = dataset.Tables(0)
        TableLayoutPanel1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TableLayoutPanel1.Visible = True
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        Dim strsql As String
        strsql = "select * from Teaminfo where ID = " + TextBox1.Text + ""
        command = New SqlCommand(strsql, connection)
        datareader = Command.ExecuteReader
        datareader.Read()
        'Read all the data from the database and show it in the textbox
        Try
            Label10.Text = datareader("ID")
            Label12.Text = datareader("Name")
            Label14.Text = datareader("Coach")
            Label16.Text = datareader("College")
            Label11.Text = datareader("City")
            Label13.Text = datareader("Email")
            Label15.Text = datareader("GType")
            Label17.Text = datareader("Game")
            connection.Close()
        Catch dr As Exception
        End Try
    End Sub
End Class