Imports System.Net
Imports System.Text
Public Class Gmap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTGetCoords.Click
        Dim state As String = TXTState.Text
        Dim city As String = TXTCity.Text
        Dim zip As String = TXTZip.Text
        Dim street As String = TXTStreet.Text

        BTGetCoord.Enabled = True

        Try
            Dim QueryAddress As New StringBuilder
            QueryAddress.Append("http://maps.google.com/maps?q=")
            If TXTStreet.Text <> String.Empty Then
                QueryAddress.Append(street + "," & "+")
            End If
            If TXTCity.Text <> String.Empty Then
                QueryAddress.Append(city + "," & "+")
            End If
            If TXTState.Text <> String.Empty Then
                QueryAddress.Append(state + "," & "+")
            End If
            If TXTZip.Text <> String.Empty Then
                QueryAddress.Append(zip + "," & "+")
            End If

            WebBrowser1.Navigate(QueryAddress.ToString)


        Catch ex As Exception
            MessageBox.Show("Unable to retrive map")
        End Try

    End Sub


    Private Sub CreateBrowserKey(Optional ByVal IgnoreIDocDirective As Boolean = False)
        Dim value As Int32
        ' Value reference: http://msdn.microsoft.com/en-us/library/ee330730%28v=VS.85%29.aspx
        ' IDOC Reference:  http://msdn.microsoft.com/en-us/library/ms535242%28v=vs.85%29.aspx
        Select Case (New WebBrowser).Version.Major
            Case 8
                If IgnoreIDocDirective Then
                    value = 8888
                Else
                    value = 8000
                End If
            Case 9
                If IgnoreIDocDirective Then
                    value = 9999
                Else
                    value = 9000
                End If
            Case 10
                If IgnoreIDocDirective Then
                    value = 10001
                Else
                    value = 10000
                End If
            Case 11
                If IgnoreIDocDirective Then
                    value = 11001
                Else
                    value = 11000
                End If

            Case Else
                Exit Sub
        End Select
        Microsoft.Win32.Registry.SetValue(Microsoft.Win32.Registry.CurrentUser.ToString & "\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
                                                  Process.GetCurrentProcess.ProcessName & ".exe",
                                                  value,
                                                  Microsoft.Win32.RegistryValueKind.DWord)
    End Sub

    Private Sub RemoveBrowserKey()
        Dim key As Microsoft.Win32.RegistryKey
        key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION".Substring(1), True)
        key.DeleteValue(Process.GetCurrentProcess.ProcessName & ".exe", False)
    End Sub

    Private Sub Gmap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateBrowserKey()
        ButtonUseCoord.Enabled = False
        BTGetCoord.Enabled = False
    End Sub

    Private Sub Gmap_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RemoveBrowserKey()
    End Sub

    Private Sub BTGetCoord_Click(sender As Object, e As EventArgs) Handles BTGetCoord.Click
        Dim Param As String = WebBrowser1.Url.ToString.Substring(InStr(WebBrowser1.Url.ToString, "@"))
        Dim A As Array = Param.Split(",")
        Dim S As Integer = A.GetUpperBound(0)
        If S >= 1 Then
            A(0) = Replace(A(0), ".", ",")
            A(1) = Replace(A(1), ".", ",")
            LAT.Text = A(0)
            LON.Text = A(1)
            If CDbl(A(0)) > 0 Then LatQ.Text = "N" Else LatQ.Text = "S"
            If CDbl(A(1)) > 0 Then LongQ.Text = "E" Else LongQ.Text = "W"
            LatG.Text = Math.Truncate(CDbl(A(0)))
            LatP.Text = Math.Truncate((CDbl(A(0)) - Math.Truncate(CDbl(A(0)))) * 60)
            LatS.Text = ((((CDbl(A(0)) - Math.Truncate(CDbl(A(0)))) * 60) - Math.Truncate((CDbl(A(0)) - Math.Truncate(CDbl(A(0)))) * 60)) * 60).ToString("N2")
            LongG.Text = Math.Truncate(CDbl(A(1)))
            LongP.Text = Math.Truncate((CDbl(A(1)) - Math.Truncate(CDbl(A(1)))) * 60)
            LongS.Text = ((((CDbl(A(1)) - Math.Truncate(CDbl(A(1)))) * 60) - Math.Truncate((CDbl(A(1)) - Math.Truncate(CDbl(A(1)))) * 60)) * 60).ToString("N2")
        Else
            MsgBox("wrong number of parameters returned form Google Maps")
        End If
        ButtonUseCoord.Enabled = True
    End Sub

    Private Sub ButtonUseCoord_Click(sender As Object, e As EventArgs) Handles ButtonUseCoord.Click
        Master.LatG.Text = Me.LatG.Text
        Master.LatP.Text = Me.LatP.Text
        Master.LatS.Text = Me.LatS.Text
        Master.LongQ.Text = Me.LongQ.Text

        Master.LongG.Text = Me.LongG.Text
        Master.LongP.Text = Me.LongP.Text
        Master.LongS.Text = Me.LongS.Text
        Master.LongQ.Text = Me.LongQ.Text

        Master.RenderGraph()
        Me.Close()
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TXTStreet.Text = ""
        TXTCity.Text = ""
        TXTState.Text = ""
        TXTZip.Text = ""
        'txtLatitudine.Text = ""
        'txtLongitudine.Text = ""
        ButtonUseCoord.Enabled = False
        BTGetCoord.Enabled = False
    End Sub
End Class