Module DXF

    Public DXFPenup As Boolean
    Public DXFLayerName
    Public DXFox As Double
    Public DXFoy As Double
    Public DXFActualOutFileName As String

    Dim DXFHeader As String = "0
SECTION
  2
HEADER
  9
$ACADVER
  1
AC1002
  9
$INSBASE
 10
0.0
 20
0.0
  9
$EXTMIN
 10
1.000000E+20
 20
1.000000E+20
  9
$EXTMAX
 10
-1.000000E+20
 20
-1.000000E+20
  9
$LIMMIN
 10
0.0
 20
0.0
  9
$LIMMAX
 10
297.0
 20
210.0
  9
$VIEWCTR
 10
166.10189
 20
105.0
  9
$VIEWSIZE
 40
210.0
  9
$SNAPMODE
 70
     0
  9
$SNAPUNIT
 10
1.0
 20
1.0
  9
$SNAPBASE
 10
0.0
 20
0.0
  9
$SNAPANG
 50
0.0
  9
$SNAPSTYLE
 70
     0
  9
$SNAPISOPAIR
 70
     0
  9
$GRIDMODE
 70
     0
  9
$GRIDUNIT
 10
0.0
 20
0.0
  9
$ORTHOMODE
 70
     0
  9
$REGENMODE
 70
     1
  9
$FILLMODE
 70
     1
  9
$QTEXTMODE
 70
     0
  9
$DRAGMODE
 70
     2
  9
$LTSCALE
 40
1.0
  9
$OSMODE
 70
     0
  9
$ATTMODE
 70
     1
  9
$TEXTSIZE
 40
0.2
  9
$TRACEWID
 40
0.05
  9
$TEXTSTYLE
  7
STANDARD
  9
$CLAYER
  8
0
  9
$CELTYPE
  6
DAPIANO
  9
$CECOLOR
 62
   256
  9
$DIMSCALE
 40
1.0
  9
$DIMASZ
 40
0.18
  9
$DIMEXO
 40
0.0625
  9
$DIMDLI
 40
0.38
  9
$DIMRND
 40
0.0
  9
$DIMDLE
 40
0.0
  9
$DIMEXE
 40
0.18
  9
$DIMTP
 40
0.0
  9
$DIMTM
 40
0.0
  9
$DIMTXT
 40
0.18
  9
$DIMCEN
 40
0.09
  9
$DIMTSZ
 40
0.0
  9
$DIMTOL
 70
     0
  9
$DIMLIM
 70
     0
  9
$DIMTIH
 70
     1
  9
$DIMTOH
 70
     1
  9
$DIMSE1
 70
     0
  9
$DIMSE2
 70
     0
  9
$DIMTAD
 70
     0
  9
$DIMZIN
 70
     0
  9
$DIMBLK
  1

  9
$LUNITS
 70
     2
  9
$LUPREC
 70
     4
  9
$AXISMODE
 70
     0
  9
$AXISUNIT
 10
0.0
 20
0.0
  9
$SKETCHINC
 40
0.1
  9
$FILLETRAD
 40
0.0
  9
$AUNITS
 70
     0
  9
$AUPREC
 70
     0
  9
$MENU
  1
ACAD
  9
$ELEVATION
 40
0.0
  9
$THICKNESS
 40
0.0
  9
$VIEWDIR
 10
0.0
 20
0.0
 30
1.0
  9
$LIMCHECK
 70
     0
  9
$BLIPMODE
 70
     1
  9
$CHAMFERA
 40
0.0
  9
$CHAMFERB
 40
0.0
  9
$FASTZOOM
 70
     1
  9
$SKPOLY
 70
     0
  9
$TDCREATE
 40
2448898.6342852347
  9
$TDUPDATE
 40
2448898.6342852347
  9
$TDINDWG
 40
0.0000000000
  9
$TDUSRTIMER
 40
0.0000000000
  9
$USRTIMER
 70
     1
  9
$ANGBASE
 50
0.0
  9
$ANGDIR
 70
     0
  9
