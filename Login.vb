﻿Public Class Login
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Change the panel  when the timer hits the following interval
        If Timer1.Interval = 10000 Then
            Panel1.Visible = False
            Panel3.Visible = True
        ElseIf Timer1.Interval = 20000 Then
            Panel3.Visible = False
            Panel1.Visible = True
        ElseIf Timer1.Interval = 30000 Then
            Panel3.Visible = True
            Panel1.Visible = False
        ElseIf Timer1.Interval = 40000 Then
            Panel3.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Credentials for logging into the application.
        If TextBox1.Text = "Admin" And TextBox2.Text = "Admin123" Then
            Label15.Text = "Logged In Successfully"
            Me.Hide()
            Home.ShowDialog()
            Me.Close()
        Else
            Label15.Text = "Incorrect Credentials"
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()

    End Sub
End Class