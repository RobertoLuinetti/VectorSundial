Public Class Master

    Dim tick_ora As Double = 1
    Dim hoff As Double = 0
    Dim voff As Double = -2
    Dim DXFOut As Boolean = False
    Dim GraphFormat As String = "JPEG"
    Dim Lemni As String = "H12"
    Dim GraphFileName As String
    Dim DXFFileName As String

    Public Sub RenderGraph()

        Me.Cursor = Cursors.WaitCursor
        'Dim bm As New Bitmap(PicGraph.ClientSize.Width, PicGraph.ClientSize.Height)
        Dim bm As New Bitmap(960, 520)
        Dim StrOUT As String
        Using gr As Graphics = Graphics.FromImage(bm)
            gr.Clear(Color.Black)

            Dim latitudine As Double = LatG.Text + (LatP.Text / 60) + (LatS.Text / 3600)
            Dim longitudine As Double = LongG.Text + (LongP.Text / 60) + (LongS.Text / 3600)
            Dim azimut As Double = 180 - Declinazione.Value / 10
            Dim dr As Double = Math.PI / 180
            Dim elevazione_max As Double = 23.27 * dr

            latitudine = latitudine * dr
            longitudine = longitudine * dr
            azimut = azimut * dr

            Dim d As Double = 0.1
            Dim latoy As Double = 5
            Dim ratio As Double = Larghezza.Text / Altezza.Text
            Dim latox As Double = latoy * ratio
            SetDisplayPhysicalArea(PicGraph, 960, 520, 10, 10, 500 * ratio, 500)

            Dim xl As Double = (-latox + hoff)
            Dim xr As Double = (+latox + hoff)
            Dim yb As Double = (-latoy + voff)
            Dim yt As Double = (+latoy + voff)
            Dim ofc As Double = latoy / 50
            SetScale(xl, xr, yb, yt)
            Frame(gr, PenGreen)

            Dim bgy As Double = Math.Tan(latitudine) / Math.Sin(azimut)
            Dim bgx As Double

            If azimut <> (90 * dr) Then
                bgx = 1 / Math.Tan(azimut)
            Else
                bgx = 0
            End If

            'Gnomon reference
            Draw(gr, PenCyan, bgx - ofc, bgy, bgx + ofc, bgy)
            Draw(gr, PenCyan, bgx, bgy - ofc, bgx, bgy - ofc + 2 * ofc)
            Draw(gr, PenCyan, -ofc, 0, +ofc, 0)
            Draw(gr, PenCyan, 0, -ofc, 0, +ofc)

            'ScaleFactor
            Dim SC As Double = CDbl(Altezza.Text.Replace(",", ".")) / (Math.Abs(yb) + Math.Abs(yt)) * 10

            If DXFOut Then DXF_Border("Sundial", xl * SC, yb * SC, 0, xr * SC, yt * SC, 0)
            If DXFOut Then
                DXF_Line("Sundial", (bgx - ofc) * SC, bgy * SC, 0, (bgx + ofc) * SC, bgy * SC, 0)
                DXF_Line("Sundial", bgx * SC, (bgy - ofc) * SC, 0, bgx * SC, (bgy - ofc + 2 * ofc) * SC, 0)
                DXF_Line("Sundial", -ofc * SC, 0, 0, +ofc * SC, 0, 0)
                DXF_Line("Sundial", 0, -ofc * SC, 0, 0, +ofc * SC, 0)
                DXF_Penup()
            End If

            Dim proiezione_gnomone As Double = (Math.Sqrt(bgx * bgx + bgy * bgy))
            Dim gnomone_perpendicolare As Double = ((proiezione_gnomone / Math.Sin(Math.PI / 2 - (Math.PI / 2 - latitudine))) * Math.Sin(Math.PI / 2 - latitudine))
            Dim gnomone_obliquo As Double = (Math.Sqrt(proiezione_gnomone * proiezione_gnomone + gnomone_perpendicolare * gnomone_perpendicolare))
            proiezione_gnomone = proiezione_gnomone * SC
            gnomone_perpendicolare = gnomone_perpendicolare * SC
            gnomone_obliquo = gnomone_obliquo * SC
            Me.Gnomone.Text = gnomone_perpendicolare
            Me.Gnomone.Refresh()
            StrOUT = "Gnomon projection = " & proiezione_gnomone.ToString("N2") & vbCrLf & vbCrLf & "Gnomon perpend. = " & gnomone_perpendicolare.ToString("N2") & vbCrLf & vbCrLf & "Gnomon oblique = " & gnomone_obliquo.ToString("N2") & vbCrLf & vbCrLf
            StrOUT = StrOUT & "Base height = " & Altezza.Text & vbCrLf & vbCrLf & "Base widht = " & Larghezza.Text & vbCrLf & vbCrLf
            Dim ascensione As Double
            Dim elevazione As Double
            Dim xold, yold, x, y As Double



            'LINEE ORARIE
            If DXFOut Then DXF_LayerName("Hours")
            For ora = 6 To 18 Step tick_ora
                ascensione = longitudine + 15 * (ora - 12) * dr
                xold = x
                yold = y
                For elevazione = -elevazione_max To elevazione_max Step elevazione_max / 600
                    Astro(latitudine, ascensione, elevazione, azimut, x, y)

                    If (x > xold + d) Or (x < xold - d) Or (y > yold + d) Or (y < yold - d) Then
                        Plotter.Move(x, y)
                        If DXFOut Then
                            DXF_Penup()
                            DXF_Plot("Hours", x * SC, y * SC)
                        End If
                    End If
                    If ora = Math.Truncate(ora) Then
                        Plot(gr, Color.Yellow, x, y)
                        'DXF_Penup()
                        If DXFOut Then DXF_Plot("Hours", x * SC, y * SC)
                    Else
                        Plot(gr, Color.Gray, x, y)
                        If DXFOut Then DXF_Plot("Hours", x * SC, y * SC)
                    End If
                    xold = x
                    yold = y

                    'If ora = 12 And elevazione >= elevazione_max - 0.001 Then Label(gr, ora, "verdana", 10, Color.White, x, y)

                Next elevazione
                Penup()
                If DXFOut Then DXF_Penup()
            Next ora

            'LINEE STAGIONALI
            If DXFOut Then DXF_LayerName("SeasonLines")
            Dim C As Color
            For elevazione = elevazione_max To -elevazione_max Step -elevazione_max / 3
                Penup()
                If DXFOut Then DXF_Penup()
                For ora = 6 - 0.01 To 18 + 0.01 Step 0.02 ' tick_ora
                    ascensione = longitudine + 15 * (ora - 12) * dr
                    Astro(latitudine, ascensione, elevazione, azimut, x, y)
                    If elevazione = -elevazione_max Then
                        C = Color.Red
                    ElseIf elevazione = elevazione_max Then
                        C = Color.Red
                    ElseIf elevazione = 0 Then
                        C = Color.Green
                    Else
                        C = Color.Gray
                    End If

                    If x >= xr Or x <= xl Or y >= yt Or y <= yb Then
                        Penup()
                        If DXFOut Then DXF_Penup()
                    Else
                        Plot(gr, C, x, y)
                        If DXFOut Then DXF_Plot("SeasonLines", x * SC, y * SC)
                    End If
                Next ora
                Penup()
                If DXFOut Then DXF_Penup()
            Next elevazione

            'LEMNISCATA
            If DXFOut Then DXF_LayerName("Lemniscate")
            Dim h, hmin, hmax, z As Integer
            If Lemni <> "NONE" Then
                If Lemni = "ALL" Then
                    hmin = 8 : hmax = 16
                Else
                    hmin = 12 : hmax = 12
                End If
                If DXFOut Then DXF_Penup()
                For h = hmin To hmax Step 1
                    For z = 1 To 365 Step 1
                        ascensione = longitudine + 15 * (h - 12 + TE(z, 1) / 60) * dr
                        elevazione = TE(z, 0) * dr
                        Astro(latitudine, ascensione, elevazione, azimut, x, y)
                        Plot(gr, Color.LightGreen, x, y)
                        If DXFOut Then DXF_Plot("Lemniscate", x * SC, y * SC)
                    Next
                    If DXFOut Then DXF_Penup()
                    Penup()
                Next h
            End If

            'Time Equation
            If CB_TimeEq.Checked Then
                If DXFOut Then DXF_LayerName("TimeEquation")
                If DXFOut Then DXF_Penup()
                Draw(gr, PenGreen, xl / 4, yb - yb / 15, xr / 4, yb - yb / 15)
                Draw(gr, PenGreen, xr / 4, yb - yb / 15, xr / 4, yb - yb / 3)
                Draw(gr, PenGreen, xr / 4, yb - yb / 3, xl / 4, yb - yb / 3)
                Draw(gr, PenGreen, xl / 4, yb - yb / 3, xl / 4, yb - yb / 15)
                If DXFOut Then DXF_Penup()
                If DXFOut Then DXF_Line("TimeEquation", (xl / 4) * SC, (yb - yb / 15) * SC, 0, (xr / 4) * SC, (yb - yb / 15) * SC, 0)
                If DXFOut Then DXF_Line("TimeEquation", (xr / 4) * SC, (yb - yb / 15) * SC, 0, (xr / 4) * SC, (yb - yb / 3) * SC, 0)
                If DXFOut Then DXF_Line("TimeEquation", (xr / 4) * SC, (yb - yb / 3) * SC, 0, (xl / 4) * SC, (yb - yb / 3) * SC, 0)
                If DXFOut Then DXF_Line("TimeEquation", (xl / 4) * SC, (yb - yb / 3) * SC, 0, (xl / 4) * SC, (yb - yb / 15) * SC, 0)
                If DXFOut Then DXF_Penup()
                Dim xtick As Double = (xr / 4 - xl / 4) / 12
                Dim ytick As Double = Math.Abs((yb - yb / 15) - (yb - yb / 3)) / 8
                For z = 1 To 12
                    Draw(gr, PenGreen, xl / 4 + z * xtick, yb - yb / 15, xl / 4 + z * xtick, yb - yb / 3)
                    If DXFOut Then DXF_Line("TimeEquation", (xl / 4 + z * xtick) * SC, (yb - yb / 15) * SC, 0, (xl / 4 + z * xtick) * SC, (yb - yb / 3) * SC, 0)
                Next
                For z = 1 To 8
                    Draw(gr, PenGreen, xl / 4, yb - yb / 15 + z * ytick, xr / 4, yb - yb / 15 + z * ytick)
                    If DXFOut Then DXF_Line("TimeEquation", (xl / 4) * SC, (yb - yb / 15 + z * ytick) * SC, 0, (xr / 4) * SC, (yb - yb / 15 + z * ytick) * SC, 0)
                Next
                Plotter.Move(xl / 4, TE(1, 1) / (xr / 4 - xl / 4) / 40)
                If DXFOut Then DXF_Penup()
                If DXFOut Then DXF_Plot("TimeEquation", (xl / 4) * SC, (TE(1, 1) / (xr / 4 - xl / 4) / 40) * SC)
                If DXFOut Then DXF_Penup()
                For z = 2 To 365
                    'Plot(gr, Color.Yellow, xl / 4 + (xtick * 12 / 365) * z, (TE(z, 1) / 40 * (ytick * 8 / 40)) - (yb - yb / 15) + ytick * 4)
                    Plot(gr, Color.Yellow, xl / 4 + (xtick * 12 / 365) * z, (TE(z, 1) * (ytick * 8 / 40)) + (yb - yb / 15) + ytick * 4)
                    If DXFOut Then DXF_Plot("TimeEquation", (xl / 4 + (xtick * 12 / 365) * z) * SC, ((TE(z, 1) * (ytick * 8 / 40)) + (yb - yb / 15) + ytick * 4) * SC)
                Next
            End If

            If DXFOut Then
                DXF_save_to_file(DXFFileName)
                DXFOut = False
            End If

        End Using

        PicGraph.Image = bm

        Me.Cursor = Cursors.Default

        If GraphFormat = "jpeg" Then
            Clipboard.SetDataObject(DirectCast(PicGraph.Image.Clone, Bitmap), True)
            bm.Save(GraphFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        ElseIf GraphFormat = "bmp" Then
            Clipboard.SetDataObject(DirectCast(PicGraph.Image.Clone, Bitmap), True)
            bm.Save(GraphFileName, System.Drawing.Imaging.ImageFormat.Bmp)
        ElseIf GraphFormat = "gif" Then
            Clipboard.SetDataObject(DirectCast(PicGraph.Image.Clone, Bitmap), True)
            bm.Save(GraphFileName, System.Drawing.Imaging.ImageFormat.Gif)
        End If
        GraphFormat = ""

        RTB_OutData.Text = StrOUT
        Me.Gnomone.Refresh()

    End Sub

    Private Sub Astro(latitudine As Double, ascensione As Double, elevazione As Double, azimut As Double, ByRef x As Double, ByRef y As Double)
        Dim A1, A2, A3 As Double
        Dim P As Double = Math.PI / 180
        A1 = Math.Sin(elevazione) * Math.Sin(latitudine) + Math.Cos(elevazione) * Math.Cos(latitudine) * Math.Cos(ascensione)
        A1 = Math.Atan(A1 / Math.Sqrt(1 - A1 * A1))

        If ascensione = 0 Then 'R1
            A2 = Math.PI
        Else
            A2 = (Math.Sin(elevazione) * Math.Cos(latitudine) - Math.Cos(elevazione) * Math.Sin(latitudine) * Math.Cos(ascensione)) / Math.Cos(A1)
            A2 = Math.PI / 2 - Math.Atan(A2 / Math.Sqrt(1 - A2 * A2))
            If ascensione > 0 Then A2 = 2 * Math.PI - A2  'R1
        End If

        A3 = A2 - azimut - Math.PI / 2
        x = Math.Tan(A3)
        y = -1 * Math.Tan(A1) / Math.Cos(A3)
    End Sub

    Private Sub Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Linee_Ore.Checked = True
        Me.RBh12.Checked = True
        getDefault("Home")
        getSetup()

    End Sub

    Private Sub Declinazione_Scroll(sender As Object, e As EventArgs) Handles Declinazione.Scroll
        DeclinazioneTXT.Text = Declinazione.Value / 10 - 90
        RenderGraph()
    End Sub

    Private Sub Linee_Ore_CheckedChanged(sender As Object, e As EventArgs) Handles Linee_Ore.CheckedChanged
        tick_ora = 1
        RenderGraph()
    End Sub

    Private Sub Linee_MezzeOre_CheckedChanged(sender As Object, e As EventArgs) Handles Linee_MezzeOre.CheckedChanged
        tick_ora = 0.5
        RenderGraph()
    End Sub

    Private Sub Linee_QuartiOra_CheckedChanged(sender As Object, e As EventArgs) Handles Linee_QuartiOra.CheckedChanged
        tick_ora = 0.25
        RenderGraph()
    End Sub

    Private Sub TrackBarVoff_Scroll(sender As Object, e As EventArgs) Handles TrackBarVoff.Scroll
        voff = TrackBarVoff.Value / 10
        TextBoxVoff.Text = TrackBarVoff.Value / 10
        RenderGraph()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TrackBarVoff.Value = -20
        voff = TrackBarVoff.Value / 10
        TextBoxVoff.Text = TrackBarVoff.Value / 10
        RenderGraph()
    End Sub

    Private Sub TrackBarHoff_Scroll(sender As Object, e As EventArgs) Handles TrackBarHoff.Scroll
        hoff = -1 * TrackBarHoff.Value / 10
        TextBoxhoff.Text = TrackBarHoff.Value / 10
        RenderGraph()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TrackBarHoff.Value = 0
        hoff = TrackBarHoff.Value / 10
        TextBoxhoff.Text = TrackBarHoff.Value / 10
        RenderGraph()
    End Sub

    Private Sub ButtonDXF_Click(sender As Object, e As EventArgs) Handles ButtonDXF.Click
        Dim SaveFileDlg As New SaveFileDialog
        SaveFileDlg.Filter = "DXF vector graphic file|*.DXF"
        SaveFileDlg.Title = "Save a DXF vector graphic file"
        Dim result As DialogResult = SaveFileDlg.ShowDialog()

        If SaveFileDlg.FileName <> "" Then
            DXFFileName = SaveFileDlg.FileName
            DXFOut = True
            RenderGraph()
        End If

    End Sub

    Private Sub Gnomone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Gnomone.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub Altezza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Altezza.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub Larghezza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Larghezza.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub LatG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LatG.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub LatP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LatP.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub LatS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LatS.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub LatQ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LatQ.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub LongG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LongG.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub LongP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LongP.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub LongS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LongS.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub LongQ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LongQ.KeyPress
        If e.KeyChar = vbCr Then
            RenderGraph()
        End If
    End Sub

    Private Sub ButtonBMP_Click(sender As Object, e As EventArgs) Handles ButtonBMP.Click
        Dim SaveFileDlg As New SaveFileDialog
        SaveFileDlg.Filter = "Bitmap Image|*.bmp|JPeg Image|*.jpg|Gif Image|*.gif"
        SaveFileDlg.Title = "Save an Image File"
        Dim result As DialogResult = SaveFileDlg.ShowDialog()

        If SaveFileDlg.FileName <> "" Then
            Select Case SaveFileDlg.FilterIndex
                Case 1
                    GraphFormat = "bmp"
                Case 2
                    GraphFormat = "jpeg"
                Case 3
                    GraphFormat = "gif"
            End Select
            GraphFileName = SaveFileDlg.FileName
            RenderGraph()
        End If

    End Sub

    Private Sub RBh12_CheckedChanged(sender As Object, e As EventArgs) Handles RBh12.CheckedChanged
        Lemni = "H12"
        RenderGraph()
    End Sub

    Private Sub RBAll_CheckedChanged(sender As Object, e As EventArgs) Handles RBAll.CheckedChanged
        Lemni = "ALL"
        RenderGraph()
    End Sub

    Private Sub RBGraph_CheckedChanged(sender As Object, e As EventArgs) Handles RBGraph.CheckedChanged
        Lemni = "NONE"
        RenderGraph()
    End Sub

    Private Sub CB_TimeEq_CheckedChanged(sender As Object, e As EventArgs) Handles CB_TimeEq.CheckedChanged
        RenderGraph()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeclinazioneTXT.Text = 0
        Declinazione.Value = 900
        RenderGraph()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Qta As Integer = ExecuteScalarQuery("select count(*) from [POSITION] where DESCRIPTION='" & Description.Text & "'")
        If Qta = 0 Then
            Dim StrSQL As String = "INSERT INTO [POSITION] ([DESCRIPTION], [GNOMON], [HEIGHT], [WIDTH], [LATG], [LATP], [LATS], [LATQ], [LONGG], [LONGP], [LONGS], [LONGQ],[Declination],[HShift],[VShift],[TimeDetail],[Lemniscate],[TimeEquation]) VALUES ("
            StrSQL = StrSQL & "'" & Description.Text & "',"
            StrSQL = StrSQL & Gnomone.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & Altezza.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & Larghezza.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & LatG.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & LatP.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & LatS.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & "'" & LatQ.Text & "',"
            StrSQL = StrSQL & LongG.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & LongP.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & LongS.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & "'" & LongQ.Text & "',"
            StrSQL = StrSQL & Declinazione.Value & ","
            StrSQL = StrSQL & TextBoxhoff.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & TextBoxVoff.Text.Replace(",", ".") & ","

            Select Case tick_ora
                Case = 1
                    StrSQL = StrSQL & "'HO',"
                Case = 0.5
                    StrSQL = StrSQL & "'HH',"
                Case = 0.25
                    StrSQL = StrSQL & "'QH',"
            End Select

            StrSQL = StrSQL & "'" & Lemni & "',"
            If CB_TimeEq.Checked = True Then
                StrSQL = StrSQL & "true)"
            Else
                StrSQL = StrSQL & "false)"
            End If

            'MsgBox(StrSQL)
            ExecuteCommand(StrSQL)
        Else
            Dim StrSQL As String = "UPDATE [POSITION] "
            StrSQL = StrSQL & " SET [GNOMON] =" & Gnomone.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & " [HEIGHT]=" & Altezza.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & " [WIDTH]=" & Larghezza.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & " [LATG]=" & LatG.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & " [LATP]=" & LatP.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & " [LATS]=" & LatS.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & " [LATQ]='" & LatQ.Text & "',"
            StrSQL = StrSQL & " [LONGG]=" & LongG.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & " [LONGP]=" & LongP.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & " [LONGS]=" & LongS.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & " [LONGQ]='" & LongQ.Text & "',"
            StrSQL = StrSQL & " [Declination]=" & Declinazione.Value & ","
            StrSQL = StrSQL & " [HShift]=" & TextBoxhoff.Text.Replace(",", ".") & ","
            StrSQL = StrSQL & " [VShift]=" & TextBoxVoff.Text.Replace(",", ".") & ","

            Select Case tick_ora
                Case = 1
                    StrSQL = StrSQL & " [TimeDetail]='HO',"
                Case = 0.5
                    StrSQL = StrSQL & " [TimeDetail]='HH',"
                Case = 0.25
                    StrSQL = StrSQL & " [TimeDetail]='QH',"
            End Select

            StrSQL = StrSQL & " [Lemniscate]='" & Lemni & "',"
            If CB_TimeEq.Checked = True Then
                StrSQL = StrSQL & " [TimeEquation]=true"
            Else
                StrSQL = StrSQL & " [TimeEquation]=false"
            End If

            StrSQL = StrSQL & " WHERE [DESCRIPTION]='" & Description.Text & "'"

            'MsgBox(StrSQL)
            ExecuteCommand(StrSQL)

        End If
        getSetup()
    End Sub

    Private Sub getDefault(ByVal SetUpDescription As String)
        Dim DBDT As DataTable
        ExecuteQuery("select * from [Position] where DESCRIPTION='" & SetUpDescription & "'", DBDT)
        For Each R As DataRow In DBDT.Rows
            Description.Text = R("DESCRIPTION")
            Gnomone.Text = R("GNOMON")
            Altezza.Text = R("Height")
            Larghezza.Text = R("Width")
            LatG.Text = R("LatG")
            LatP.Text = R("LatP")
            LatS.Text = R("LatS")
            LatQ.Text = R("LatQ")
            LongG.Text = R("LongG")
            LongP.Text = R("LongP")
            LongS.Text = R("LongS")
            LongQ.Text = R("LongQ")
            DeclinazioneTXT.Text = R("Declination") / 10 - 90
            Declinazione.Value = R("Declination")
            TextBoxhoff.Text = R("HShift")
            TrackBarHoff.Value = R("HShift")
            TextBoxVoff.Text = R("VShift")
            TrackBarVoff.Value = R("VShift")
            Select Case R("TimeDetail")
                Case = "HO"
                    tick_ora = 1
                    Me.Linee_Ore.Checked = True
                Case = "HH"
                    tick_ora = 0.5
                    Me.Linee_MezzeOre.Checked = True
                Case = "QH"
                    tick_ora = 0.25
                    Me.Linee_QuartiOra.Checked = True
            End Select
            Select Case R("Lemniscate")
                Case = "H12"
                    Lemni = "H12"
                    Me.RBh12.Checked = True
                Case = "ALL"
                    Lemni = "ALL"
                    Me.RBAll.Checked = True
                Case = "NONE"
                    Lemni = "NONE"
                    Me.RBGraph.Checked = True
            End Select

            If R("TimeEquation") = True Then CB_TimeEq.Checked = True
        Next
    End Sub

    Private Sub getSetup()
        Dim DBDT As DataTable
        LBSavedSetup.Items.Clear()
        ExecuteQuery("select * from [Position]", DBDT)
        For Each R As DataRow In DBDT.Rows
            LBSavedSetup.Items.Add(R("DESCRIPTION"))
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Description.Text.ToUpper = "HOME" Then
            MsgBox("Tou can't delete HOME sundial")
        Else
            ExecuteCommand("DELETE * FROM [Position] where DESCRIPTION='" & Description.Text & "'")
            LBSavedSetup.Items.Clear()
            getDefault("Home")
            getSetup()
        End If
    End Sub

    Private Sub LBSavedSetup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBSavedSetup.SelectedIndexChanged
        getDefault(LBSavedSetup.SelectedItem)
        RenderGraph()
    End Sub

    Private Sub GeoButton_Click(sender As Object, e As EventArgs) Handles GeoButton.Click
        Gmap.Show()
    End Sub

    Private Sub ButtonMotto_Click(sender As Object, e As EventArgs) Handles ButtonMotto.Click
        Motti.Show()
    End Sub
End Class