$PDMODE
 70
     0
  9
$PDSIZE
 40
0.0
  9
$PLINEWID
 40
0.0
  9
$COORDS
 70
     0
  9
$USERI1
 70
     0
  9
$USERI2
 70
     0
  9
$USERI3
 70
     0
  9
$USERI4
 70
     0
  9
$USERI5
 70
     0
  9
$USERR1
 40
0.0
  9
$USERR2
 40
0.0
  9
$USERR3
 40
0.0
  9
$USERR4
 40
0.0
  9
$USERR5
 40
0.0
  0
ENDSEC
  0
SECTION
  2
TABLES
  0
TABLE
  2
LTYPE
 70
     1
  0
LTYPE
  2
CONTINUA
 70
     0
  3
Linea piena
 72
    65
 73
     0
 40
0.0
  0
ENDTAB
  0
TABLE
  2
LAYER
 70
     1
  0
LAYER
  2
0
 70
     0
 62
     7
  6
CONTINUA
  0
ENDTAB
  0
TABLE
  2
STYLE
 70
     1
  0
STYLE
  2
STANDARD
 70
     0
 40
0.0
 41
1.0
 50
0.0
 71
     0
 42
0.2
  3
txt
  4

  0
ENDTAB
  0
TABLE
  2
VIEW
 70
     0
  0
ENDTAB
  0
ENDSEC
  0
SECTION
  2
BLOCKS
  0
BLOCK
  8
0
  2
BORDER
 70
     0
 10
0.0
 20
0.0
  0
ENDBLK
  8
0
  0
ENDSEC
  0
SECTION
  2
ENTITIES
  0
INSERT
  8
0
  2
BORDER
 10
0.0
 20
0.0
 41
297.0
 42
210.0
 43
297.0
  0

"

    Public Sub DXF_Init(ByVal DXFOutFileName As String)
        DXFLayerName = "0"
        DXFox = 0
        DXFoy = 0
        Flog(DXFOutFileName, LogCMD.Delete)
        Flog(DXFOutFileName, LogCMD.NewFileAndPath)
        Flog(DXFOutFileName, LogCMD.Write, DXFHeader & vbCrLf)
        ' Flog(DXFOutFileName, LogCMD.Write, "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA")
        DXF_Penup()
        DXFActualOutFileName = DXFOutFileName
    End Sub

    Public Sub DXF_Close()
        Flog(DXFActualOutFileName, LogCMD.Write, "ENDSEC" & vbCrLf & "  0" & vbCrLf & "EOF" & vbCrLf)
        Flog(DXFActualOutFileName, LogCMD.Close)
    End Sub

    Public Sub DXF_Penup()
        DXFPenup = True
    End Sub

    Public Sub DXF_LayerName(ByVal layername As String)
        DXFLayerName = layername.ToUpper
    End Sub

    Public Sub DXF_Plot(ByVal x As Double, ByVal y As Double)
        If DXFPenup = True Then
            DXFox = x
            DXFoy = y
            DXFPenup = False
        End If
        Flog(DXFActualOutFileName, LogCMD.Write, "LINE")
        Flog(DXFActualOutFileName, LogCMD.Write, "  8")
        Flog(DXFActualOutFileName, LogCMD.Write, DXFLayerName)
        Flog(DXFActualOutFileName, LogCMD.Write, " 10" & vbCrLf & DXFNumber(DXFox))
        Flog(DXFActualOutFileName, LogCMD.Write, " 20" & vbCrLf & DXFNumber(DXFoy))
        Flog(DXFActualOutFileName, LogCMD.Write, " 11" & vbCrLf & DXFNumber(x))
        Flog(DXFActualOutFileName, LogCMD.Write, " 21" & vbCrLf & DXFNumber(y))
        Flog(DXFActualOutFileName, LogCMD.Write, "  0")
        DXFox = x
        DXFoy = y
    End Sub

    Private Function DXFNumber(ByVal Nval As Double) As String
        DXFNumber = Format(Nval, "000000.000000").ToString()
    End Function

End Module
