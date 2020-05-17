Public Class Motti
    Private Sub Motti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DBDT As DataTable
        ListBoxMotti.Items.Clear()
        ExecuteQuery("select * from [ALL]", DBDT)
        For Each R As DataRow In DBDT.Rows
            ListBoxMotti.Items.Add(R("MOTTO") & " - " & R("TRADUCTION"))
        Next
    End Sub

    Private Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        Master.Motto.Text = Me.ListBoxMotti.SelectedItem
        Master.RTB_OutData.Text = Master.RTB_OutData.Text & "Motto = " & Me.ListBoxMotti.SelectedItem
        Me.Close()
    End Sub
End Class