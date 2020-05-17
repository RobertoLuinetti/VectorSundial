Imports System.Data.OleDb
Module AccessDB

    Public ConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Meridiane.accdb;"

    Private DBDA As OleDbDataAdapter
    'Public DBDT As DataTable

    Public Sub ExecuteQuery(ByVal StrSQl As String, ByRef DBDT As DataTable)
        Dim cnn As OleDbConnection
        Dim cmd As OleDbCommand
        'Dim reader As OleDbDataReader

        cnn = New OleDbConnection(ConnString)
        Try
            cnn.Open()
            cmd = New OleDbCommand(StrSQl, cnn)
            'reader = cmd.ExecuteReader()
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(cmd)
            DBDA.Fill(DBDT)
            'While reader.Read()
            '    MsgBox(reader.Item(0) & "  -  " & reader.Item(1) & "  -  " & reader.Item(2))
            'End While
            'reader.Close()
            cmd.Dispose()
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ExecuteCommand(ByVal StrSQL As String)
        Dim cnn As OleDbConnection
        Dim cmd As OleDbCommand
        cnn = New OleDbConnection(ConnString)
        Try
            cnn.Open()
            cmd = New OleDbCommand(StrSQL, cnn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ExecuteScalarQuery(ByVal StrSQL As String) As Object
        Dim cnn As OleDbConnection
        Dim cmd As OleDbCommand

        cnn = New OleDbConnection(ConnString)
        Try
            cnn.Open()
            cmd = New OleDbCommand(StrSQL, cnn)
            Dim RetValue As Object = Convert.ToInt32(cmd.ExecuteScalar())
            cmd.Dispose()
            cnn.Close()
            ExecuteScalarQuery = RetValue
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Module
