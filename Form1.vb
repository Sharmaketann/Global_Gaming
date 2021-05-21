Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1                         'Increment the value of ProgressBar.
        If ProgressBar1.Value <= 10 Then
            Label1.Text = "Getting things ready....."
        ElseIf ProgressBar1.Value <= 30 Then
            Label1.Text = "Initializing System...."
        ElseIf ProgressBar1.Value <= 50 Then
            Label1.Text = "Connecting to the database...."
        ElseIf ProgressBar1.Value <= 70 Then
            Label1.Text = "Collecting Data...."
        ElseIf ProgressBar1.Value <= 90 Then
            Label1.Text = "Almost There...."
        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = "Configuring System...."
            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()                        'Terminate the timer.
                Me.Hide()
                Login.ShowDialog()                      'Shows the next form.
                Me.Close()

            End If
        End If
    End Sub
End Class
