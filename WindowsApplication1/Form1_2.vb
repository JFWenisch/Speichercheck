Imports ZedGraph
Imports System.Net.Mail
Imports System.IO
Imports System





Public Class Form1






    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim s As String
        s = DateTime.Now
        Dim cdrive As System.IO.DriveInfo
        Dim x As String
        x = TextBox2.Text


        Label2.Visible = True
       
        Label13.Visible = True


        Try


            cdrive = My.Computer.FileSystem.GetDriveInfo(x)
            Dim a = cdrive.TotalFreeSpace

            Label2.Text = (cdrive.TotalFreeSpace / 1073741824)
        Catch


            MsgBox("Laufwerk wurde nicht gefunden", , "Warnung")

        End Try

        Timer3.Start()


        If Label2.Text <= TextBox3.Text Then Label2.ForeColor = Color.Red
        If Label2.Text >= TextBox3.Text Then Label2.ForeColor = Color.Green
        If Label2.Text <= TextBox1.Text Then Label2.ForeColor = Color.Red
        If Label2.Text >= TextBox1.Text Then Label2.ForeColor = Color.Green


        Try
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), vbNewLine & "Laufwerk:<")
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), x & ">")
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), "Speicherplatz:<")
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), Label2.Text & ">")
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), "Datum:<")
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), s & ">")

            RichTextBox1.Text += vbNewLine & "Laufwerk:<" & x & "> " & "Speicherplatz:<" & Label2.Text & "> " & "Datum:<" & s & "> "


            CreateGraph(ZedGraphControl1)
        Catch
            RichTextBox1.Text += vbNewLine & "Laufwerk:<" & x & "> " & "Speicherplatz:<" & Label2.Text & "> " & "Datum:<" & s & "> "
            CreateGraph(ZedGraphControl1)

        End Try



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Button2.Visible = True
        Me.Button1.Visible = False
        If System.IO.Directory.Exists("C:\Documents and Settings\All Users\Documents\SC") Then GoTo Erstellen Else 
        System.IO.Directory.CreateDirectory("C:\Documents and Settings\All Users\Documents\SC")
Erstellen:

        If System.IO.File.Exists("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy")) Then GoTo Schreiben Else 
        System.IO.File.Create("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy") + ".txt")

