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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ZedGraphControl1 = New ZedGraph.ZedGraphControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
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
        Me.ProgressBar1.Location = New System.Drawing.Point(-2, 329)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(507, 20)
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
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label2.Location = New System.Drawing.Point(386, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 18)
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
        Me.TabControl1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-2, -3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(507, 340)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = Global.Speichercheck.My.Resources.Resources.Tabpagebg2
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(499, 308)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Window
        Me.Label14.Location = New System.Drawing.Point(329, 112)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 21)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "00"
        Me.Label14.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(10, 267)
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
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(419, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Build 1.0.5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(286, 80)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Restspeicher:"
        Me.Label8.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(290, 150)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 21)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(290, 232)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(176, 21)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(290, 191)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 21)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(4, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Zu überprüfenden Laufwerksbuchstaben eingeben." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Zum Beispiel : C"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(7, 218)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(278, 32)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "E-Mail Benachrichtigung bei wieviel Restspeicher ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Angabe in Gb)Zum Beispiel: 2" & _
            "5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(4, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Warnung bei wieviel Restpeicherplatz?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Angabe in Gigabyte)Zum Beispiel: 50"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(107, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 84)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(-318, -52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(851, 226)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.BackgroundImage = Global.Speichercheck.My.Resources.Resources.Tabpagebg2
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.TextBox4)
        Me.TabPage3.Controls.Add(Me.RichTextBox1)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.CheckBox2)
        Me.TabPage3.ForeColor = System.Drawing.Color.LimeGreen
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(499, 308)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Erweitert"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(159, 245)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(235, 21)
        Me.TextBox4.TabIndex = 7
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 13)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(458, 200)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = "----- Aktuelles Log -----"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tw Cen MT Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(137, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(337, 15)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Log Files sind zu finden unter ""C:\Documents and Settings\All Users\Documents\SC\" & _
            """"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(172, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Log File an E-Mail anhängen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(57, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "E-Mail Adresse :"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Location = New System.Drawing.Point(91, 281)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.Speichercheck.My.Resources.Resources.Tabpagebg2
        Me.TabPage2.Controls.Add(Me.ZedGraphControl1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(499, 308)
        Me.TabPage2.TabIndex = 6
        Me.TabPage2.Text = "Grafik"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ZedGraphControl1
        '
        Me.ZedGraphControl1.BackColor = System.Drawing.Color.Transparent
        Me.ZedGraphControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ZedGraphControl1.Location = New System.Drawing.Point(22, 20)
        Me.ZedGraphControl1.Name = "ZedGraphControl1"
        Me.ZedGraphControl1.ScrollGrace = 0.0R
        Me.ZedGraphControl1.ScrollMaxX = 0.0R
        Me.ZedGraphControl1.ScrollMaxY = 0.0R
        Me.ZedGraphControl1.ScrollMaxY2 = 0.0R
        Me.ZedGraphControl1.ScrollMinX = 0.0R
        Me.ZedGraphControl1.ScrollMinY = 0.0R
        Me.ZedGraphControl1.ScrollMinY2 = 0.0R
        Me.ZedGraphControl1.Size = New System.Drawing.Size(451, 264)
        Me.ZedGraphControl1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = Global.Speichercheck.My.Resources.Resources.Tabpagebg2
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.RichTextBox2)
        Me.TabPage4.Controls.Add(Me.RichTextBox4)
        Me.TabPage4.Controls.Add(Me.RichTextBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(499, 308)
        Me.TabPage4.TabIndex = 7
        Me.TabPage4.Text = "Credits"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(7, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Kontakt:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(7, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Haftung:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(10, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "About:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.Black
        Me.RichTextBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Transparent
        Me.RichTextBox2.Location = New System.Drawing.Point(10, 247)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(451, 51)
        Me.RichTextBox2.TabIndex = 6
        Me.RichTextBox2.Text = "visit: www.afroliciouzz.de" & Global.Microsoft.VisualBasic.ChrW(10) & "E-Mail: email@afroliciouzz.de"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.Black
        Me.RichTextBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox4.ForeColor = System.Drawing.Color.Transparent
        Me.RichTextBox4.Location = New System.Drawing.Point(10, 163)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.Size = New System.Drawing.Size(451, 45)
        Me.RichTextBox4.TabIndex = 5
        Me.RichTextBox4.Text = resources.GetString("RichTextBox4.Text")
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BackColor = System.Drawing.Color.Black
        Me.RichTextBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RichTextBox5.ForeColor = System.Drawing.Color.Transparent
        Me.RichTextBox5.Location = New System.Drawing.Point(10, 96)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.Size = New System.Drawing.Size(451, 45)
        Me.RichTextBox5.TabIndex = 4
        Me.RichTextBox5.Text = resources.GetString("RichTextBox5.Text")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label13.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label13.Location = New System.Drawing.Point(252, 4)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 18)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Restspeicher:"
        Me.Label13.Visible = False
        '
        'Timer4
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Speichercheck.My.Resources.Resources.Tabpagebg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(503, 349)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Aharoni", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(519, 385)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Speichercheck"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
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
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents ZedGraphControl1 As ZedGraph.ZedGraphControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
