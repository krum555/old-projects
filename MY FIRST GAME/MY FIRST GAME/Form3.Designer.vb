<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox6 = New System.Windows.Forms.ToolStripTextBox()
        Me.SpeedOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox7 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox8 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox9 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTextBox10 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox11 = New System.Windows.Forms.ToolStripTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(609, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlsToolStripMenuItem, Me.SpeedOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(685, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox2, Me.ToolStripTextBox1, Me.ToolStripTextBox3, Me.ToolStripTextBox4, Me.ToolStripTextBox5, Me.ToolStripTextBox6})
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.ReadOnly = True
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox2.Text = "PAUSE"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "&P"
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.ReadOnly = True
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox3.Text = "LEFT"
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox4.Text = "&A"
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.ReadOnly = True
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox5.Text = "RIGHT"
        '
        'ToolStripTextBox6
        '
        Me.ToolStripTextBox6.Name = "ToolStripTextBox6"
        Me.ToolStripTextBox6.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox6.Text = "&D"
        '
        'SpeedOptionsToolStripMenuItem
        '
        Me.SpeedOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox7, Me.ToolStripTextBox8, Me.ToolStripTextBox9, Me.ToolStripComboBox1, Me.ToolStripTextBox10, Me.ToolStripTextBox11})
        Me.SpeedOptionsToolStripMenuItem.Name = "SpeedOptionsToolStripMenuItem"
        Me.SpeedOptionsToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.SpeedOptionsToolStripMenuItem.Text = "Speed Options"
        '
        'ToolStripTextBox7
        '
        Me.ToolStripTextBox7.Name = "ToolStripTextBox7"
        Me.ToolStripTextBox7.ReadOnly = True
        Me.ToolStripTextBox7.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox7.Text = "Speed build up"
        Me.ToolStripTextBox7.ToolTipText = "Rate at which the speed builds up" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the more you decrease the bigger the speed"
        '
        'ToolStripTextBox8
        '
        Me.ToolStripTextBox8.Name = "ToolStripTextBox8"
        Me.ToolStripTextBox8.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox8.Text = "100"
        Me.ToolStripTextBox8.ToolTipText = "Rate at which the speed builds up" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the more you decrease the bigger the speed"
        '
        'ToolStripTextBox9
        '
        Me.ToolStripTextBox9.Name = "ToolStripTextBox9"
        Me.ToolStripTextBox9.ReadOnly = True
        Me.ToolStripTextBox9.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox9.Text = "Speed build up ..."
        Me.ToolStripTextBox9.ToolTipText = "Speed build up on/off"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"True", "False"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ToolStripComboBox1.Text = "True"
        Me.ToolStripComboBox1.ToolTipText = "Speed build up on/off"
        '
        'ToolStripTextBox10
        '
        Me.ToolStripTextBox10.Name = "ToolStripTextBox10"
        Me.ToolStripTextBox10.ReadOnly = True
        Me.ToolStripTextBox10.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox10.Text = "Movement speed"
        Me.ToolStripTextBox10.ToolTipText = "The speed at which everything moves" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the more you decrease the bigger the speed"
        '
        'ToolStripTextBox11
        '
        Me.ToolStripTextBox11.Name = "ToolStripTextBox11"
        Me.ToolStripTextBox11.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox11.Text = "100"
        Me.ToolStripTextBox11.ToolTipText = "The speed at which everything moves" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the more you decrease the bigger the speed"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(685, 190)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox6 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SpeedOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox7 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox8 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox9 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripTextBox10 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox11 As System.Windows.Forms.ToolStripTextBox
End Class
