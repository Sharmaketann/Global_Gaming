Imports System.Data.SqlClient

Public Class TeamStanding
    Dim connection As New SqlConnection
    Dim command As New SqlCommand
    Dim dataadapter As New SqlDataAdapter
    Dim dataset As New DataSet
    Dim datareader As SqlDataReader
    Private Sub TeamStanding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("select Name, Points from TeamScoreboard where Points Between 35 AND 40 AND Games >= 8", connection)
        Dim datareader As SqlDataReader
        datareader = command.ExecuteReader
        datareader.Read()
        Try
            Label8.Text = datareader("Name")
        Catch ex As Exception
            Label8.Text = ("N/A")
        End Try
        connection.Close()


        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("select Name, Points from TeamScoreboard where Points Between 30 AND 35 ", connection)
        datareader = command.ExecuteReader
        datareader.Read()
        Try
            Label9.Text = datareader("Name")
        Catch ex As Exception
            Label9.Text = ("N/A")
        End Try
        connection.Close()

        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("select Name, Points from TeamScoreboard where Points Between 25 AND 29 ", connection)
        datareader = command.ExecuteReader
        datareader.Read()
        Try
            Label10.Text = datareader("Name")
        Catch ex As Exception
            Label10.Text = ("N/A")
        End Try
        connection.Close()

        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("select Name, Points from TeamScoreboard where Points Between 20 AND 24 ", connection)
        datareader = command.ExecuteReader
        datareader.Read()
        Try
            Label11.Text = datareader("Name")
        Catch ex As Exception
            Label11.Text = ("N/A")
        End Try
        connection.Close()

        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("select Name, Points from TeamScoreboard where Points Between 15 AND 19 ", connection)
        datareader = command.ExecuteReader
        datareader.Read()
        Try
            Label12.Text = datareader("Name")
        Catch ex As Exception
            Label12.Text = ("N/A")
        End Try
        connection.Close()

        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("select Name, Points from TeamScoreboard where Points Between 10 AND 14 ", connection)
        datareader = command.ExecuteReader
        datareader.Read()
        Try
            Label13.Text = datareader("Name")
        Catch ex As Exception
            Label13.Text = ("N/A")
        End Try
        connection.Close()
    End Sub
End Class