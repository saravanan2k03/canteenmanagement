
Public Class Log_data



    Private Sub Log_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLogs()
        DataGridView1.DataSource = dtCustomers
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) 



    End Sub

End Class