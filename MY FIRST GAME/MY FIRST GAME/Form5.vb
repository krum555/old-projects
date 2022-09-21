Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Timer1.Start()
        Form1.Timer2.Start()
        Form1.Timer3.Start()
        Form1.Timer4.Start()
        Form1.Timer5.Start()
        Form1.Show()
    End Sub

    Private Sub Form5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Label33.Visible = False
        Form2.Show()
        Me.Close()
        Form1.Show()
        Form1.Hide()
    End Sub
End Class