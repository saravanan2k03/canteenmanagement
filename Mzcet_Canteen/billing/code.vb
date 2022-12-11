Public Class code
    Private Sub checkgriddata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles checkgriddata.CellContentClick

    End Sub

    Private Sub code_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        product_name_search.Focus()
        dtCustomers = ReadFromDatabase("SELECT * FROM items")
        checkgriddata.DataSource = dtCustomers
    End Sub

    Private Sub product_name_search_TextChanged(sender As Object, e As EventArgs) Handles product_name_search.TextChanged
        dtCustomers = ReadFromDatabase("select * from items where Product_Name Like '" & product_name_search.Text & "'+'%' ")
        checkgriddata.DataSource = dtCustomers
    End Sub
End Class