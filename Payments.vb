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
        connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Global;Integrated Security=True")
        connection.Open()
        command = New SqlCommand("insert into Payment values('" + Label4.Text + "','" + Label7.Text + "'," + ComboBox1.Text + ",'" + ComboBox2.Text + "','" + Label9.Text + "','" + Label10.Text + "','" + Label11.Text + "','" + ComboBox3.Text + "','" + TextBox1.Text + "')", connection)
        command.ExecuteNonQuery()
        MsgBox("Payment Done")
        connection.Close()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Dim myChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890" '// Characters to use for ID.
        Dim myID As String = Nothing '// used to add random char. until the preset ID length.
        Dim idLength As Integer = 5 '// allow a 10 char. Alphanumeric ID.
        Dim rnd As New Random '// for randomizing char.s.
        For i As Integer = 1 To idLength '// each loop adds 1 random char. 
            myID &= myChars(rnd.Next(0, myChars.Length)) '// add random char. to String. ex: myChars(2) ='s "C".
        Next
        Label4.Text = myID
        Label4.Refresh()

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox1.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Global Gaming Management", New Font("Poppins", 18, FontStyle.Bold), Brushes.Black, New Point(280, 20))
        e.Graphics.DrawString("Event Organizers", New Font("Poppins", 12, FontStyle.Bold), Brushes.Black, New Point(360, 50))
        e.Graphics.DrawString("Bill Generation", New Font("Poppins", 12, FontStyle.Regular), Brushes.Black, New Point(368, 120))
        e.Graphics.DrawString("Date:" + DateTime.Now, New Font("Montserrat", 8, FontStyle.Regular), Brushes.Black, New Point(20, 70))

        e.Graphics.DrawString("-----------------------------------------------------------------------------------", New Font("Poppins", 12, FontStyle.Regular), Brushes.Black, New Point(20, 85))

        e.Graphics.DrawString("Payment ID", New Font("Montserrat", 8, FontStyle.Regular), Brushes.Black, New Point(20, 150))
        e.Graphics.DrawString("Player ID", New Font("Montserrat", 8, FontStyle.Regular), Brushes.Black, New Point(180, 150))
        e.Graphics.DrawString("Player Name", New Font("Montserrat", 8, FontStyle.Regular), Brushes.Black, New Point(280, 150))
        e.Graphics.DrawString("Tournament", New Font("Montserrat", 8, FontStyle.Regular), Brushes.Black, New Point(390, 150))
        e.Graphics.DrawString("Amount", New Font("Montserrat", 8, FontStyle.Regular), Brushes.Black, New Point(670, 150))

        e.Graphics.DrawString("-----------------------------------------------------------------------------------", New Font("Poppins", 12, FontStyle.Regular), Brushes.Black, New Point(20, 85))

        e.Graphics.DrawString(Label4.Text, New Font("Montserrat", 8, FontStyle.Bold), Brushes.Black, New Point(20, 200))
        e.Graphics.DrawString(ComboBox1.Text, New Font("Montserrat", 8, FontStyle.Bold), Brushes.Black, New Point(180, 200))
        e.Graphics.DrawString(ComboBox2.Text, New Font("Montserrat", 8, FontStyle.Bold), Brushes.Black, New Point(280, 200))
        e.Graphics.DrawString(ComboBox3.Text, New Font("Montserrat", 8, FontStyle.Bold), Brushes.Black, New Point(390, 200))
        e.Graphics.DrawString("Rs:   " + TextBox1.Text, New Font("Montserrat", 8, FontStyle.Bold), Brushes.Black, New Point(670, 200))

        e.Graphics.DrawString("-----------------------------------------------------------------------------------", New Font("Poppins", 12, FontStyle.Regular), Brushes.Black, New Point(20, 250))

        e.Graphics.DrawString("Total Amount:    " + TextBox1.Text, New Font("Montserrat", 8, FontStyle.Bold), Brushes.Black, New Point(580, 300))


        e.Graphics.DrawString("-----------------------------------------------------------------------------------", New Font("Poppins", 12, FontStyle.Regular), Brushes.Black, New Point(20, 350))

        e.Graphics.DrawString("'Offense Wins Game, But Defense Wins Championships'", New Font("Poppins", 10, FontStyle.Bold), Brushes.Black, New Point(250, 400))

        e.Graphics.DrawString("'Thanks for the Registration'", New Font("Poppins", 10, FontStyle.Bold), Brushes.Black, New Point(350, 450))

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class