Public Class Intercolliegate
    Private Sub Intercolliegate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.ForeColor = Color.Blue
        TableLayoutPanel3.Visible = False
        TableLayoutPanel2.Visible = True
        TableLayoutPanel5.Visible = False
        TableLayoutPanel4.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label4.ForeColor = Color.BlueViolet
        TableLayoutPanel3.Visible = True
        TableLayoutPanel2.Visible = False
        TableLayoutPanel4.Visible = False
        TableLayoutPanel5.Visible = False
        Label6.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.ForeColor = Color.Blue
        TableLayoutPanel2.Visible = True
        TableLayoutPanel3.Visible = False
        TableLayoutPanel4.Visible = False
        TableLayoutPanel5.Visible = False
        Label4.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label6.ForeColor = Color.Black
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Label5.ForeColor = Color.Blue
        TableLayoutPanel2.Visible = False
        TableLayoutPanel3.Visible = False
        TableLayoutPanel4.Visible = True
        TableLayoutPanel5.Visible = False
        Label4.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label6.ForeColor = Color.Black
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Label6.ForeColor = Color.Blue
        TableLayoutPanel2.Visible = False
        TableLayoutPanel3.Visible = False
        TableLayoutPanel4.Visible = False
        TableLayoutPanel5.Visible = True
        Label4.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label5.ForeColor = Color.Black

    End Sub
End Class