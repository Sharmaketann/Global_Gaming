Imports System.Data.SqlClient

Public Class Payments
    Dim connection As New SqlConnection
    Dim command As New SqlCommand
    Dim dataadapter As New SqlDataAdapter
    Dim dataset As New DataSet
    Dim datareader As SqlDataReader

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmb As String
        cmb = ComboBox1.Text
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("select Name from Individual where ID = '" + cmb + "'", connection)
        datareader = command.ExecuteReader
        While datareader.Read
            ComboBox2.Text = (datareader("Name").ToString())
        End While
        connection.Close()
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        command = New SqlCommand("select ID,Name from Individual", connection)
        datareader = command.ExecuteReader
        While datareader.Read
            ComboBox1.Items.Add(datareader("ID").ToString())
            ComboBox2.Items.Add(datareader("Name").ToString())
        End While
        connection.Close()

    End Sub

    Private Sub Payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890" '// Characters to use for ID.
        Dim myID As String = Nothing '// used to add random char. until the preset ID length.
        Dim idLength As Integer = 5 '// allow a 10 char. Alphanumeric ID.
        Dim rnd As New Random '// for randomizing char.s.
        For i As Integer = 1 To idLength '// each loop adds 1 random char. 
            myID &= myChars(rnd.Next(0, myChars.Length)) '// add random char. to String. ex: myChars(2) ='s "C".
        Next
        Label4.Text = myID
        Label4.Refresh()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Date.Now.ToString("dd-MMM-yyyy")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("select * from Individual where ID =" + ComboBox1.Text + "", connection)
        Dim datareader As SqlDataReader
        datareader = command.ExecuteReader
        datareader.Read()
        Try
            Label9.Text = datareader("College")
            Label10.Text = datareader("City")
            Label11.Text = datareader("Email")
            connection.Close()
        Catch dr As Exception
            MsgBox("Record not found")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection = New SqlConnection("")
    End Sub
End Class