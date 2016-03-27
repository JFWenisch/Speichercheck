<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ZedGraphControl1 = New ZedGraph.ZedGraphControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(-2, 445)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(587, 20)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 13
        '
        'Timer3
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Speichercheck wird noch ausgeführt !"
        Me.NotifyIcon1.BalloonTipTitle = "Achtung"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Speichercheck"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label2.Location = New System.Drawing.Point(415, 2)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "00"
        Me.Label2.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-2, -3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(587, 453)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TrackBar1)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(579, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Window
        Me.Label22.Location = New System.Drawing.Point(6, 163)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(149, 14)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Intervall der Überprüfung:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Window
        Me.Label21.Location = New System.Drawing.Point(464, 211)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 13)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "30 min"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Window
        Me.Label20.Location = New System.Drawing.Point(404, 211)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "15min"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Window
        Me.Label19.Location = New System.Drawing.Point(286, 211)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "1 min"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Window
        Me.Label18.Location = New System.Drawing.Point(296, 211)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "10"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Window
        Me.Label17.Location = New System.Drawing.Point(351, 211)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "5 min"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Window
        Me.Label16.Location = New System.Drawing.Point(518, 211)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "1 std"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Window
        Me.Label15.Location = New System.Drawing.Point(232, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "10 sek"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(225, 163)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(320, 45)
        Me.TrackBar1.TabIndex = 29
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.Window
        Me.Label25.Location = New System.Drawing.Point(531, 282)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(22, 14)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Gb"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(531, 322)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 14)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Gb"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(363, 77)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 30)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Instant-check"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(50, 385)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(473, 30)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(50, 385)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(473, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(516, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Build 1.7"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(479, 237)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(44, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(479, 322)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(44, 20)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(479, 276)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(44, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(2, 243)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Laufwerksbuchstaben eingeben."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(2, 322)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "E-Mail Benachrichtigung bei wieviel Restspeicher ?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(2, 282)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Warnung bei wieviel Restpeicherplatz?"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Black
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.CheckBox1)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.TextBox8)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.TextBox4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.CheckBox2)
        Me.TabPage3.ForeColor = System.Drawing.Color.White
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(579, 424)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mail Konfiguration"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.Window
        Me.Label29.Location = New System.Drawing.Point(47, 123)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(211, 24)
        Me.Label29.TabIndex = 27
        Me.Label29.Text = "SMTP Konfiguration"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(224, 231)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(159, 21)
        Me.TextBox8.TabIndex = 26
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.Window
        Me.Label28.Location = New System.Drawing.Point(48, 238)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 14)
        Me.Label28.TabIndex = 25
        Me.Label28.Text = "SMTP Port :"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(224, 204)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(320, 21)
        Me.TextBox7.TabIndex = 24
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.Window
        Me.Label27.Location = New System.Drawing.Point(48, 211)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 14)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "SMTP Server :"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(224, 177)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(320, 21)
        Me.TextBox6.TabIndex = 22
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.Window
        Me.Label26.Location = New System.Drawing.Point(48, 184)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 14)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Passwort :"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(224, 150)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(320, 21)
        Me.TextBox5.TabIndex = 20
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Window
        Me.Label23.Location = New System.Drawing.Point(48, 157)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 14)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Username :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.Window
        Me.Label24.Location = New System.Drawing.Point(385, 410)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(189, 12)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "Die E-Mail Adresse wird nicht(!) gespeichert."
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(224, 58)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(320, 21)
        Me.TextBox4.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(48, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Empfänger E-Mail Adresse :"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Location = New System.Drawing.Point(410, 85)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(134, 17)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "LOG-File anhängen"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Controls.Add(Me.ZedGraphControl1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(579, 424)
        Me.TabPage2.TabIndex = 6
        Me.TabPage2.Text = "Überwachung"
        '
        'ZedGraphControl1
        '
        Me.ZedGraphControl1.BackColor = System.Drawing.Color.Transparent
        Me.ZedGraphControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ZedGraphControl1.Location = New System.Drawing.Point(3, 6)
        Me.ZedGraphControl1.Name = "ZedGraphControl1"
        Me.ZedGraphControl1.ScrollGrace = 0.0R
        Me.ZedGraphControl1.ScrollMaxX = 0.0R
        Me.ZedGraphControl1.ScrollMaxY = 0.0R
        Me.ZedGraphControl1.ScrollMaxY2 = 0.0R
        Me.ZedGraphControl1.ScrollMinX = 0.0R
        Me.ZedGraphControl1.ScrollMinY = 0.0R
        Me.ZedGraphControl1.ScrollMinY2 = 0.0R
        Me.ZedGraphControl1.Size = New System.Drawing.Size(573, 254)
        Me.ZedGraphControl1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Black
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.PictureBox3)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.RichTextBox2)
        Me.TabPage4.Controls.Add(Me.RichTextBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(579, 424)
        Me.TabPage4.TabIndex = 7
        Me.TabPage4.Text = "Credits"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(6, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Kontakt:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(6, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Haftung:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.Black
        Me.RichTextBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Transparent
        Me.RichTextBox2.Location = New System.Drawing.Point(63, 195)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(393, 46)
        Me.RichTextBox2.TabIndex = 6
        Me.RichTextBox2.Text = "visit: www.nirako.de" & Global.Microsoft.VisualBasic.ChrW(10) & "E-Mail: info@nirako.de"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.Black
        Me.RichTextBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox4.ForeColor = System.Drawing.Color.Transparent
        Me.RichTextBox4.Location = New System.Drawing.Point(63, 47)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.Size = New System.Drawing.Size(393, 112)
        Me.RichTextBox4.TabIndex = 5
        Me.RichTextBox4.Text = resources.GetString("RichTextBox4.Text")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label13.Location = New System.Drawing.Point(316, 2)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 14)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Restspeicher:"
        Me.Label13.Visible = False
        '
        'Timer4
        '
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 266)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(573, 158)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = "----- Aktuelles Log -----"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(199, 371)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(346, 12)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Logs sind zu finden unter ""C:\Documents and Settings\All Users\Documents\SC\"""
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 153)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(135, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(395, 237)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(149, 17)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "SSL Verschlüsselung:"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = Global.Speichercheck.My.Resources.Resources.LOGO
        Me.PictureBox3.Location = New System.Drawing.Point(385, 327)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 59)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Aharoni", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 500)
        Me.Name = "Form1"
        Me.Text = "Speichercheck"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents ZedGraphControl1 As ZedGraph.ZedGraphControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
