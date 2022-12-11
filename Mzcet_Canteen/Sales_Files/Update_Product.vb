Public Class Update_Product

    Public dt As Date = Today


    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        submit_update()
    End Sub

    Private Sub Update_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        product_id1.Text = product_id_data
        product_name1.Text = product_name_data
        Price_1.Text = product_price_data
        Quantity_1.Text = product_quantity_data
        short_key.Text = shortkey
        Quantity_1.Focus()
    End Sub

    Private Sub Price_1_KeyDown(sender As Object, e As KeyEventArgs) Handles Price_1.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit_update()
        End If
    End Sub


    Public Function submit_update()
        Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
        Dim t As String = TimeOfDay.ToString("h:mm:ss tt")

        dtCustomers = ReadFromDatabase("insert into product_log (Product_id,old_product_name,new_product_name,old_shortcut_key,new_shortcut_key,old_quantity,new_quantity,old_price,new_price,date,time,changes)values('" + product_id_data + "','" + product_name_data + "','" + product_name1.Text + "','" + shortkey + "','" + short_key.Text + "','" + product_quantity_data + "','" + Quantity_1.Text + "','" + product_price_data + "','" + Price_1.Text + "','" + d + "','" + t + "','" + changes + "')")

        dtCustomers = ReadFromDatabase("UPDATE items SET Product_name='" & product_name1.Text & "',Price='" & Price_1.Text & "',Quantity='" & Quantity_1.Text & "',Date='" & DateTime.Now.ToString() & "',month='" & MonthName(DateTime.Now.Month.ToString()) & "',shortcut_key='" + short_key.Text + "' WHERE Product_id='" & product_id1.Text & "'")
        dtCustomers = ReadFromDatabase("SELECT * FROM items")

        DataGrid1.DataSource = dtCustomers
        Me.Close()
    End Function

    Private Sub product_id1_TextChanged(sender As Object, e As EventArgs) Handles product_id1.TextChanged

    End Sub

    Private Sub product_name1_TextChanged(sender As Object, e As EventArgs) Handles product_name1.TextChanged

    End Sub

    Private Sub product_name1_KeyDown(sender As Object, e As KeyEventArgs) Handles product_name1.KeyDown
        NextBox(e)
    End Sub

    Private Sub short_key_TextChanged(sender As Object, e As EventArgs) Handles short_key.TextChanged

    End Sub

    Private Sub short_key_KeyDown(sender As Object, e As KeyEventArgs) Handles short_key.KeyDown
        NextBox(e)
    End Sub

    Private Sub Quantity_1_TextChanged(sender As Object, e As EventArgs) Handles Quantity_1.TextChanged

    End Sub

    Private Sub Quantity_1_KeyDown(sender As Object, e As KeyEventArgs) Handles Quantity_1.KeyDown
        NextBox(e)
    End Sub

    Private Sub Price_1_TextChanged(sender As Object, e As EventArgs) Handles Price_1.TextChanged

    End Sub
End Class