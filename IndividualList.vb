Imports System.Data.SqlClient

Public Class IndividualList
    Dim connection As New SqlConnection
    Dim command As New SqlCommand
    Dim dataadapter As New SqlDataAdapter
    Dim dataset As DataSet
    Dim datareader As SqlDataReader

    Private Sub IndividualList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GlobalDataSet.Individual' table. You can move, or remove it, as needed.
        Me.IndividualTableAdapter.Fill(Me.GlobalDataSet.Individual)
        TableLayoutPanel1.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TableLayoutPanel1.Visible = True
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        Dim strsql As String
        strsql = "select * from Individual where ID = " + TextBox1.Text + ""
        command = New SqlCommand(strsql, connection)
        datareader = command.ExecuteReader
        datareader.Read()
        'Read all the data from the database and show it in the textbox
        Label10.Text = datareader("ID")
        Label11.Text = datareader("Name")
        Label12.Text = datareader("GName")
        Label13.Text = datareader("College")
        Label14.Text = datareader("City")
        Label15.Text = datareader("Email")
        Label16.Text = datareader("GType")
        Label17.Text = datareader("Game")
        connection.Close()
    End Sub
End Class