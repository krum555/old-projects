Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Timer1.Start()
        Form1.Timer2.Start()
        Form1.Timer3.Start()
        Form1.Timer4.Start()
        Form1.Timer5.Start()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Form3.ToolStripTextBox1.Text = Form3.ToolStripTextBox1.Text.Remove(Microsoft.VisualBasic.Left("&", 1))
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Show()
        Form1.Hide()
        Form3.Show()
        Form3.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Timer1.Start()
        Form1.Timer2.Start()
        Form1.Timer3.Start()
        Form1.Timer4.Start()
        Form1.Timer5.Start()
        Form1.Show()
        Me.Hide()
        Form1.Label33.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button1.Text = "Start Game" Then
            Button1.Text = "Започни Игра"
            Button5.Text = "Игра За Двама"
            Button2.Text = "Резултати"
            Button3.Text = "Опции"
            Button4.Text = "Изход"
            Form3.ControlsToolStripMenuItem.Text = "Контроли"
        Else : Button1.Text = "Start Game"
            Button5.Text = "MultiPlayer"
            Button2.Text = "High Scores"
            Button3.Text = "Options"
            Button4.Text = "Quit"
            Form3.ControlsToolStripMenuItem.Text = "Controls"
        End If
    End Sub
End Class