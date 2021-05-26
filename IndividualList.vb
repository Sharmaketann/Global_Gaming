Imports System.Data.SqlClient
Imports System.IO
Public Class IndividualList
    Dim connection As New SqlConnection
    Dim command As New SqlCommand
    Dim dataadapter As New SqlDataAdapter
    Dim dataset As DataSet
    Dim datareader As SqlDataReader

    Private Sub IndividualList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Nothing
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        dataadapter = New SqlDataAdapter("select * from Individual", connection)
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
        strsql = "select * from Individual where ID = " + TextBox1.Text + ""
        command = New SqlCommand(strsql, connection)
        datareader = command.ExecuteReader
        datareader.Read()
        'Read all the data from the database and show it in the textbox
        Try
            Label10.Text = datareader("ID")
            Label11.Text = datareader("Name")
            Label12.Text = datareader("GName")
            Label13.Text = datareader("College")
            Label14.Text = datareader("City")
            Label15.Text = datareader("Email")
            Label16.Text = datareader("GType")
            Label17.Text = datareader("Game")
            connection.Close()
        Catch dr As Exception
            MsgBox("Record Not Found", MsgBoxStyle.ApplicationModal)
        End Try
        If Label17.Text = "Dota 2" Then
            PictureBox1.Image = My.Resources.dota
        ElseIf Label17.Text = "Chess" Then
            PictureBox1.Image = My.Resources.chess
        ElseIf Label17.Text = "PuBG" Then
            PictureBox1.Image = My.Resources.pubg
        Else
            PictureBox1.Image = Nothing
        End If

    End Sub
End Class