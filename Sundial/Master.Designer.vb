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
        Me.ButtonRUN = New System.Windows.Forms.Button()
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
        CType(Me.PicGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Declinazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonRUN
        '
        Me.ButtonRUN.Location = New System.Drawing.Point(182, 12)
        Me.ButtonRUN.Name = "ButtonRUN"
        Me.ButtonRUN.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRUN.TabIndex = 0
        Me.ButtonRUN.Text = "RUN"
        Me.ButtonRUN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "LONG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "LAT"
        '
        'LongQ
        '
        Me.LongQ.Location = New System.Drawing.Point(146, 38)
        Me.LongQ.Name = "LongQ"
        Me.LongQ.Size = New System.Drawing.Size(13, 20)
        Me.LongQ.TabIndex = 25
        Me.LongQ.Text = "E"
        Me.LongQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatQ
        '
        Me.LatQ.Location = New System.Drawing.Point(146, 12)
        Me.LatQ.Name = "LatQ"
        Me.LatQ.Size = New System.Drawing.Size(13, 20)
        Me.LatQ.TabIndex = 24
        Me.LatQ.Text = "N"
        Me.LatQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongS
        '
        Me.LongS.Location = New System.Drawing.Point(105, 38)
        Me.LongS.Name = "LongS"
        Me.LongS.Size = New System.Drawing.Size(35, 20)
        Me.LongS.TabIndex = 23
        Me.LongS.Text = "28,4"
        Me.LongS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatS
        '
        Me.LatS.Location = New System.Drawing.Point(105, 12)
        Me.LatS.Name = "LatS"
        Me.LatS.Size = New System.Drawing.Size(35, 20)
        Me.LatS.TabIndex = 22
        Me.LatS.Text = "42,7"
        Me.LatS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongP
        '
        Me.LongP.Location = New System.Drawing.Point(80, 38)
        Me.LongP.Name = "LongP"
        Me.LongP.Size = New System.Drawing.Size(19, 20)
        Me.LongP.TabIndex = 21
        Me.LongP.Text = "4"
        Me.LongP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongG
        '
        Me.LongG.Location = New System.Drawing.Point(55, 38)
        Me.LongG.Name = "LongG"
        Me.LongG.Size = New System.Drawing.Size(19, 20)
        Me.LongG.TabIndex = 20
        Me.LongG.Text = "9"
        Me.LongG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatP
        '
        Me.LatP.Location = New System.Drawing.Point(80, 12)
        Me.LatP.Name = "LatP"
        Me.LatP.Size = New System.Drawing.Size(19, 20)
        Me.LatP.TabIndex = 19
        Me.LatP.Text = "35"
        Me.LatP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatG
        '
        Me.LatG.Location = New System.Drawing.Point(55, 12)
        Me.LatG.Name = "LatG"
        Me.LatG.Size = New System.Drawing.Size(19, 20)
        Me.LatG.TabIndex = 18
        Me.LatG.Text = "45"
        Me.LatG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PicGraph
        '
        Me.PicGraph.Location = New System.Drawing.Point(12, 95)
        Me.PicGraph.Name = "PicGraph"
        Me.PicGraph.Size = New System.Drawing.Size(960, 540)
        Me.PicGraph.TabIndex = 28
        Me.PicGraph.TabStop = False
        '
        'ButtonDXF
        '
        Me.ButtonDXF.Location = New System.Drawing.Point(278, 12)
        Me.ButtonDXF.Name = "ButtonDXF"
        Me.ButtonDXF.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDXF.TabIndex = 29
        Me.ButtonDXF.Text = "DXF"
        Me.ButtonDXF.UseVisualStyleBackColor = True
        '
        'Declinazione
        '
        Me.Declinazione.Location = New System.Drawing.Point(415, 38)
        Me.Declinazione.Maximum = 180
        Me.Declinazione.Name = "Declinazione"
        Me.Declinazione.Size = New System.Drawing.Size(104, 45)
        Me.Declinazione.TabIndex = 30
        Me.Declinazione.TickFrequency = 30
        Me.Declinazione.Value = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Declinazione Parete"
        '
        'Linee_Ore
        '
        Me.Linee_Ore.AutoSize = True
        Me.Linee_Ore.Location = New System.Drawing.Point(16, 19)
        Me.Linee_Ore.Name = "Linee_Ore"
        Me.Linee_Ore.Size = New System.Drawing.Size(53, 17)
        Me.Linee_Ore.TabIndex = 32
        Me.Linee_Ore.TabStop = True
        Me.Linee_Ore.Text = "Orario"
        Me.Linee_Ore.UseVisualStyleBackColor = True
        '
        'Linee_MezzeOre
        '
        Me.Linee_MezzeOre.AutoSize = True
        Me.Linee_MezzeOre.Location = New System.Drawing.Point(16, 42)
        Me.Linee_MezzeOre.Name = "Linee_MezzeOre"
        Me.Linee_MezzeOre.Size = New System.Drawing.Size(74, 17)
        Me.Linee_MezzeOre.TabIndex = 33
        Me.Linee_MezzeOre.TabStop = True
        Me.Linee_MezzeOre.Text = "Mezze ore"
        Me.Linee_MezzeOre.UseVisualStyleBackColor = True
        '
        'Linee_QuartiOra
        '
        Me.Linee_QuartiOra.AutoSize = True
        Me.Linee_QuartiOra.Location = New System.Drawing.Point(16, 65)
        Me.Linee_QuartiOra.Name = "Linee_QuartiOra"
        Me.Linee_QuartiOra.Size = New System.Drawing.Size(79, 17)
        Me.Linee_QuartiOra.TabIndex = 34
        Me.Linee_QuartiOra.TabStop = True
        Me.Linee_QuartiOra.Text = "Quarti d'ora"
        Me.Linee_QuartiOra.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Linee_Ore)
        Me.GroupBox1.Controls.Add(Me.Linee_QuartiOra)
        Me.GroupBox1.Controls.Add(Me.Linee_MezzeOre)
        Me.GroupBox1.Location = New System.Drawing.Point(592, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 89)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dettaglio temporale"
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 647)
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
        Me.Controls.Add(Me.ButtonRUN)
        Me.Name = "Master"
        Me.Text = "Form1"
        CType(Me.PicGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Declinazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRUN As Button
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
End Class
