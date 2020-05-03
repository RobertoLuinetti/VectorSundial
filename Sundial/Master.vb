Public Class Master

    Dim tick_ora As Double = 1

    Private Sub ButtonRUN_Click(sender As Object, e As EventArgs) Handles ButtonRUN.Click
        RenderGraph()
    End Sub

    Public Sub RenderGraph()
        Me.Cursor = Cursors.WaitCursor
        Dim bm As New Bitmap(PicGraph.ClientSize.Width, PicGraph.ClientSize.Height)
        Using gr As Graphics = Graphics.FromImage(bm)
            gr.Clear(Color.Black)

            Dim latitudine As Double = 45 + (35 / 60) + (42 / 3600)
            Dim longitudine As Double = 9 + (4 / 60) + (28 / 3600)
            Dim azimut As Double = Declinazione.Value
            Dim gnomone As Double = 20
            Dim x_old_clip As Double = 0
            Dim y_old_clip As Double = 0
            Dim dr As Double = Math.PI / 180
            Dim elevazione_max As Double = 23.27 * dr

            latitudine = latitudine * dr
            longitudine = longitudine * dr
            azimut = azimut * dr
            Dim cliplimit As Double = 2000
            Dim hoff As Double = 0
            Dim voff As Double = -2
            Dim tick As Double = elevazione_max * 2 / 3600
            'tick = tick / 50
            Dim d As Double = 1
            Dim latoy As Double = 5
            Dim ratio As Double = 133 / 100
            Dim latox As Double = latoy * ratio
            SetDisplayPhysicalArea(PicGraph, 960, 540, 20, 20, 665, 500)


            Dim xl As Double = (-latox + hoff)
            Dim xr As Double = (+latox + hoff)
            Dim yb As Double = (-latoy + voff)
            Dim yt As Double = (+latoy + voff)
            Dim ofc As Double = latoy / 50
            SetScale(xl, xr, yb, yt)
            'Draw(gr, PenCyan, xl, yb, xr, yt)
            Frame(gr, PenGreen)
            '           Axes(1, 1, 10, yt); axes(1,1,10,yb); axes(1,1,xl,10); axes(1,1,xr,10);
            '{    axes(1,1,xl,yt); axes(1,1,xr,yb);}
            '    initdxf('sun');
            '    clipdxfplot(xl, yb); clipdxfplot(xr, yb); clipdxfplot(xr,yt);
            '    clipdxfplot(xl, yt); clipdxfplot(xl,yb); penupdxf;    
            Dim bgy As Double = Math.Tan(latitudine) / Math.Sin(azimut)
            Dim bgx As Double
            If azimut <> (90 * dr) Then
                bgx = 1 / Math.Tan(azimut)
            Else
                bgx = 0
            End If
            Draw(gr, PenCyan, bgx - ofc, bgy, bgx + ofc, bgy)
            Draw(gr, PenCyan, bgx, bgy - ofc, bgx, bgy - ofc + 2 * ofc)
            Draw(gr, PenCyan, -ofc, 0, +ofc, 0)
            Draw(gr, PenCyan, 0, -ofc, 0, +ofc)

            Dim proiezione_gnomone As Double = Math.Sqrt(bgx * bgx + bgy * bgy)
            Dim gnomone_perpendicolare As Double = (proiezione_gnomone / Math.Sin(Math.PI / 2 - (Math.PI / 2 - latitudine))) * Math.Sin(Math.PI / 2 - latitudine)
            Dim gnomone_obliquo As Double = Math.Sqrt(proiezione_gnomone * proiezione_gnomone + gnomone_perpendicolare * gnomone_perpendicolare)



            Dim ascensione As Double
            Dim elevazione As Double
            Dim xold, yold, x, y As Double
            Dim xx, yy As Double
            Dim a1, a2, a3 As Double
            For ora = 6 To 18 Step tick_ora
                ascensione = longitudine + 15 * (ora - 12) * dr
                xold = x
                yold = y
                For elevazione = -elevazione_max To elevazione_max Step elevazione_max / 1200

                    'astro begin
                    a1 = Math.Sin(elevazione) * Math.Sin(latitudine) + Math.Cos(elevazione) * Math.Cos(latitudine) * Math.Cos(ascensione)
                    a1 = Math.Atan(a1 / Math.Sqrt(1 - a1 * a1))

                    If ascensione = 0 Then
                        a2 = Math.PI
                    Else
                        a2 = (Math.Sin(elevazione) * Math.Cos(latitudine) - Math.Cos(elevazione) * Math.Sin(latitudine) * Math.Cos(ascensione)) / Math.Cos(a1)
                        a2 = Math.PI / 2 - Math.Atan(a2 / Math.Sqrt(1 - a2 * a2))
                        If ascensione > 0 Then a2 = 2 * Math.PI - a2
                    End If

                    a3 = a2 - azimut - Math.PI / 2
                    x = Math.Tan(a3)
                    y = -1 * Math.Tan(a1) / Math.Cos(a3)
                    'astro end
                    If (x > xold + d) Or (x < xold - d) Or (y > yold + d) Or (y < yold - d) Then
                        xx = x
                        yy = y
                    End If
                    If ora = Math.Truncate(ora) Then
                        Draw(gr, PenYellow, xx, yy, x, y)
                    Else
                        Draw(gr, PenCyan, xx, yy, x, y)
                    End If

                    'Draw(gr, PenCyan, xx, yy, x, y)
                    'Plot(gr, Color.Red, x, y)
                    xold = x
                    yold = y
                Next elevazione
            Next ora

        End Using

        PicGraph.Image = bm

        Me.Cursor = Cursors.Default

        'If BMPSave = True Then
        '    Clipboard.SetDataObject(DirectCast(picGraph.Image.Clone, Bitmap), True)
        '    InFile = Replace(InFile, ".gpx", ".bmp")
        '    bm.Save(InFile, System.Drawing.Imaging.ImageFormat.Bmp)
        '    BMPSave = False
        'End If
    End Sub

    Private Sub Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Linee_Ore.Checked = True
    End Sub


    Private Sub Declinazione_Scroll(sender As Object, e As EventArgs) Handles Declinazione.Scroll
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
End Class
