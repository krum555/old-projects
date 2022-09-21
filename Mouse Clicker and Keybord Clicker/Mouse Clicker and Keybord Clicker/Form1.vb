Public Class Form1
    Dim s As Integer
    Private Declare Function GetKeyState Lib "user32" (ByVal vKey As Int32) As Short
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10
    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    'Declare Function SetCursorPos Lib "user32.dll" (ByVal point As Point)
    'Dim point As Point
    'Public Shared Property Position As Point
    Public Property stufit As Keys = Keys.F2
    Public Property stufbat As Keys = Keys.F1
    Declare Sub sleep Lib "kernel32" (ByVal milliseconds As Long)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text += 1
        If RadioButton1.Checked = True Then
            Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        ElseIf RadioButton2.Checked = True Then
            Call apimouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
            Call apimouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Timer1.Enabled = True Then
            NumericUpDown1.ReadOnly = True
        Else
            NumericUpDown1.ReadOnly = False
        End If
        If Timer1.Enabled = False Then
            Timer1.Interval = NumericUpDown1.Value
        End If
        If keybord115.Enabled = True Then
            NumericUpDown2.ReadOnly = True
        Else
            NumericUpDown2.ReadOnly = False
        End If
        If keybord115.Enabled = False Then
            keybord115.Interval = NumericUpDown2.Value
        End If
        If WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = False
        Else
            ShowInTaskbar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If Timer3.Enabled = False Then
            Timer3.Enabled = True
        Else
            Timer3.Enabled = False
        End If
    End Sub
    'Label2.Text = MousePosition.X
    'Label3.Text = MousePosition.Y
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        MsgBox("Press G to set the curent mouse position", MsgBoxStyle.Information, "")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("This determines the clicking speed, the lower the number the higher the speed", MsgBoxStyle.Information, "")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CheckBox1.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
        If CheckBox2.Checked = True Then
            Timer4.Enabled = True
        Else
            Timer4.Enabled = False
        End If
        If CheckBox2.Checked = True Then
            Timer5.Enabled = True
        Else
            Timer5.Enabled = False
        End If
        If CheckBox3.Checked = True Then
            keybord115.Enabled = True
        Else
            keybord115.Enabled = False
        End If
        CheckBox4.Checked = False
        Timer1.Enabled = False
        Label1.Text = 0
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 1 Then
            Me.Opacity = "0.15"
            Label6.Text = "15%"
        ElseIf TrackBar1.Value = 2 Then
            Me.Opacity = "0.20"
            Label6.Text = "20%"
        ElseIf TrackBar1.Value = 3 Then
            Me.Opacity = "0.25"
            Label6.Text = "25%"
        ElseIf TrackBar1.Value = 4 Then
            Me.Opacity = "0.30"
            Label6.Text = "30%"
        ElseIf TrackBar1.Value = 5 Then
            Me.Opacity = "0.35"
            Label6.Text = "35%"
        ElseIf TrackBar1.Value = 6 Then
            Me.Opacity = "0.40"
            Label6.Text = "40%"
        ElseIf TrackBar1.Value = 7 Then
            Me.Opacity = "0.45"
            Label6.Text = "45%"
        ElseIf TrackBar1.Value = 8 Then
            Me.Opacity = "0.50"
            Label6.Text = "50%"
        ElseIf TrackBar1.Value = 9 Then
            Me.Opacity = "0.55"
            Label6.Text = "55%"
        ElseIf TrackBar1.Value = 10 Then
            Me.Opacity = "0.60"
            Label6.Text = "60%"
        ElseIf TrackBar1.Value = 11 Then
            Me.Opacity = "0.65"
            Label6.Text = "65%"
        ElseIf TrackBar1.Value = 12 Then
            Me.Opacity = "0.70"
            Label6.Text = "70%"
        ElseIf TrackBar1.Value = 13 Then
            Me.Opacity = "0.75"
            Label6.Text = "75%"
        ElseIf TrackBar1.Value = 14 Then
            Me.Opacity = "0.80"
            Label6.Text = "80%"
        ElseIf TrackBar1.Value = 15 Then
            Me.Opacity = "0.85"
            Label6.Text = "85%"
        ElseIf TrackBar1.Value = 16 Then
            Me.Opacity = "0.90"
            Label6.Text = "90%"
        ElseIf TrackBar1.Value = 17 Then
            Me.Opacity = "0.95"
            Label6.Text = "95%"
        ElseIf TrackBar1.Value = 18 Then
            Me.Opacity = "1"
            Label6.Text = "100%"
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If GetKeyState(stufit) Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
        If Timer1.Enabled = False And Not Label1.Text = 0 Then
            ListBox1.Items.Add(Label1.Text)
            Label1.Text = 0
        End If

    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
        Me.TopMost = True
        Me.TopMost = False
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.WindowState = FormWindowState.Normal
        Me.TopMost = True
        Me.TopMost = False
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Timer1.Enabled = False
            Label1.Text = 0
            Label4.Visible = True
            Label9.Visible = True
            Label8.Visible = True
            ListBox2.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            Timer4.Enabled = False
            Timer5.Enabled = False
            Timer1.Enabled = False
            Label1.Text = 0
        Else
            Timer1.Enabled = False
            Label1.Text = 0
            Label4.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            ListBox2.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            CheckBox2.Text = "Keybord Quick Start/Stop key: (" + TextBox1.Text + ")"
            CheckBox3.Text = "Mouse Quick Start/Stop key: (" + TextBox2.Text + ")"
            Timer4.Enabled = True
            Timer5.Enabled = True
            Timer1.Enabled = False
            Label1.Text = 0
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Please enter a symbol!", MsgBoxStyle.Exclamation)
                CheckBox4.Checked = True
            End If
            If TextBox1.Text = "Q" Then stufit = Keys.Q
            If TextBox2.Text = "Q" Then stufbat = Keys.Q
            If TextBox1.Text = "W" Then stufit = Keys.W
            If TextBox2.Text = "W" Then stufbat = Keys.W
            If TextBox1.Text = "E" Then stufit = Keys.E
            If TextBox2.Text = "E" Then stufbat = Keys.E
            If TextBox1.Text = "R" Then stufit = Keys.R
            If TextBox2.Text = "R" Then stufbat = Keys.R
            If TextBox1.Text = "T" Then stufit = Keys.T
            If TextBox2.Text = "T" Then stufbat = Keys.T
            If TextBox1.Text = "Y" Then stufit = Keys.Y
            If TextBox2.Text = "Y" Then stufbat = Keys.Y
            If TextBox1.Text = "U" Then stufit = Keys.U
            If TextBox2.Text = "U" Then stufbat = Keys.U
            If TextBox1.Text = "I" Then stufit = Keys.I
            If TextBox2.Text = "I" Then stufbat = Keys.I
            If TextBox1.Text = "O" Then stufit = Keys.O
            If TextBox2.Text = "O" Then stufbat = Keys.O
            If TextBox1.Text = "P" Then stufit = Keys.P
            If TextBox2.Text = "P" Then stufbat = Keys.P
            If TextBox1.Text = "A" Then stufit = Keys.A
            If TextBox2.Text = "A" Then stufbat = Keys.A
            If TextBox1.Text = "S" Then stufit = Keys.S
            If TextBox2.Text = "S" Then stufbat = Keys.S
            If TextBox1.Text = "D" Then stufit = Keys.D
            If TextBox2.Text = "D" Then stufbat = Keys.D
            If TextBox1.Text = "F" Then stufit = Keys.F
            If TextBox2.Text = "F" Then stufbat = Keys.F
            If TextBox1.Text = "G" Then stufit = Keys.G
            If TextBox2.Text = "G" Then stufbat = Keys.G
            If TextBox1.Text = "H" Then stufit = Keys.H
            If TextBox2.Text = "H" Then stufbat = Keys.H
            If TextBox1.Text = "J" Then stufit = Keys.J
            If TextBox2.Text = "J" Then stufbat = Keys.J
            If TextBox1.Text = "K" Then stufit = Keys.K
            If TextBox2.Text = "K" Then stufbat = Keys.K
            If TextBox1.Text = "L" Then stufit = Keys.L
            If TextBox2.Text = "L" Then stufbat = Keys.L
            If TextBox1.Text = "Z" Then stufit = Keys.Z
            If TextBox2.Text = "Z" Then stufbat = Keys.Z
            If TextBox1.Text = "X" Then stufit = Keys.X
            If TextBox2.Text = "X" Then stufbat = Keys.X
            If TextBox1.Text = "C" Then stufit = Keys.C
            If TextBox2.Text = "C" Then stufbat = Keys.C
            If TextBox1.Text = "V" Then stufit = Keys.V
            If TextBox2.Text = "V" Then stufbat = Keys.V
            If TextBox1.Text = "B" Then stufit = Keys.B
            If TextBox2.Text = "B" Then stufbat = Keys.B
            If TextBox1.Text = "N" Then stufit = Keys.N
            If TextBox2.Text = "N" Then stufbat = Keys.N
            If TextBox1.Text = "M" Then stufit = Keys.M
            If TextBox2.Text = "M" Then stufbat = Keys.M
            If TextBox1.Text = "1" Then stufit = Keys.D1
            If TextBox2.Text = "1" Then stufbat = Keys.D1
            If TextBox1.Text = "2" Then stufit = Keys.D2
            If TextBox2.Text = "2" Then stufbat = Keys.D2
            If TextBox1.Text = "3" Then stufit = Keys.D3
            If TextBox2.Text = "3" Then stufbat = Keys.D3
            If TextBox1.Text = "4" Then stufit = Keys.D4
            If TextBox2.Text = "4" Then stufbat = Keys.D4
            If TextBox1.Text = "5" Then stufit = Keys.D5
            If TextBox2.Text = "5" Then stufbat = Keys.D5
            If TextBox1.Text = "6" Then stufit = Keys.D6
            If TextBox2.Text = "6" Then stufbat = Keys.D6
            If TextBox1.Text = "7" Then stufit = Keys.D7
            If TextBox2.Text = "7" Then stufbat = Keys.D7
            If TextBox1.Text = "8" Then stufit = Keys.D8
            If TextBox2.Text = "8" Then stufbat = Keys.D8
            If TextBox1.Text = "9" Then stufit = Keys.D9
            If TextBox2.Text = "9" Then stufbat = Keys.D9
            If TextBox1.Text = "0" Then stufit = Keys.D0
            If TextBox2.Text = "0" Then stufbat = Keys.D0
            If TextBox1.Text = "SBAR" Then stufit = Keys.Space
            If TextBox2.Text = "SBAR" Then stufbat = Keys.Space
            If TextBox1.Text = "ALT" Then stufit = Keys.Alt
            If TextBox2.Text = "ALT" Then stufbat = Keys.Alt
            If TextBox1.Text = "LCTRL" Then stufit = Keys.LControlKey
            If TextBox2.Text = "LCTRL" Then stufbat = Keys.LControlKey
            If TextBox1.Text = "TAB" Then stufit = Keys.Tab
            If TextBox2.Text = "TAB" Then stufbat = Keys.Tab
            If TextBox1.Text = "LSHIFT" Then stufit = Keys.LShiftKey
            If TextBox2.Text = "LSHIFT" Then stufbat = Keys.LShiftKey
            If TextBox1.Text = "RSHIFT" Then stufit = Keys.RShiftKey
            If TextBox2.Text = "RSHIFT" Then stufbat = Keys.RShiftKey
            If TextBox1.Text = "CAPS" Then stufit = Keys.CapsLock
            If TextBox2.Text = "CAPS" Then stufbat = Keys.CapsLock
            If TextBox1.Text = "RCTRL" Then stufit = Keys.RControlKey
            If TextBox2.Text = "RCTRL" Then stufbat = Keys.RControlKey
            If TextBox1.Text = "ENTER" Then stufit = Keys.Enter
            If TextBox2.Text = "ENTER" Then stufbat = Keys.Enter
            If TextBox1.Text = "BACK" Then stufit = Keys.Back
            If TextBox2.Text = "BACK" Then stufbat = Keys.Back
            If TextBox1.Text = "/" Then stufit = Keys.Divide
            If TextBox2.Text = "/" Then stufbat = Keys.Divide
            If TextBox1.Text = "END" Then stufit = Keys.End
            If TextBox2.Text = "END" Then stufbat = Keys.End
            If TextBox1.Text = "ESC" Then stufit = Keys.Escape
            If TextBox2.Text = "ESC" Then stufbat = Keys.Escape
            If TextBox1.Text = "INS" Then stufit = Keys.Insert
            If TextBox2.Text = "INS" Then stufbat = Keys.Insert
            If TextBox1.Text = "*" Then stufit = Keys.Multiply
            If TextBox2.Text = "*" Then stufbat = Keys.Multiply
            If TextBox1.Text = "PGUP" Then stufit = Keys.PageUp
            If TextBox2.Text = "PGUP" Then stufbat = Keys.PageUp
            If TextBox1.Text = "PGDOWN" Then stufit = Keys.PageDown
            If TextBox2.Text = "PGDOWN" Then stufbat = Keys.PageDown
            If TextBox1.Text = "NMLOCK" Then stufit = Keys.NumLock
            If TextBox2.Text = "NMLOCK" Then stufbat = Keys.NumLock
            If TextBox1.Text = "NM0" Then stufit = Keys.NumPad0
            If TextBox2.Text = "NM0" Then stufbat = Keys.NumPad0
            If TextBox1.Text = "NM1" Then stufit = Keys.NumPad1
            If TextBox2.Text = "NM1" Then stufbat = Keys.NumPad1
            If TextBox1.Text = "NM2" Then stufit = Keys.NumPad2
            If TextBox2.Text = "NM2" Then stufbat = Keys.NumPad2
            If TextBox1.Text = "NM3" Then stufit = Keys.NumPad3
            If TextBox2.Text = "NM3" Then stufbat = Keys.NumPad3
            If TextBox1.Text = "NM4" Then stufit = Keys.NumPad4
            If TextBox2.Text = "NM4" Then stufbat = Keys.NumPad4
            If TextBox1.Text = "NM5" Then stufit = Keys.NumPad5
            If TextBox2.Text = "NM5" Then stufbat = Keys.NumPad5
            If TextBox1.Text = "NM6" Then stufit = Keys.NumPad6
            If TextBox2.Text = "NM6" Then stufbat = Keys.NumPad6
            If TextBox1.Text = "NM7" Then stufit = Keys.NumPad7
            If TextBox2.Text = "NM7" Then stufbat = Keys.NumPad7
            If TextBox1.Text = "NM8" Then stufit = Keys.NumPad8
            If TextBox2.Text = "NM8" Then stufbat = Keys.NumPad8
            If TextBox1.Text = "NM9" Then stufit = Keys.NumPad9
            If TextBox2.Text = "NM9" Then stufbat = Keys.NumPad9
            If TextBox1.Text = "RMB" Then stufit = Keys.RButton
            If TextBox2.Text = "RMB" Then stufbat = Keys.RButton
            If TextBox1.Text = "LMB" Then stufit = Keys.LButton
            If TextBox2.Text = "LMB" Then stufbat = Keys.LButton
            If TextBox1.Text = "RIGHT" Then stufit = Keys.Right
            If TextBox2.Text = "RIGHT" Then stufbat = Keys.Right
            If TextBox1.Text = "LEFT" Then stufit = Keys.Left
            If TextBox2.Text = "LEFT" Then stufbat = Keys.Left
            If TextBox1.Text = "UP" Then stufit = Keys.Up
            If TextBox2.Text = "UP" Then stufbat = Keys.Up
            If TextBox1.Text = "DOWN" Then stufit = Keys.Down
            If TextBox2.Text = "DOWN" Then stufbat = Keys.Down
            If TextBox1.Text = "-" Then stufit = Keys.Subtract
            If TextBox2.Text = "-" Then stufbat = Keys.Subtract
            If TextBox1.Text = "MMB" Then stufit = Keys.MButton
            If TextBox2.Text = "MMB" Then stufbat = Keys.MButton
            If TextBox1.Text = "+" Then stufit = Keys.Add
            If TextBox2.Text = "+" Then stufbat = Keys.Add
            If TextBox1.Text = "F1" Then stufit = Keys.F1
            If TextBox2.Text = "F1" Then stufbat = Keys.F1
            If TextBox1.Text = "F2" Then stufit = Keys.F2
            If TextBox2.Text = "F2" Then stufbat = Keys.F2
            If TextBox1.Text = "F3" Then stufit = Keys.F3
            If TextBox2.Text = "F3" Then stufbat = Keys.F3
            If TextBox1.Text = "F4" Then stufit = Keys.F4
            If TextBox2.Text = "F4" Then stufbat = Keys.F4
            If TextBox1.Text = "F5" Then stufit = Keys.F5
            If TextBox2.Text = "F5" Then stufbat = Keys.F5
            If TextBox1.Text = "F6" Then stufit = Keys.F6
            If TextBox2.Text = "F6" Then stufbat = Keys.F6
            If TextBox1.Text = "F7" Then stufit = Keys.F7
            If TextBox2.Text = "F7" Then stufbat = Keys.F7
            If TextBox1.Text = "F8" Then stufit = Keys.F8
            If TextBox2.Text = "F8" Then stufbat = Keys.F8
            If TextBox1.Text = "F9" Then stufit = Keys.F9
            If TextBox2.Text = "F9" Then stufbat = Keys.F9
            If TextBox1.Text = "F10" Then stufit = Keys.F10
            If TextBox2.Text = "F10" Then stufbat = Keys.F10
            If TextBox1.Text = "F11" Then stufit = Keys.F11
            If TextBox2.Text = "F11" Then stufbat = Keys.F11
            If TextBox1.Text = "F12" Then stufit = Keys.F12
            If TextBox2.Text = "F12" Then stufbat = Keys.F12
            'If Not TextBox1.Text Or TextBox2.Text Then
            '    MsgBox("You have entered an invalid symbol!", MsgBoxStyle.Exclamation)
            '    CheckBox4.Checked = True
            'End If
            'Select Case stufit Or stufbat
            '    Case Not TextBox1.Text = "+" Or TextBox1.Text = "MMB" Or TextBox1.Text = "-" Or TextBox1.Text = "DOWN" Or TextBox1.Text = "UP" Or TextBox1.Text = "LEFT" Or TextBox1.Text = "RIGHT" Or TextBox1.Text = "LMB" Or TextBox1.Text = "RMB" Or TextBox1.Text = "NM9" Or TextBox1.Text = "NM8" Or TextBox1.Text = "NM7" Or TextBox1.Text = "NM6" Or TextBox1.Text = "NM5" Or TextBox1.Text = "NM4" Or TextBox1.Text = "NM3" Or TextBox1.Text = "NM2" Or TextBox1.Text = "NM1" Or TextBox1.Text = "NM0" Or TextBox1.Text = "NMLOCK" Or TextBox1.Text = "PGDOWN" Or TextBox1.Text = "PGUP" Or TextBox1.Text = "INS" Or TextBox1.Text = "ESC" Or TextBox1.Text = "END" Or TextBox1.Text = "*" Or TextBox1.Text = "/" Or TextBox1.Text = "BACK" Or TextBox1.Text = "ENTER" Or TextBox1.Text = "LCTRL" Or TextBox1.Text = "RCTRL" Or TextBox1.Text = "CAPS" Or TextBox1.Text = "RSHIFT" Or TextBox1.Text = "LSHIFT" Or TextBox1.Text = "TAB" Or TextBox1.Text = "ALT" Or TextBox1.Text = "SBAR" Or TextBox1.Text = "1" Or TextBox1.Text = "2" Or TextBox1.Text = "3" Or TextBox1.Text = "4" Or TextBox1.Text = "5" Or TextBox1.Text = "6" Or TextBox1.Text = "7" Or TextBox1.Text = "8" Or TextBox1.Text = "9" Or TextBox1.Text = "0" Or TextBox1.Text = "Q" Or TextBox1.Text = "W" Or TextBox1.Text = "E" Or TextBox1.Text = "R" Or TextBox1.Text = "T" Or TextBox1.Text = "Y" Or TextBox1.Text = "U" Or TextBox1.Text = "I" Or TextBox1.Text = "O" Or TextBox1.Text = "P" Or TextBox1.Text = "A" Or TextBox1.Text = "S" Or TextBox1.Text = "D" Or TextBox1.Text = "G" Or TextBox1.Text = "H" Or TextBox1.Text = "J" Or TextBox1.Text = "K" Or TextBox1.Text = "L" Or TextBox1.Text = "Z" Or TextBox1.Text = "X" Or TextBox1.Text = "C" Or TextBox1.Text = "V" Or TextBox1.Text = "B" Or TextBox1.Text = "N" Or TextBox1.Text = "M" Or TextBox2.Text = "+" Or TextBox2.Text = "MMB" Or TextBox2.Text = "-" Or TextBox2.Text = "DOWN" Or TextBox2.Text = "UP" Or TextBox2.Text = "LEFT" Or TextBox2.Text = "RIGHT" Or TextBox2.Text = "LMB" Or TextBox2.Text = "RMB" Or TextBox2.Text = "NM9" Or TextBox2.Text = "NM8" Or TextBox2.Text = "NM7" Or TextBox2.Text = "NM6" Or TextBox2.Text = "NM5" Or TextBox2.Text = "NM4" Or TextBox2.Text = "NM3" Or TextBox2.Text = "NM2" Or TextBox2.Text = "NM1" Or TextBox2.Text = "NM0" Or TextBox2.Text = "NMLOCK" Or TextBox2.Text = "PGDOWN" Or TextBox2.Text = "PGUP" Or TextBox2.Text = "INS" Or TextBox2.Text = "ESC" Or TextBox2.Text = "END" Or TextBox2.Text = "*" Or TextBox2.Text = "/" Or TextBox2.Text = "BACK" Or TextBox2.Text = "ENTER" Or TextBox2.Text = "LCTRL" Or TextBox2.Text = "RCTRL" Or TextBox2.Text = "CAPS" Or TextBox2.Text = "RSHIFT" Or TextBox2.Text = "LSHIFT" Or TextBox2.Text = "TAB" Or TextBox2.Text = "ALT" Or TextBox2.Text = "SBAR" Or TextBox2.Text = "1" Or TextBox2.Text = "2" Or TextBox2.Text = "3" Or TextBox2.Text = "4" Or TextBox2.Text = "5" Or TextBox2.Text = "6" Or TextBox2.Text = "7" Or TextBox2.Text = "8" Or TextBox2.Text = "9" Or TextBox2.Text = "0" Or TextBox2.Text = "Q" Or TextBox2.Text = "W" Or TextBox2.Text = "E" Or TextBox2.Text = "R" Or TextBox2.Text = "T" Or TextBox2.Text = "Y" Or TextBox2.Text = "U" Or TextBox2.Text = "I" Or TextBox2.Text = "O" Or TextBox2.Text = "P" Or TextBox2.Text = "A" Or TextBox2.Text = "S" Or TextBox2.Text = "D" Or TextBox2.Text = "G" Or TextBox2.Text = "H" Or TextBox2.Text = "J" Or TextBox2.Text = "K" Or TextBox2.Text = "L" Or TextBox2.Text = "Z" Or TextBox2.Text = "X" Or TextBox2.Text = "C" Or TextBox2.Text = "V" Or TextBox2.Text = "B" Or TextBox2.Text = "N" Or TextBox2.Text = "M"
            '        MsgBox("Not a valid simbol", MsgBoxStyle.Exclamation, "")
            'End Select
            'Select Case dager
            '    Case TextBox1.Text = 1 To 144
            '        ListBox3.Items.Add(dager)
            '    Case Else

            'End Select
            If TextBox1.Text = TextBox2.Text Then
                TextBox2.Text = ""
                MsgBox("Choose a different from the first key!", MsgBoxStyle.Exclamation)
                CheckBox4.Checked = True
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If keybord115.Enabled = False Then
            keybord115.Start()
        Else
            keybord115.Stop()
        End If

    End Sub
    Private Sub keybord115_Tick(sender As Object, e As EventArgs) Handles keybord115.Tick
        Label2.Text += 1
        My.Computer.Keyboard.SendKeys(keypreserx.Text)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox3.Items.Clear()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If GetKeyState(stufbat) Then
            keybord115.Enabled = True
        Else
            keybord115.Enabled = False
        End If
        If keybord115.Enabled = False And Not Label2.Text = 0 Then
            ListBox3.Items.Add(Label2.Text)
            Label2.Text = 0
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class