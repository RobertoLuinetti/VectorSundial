<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gmap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gmap))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.BTGetCoords = New System.Windows.Forms.Button()
        Me.TXTStreet = New System.Windows.Forms.TextBox()
        Me.TXTCity = New System.Windows.Forms.TextBox()
        Me.TXTZip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.State = New System.Windows.Forms.Label()
        Me.TXTState = New System.Windows.Forms.TextBox()
        Me.BTGetCoord = New System.Windows.Forms.Button()
        Me.ButtonUseCoord = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LongQ = New System.Windows.Forms.TextBox()
        Me.LatQ = New System.Windows.Forms.TextBox()
        Me.LongS = New System.Windows.Forms.TextBox()
        Me.LatS = New System.Windows.Forms.TextBox()
        Me.LongP = New System.Windows.Forms.TextBox()
        Me.LongG = New System.Windows.Forms.TextBox()
        Me.LatP = New System.Windows.Forms.TextBox()
        Me.LatG = New System.Windows.Forms.TextBox()
        Me.LAT = New System.Windows.Forms.TextBox()
        Me.LON = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(170, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(618, 426)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.TabStop = False
        '
        'BTGetCoords
        '
        Me.BTGetCoords.Location = New System.Drawing.Point(76, 116)
        Me.BTGetCoords.Name = "BTGetCoords"
        Me.BTGetCoords.Size = New System.Drawing.Size(75, 23)
        Me.BTGetCoords.TabIndex = 5
        Me.BTGetCoords.Text = "Map search"
        Me.BTGetCoords.UseVisualStyleBackColor = True
        '
        'TXTStreet
        '
        Me.TXTStreet.Location = New System.Drawing.Point(51, 90)
        Me.TXTStreet.Name = "TXTStreet"
        Me.TXTStreet.Size = New System.Drawing.Size(100, 20)
        Me.TXTStreet.TabIndex = 4
        '
        'TXTCity
        '
        Me.TXTCity.Location = New System.Drawing.Point(51, 38)
        Me.TXTCity.Name = "TXTCity"
        Me.TXTCity.Size = New System.Drawing.Size(100, 20)
        Me.TXTCity.TabIndex = 2
        '
        'TXTZip
        '
        Me.TXTZip.Location = New System.Drawing.Point(51, 64)
        Me.TXTZip.Name = "TXTZip"
        Me.TXTZip.Size = New System.Drawing.Size(100, 20)
        Me.TXTZip.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Street"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ZIP"
        '
        'State
        '
        Me.State.AutoSize = True
        Me.State.Location = New System.Drawing.Point(13, 15)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(32, 13)
        Me.State.TabIndex = 12
        Me.State.Text = "State"
        '
        'TXTState
        '
        Me.TXTState.Location = New System.Drawing.Point(51, 12)
        Me.TXTState.Name = "TXTState"
        Me.TXTState.Size = New System.Drawing.Size(100, 20)
        Me.TXTState.TabIndex = 1
        '
        'BTGetCoord
        '
        Me.BTGetCoord.Location = New System.Drawing.Point(75, 210)
        Me.BTGetCoord.Name = "BTGetCoord"
        Me.BTGetCoord.Size = New System.Drawing.Size(75, 23)
        Me.BTGetCoord.TabIndex = 7
        Me.BTGetCoord.Text = "Get Coord."
        Me.BTGetCoord.UseVisualStyleBackColor = True
        '
        'ButtonUseCoord
        '
        Me.ButtonUseCoord.Location = New System.Drawing.Point(75, 346)
        Me.ButtonUseCoord.Name = "ButtonUseCoord"
        Me.ButtonUseCoord.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUseCoord.TabIndex = 8
        Me.ButtonUseCoord.Text = "Use Coord."
        Me.ButtonUseCoord.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(76, 146)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReset.TabIndex = 6
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(6, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "LONG"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(16, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "LAT"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LongQ
        '
        Me.LongQ.Location = New System.Drawing.Point(137, 320)
        Me.LongQ.Name = "LongQ"
        Me.LongQ.ReadOnly = True
        Me.LongQ.Size = New System.Drawing.Size(13, 20)
        Me.LongQ.TabIndex = 35
        Me.LongQ.TabStop = False
        Me.LongQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatQ
        '
        Me.LatQ.Location = New System.Drawing.Point(137, 291)
        Me.LatQ.Name = "LatQ"
        Me.LatQ.ReadOnly = True
        Me.LatQ.Size = New System.Drawing.Size(13, 20)
        Me.LatQ.TabIndex = 34
        Me.LatQ.TabStop = False
        Me.LatQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongS
        '
        Me.LongS.Location = New System.Drawing.Point(96, 320)
        Me.LongS.Name = "LongS"
        Me.LongS.ReadOnly = True
        Me.LongS.Size = New System.Drawing.Size(35, 20)
        Me.LongS.TabIndex = 33
        Me.LongS.TabStop = False
        Me.LongS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatS
        '
        Me.LatS.Location = New System.Drawing.Point(96, 291)
        Me.LatS.Name = "LatS"
        Me.LatS.ReadOnly = True
        Me.LatS.Size = New System.Drawing.Size(35, 20)
        Me.LatS.TabIndex = 32
        Me.LatS.TabStop = False
        Me.LatS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongP
        '
        Me.LongP.Location = New System.Drawing.Point(71, 320)
        Me.LongP.Name = "LongP"
        Me.LongP.ReadOnly = True
        Me.LongP.Size = New System.Drawing.Size(19, 20)
        Me.LongP.TabIndex = 31
        Me.LongP.TabStop = False
        Me.LongP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LongG
        '
        Me.LongG.Location = New System.Drawing.Point(46, 320)
        Me.LongG.Name = "LongG"
        Me.LongG.ReadOnly = True
        Me.LongG.Size = New System.Drawing.Size(19, 20)
        Me.LongG.TabIndex = 30
        Me.LongG.TabStop = False
        Me.LongG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatP
        '
        Me.LatP.Location = New System.Drawing.Point(71, 291)
        Me.LatP.Name = "LatP"
        Me.LatP.ReadOnly = True
        Me.LatP.Size = New System.Drawing.Size(19, 20)
        Me.LatP.TabIndex = 29
        Me.LatP.TabStop = False
        Me.LatP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LatG
        '
        Me.LatG.Location = New System.Drawing.Point(46, 291)
        Me.LatG.Name = "LatG"
        Me.LatG.ReadOnly = True
        Me.LatG.Size = New System.Drawing.Size(19, 20)
        Me.LatG.TabIndex = 28
        Me.LatG.TabStop = False
        Me.LatG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LAT
        '
        Me.LAT.Location = New System.Drawing.Point(46, 239)
        Me.LAT.Name = "LAT"
        Me.LAT.ReadOnly = True
        Me.LAT.Size = New System.Drawing.Size(104, 20)
        Me.LAT.TabIndex = 38
        Me.LAT.TabStop = False
        '
        'LON
        '
        Me.LON.Location = New System.Drawing.Point(46, 265)
        Me.LON.Name = "LON"
        Me.LON.ReadOnly = True
        Me.LON.Size = New System.Drawing.Size(105, 20)
        Me.LON.TabIndex = 39
        Me.LON.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(8, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "LONG"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(16, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "LAT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Gmap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LON)
        Me.Controls.Add(Me.LAT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LongQ)
        Me.Controls.Add(Me.LatQ)
        Me.Controls.Add(Me.LongS)
        Me.Controls.Add(Me.LatS)
        Me.Controls.Add(Me.LongP)
        Me.Controls.Add(Me.LongG)
        Me.Controls.Add(Me.LatP)
        Me.Controls.Add(Me.LatG)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonUseCoord)
        Me.Controls.Add(Me.BTGetCoord)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.TXTState)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTZip)
        Me.Controls.Add(Me.TXTCity)
        Me.Controls.Add(Me.TXTStreet)
        Me.Controls.Add(Me.BTGetCoords)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Gmap"
        Me.Text = "Gmap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents BTGetCoords As Button
    Friend WithEvents TXTStreet As TextBox
    Friend WithEvents TXTCity As TextBox
    Friend WithEvents TXTZip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents State As Label
    Friend WithEvents TXTState As TextBox
    Friend WithEvents BTGetCoord As Button
    Friend WithEvents ButtonUseCoord As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LongQ As TextBox
    Friend WithEvents LatQ As TextBox
    Friend WithEvents LongS As TextBox
    Friend WithEvents LatS As TextBox
    Friend WithEvents LongP As TextBox
    Friend WithEvents LongG As TextBox
    Friend WithEvents LatP As TextBox
    Friend WithEvents LatG As TextBox
    Friend WithEvents LAT As TextBox
    Friend WithEvents LON As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
