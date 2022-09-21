Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ToolStripTextBox1.Text = ToolStripTextBox1.Text + (Microsoft.VisualBasic.Left("&", 1))
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Show()
        Me.Hide()
    End Sub
End Class