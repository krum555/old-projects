Public Class Form1
    Dim l As Integer
    Dim v As Integer
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        v = CInt(Int(4 * Rnd()) + 1)
        l = CInt(Int(5 * Rnd()) + 1)
        If v = 1 Then v = 25
        If v = 2 Then v = 100
        If v = 3 Then v = 175
        If v = 4 Then v = 250
        If l = 1 Then l = -100
        If l = 2 Then l = -200
        If l = 3 Then l = -300
        If l = 4 Then l = -400
        If l = 5 Then l = -500
        If Label1.Location = Label25.Location Or Label1.Location = Label26.Location Or Label1.Location = Label27.Location Or Label1.Location = Label28.Location Then
            Label1.Top = l
            Label1.Left = v
        End If
        If Label2.Location = Label25.Location Or Label2.Location = Label26.Location Or Label2.Location = Label27.Location Or Label2.Location = Label28.Location Then
            Label2.Top = l
            Label2.Left = v
        End If
        If Label3.Location = Label25.Location Or Label3.Location = Label26.Location Or Label3.Location = Label27.Location Or Label3.Location = Label28.Location Then
            Label3.Top = l
            Label3.Left = v
        End If
        If Label4.Location = Label25.Location Or Label4.Location = Label26.Location Or Label4.Location = Label27.Location Or Label4.Location = Label28.Location Then
            Label4.Top = l
            Label4.Left = v
        End If
        If Label5.Location = Label25.Location Or Label5.Location = Label26.Location Or Label5.Location = Label27.Location Or Label5.Location = Label28.Location Then
            Label5.Top = l
            Label5.Left = v
        End If
        If Label6.Location = Label25.Location Or Label6.Location = Label26.Location Or Label6.Location = Label27.Location Or Label6.Location = Label28.Location Then
            Label6.Top = l
            Label6.Left = v
        End If
        If Label7.Location = Label25.Location Or Label7.Location = Label26.Location Or Label7.Location = Label27.Location Or Label7.Location = Label28.Location Then
            Label7.Top = l
            Label7.Left = v
        End If
        If Label8.Location = Label25.Location Or Label8.Location = Label26.Location Or Label8.Location = Label27.Location Or Label8.Location = Label28.Location Then
            Label8.Top = l
            Label8.Left = v
        End If
        If Label9.Location = Label25.Location Or Label9.Location = Label26.Location Or Label9.Location = Label27.Location Or Label9.Location = Label28.Location Then
            Label9.Top = Label9.Top - 843
            Label9.Left = v
        End If
        If Label10.Location = Label25.Location Or Label10.Location = Label26.Location Or Label10.Location = Label27.Location Or Label10.Location = Label28.Location Then
            Label10.Top = l
            Label10.Left = v
        End If
        If Label11.Location = Label25.Location Or Label11.Location = Label26.Location Or Label11.Location = Label27.Location Or Label11.Location = Label28.Location Then
            Label11.Top = l
            Label11.Left = v
        End If
        If Label12.Location = Label25.Location Or Label12.Location = Label26.Location Or Label12.Location = Label27.Location Or Label12.Location = Label28.Location Then
            Label12.Top = l
            Label12.Left = v
        End If
        If Label13.Location = Label25.Location Or Label13.Location = Label26.Location Or Label13.Location = Label27.Location Or Label13.Location = Label28.Location Then
            Label13.Top = l
            Label13.Left = v
        End If
        If Label14.Location = Label25.Location Or Label14.Location = Label26.Location Or Label14.Location = Label27.Location Or Label14.Location = Label28.Location Then
            Label14.Top = l
            Label14.Left = v
        End If
        If Label15.Location = Label25.Location Or Label15.Location = Label26.Location Or Label15.Location = Label27.Location Or Label15.Location = Label28.Location Then
            Label15.Top = l
            Label15.Left = v
        End If
        If Label16.Location = Label25.Location Or Label16.Location = Label26.Location Or Label16.Location = Label27.Location Or Label16.Location = Label28.Location Then
            Label16.Top = l
            Label16.Left = v
        End If
        If Label17.Location = Label25.Location Or Label17.Location = Label26.Location Or Label17.Location = Label27.Location Or Label17.Location = Label28.Location Then
            Label17.Top = l
            Label17.Left = v
        End If
        If Label18.Location = Label25.Location Or Label18.Location = Label26.Location Or Label18.Location = Label27.Location Or Label18.Location = Label28.Location Then
            Label18.Top = l
            Label18.Left = v
        End If
        If Label19.Location = Label25.Location Or Label19.Location = Label26.Location Or Label19.Location = Label27.Location Or Label19.Location = Label28.Location Then
            Label19.Top = l
            Label19.Left = v
        End If
        If Label20.Location = Label25.Location Or Label20.Location = Label26.Location Or Label20.Location = Label27.Location Or Label20.Location = Label28.Location Then
            Label20.Top = l
            Label20.Left = v
        End If
        If Label21.Location = Label25.Location Or Label21.Location = Label26.Location Or Label21.Location = Label27.Location Or Label21.Location = Label28.Location Then
            Label21.Top = l
            Label21.Left = v
        End If
        If Label22.Location = Label25.Location Or Label22.Location = Label26.Location Or Label22.Location = Label27.Location Or Label22.Location = Label28.Location Then
            Label22.Top = l
            Label22.Left = v
        End If
        If Label23.Location = Label25.Location Or Label23.Location = Label26.Location Or Label23.Location = Label27.Location Or Label23.Location = Label28.Location Then
            Label23.Top = l
            Label23.Left = v
        End If
        If Label24.Location = Label25.Location Or Label24.Location = Label26.Location Or Label24.Location = Label27.Location Or Label24.Location = Label28.Location Then
            Label24.Top = l
            Label24.Left = v
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Top = Label1.Top + 1
        Label2.Top = Label2.Top + 1
        Label3.Top = Label3.Top + 1
        Label4.Top = Label4.Top + 1
        Label5.Top = Label5.Top + 1
        Label6.Top = Label6.Top + 1
        Label7.Top = Label7.Top + 1
        Label8.Top = Label8.Top + 1
        Label9.Top = Label9.Top + 1
        Label10.Top = Label10.Top + 1
        Label11.Top = Label11.Top + 1
        Label12.Top = Label12.Top + 1
        Label13.Top = Label13.Top + 1
        Label14.Top = Label14.Top + 1
        Label15.Top = Label15.Top + 1
        Label16.Top = Label16.Top + 1
        Label17.Top = Label17.Top + 1
        Label18.Top = Label18.Top + 1
        Label19.Top = Label19.Top + 1
        Label20.Top = Label20.Top + 1
        Label21.Top = Label21.Top + 1
        Label22.Top = Label22.Top + 1
        Label23.Top = Label23.Top + 1
        Label24.Top = Label24.Top + 1
        Label30.Text += 1
        If Timer2.Interval = 1 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Interval = Timer2.Interval - 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label29.Left = Label29.Left - 75
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label29.Left = Label29.Left + 75
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Label1.Location = Label29.Location Then

            Me.Close()
        End If
        If Label2.Location = Label29.Location Then

            Me.Close()
        End If
        If Label3.Location = Label29.Location Then

            Me.Close()
        End If
        If Label4.Location = Label29.Location Then

            Me.Close()
        End If
        If Label5.Location = Label29.Location Then

            Me.Close()
        End If
        If Label6.Location = Label29.Location Then

            Me.Close()
        End If
        If Label7.Location = Label29.Location Then

            Me.Close()
        End If
        If Label8.Location = Label29.Location Then

            Me.Close()
        End If
        If Label9.Location = Label29.Location Then

            Me.Close()
        End If
        If Label10.Location = Label29.Location Then

            Me.Close()
        End If
        If Label11.Location = Label29.Location Then

            Me.Close()
        End If
        If Label12.Location = Label29.Location Then

            Me.Close()
        End If
        If Label13.Location = Label29.Location Then

            Me.Close()
        End If
        If Label14.Location = Label29.Location Then

            Me.Close()
        End If
        If Label15.Location = Label29.Location Then

            Me.Close()
        End If
        If Label16.Location = Label29.Location Then

            Me.Close()
        End If
        If Label17.Location = Label29.Location Then

            Me.Close()
        End If
        If Label18.Location = Label29.Location Then

            Me.Close()
        End If
        If Label19.Location = Label29.Location Then

            Me.Close()
        End If
        If Label20.Location = Label29.Location Then

            Me.Close()
        End If
        If Label21.Location = Label29.Location Then

            Me.Close()
        End If
        If Label22.Location = Label29.Location Then

            Me.Close()
        End If
        If Label23.Location = Label29.Location Then

            Me.Close()
        End If
        If Label24.Location = Label29.Location Then

            Me.Close()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If Label29.Location.X = "325" Then
            Label29.Left = Label29.Left - 300
        End If
        If Label29.Location.X = "-50" Then
            Label29.Left = Label29.Left + 300
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Button2.Text = Form3.ToolStripTextBox6.Text
        Button1.Text = Form3.ToolStripTextBox4.Text
        Button3.Text = Form3.ToolStripTextBox1.Text
        If Timer3.Enabled = False Then
            Timer1.Interval = Form3.ToolStripTextBox8.Text
            Timer2.Interval = Form3.ToolStripTextBox11.Text
        End If
        If Timer3.Enabled = False Then
            If Form3.ToolStripComboBox1.Text = "True" Then
                Timer1.Enabled = True
            ElseIf Form3.ToolStripComboBox1.Text = "False" Then
                Timer1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form4.CheckedListBox1.Items.Add(Label30.Text)
        Form5.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Timer3.Enabled = True Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False
            Timer5.Enabled = False
            Timer6.Enabled = False
            Label31.Visible = True
        Else : Timer3.Enabled = False
            Timer1.Enabled = True
            Timer2.Enabled = True
            Timer3.Enabled = True
            Timer4.Enabled = True
            Timer5.Enabled = True
            Timer6.Enabled = True
            Label31.Visible = False
        End If
    End Sub
End Class
