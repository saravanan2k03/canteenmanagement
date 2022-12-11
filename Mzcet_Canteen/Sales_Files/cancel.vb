Public Class cancel

    Private Sub cancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_Product_date.Text = Cancel_Date
        display_Product_id.Text = Cancel_Product_id
        display_Product_qunatity.Text = Cancel_Qunatity
        display_Product_spr_no.Text = Cancel_Spr_No
        display_Product_total.Text = Cancel_Total

        display_Product_date.Enabled = False
        display_Product_total.Enabled = False
        display_Product_qunatity.Enabled = False
        display_Product_spr_no.Enabled = False
        display_Product_id.Enabled = False

    End Sub


    Private Sub display_Product_id_TextChanged(sender As Object, e As EventArgs) Handles display_Product_id.TextChanged

    End Sub

    Private Sub display_Product_qunatity_TextChanged(sender As Object, e As EventArgs) Handles display_Product_qunatity.TextChanged

    End Sub

    Private Sub display_Product_total_TextChanged(sender As Object, e As EventArgs) Handles display_Product_total.TextChanged

    End Sub

    Private Sub display_Product_spr_no_TextChanged(sender As Object, e As EventArgs) Handles display_Product_spr_no.TextChanged

    End Sub

    Private Sub display_Product_date_TextChanged(sender As Object, e As EventArgs) Handles display_Product_date.TextChanged

    End Sub



    Public Function Cancel_recently_purchase()
        Try
            ReadFromDatabase("UPDATE Buyer_Details SET Status = 'Cancelled' WHERE Ref_NO = '" & Cancel_Ref_No & "' ")
            ReadFromDatabase("UPDATE items SET Quantity = cast(quantity as integer) +'" & Convert.ToInt32(Cancel_Qunatity) & "' WHERE Product_id = '" & Cancel_Product_id & "' ")
            ReadFromDatabase("UPDATE buyer SET balance = cast(balance as integer) +'" & Convert.ToInt32(Cancel_Total) & "' WHERE Spr_no = '" & Cancel_Spr_No & "' ")
            MsgBox("Cancelled SuccessFully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub Abort_Purchased_Click(sender As Object, e As EventArgs) Handles Abort_Purchased.Click
        Cancel_recently_purchase()
    End Sub
End Class