Schreiben:


        Dim i As Integer
        If TrackBar1.Value = 0 Then i = 10000
        If TrackBar1.Value = 1 Then i = 60000
        If TrackBar1.Value = 2 Then i = 300000
        If TrackBar1.Value = 3 Then i = 900000
        If TrackBar1.Value = 4 Then i = 1800000
        If TrackBar1.Value = 5 Then i = 3600000

        Dim cdrive As System.IO.DriveInfo
        Dim x As String
        x = TextBox2.Text
        cdrive = My.Computer.FileSystem.GetDriveInfo(x)
        Label2.Text = (cdrive.TotalFreeSpace / 1073741824)


        Timer1.Interval = i
        Timer1.Enabled = True

        Timer2.Interval = i
        Timer2.Enabled = True


        Timer3.Interval = i / 10
        Timer3.Enabled = True
        
        Timer4.Interval = i
        Timer4.Enabled = True
        Timer4.Start()

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False

        CheckBox1.Enabled = False
        CheckBox2.Enabled = False



    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If Label2.Text <= TextBox1.Text Then MsgBox("Speicher im kritischen Bereich", , "Warnung")
        Timer2.Stop()

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        ProgressBar1.Value += 1
        ProgressBar1.Maximum = 10
        If ProgressBar1.Value = 10 Then ProgressBar1.Value = ProgressBar1.Value - 10

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        If Me.WindowState = FormWindowState.Minimized Then NotifyIcon1.ShowBalloonTip(10)

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed

        TrackBar1.Maximum = 5
        TrackBar1.TickFrequency = 1
        TrackBar1.LargeChange = 1
        TrackBar1.SmallChange = 1


        CreateGraph(ZedGraphControl1)
        Me.DesktopBounds = New Rectangle(100, 100, 600, 500)
        If Me.WindowState = FormWindowState.Normal Then Me.ShowInTaskbar = True
        If Me.WindowState = FormWindowState.Maximized Then Me.ShowInTaskbar = True
        If Me.WindowState = FormWindowState.Minimized Then Me.ShowInTaskbar = False
        NotifyIcon1.Visible = True




    End Sub
    Private Sub NotifyIcon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseMove

        NotifyIcon1.Text = "Freier Festplattenspeicher: " & Label2.Text

    End Sub
    Private Sub CreateGraph(ByVal zgc As ZedGraphControl)
        Dim x As Double
        x = New XDate(DateTime.Now)
        Dim myPane As GraphPane = zgc.GraphPane
        Dim list = New PointPairList()



        ' Set the titles and axis labels
        myPane.Title.Text = "Speicherplatz"
        myPane.XAxis.Title.Text = "Zeitachse"
        myPane.YAxis.Title.Text = "Freier Speicher in Gb"
        ' Farben bestimmen



        'Punktierung einsetzen und Farbe bestimmen
        myPane.XAxis.MajorGrid.IsVisible = True
        myPane.YAxis.MajorGrid.IsVisible = True
        myPane.XAxis.MajorGrid.Color = Color.Black
        myPane.YAxis.MajorGrid.Color = Color.Black
        myPane.Fill = New Fill(Color.White)


        myPane.XAxis.Type = AxisType.Date
        myPane.XAxis.Scale.Format = "hh:mm:ssss"
        myPane.Legend.IsVisible = False

        ' Neue Linie erstelle (Formatierung)
        list.Add(x, Label2.Text)
        Dim myCurve As LineItem = myPane.AddCurve("Speicherplatz", list, Color.Red, SymbolType.Diamond)
        myCurve.Line.Width = 10.0F
        myCurve.Line.Color = Color.Red
        myCurve.Symbol.Fill = New Fill(Color.Black)
        myCurve.Symbol.Size = 7
        myPane.Chart.Fill = New Fill(Color.White,
    Color.FromArgb(200, 255, 200), -45.0F)
        myCurve.Line.Fill = New Fill(Color.Black, Color.Red, 45.0F)
        myCurve.Line.IsVisible = True
        

        ' Calculate the Axis Scale Ranges
        zgc.AxisChange()
        ZedGraphControl1.Invalidate()
    End Sub

    Private Sub MyRoutine()

        Timer4.Stop()
        Dim s As String
        s = DateTime.Now
        Dim Msg As New MailMessage
        Dim myCredentials As New System.Net.NetworkCredential
        Dim p As String
        p = TextBox4.Text


        myCredentials.UserName = TextBox5.Text
        myCredentials.Password = TextBox6.Text

        Msg.IsBodyHtml = False

        Dim mySmtpsvr As New SmtpClient()
        mySmtpsvr.Host = TextBox7.Text
        mySmtpsvr.Port = TextBox8.Text
        mySmtpsvr.EnableSsl = False
        If CheckBox1.Checked Then mySmtpsvr.EnableSsl = True
        mySmtpsvr.UseDefaultCredentials = False
        mySmtpsvr.Credentials = myCredentials

        Try
            Msg.From = New MailAddress("Speichercheck@nirako.de")
            Msg.To.Add(p)
            Msg.Subject = "Speichercheck: Benachrichtigung über geringen Speicherplatz auf " + TextBox2.Text
            Msg.Body = "Speichercheck hat erkannt das am  " + s + " der Speicher die von Ihnen gewählte Grenze unterschritten hat. Der aktuelle Speicherplatz betrug zum Zeitpunkt der Messung: " + Label2.Text + " .Sofern die Option ausgewählt wurde, finden Sie angehängt das Log File,dass Sie mit einem Texteditor öffnen können"
            Dim att As Attachment = Nothing
            att = New Attachment("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"))
            If CheckBox2.Checked = True Then Msg.Attachments.Add(att)

            mySmtpsvr.Send(Msg)
            MsgBox("E-Mail gesendet.", MsgBoxStyle.Information, Title:="Information")
        Catch ex As Exception
            MsgBox("Um eine E-Mail verschicken zu können muss unter -Erweitert- die richtige E-Mail Adresse eingetragen sein.", MsgBoxStyle.Critical, Title:="E-Mail nicht gesendet") 'Falls ein Fehler auftritt wird eine MsgBox angezeigt

        End Try


    End Sub


    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        If Label2.Text <= TextBox3.Text Then MyRoutine()

    End Sub


    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        'Firstly(we) 'll define some parameters.
        Dim CurrentTab As TabPage = TabControl1.TabPages(e.Index)
        Dim ItemRect As Rectangle = TabControl1.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.White)
        Dim TextBrush As New SolidBrush(Color.Black)

        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.WhiteSmoke
            TextBrush.Color = Color.Black
            ItemRect.Inflate(2, 2)
        End If

        'Set up rotation for left and right aligned tabs
        If TabControl1.Alignment = TabAlignment.Left Or TabControl1.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If TabControl1.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(ItemRect.Left + (ItemRect.Width \ 2), ItemRect.Top + (ItemRect.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            ItemRect = New Rectangle(-(ItemRect.Height \ 2), -(ItemRect.Width \ 2), ItemRect.Height, ItemRect.Width)
        End If

        'Next we'll paint the TabItem with our Fill Brush
        e.Graphics.FillRectangle(FillBrush, ItemRect)


        'Now draw the text.h
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)
        'Reset any Graphics rotation
        e.Graphics.ResetTransform()

        'Finally, we should Dispose of our brushes.
        FillBrush.Dispose()
        TextBrush.Dispose()

    End Sub


    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        ProgressBar1.Value = 0
        Me.Button1.Show()
        Me.Button2.Hide()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        ProgressBar1.Value = 0
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        Me.Button1.Show()
        Me.Button2.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim s As String
        s = DateTime.Now
        Dim cdrive As System.IO.DriveInfo
        Dim x As String
        x = TextBox2.Text

        Label2.Visible = True
        Label13.Visible = True

        Try

            cdrive = My.Computer.FileSystem.GetDriveInfo(x)
            Label2.Text = (cdrive.TotalFreeSpace / 1073741824)
        Catch

            MsgBox("Laufwerk wurde nicht gefunden", , "Warnung")

        End Try


        If Label2.Text <= TextBox1.Text Then Label2.ForeColor = Color.Red

        Try
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), vbNewLine & "Laufwerk:<")
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), x & ">")
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), "Speicherplatz:<")
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), Label2.Text & ">")
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), "Datum:<")
            System.IO.File.AppendAllText("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy"), s & ">")

            RichTextBox1.Text += vbNewLine & "Laufwerk:<" & x & "> " & "Speicherplatz:<" & Label2.Text & "> " & "Datum:<" & s & "> "


            CreateGraph(ZedGraphControl1)
        Catch
            RichTextBox1.Text += vbNewLine & "Laufwerk:<" & x & "> " & "Speicherplatz:<" & Label2.Text & "> " & "Datum:<" & s & "> "
            CreateGraph(ZedGraphControl1)

        End Try


    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class