Public Class add_product
    Private Sub add_product_Load(sender As Object, e As EventArgs)
        shortkeybox.Focus()
    End Sub

    Private Sub quantity_TextChanged(sender As Object, e As EventArgs) Handles quantity.TextChanged

    End Sub

    Private Sub price_TextChanged(sender As Object, e As EventArgs) Handles price.TextChanged

    End Sub

    Private Sub product_name_TextChanged(sender As Object, e As EventArgs) Handles product_name.TextChanged

    End Sub

    Private Sub product_id_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReadFromDatabase("INSERT INTO items([shortcut_key],[Product_Name],[Price],[Quantity],[Date],[Month]) VALUES ('" & shortkeybox.Text & "','" & product_name.Text & "','" & price.Text & "','" & quantity.Text & "','" & DateTime.Now.ToString() & "','" & MonthName(DateTime.Now.Month.ToString()) & "')")
        dtCustomers = ReadFromDatabase("SELECT * FROM items")
        DataGrid1.DataSource = dtCustomers
        MsgBox(database_query_status)
        shortkeybox.Clear()
        product_name.Clear()
        price.Clear()
        quantity.Clear()
    End Sub


    Private Sub price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles price.KeyPress
        onlyDigits(e)
    End Sub

    Private Sub quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantity.KeyPress
        onlyDigits(e)
    End Sub

    Private Sub product_id_KeyDown(sender As Object, e As KeyEventArgs)
        NextBox(e)
    End Sub

    Private Sub product_name_KeyDown(sender As Object, e As KeyEventArgs) Handles product_name.KeyDown
        NextBox(e)
    End Sub

    Private Sub price_KeyDown(sender As Object, e As KeyEventArgs) Handles price.KeyDown
        NextBox(e)
    End Sub

    Private Sub quantity_KeyDown(sender As Object, e As KeyEventArgs) Handles quantity.KeyDown
        NextBox(e)
    End Sub

    Private Sub add_product_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        shortkeybox.Clear()
        product_name.Clear()
        price.Clear()
        quantity.Clear()
    End Sub

    Private Sub shortkeybox_KeyDown(sender As Object, e As KeyEventArgs) Handles shortkeybox.KeyDown
        NextBox(e)
    End Sub
End Class