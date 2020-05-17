Module Logger
    Enum LogCMD
        Delete
        NewFile
        NewFileAndPath
        Write
        Close
    End Enum

    Dim file As System.IO.StreamWriter

    Public Sub Flog(Filename As String, Command As LogCMD, Optional Message As String = "")

        Select Case Command
            Case LogCMD.Delete
                If My.Computer.FileSystem.FileExists(Filename) Then My.Computer.FileSystem.DeleteFile(Filename)
            Case LogCMD.NewFile
                file = My.Computer.FileSystem.OpenTextFileWriter(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & Filename, True)
            Case LogCMD.NewFileAndPath
                file = My.Computer.FileSystem.OpenTextFileWriter(Filename, True)
            Case LogCMD.Write
                file.WriteLine(Message)
            Case LogCMD.Close
                file.Close()
            Case Else
        End Select

    End Sub

End Module
