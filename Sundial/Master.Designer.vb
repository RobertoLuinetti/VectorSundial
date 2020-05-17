<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LongQ = New System.Windows.Forms.TextBox()
        Me.LatQ = New System.Windows.Forms.TextBox()
        Me.LongS = New System.Windows.Forms.TextBox()
        Me.LatS = New System.Windows.Forms.TextBox()
        Me.LongP = New System.Windows.Forms.TextBox()
        Me.LongG = New System.Windows.Forms.TextBox()
        Me.LatP = New System.Windows.Forms.TextBox()
        Me.LatG = New System.Windows.Forms.TextBox()
        Me.PicGraph = New System.Windows.Forms.PictureBox()
        Me.ButtonDXF = New System.Windows.Forms.Button()
        Me.Declinazione = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Linee_Ore = New System.Windows.Forms.RadioButton()
        Me.Linee_MezzeOre = New System.Windows.Forms.RadioButton()
        Me.Linee_QuartiOra = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeclinazioneTXT = New System.Windows.Forms.TextBox()
        Me.TrackBarHoff = New System.Windows.Forms.TrackBar()
        Me.TrackBarVoff = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxhoff = New System.Windows.Forms.TextBox()
        Me.TextBoxVoff = New System.Windows.Forms.TextBox()
        Me.Gnomone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Altezza = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Larghezza = New System.Windows.Forms.TextBox()
        Me.ButtonBMP = New System.Windows.Forms.Button()
        Me.RBh12 = New System.Windows.Forms.RadioButton()
        Me.RBAll = New System.Windows.Forms.RadioButton()
        Me.RBGraph = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CB_TimeEq = New System.Windows.Forms.CheckBox()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LBSavedSetup = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RTB_OutData = New System.Windows.Forms.RichTextBox()
        Me.GeoButton = New System.Windows.Forms.Button()
        Me.ButtonMotto = New System.Windows.Forms.Button()
        Me.Motto = New System.Windows.Forms.TextBox()
        CType(Me.PicGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Declinazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBarHoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarVoff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(27, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "LONG"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(37, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "LAT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LongQ
        '
        Me.LongQ.Location = New System.Drawing.Point(158, 41)
        Me.LongQ.Name = "LongQ"
        Me.LongQ.Size = New System.Drawing.Size(13, 20)
        Me.LongQ.TabIndex = 25
        Me.LongQ.Text = "E"
        Me.LongQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatQ
        '
        Me.LatQ.Location = New System.Drawing.Point(158, 12)
        Me.LatQ.Name = "LatQ"
        Me.LatQ.Size = New System.Drawing.Size(13, 20)
        Me.LatQ.TabIndex = 24
        Me.LatQ.Text = "N"
        Me.LatQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongS
        '
        Me.LongS.Location = New System.Drawing.Point(117, 41)
        Me.LongS.Name = "LongS"
        Me.LongS.Size = New System.Drawing.Size(35, 20)
        Me.LongS.TabIndex = 23
        Me.LongS.Text = "28,4"
        Me.LongS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatS
        '
        Me.LatS.Location = New System.Drawing.Point(117, 12)
        Me.LatS.Name = "LatS"
        Me.LatS.Size = New System.Drawing.Size(35, 20)
        Me.LatS.TabIndex = 22
        Me.LatS.Text = "42,7"
        Me.LatS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongP
        '
        Me.LongP.Location = New System.Drawing.Point(92, 41)
        Me.LongP.Name = "LongP"
        Me.LongP.Size = New System.Drawing.Size(19, 20)
        Me.LongP.TabIndex = 21
        Me.LongP.Text = "4"
        Me.LongP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongG
        '
        Me.LongG.Location = New System.Drawing.Point(67, 41)
        Me.LongG.Name = "LongG"
        Me.LongG.Size = New System.Drawing.Size(19, 20)
        Me.LongG.TabIndex = 20
        Me.LongG.Text = "9"
        Me.LongG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatP
        '
        Me.LatP.Location = New System.Drawing.Point(92, 12)
        Me.LatP.Name = "LatP"
        Me.LatP.Size = New System.Drawing.Size(19, 20)
        Me.LatP.TabIndex = 19
        Me.LatP.Text = "35"
        Me.LatP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatG
        '
        Me.LatG.Location = New System.Drawing.Point(67, 12)
        Me.LatG.Name = "LatG"
        Me.LatG.Size = New System.Drawing.Size(19, 20)
        Me.LatG.TabIndex = 18
        Me.LatG.Text = "45"
        Me.LatG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PicGraph
        '
        Me.PicGraph.Location = New System.Drawing.Point(15, 132)
        Me.PicGraph.Name = "PicGraph"
        Me.PicGraph.Size = New System.Drawing.Size(137, 112)
        Me.PicGraph.TabIndex = 28
        Me.PicGraph.TabStop = False
        '
        'ButtonDXF
        '
        Me.ButtonDXF.Location = New System.Drawing.Point(67, 98)
        Me.ButtonDXF.Name = "ButtonDXF"
        Me.ButtonDXF.Size = New System.Drawing.Size(47, 23)
        Me.ButtonDXF.TabIndex = 29
        Me.ButtonDXF.Text = "Vector"
        Me.ButtonDXF.UseVisualStyleBackColor = True
        '
        'Declinazione
        '
        Me.Declinazione.Location = New System.Drawing.Point(532, 35)
        Me.Declinazione.Maximum = 1800
        Me.Declinazione.Name = "Declinazione"
        Me.Declinazione.Size = New System.Drawing.Size(104, 45)
        Me.Declinazione.TabIndex = 30
        Me.Declinazione.TickFrequency = 300
        Me.Declinazione.Value = 900
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(542, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Wall declination"
        '
        'Linee_Ore
        '
        Me.Linee_Ore.AutoSize = True
        Me.Linee_Ore.Location = New System.Drawing.Point(16, 19)
        Me.Linee_Ore.Name = "Linee_Ore"
        Me.Linee_Ore.Size = New System.Drawing.Size(53, 17)
        Me.Linee_Ore.TabIndex = 32
        Me.Linee_Ore.TabStop = True
        Me.Linee_Ore.Text = "Hours"
        Me.Linee_Ore.UseVisualStyleBackColor = True
        '
        'Linee_MezzeOre
        '
        Me.Linee_MezzeOre.AutoSize = True
        Me.Linee_MezzeOre.Location = New System.Drawing.Point(16, 42)
        Me.Linee_MezzeOre.Name = "Linee_MezzeOre"
        Me.Linee_MezzeOre.Size = New System.Drawing.Size(73, 17)
        Me.Linee_MezzeOre.TabIndex = 33
        Me.Linee_MezzeOre.TabStop = True
        Me.Linee_MezzeOre.Text = "Half hours"
        Me.Linee_MezzeOre.UseVisualStyleBackColor = True
        '
        'Linee_QuartiOra
        '
        Me.Linee_QuartiOra.AutoSize = True
        Me.Linee_QuartiOra.Location = New System.Drawing.Point(16, 65)
        Me.Linee_QuartiOra.Name = "Linee_QuartiOra"
        Me.Linee_QuartiOra.Size = New System.Drawing.Size(89, 17)
        Me.Linee_QuartiOra.TabIndex = 34
        Me.Linee_QuartiOra.TabStop = True
        Me.Linee_QuartiOra.Text = "Quarter hours"
        Me.Linee_QuartiOra.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Linee_Ore)
        Me.GroupBox1.Controls.Add(Me.Linee_QuartiOra)
        Me.GroupBox1.Controls.Add(Me.Linee_MezzeOre)
        Me.GroupBox1.Location = New System.Drawing.Point(882, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 89)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(524, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "O"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(632, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "E"
        '
        'DeclinazioneTXT
        '
        Me.DeclinazioneTXT.BackColor = System.Drawing.SystemColors.Control
        Me.DeclinazioneTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DeclinazioneTXT.Location = New System.Drawing.Point(606, 71)
        Me.DeclinazioneTXT.Name = "DeclinazioneTXT"
        Me.DeclinazioneTXT.Size = New System.Drawing.Size(30, 13)
        Me.DeclinazioneTXT.TabIndex = 38
        Me.DeclinazioneTXT.Text = "0"
        Me.DeclinazioneTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackBarHoff
        '
        Me.TrackBarHoff.Location = New System.Drawing.Point(654, 35)
        Me.TrackBarHoff.Maximum = 60
        Me.TrackBarHoff.Minimum = -60
        Me.TrackBarHoff.Name = "TrackBarHoff"
        Me.TrackBarHoff.Size = New System.Drawing.Size(104, 45)
        Me.TrackBarHoff.TabIndex = 39
        Me.TrackBarHoff.TickFrequency = 20
        '
        'TrackBarVoff
        '
        Me.TrackBarVoff.Location = New System.Drawing.Point(766, 35)
        Me.TrackBarVoff.Maximum = 20
        Me.TrackBarVoff.Minimum = -40
        Me.TrackBarVoff.Name = "TrackBarVoff"
        Me.TrackBarVoff.Size = New System.Drawing.Size(104, 45)
        Me.TrackBarVoff.TabIndex = 40
        Me.TrackBarVoff.TickFrequency = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(785, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Vertical shift"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(667, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Horizontal shift"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(657, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Center"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(767, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 23)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Default"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxhoff
        '
        Me.TextBoxhoff.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxhoff.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxhoff.Location = New System.Drawing.Point(728, 68)
        Me.TextBoxhoff.Name = "TextBoxhoff"
        Me.TextBoxhoff.Size = New System.Drawing.Size(30, 13)
        Me.TextBoxhoff.TabIndex = 45
        Me.TextBoxhoff.Text = "0"
        Me.TextBoxhoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxVoff
        '
        Me.TextBoxVoff.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxVoff.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxVoff.Location = New System.Drawing.Point(836, 68)
        Me.TextBoxVoff.Name = "TextBoxVoff"
        Me.TextBoxVoff.Size = New System.Drawing.Size(30, 13)
        Me.TextBoxVoff.TabIndex = 46
        Me.TextBoxVoff.Text = "0"
        Me.TextBoxVoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Gnomone
        '
        Me.Gnomone.Location = New System.Drawing.Point(185, 41)
        Me.Gnomone.Name = "Gnomone"
        Me.Gnomone.ReadOnly = True
        Me.Gnomone.Size = New System.Drawing.Size(51, 20)
        Me.Gnomone.TabIndex = 47
        Me.Gnomone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(189, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Gnomon"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Height"
        '
        'Altezza
        '
        Me.Altezza.Location = New System.Drawing.Point(244, 41)
        Me.Altezza.Name = "Altezza"
        Me.Altezza.Size = New System.Drawing.Size(51, 20)
        Me.Altezza.TabIndex = 49
        Me.Altezza.Text = "50"
        Me.Altezza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(310, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Width"
        '
        'Larghezza
        '
        Me.Larghezza.Location = New System.Drawing.Point(301, 41)
        Me.Larghezza.Name = "Larghezza"
        Me.Larghezza.Size = New System.Drawing.Size(51, 20)
        Me.Larghezza.TabIndex = 51
        Me.Larghezza.Text = "80"
        Me.Larghezza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonBMP
        '
        Me.ButtonBMP.Location = New System.Drawing.Point(120, 98)
        Me.ButtonBMP.Name = "ButtonBMP"
        Me.ButtonBMP.Size = New System.Drawing.Size(47, 23)
        Me.ButtonBMP.TabIndex = 53
        Me.ButtonBMP.Text = "Raster"
        Me.ButtonBMP.UseVisualStyleBackColor = True
        '
        'RBh12
        '
        Me.RBh12.AutoSize = True
        Me.RBh12.Location = New System.Drawing.Point(6, 19)
        Me.RBh12.Name = "RBh12"
        Me.RBh12.Size = New System.Drawing.Size(97, 17)
        Me.RBh12.TabIndex = 54
        Me.RBh12.TabStop = True
        Me.RBh12.Text = "Twelve o'clock"
        Me.RBh12.UseVisualStyleBackColor = True
        '
        'RBAll
        '
        Me.RBAll.AutoSize = True
        Me.RBAll.Location = New System.Drawing.Point(6, 42)
        Me.RBAll.Name = "RBAll"
        Me.RBAll.Size = New System.Drawing.Size(76, 17)
        Me.RBAll.TabIndex = 55
        Me.RBAll.TabStop = True
        Me.RBAll.Text = "Every hour"
        Me.RBAll.UseVisualStyleBackColor = True
        '
        'RBGraph
        '
        Me.RBGraph.AutoSize = True
        Me.RBGraph.Location = New System.Drawing.Point(6, 65)
        Me.RBGraph.Name = "RBGraph"
        Me.RBGraph.Size = New System.Drawing.Size(51, 17)
        Me.RBGraph.TabIndex = 56
        Me.RBGraph.TabStop = True
        Me.RBGraph.Text = "None"
        Me.RBGraph.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBh12)
        Me.GroupBox2.Controls.Add(Me.RBGraph)
        Me.GroupBox2.Controls.Add(Me.RBAll)
        Me.GroupBox2.Location = New System.Drawing.Point(1005, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 113)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lemniscate"
        '
        'CB_TimeEq
        '
        Me.CB_TimeEq.AutoSize = True
        Me.CB_TimeEq.Checked = True
        Me.CB_TimeEq.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_TimeEq.Location = New System.Drawing.Point(1012, 91)
        Me.CB_TimeEq.Name = "CB_TimeEq"
        Me.CB_TimeEq.Size = New System.Drawing.Size(93, 17)
        Me.CB_TimeEq.TabIndex = 58
        Me.CB_TimeEq.Text = "Time equation"
        Me.CB_TimeEq.UseVisualStyleBackColor = True
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(67, 70)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(285, 20)
        Me.Description.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(4, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Description"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(532, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 23)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Zero"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(173, 98)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 23)
        Me.Button4.TabIndex = 62
        Me.Button4.Text = "Save set-up"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LBSavedSetup
        '
        Me.LBSavedSetup.FormattingEnabled = True
        Me.LBSavedSetup.Location = New System.Drawing.Point(362, 25)
        Me.LBSavedSetup.Name = "LBSavedSetup"
        Me.LBSavedSetup.Size = New System.Drawing.Size(149, 95)
        Me.LBSavedSetup.TabIndex = 63
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(201, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "cm."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(264, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "cm."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(317, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "cm."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(403, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Saved sundial"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(267, 98)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 23)
        Me.Button5.TabIndex = 68
        Me.Button5.Text = "Delete set-up"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RTB_OutData
        '
        Me.RTB_OutData.Location = New System.Drawing.Point(984, 132)
        Me.RTB_OutData.Name = "RTB_OutData"
        Me.RTB_OutData.Size = New System.Drawing.Size(127, 404)
        Me.RTB_OutData.TabIndex = 69
        Me.RTB_OutData.Text = ""
        '
        'GeoButton
        '
        Me.GeoButton.Location = New System.Drawing.Point(15, 98)
        Me.GeoButton.Name = "GeoButton"
        Me.GeoButton.Size = New System.Drawing.Size(45, 23)
        Me.GeoButton.TabIndex = 70
        Me.GeoButton.Text = "Geo"
        Me.GeoButton.UseVisualStyleBackColor = True
        '
        'ButtonMotto
        '
        Me.ButtonMotto.Location = New System.Drawing.Point(532, 97)
        Me.ButtonMotto.Name = "ButtonMotto"
        Me.ButtonMotto.Size = New System.Drawing.Size(50, 23)
        Me.ButtonMotto.TabIndex = 71
        Me.ButtonMotto.Text = "Motto"
        Me.ButtonMotto.UseVisualStyleBackColor = True
        '
        'Motto
        '
        Me.Motto.Location = New System.Drawing.Point(588, 99)
        Me.Motto.Name = "Motto"
        Me.Motto.ReadOnly = True
        Me.Motto.Size = New System.Drawing.Size(407, 20)
        Me.Motto.TabIndex = 72
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1122, 665)
        Me.Controls.Add(Me.Motto)
        Me.Controls.Add(Me.ButtonMotto)
        Me.Controls.Add(Me.GeoButton)
        Me.Controls.Add(Me.RTB_OutData)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LBSavedSetup)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.CB_TimeEq)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonBMP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Larghezza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Altezza)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Gnomone)
        Me.Controls.Add(Me.TextBoxVoff)
        Me.Controls.Add(Me.TextBoxhoff)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TrackBarVoff)
        Me.Controls.Add(Me.TrackBarHoff)
        Me.Controls.Add(Me.DeclinazioneTXT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Declinazione)
        Me.Controls.Add(Me.ButtonDXF)
        Me.Controls.Add(Me.PicGraph)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LongQ)
        Me.Controls.Add(Me.LatQ)
        Me.Controls.Add(Me.LongS)
        Me.Controls.Add(Me.LatS)
        Me.Controls.Add(Me.LongP)
        Me.Controls.Add(Me.LongG)
        Me.Controls.Add(Me.LatP)
        Me.Controls.Add(Me.LatG)
        Me.Name = "Master"
        Me.Text = "Vector Sundial"
        CType(Me.PicGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Declinazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBarHoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarVoff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LongQ As TextBox
    Friend WithEvents LatQ As TextBox
    Friend WithEvents LongS As TextBox
    Friend WithEvents LatS As TextBox
    Friend WithEvents LongP As TextBox
    Friend WithEvents LongG As TextBox
    Friend WithEvents LatP As TextBox
    Friend WithEvents LatG As TextBox
    Friend WithEvents PicGraph As PictureBox
    Friend WithEvents ButtonDXF As Button
    Friend WithEvents Declinazione As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Linee_Ore As RadioButton
    Friend WithEvents Linee_MezzeOre As RadioButton
    Friend WithEvents Linee_QuartiOra As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DeclinazioneTXT As TextBox
    Friend WithEvents TrackBarHoff As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxhoff As TextBox
    Friend WithEvents TextBoxVoff As TextBox
    Friend WithEvents TrackBarVoff As TrackBar
    Friend WithEvents Gnomone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Altezza As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Larghezza As TextBox
    Friend WithEvents ButtonBMP As Button
    Friend WithEvents RBh12 As RadioButton
    Friend WithEvents RBAll As RadioButton
    Friend WithEvents RBGraph As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CB_TimeEq As CheckBox
    Friend WithEvents Description As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LBSavedSetup As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents RTB_OutData As RichTextBox
    Friend WithEvents GeoButton As Button
    Friend WithEvents ButtonMotto As Button
    Friend WithEvents Motto As TextBox
End Class
