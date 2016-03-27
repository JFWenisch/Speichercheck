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


        Timer3.Start()
        Timer4.Start()


        Label2.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label8.Visible = True



        cdrive = My.Computer.FileSystem.GetDriveInfo(x)
        Label2.Text = (cdrive.TotalFreeSpace / 1073741824)
        Label14.Text = (cdrive.TotalFreeSpace / 1073741824)
        


        If Label2.Text <= TextBox1.Text Then Label2.ForeColor = Color.Red
        If Label14.Text <= TextBox1.Text Then Label2.ForeColor = Color.Red

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

        If System.IO.Directory.Exists("C:\Documents and Settings\All Users\Documents\SC") Then GoTo Erstellen Else 
        System.IO.Directory.CreateDirectory("C:\Documents and Settings\All Users\Documents\SC")
Erstellen:

        If System.IO.File.Exists("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy")) Then GoTo Schreiben Else 
        System.IO.File.Create("C:\Documents and Settings\All Users\Documents\SC\SC" + DateTime.Now.ToString("MM/dd/yyyy") + ".txt")

Schreiben:

        Timer1.Interval = 10000
        Timer1.Enabled = True

        Timer2.Interval = 30000
        Timer2.Enabled = True


        Timer3.Interval = 1000
        Timer3.Enabled = True

        Timer4.Interval = 90000
        Timer4.Enabled = True



    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If Label2.Text <= TextBox1.Text Then MsgBox("Speicher im kritischen Bereich", , "Warnung")

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

        CreateGraph(ZedGraphControl1)
        Me.DesktopBounds = New Rectangle(100, 100, 519, 380)
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
        'myPane.XAxis.MajorGrid.IsVisible = True
        myPane.YAxis.MajorGrid.IsVisible = True
        'myPane.XAxis.MajorGrid.Color = Color.White
        myPane.YAxis.MajorGrid.Color = Color.White
        myPane.Chart.Fill = New Fill(Color.Black)
        myPane.Fill = New Fill(Color.White)


        myPane.XAxis.Type = AxisType.Date
        myPane.XAxis.Scale.Format = "hh:mm:ssss"
        myPane.Legend.IsVisible = False

        ' Neue Linie erstelle (Formatierung)
        list.Add(x, Label2.Text)
        Dim myCurve As LineItem = myPane.AddCurve("Speicherplatz", list, Color.White, SymbolType.Circle)
        myCurve.Line.Width = 2.0F
        myCurve.Line.IsAntiAlias = True
        myCurve.Line.Color = Color.White
        myCurve.Symbol.Fill = New Fill(Color.White)
        myCurve.Symbol.Size = 7
        myCurve.Line.IsVisible = True
        myCurve.Line.Fill = New Fill(Color.White, Color.Red, 45.0F)

        ' Calculate the Axis Scale Ranges
        zgc.AxisChange()
        ZedGraphControl1.Invalidate()
    End Sub

    Private Sub MyRoutine()
        Dim s As String
        s = DateTime.Now
        Dim Msg As New MailMessage
        Dim myCredentials As New System.Net.NetworkCredential
        Dim p As String
        p = TextBox4.Text

        myCredentials.UserName = "m01b55d7"
        myCredentials.Password = "testtesttest"

        Msg.IsBodyHtml = False

        Dim mySmtpsvr As New SmtpClient()
        mySmtpsvr.Host = " smtp.afroliciouzz.de"
        mySmtpsvr.Port = 25

        mySmtpsvr.UseDefaultCredentials = False
        mySmtpsvr.Credentials = myCredentials

        Try
            Msg.From = New MailAddress("Speichercheck@afroliciouzz.de")
            Msg.To.Add(p)
            Msg.Subject = "Speichercheck"
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

    Private Sub ZedGraphControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZedGraphControl1.Load

    End Sub


    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        'Firstly(we) 'll define some parameters.
        Dim CurrentTab As TabPage = TabControl1.TabPages(e.Index)
        Dim ItemRect As Rectangle = TabControl1.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.Black)
        Dim TextBrush As New SolidBrush(Color.White)

        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.White
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

End Class