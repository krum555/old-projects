
Public Class Form1
    'Dim write As New StreamWriter
    'Dim read As New StreamReader
    Dim file As System.IO.StreamWriter
    Dim filea As System.IO.StreamReader
    Dim dataa As Date
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\data.bin", True)
        file.Write(TextBox1.Text)
        file.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filea = My.Computer.FileSystem.OpenTextFileReader("C:\data.bin")
        TextBox1.Text = filea.ReadToEnd
        filea.Close()
        My.Computer.FileSystem.DeleteFile("C:\data.bin")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.FileSystem.FileExists("C:\data.bin") Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = My.Computer.Clock.LocalTime
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Computer.Clock.LocalTime
        If Label1.Text.Contains("4/20/2014") Then
            TextBox1.Text = "yes"
        End If
    End Sub
End Class
