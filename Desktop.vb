Public Class Desktop

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = False
    End Sub

    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel3.Visible = False
        Panel5.Visible = False
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Panel3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel5.Visible = False
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Panel5.Visible = True
    End Sub
End Class