Public Class Product_log
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles pro_table.CellContentClick

    End Sub

    Private Sub Product_log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtCustomers = ReadFromDatabase("select * from product_log")
        pro_table.DataSource = dtCustomers
        pro_table.ClearSelection()
    End Sub
End Class