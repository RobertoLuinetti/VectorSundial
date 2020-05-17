Module DXFWriter
    Public Structure My_Points
        Public X As Double
        Public Y As Double
    End Structure

    Public DXFPenup As Boolean
    Public MyPoints As My_Points
    Public DXF_BodyText As String
    Public DXF_BlockBody As String
    Public BlockIndex As Integer
    Public DXF_Layer As String

    Public DXFox As Double
    Public DXFoy As Double

    Public DXF_Ymin As Double
    Public DXF_Ymax As Double
    Public DXF_Xmin As Double
    Public DXF_Xmax As Double

    Public Function Radians(ByVal Degree As Double) As Double
        Radians = Degree * Math.PI / 180
    End Function

    Public Sub DXF_Init()
        BlockIndex = 0
        DXF_BodyText = ""
        DXF_BlockBody = ""
    End Sub

    Public Sub DXF_LayerName(ByVal DXF_Layer As String)
        DXF_Layer = DXF_Layer
    End Sub
    Public Function DXF_Header() As String
        Dim HS(19) As String
        HS(0) = "  0|SECTION|  2|HEADER|  9"
        HS(1) = "$ACADVER|  1|AC1009|  9"
        HS(2) = "$INSBASE| 10|0.0| 20|0.0| 30|0.0|  9"
        'HS(3) = "$EXTMIN| 10|  0| 20|  0| 30|  0|  9"
        HS(3) = "$EXTMIN| 10| -8| 20| -7| 30|  0|  9"
        'HS(4) = "$EXTMAX| 10|368| 20|326| 30|0.0|  9"
        HS(4) = "$EXTMAX| 10|  8| 20|  3| 30|0.0|  9"
        HS(5) = "$LIMMIN| 10|0.0| 20|0.0|  9"
        HS(6) = "$LIMMAX| 10|100.0| 20|100.0|  9"
        HS(7) = "$ORTHOMODE| 70|     1|  9"
        HS(8) = "$DIMSCALE| 40|8.0|  9"
        HS(9) = "$DIMSTYLE|  2|STANDARD|  9"
        HS(10) = "$FILLETRAD| 40|0.0|  9"
        HS(11) = "$PSLTSCALE| 70|     1|  0"
        HS(12) = "ENDSEC|  0"
        HS(13) = "SECTION|  2|TABLES|  0"
        HS(14) = "TABLE|  2|VPORT| 70|     2|  0|VPORT|  2|*ACTIVE| 70|     0| 10|0.0| 20|0.0| 11|1.0| 21|1.0| 12|50.0| 22|50.0| 13|0.0| 23|0.0| 14|1.0| 24|1.0| 15|0.0| 25|0.0| 16|0.0| 26|0.0| 36|1.0| 17|0.0| 27|0.0| 37|0.0| 40|100.0| 41|1.55| 42|50.0| 43|0.0| 44|0.0| 50|0.0| 51|0.0| 71|     0| 72|   100| 73|     1| 74|     1| 75|     0| 76|     0| 77|     0| 78|     0|  0|ENDTAB|  0"
        HS(15) = "TABLE|  2|LTYPE| 70|     1|  0|LTYPE|  2|CONTINUOUS|  70|     0|  3|Solid Line| 72|    65| 73|     0| 40|0.0|  0|ENDTAB|  0"
        HS(16) = "TABLE|  2|LAYER| 70|     3|  0|LAYER|  2|0| 70|     0| 62|     7|  6|CONTINUOUS|  0|LAYER|  2|DEFAULT| 70|     0| 62|     7|  6|CONTINUOUS|  0|LAYER|  2|DEFPOINTS| 70|     0| 62|     7| 6|CONTINUOUS|  0|ENDTAB|  0"
        HS(17) = "TABLE|  2|VIEW| 70|     0|  0|ENDTAB|  0"
        HS(18) = "TABLE|  2|DIMSTYLE| 70|     1|  0|DIMSTYLE|  2|STANDARD| 70|     0|  3||  4||  5||  6||  7|| 40|1.0| 41|0.18| 42|0.0625| 43|0.38| 44|0.18| 45|0.0| 46|0.0| 47|0.0| 48|0.0|140|0.18|141|0.09|142|0.0|143|25.4|144|1.0|145|0.0|146|1.0|147|0.09| 71|     0| 72|     0| 73|     1| 74|     1| 75|     0| 76|     0| 77|     0| 78|     0|170|     0|171|     2|172|     0|173|     0|174|     0|175|     0|176|     0|177|     0|178|     0|  0|ENDTAB|  0"
        HS(19) = "ENDSEC|  0|"
        DXF_Header = Join(HS, "|")
    End Function

    Public Function DXF_BlockHeader() As String
        DXF_BlockHeader = "SECTION|  2|BLOCKS|  0|"
    End Function

    Public Sub DXF_BuildBlockBody()
        DXF_BlockBody = DXF_BlockBody & "BLOCK|  8|0|  2|*D" & BlockIndex & "|70|     1| 10|0.0| 20|0.0| 30|0.0|  3|*D" & BlockIndex & "|  1||0|ENDBLK|  8|0|0|"
        BlockIndex = BlockIndex + 1
    End Sub

    Public Function DXF_BlockFooter() As String
        DXF_BlockFooter = "ENDSEC|  0|"
    End Function

    Public Function DXF_BodyHeader() As String
        DXF_BodyHeader = "SECTION|  2|ENTITIES|  0|"
    End Function

    Public Function DXF_BodyFooter() As String
        DXF_BodyFooter = "ENDSEC|  0|"
    End Function

    Public Function DXF_Footer() As String
        DXF_Footer = "EOF"
    End Function

    Public Sub DXF_save_to_file(ByVal Filename As String)
        Dim varDXF()
        Dim intDXF As Integer
        Dim strDXF_Output As String
        Dim file As System.IO.StreamWriter
        strDXF_Output = DXF_Header() & DXF_BlockHeader() & DXF_BlockBody & DXF_BlockFooter() & DXF_BodyHeader() & DXF_BodyText & DXF_BodyFooter() & DXF_Footer()
        varDXF = Split(strDXF_Output, "|")
        If My.Computer.FileSystem.FileExists(Filename) Then My.Computer.FileSystem.DeleteFile(Filename)
        file = My.Computer.FileSystem.OpenTextFileWriter(Filename, True)
        For intDXF = 0 To UBound(varDXF)
            file.WriteLine(varDXF(intDXF))
        Next
        file.Close()
    End Sub

    Public Sub DXF_Line(ByVal DXF_Layer As String, ByVal X1 As Single, ByVal Y1 As Single, ByVal Z1 As Single, ByVal X2 As Single, ByVal Y2 As Single, ByVal Z2 As Single)
        DXF_BodyText = DXF_BodyText & "LINE|8|" & DXF_Layer &
            "| 10|" & DXFF(X1) & "| 20|" & DXFF(Y1) & "| 30|" & DXFF(Z1) &
            "| 11|" & DXFF(X2) & "| 21|" & DXFF(Y2) & "| 31|" & DXFF(Z2) & "|0|"
    End Sub

    Public Sub DXF_Circle(ByVal DXF_Layer As String, ByVal X As Single, ByVal Y As Single, ByVal Z As Single, ByVal Radius As Single)
        DXF_BodyText = DXF_BodyText & "CIRCLE|8|" & DXF_Layer &
            "| 10|" & X & "| 20|" & Y & "| 30|" & Z &
            "| 40|" & Radius & "| 39|  0|0|"
    End Sub

    Public Sub DXF_Arc(ByVal DXF_Layer As String, ByVal X As Single, ByVal Y As Single, ByVal Z As Single, ByVal Radius As Single, ByVal StartAngle As Single, ByVal EndAngle As Single)
        '"|62|1|" after DXF_Layer sets the to color (Red)
        DXF_BodyText = DXF_BodyText & "ARC|8|" & DXF_Layer &
            "| 10|" & X & "| 20|" & Y & "| 30|" & Z &
            "| 40|" & Radius & "| 50|" & StartAngle & "| 51|" & EndAngle & "|0|"
    End Sub

    Public Sub DXF_Text(ByVal DXF_Layer As String, ByVal X As Single, ByVal Y As Single, ByVal Z As Single, ByVal Height As Single, ByVal iText As String)
        DXF_BodyText = DXF_BodyText & "TEXT|8|" & DXF_Layer &
                  "| 10|" & X & "| 20|" & Y & "| 30|" & Z &
                  "| 40|" & Height & "|1|" & iText & "| 50|  0|0|"
    End Sub

    Public Sub DXF_Dimension(ByVal DXF_Layer As String, ByVal X1 As Single, ByVal Y1 As Single, ByVal X2 As Single, ByVal Y2 As Single, ByVal PX1 As Single, ByVal PY1 As Single, ByVal PX2 As Single, ByVal PY2 As Single, Optional ByVal iAng As Single = 0, Optional ByVal iText As String = "None")
        Dim strDim(6) As String
        strDim(0) = "DIMENSION|  8|" & DXF_Layer & "|  6|CONTINUOUS|  2|*D" & BlockIndex
        strDim(1) = " 10|" & PX1 & "| 20|" & PY1 & "| 30|0.0"
        strDim(2) = " 11|" & PX2 & "| 21|" & PY2 & "| 31|0.0"
        strDim(3) = IIf(iText = "None", " 70|     0", " 70|     0|  1|" & iText)
        strDim(4) = " 13|" & X1 & "| 23|" & Y1 & "| 33|0.0"
        strDim(5) = " 14|" & X2 & "| 24|" & Y2 & "| 34|0.0" & IIf(iAng = 0, "", "| 50|" & iAng)
        strDim(6) = "1001|ACAD|1000|DSTYLE|1002|{|1070|   287|1070|     3|1070|    40|1040|8.0|1070|   271|1070|     3|1070|   272|1070|     3|1070|   279|1070|     0|1002|}|  0|"
        DXF_BodyText = DXF_BodyText & Join(strDim, "|")
        DXF_BuildBlockBody()
    End Sub

    Public Sub DXF_Rectangle(ByVal DXF_Layer As String, ByVal X1 As Single, ByVal Y1 As Single, ByVal Z1 As Single, ByVal X2 As Single, ByVal Y2 As Single, ByVal Z2 As Single)
        Dim strRectangle(5) As String
        strRectangle(0) = "POLYLINE|  5|48|  8|" & DXF_Layer & "|66|1| 10|0| 20|0| 30|0| 70|1|0"
        strRectangle(1) = "VERTEX|5|50|8|0| 10|" & X1 & "| 20|" & Y1 & "| 30|" & Z1 & "|  0"
        strRectangle(2) = "VERTEX|5|51|8|0| 10|" & X2 & "| 20|" & Y1 & "| 30|" & Z2 & "|  0"
        strRectangle(3) = "VERTEX|5|52|8|0| 10|" & X2 & "| 20|" & Y2 & "| 30|" & Z2 & "|  0"
        strRectangle(4) = "VERTEX|5|53|8|0| 10|" & X1 & "| 20|" & Y2 & "| 30|" & Z1 & "|  0"
        strRectangle(5) = "SEQEND|0|"
        DXF_BodyText = DXF_BodyText & Join(strRectangle, "|")
    End Sub

    Public Sub DXF_Border(ByVal DXF_Layer As String, ByVal X1 As Single, ByVal Y1 As Single, ByVal Z1 As Single, ByVal X2 As Single, ByVal Y2 As Single, ByVal Z2 As Single)
        Dim strBorder(5) As String
        strBorder(0) = "POLYLINE|  8|" & DXF_Layer & "| 40|1| 41|1| 66|1| 70|1|0"
        strBorder(1) = "VERTEX|  8|" & DXF_Layer & "| 10|" & X1 & "| 20|" & Y1 & "| 30|" & Z1 & "|  0"
        strBorder(2) = "VERTEX|  8|" & DXF_Layer & "| 10|" & X2 & "| 20|" & Y1 & "| 30|" & Z2 & "|  0"
        strBorder(3) = "VERTEX|  8|" & DXF_Layer & "| 10|" & X2 & "| 20|" & Y2 & "| 30|" & Z2 & "|  0"
        strBorder(4) = "VERTEX|  8|" & DXF_Layer & "| 10|" & X1 & "| 20|" & Y2 & "| 30|" & Z1 & "|  0"
        strBorder(5) = "SEQEND|  0|"
        DXF_BodyText = DXF_BodyText & Join(strBorder, "|")
        DXF_Xmin = X1
        DXF_Ymin = Y1
        DXF_Xmax = X2
        DXF_Ymax = Y2
    End Sub

    Public Sub DXF_ShowText(ByVal X As Single, ByVal Y As Single, ByVal eAng As Single, ByVal eRad As Single, ByVal eText As Object)
        Dim eX As Single, eY As Single, iRadians As Single
        iRadians = Radians(eAng)
        'Find the angle at which to draw the arrow head and leader
        eX = X - (eRad * (Math.Cos(iRadians)))
        eY = Y - (eRad * (Math.Sin(iRadians)))
        'Draw an arrow head
        DXF_ArrowHead(iRadians + Radians(180), X, Y)
        'Draw the leader lines
        DXF_Line(DXF_Layer, X, Y, 0, eX, eY, 0)
        DXF_Line(DXF_Layer, eX, eY, 0, eX + 2, eY, 0)
        'Place the text
        DXF_Text(DXF_Layer, eX + 2.5, eY - 0.75, 0, 1.5, eText)
    End Sub
    Public Sub DXF_ArrowHead(iRadians As Single, sngX As Single, sngY As Single)
        Dim X(1) As Single, Y(1) As Single
        'The number "3" is the length of the arrow head.
        'Adding or subtracting 170 degrees from the angle
        'gives us a 10 degree angle on the arrow head.
        'Finds the first side of the arrow head
        X(0) = sngX + (3 * (Math.Sin(iRadians + Radians(170))))
        Y(0) = sngY + (3 * (Math.Cos(iRadians + Radians(170))))
        'Finds the second side of the arrow head
        X(1) = sngX + (3 * (Math.Sin(iRadians - Radians(170))))
        Y(1) = sngY + (3 * (Math.Cos(iRadians - Radians(170))))
        'Draw the first side of the arrow head
        DXF_Line(DXF_Layer, sngX, sngY, 0, X(0), Y(0), 0) '/
        'Draw the second side of the arrow head
        DXF_Line(DXF_Layer, sngX, sngY, 0, X(1), Y(1), 0) '\
        'Draw the bottom side of the arrow head
        DXF_Line(DXF_Layer, X(0), Y(0), 0, X(1), Y(1), 0) '_
    End Sub

    Public Sub DXF_Penup()
        DXFPenup = True
    End Sub

    Public Sub DXF_PlotOLD(ByVal DXF_Layer As String, ByVal x As Double, ByVal y As Double)
        If DXFPenup = True Then
            DXFox = x
            DXFoy = y
            DXFPenup = False
        End If
        DXF_Line(DXF_Layer, DXFox, DXFoy, 0, x, y, 0)
        DXFox = x
        DXFoy = y
    End Sub
    Public Sub DXF_Plot(ByVal DXF_Layer As String, ByVal x1 As Double, ByVal y1 As Double)
        If ((y1 > DXF_Ymax) Or (y1 < DXF_Ymin) Or (x1 > DXF_Xmax) Or (x1 < DXF_Xmin)) Then DXF_Penup()

        If DXFPenup = True Then
            If Not ((y1 > DXF_Ymax) Or (y1 < DXF_Ymin) Or (x1 > DXF_Xmax) Or (x1 < DXF_Xmin)) Then
                DXF_Line(DXF_Layer, x1, y1, 0, x1, y1, 0)
            Else
                DXF_Penup()
            End If
            DXFPenup = False
        Else
            DXF_Line(DXF_Layer, DXFox, DXFoy, 0, x1, y1, 0)
        End If
        DXFox = x1
        DXFoy = y1
    End Sub

    Private Function DXFF(ByVal Nval As Double) As String
        'DXFF = Format(Nval, "000000.000000").ToString()
        DXFF = Nval.ToString().Replace(",", ".")
    End Function

End Module
