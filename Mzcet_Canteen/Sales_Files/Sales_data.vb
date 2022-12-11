

Imports System.Data.SqlClient


Public Class Sales_data
    Private Sub Sales_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ordstatus = "ordered"
        renderFunction()
        DateTimePicker1.ResetText()
        DateTimePicker2.ResetText()
        Try
            Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")

            dtCustomers = ReadFromDatabase("Select buyer_details.Ref_no As Refno,buyer_details.spr_no As sprno,buyer_details.product_id As productid,items.product_name As productname,buyer_details.quantity,buyer_details.total,bill.billing_no As billno,buyer_details.status,buyer_details.Date,buyer_details.month,buyer_details.token from Buyer_Details Inner Join items On items.Product_id =Buyer_Details.Product_Id inner join Bill on Buyer_details.bill_no = Bill.bill_no  where buyer_details.Date='" + d + "'and buyer_details.status='" + ordstatus + "'")
            DataGridView1.DataSource = dtCustomers
            RichTextBox1.Text = dtCustomers.Rows.Count
            renderFunction()

        Catch ex As Exception
            MessageBox.Show("No product yet", "Info")
        End Try
        DataGridView1.DataSource = dtCustomers
        RichTextBox1.Text = dtCustomers.Rows.Count

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        renderFunction()
        DateDatas()
        RichTextBox1.Text = dtCustomers.Rows.Count
    End Sub


    Public Function DateDatas()
        Try

            dtCustomers = ReadFromDatabase("Select buyer_details.Ref_no As Refno,buyer_details.spr_no As sprno,buyer_details.product_id As productid,items.product_name As productname,buyer_details.quantity,buyer_details.total,bill.billing_no As billno,buyer_details.status,buyer_details.Date,buyer_details.month,buyer_details.token,sum(total) as tot from Buyer_Details Inner Join items On items.Product_id =Buyer_Details.Product_Id inner join Bill on Buyer_details.bill_no = Bill.bill_no  where buyer_details.Date between '" & DateTimePicker1.Value.Date.ToString("dd-MM-yyyy") & "'and'" & DateTimePicker2.Value.Date.ToString("dd-MM-yyyy") & "'and status='" + ordstatus + "'")
            DataGridView1.DataSource = dtCustomers
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Private Sub PDF_Print_Click(sender As Object, e As EventArgs) Handles PDF_Print.Click
        PrintPdf(DataGridView1, "sales")
        MessageBox.Show("Saved In C Drive")
    End Sub
    Public Sub renderFunction()
        Try
            Dim con As SqlConnection = New SqlConnection(DBConnectionString)
            con.Open()
            Dim cmd1 As New SqlCommand("select sum(quantity) as quant ,sum(total) as tot From buyer_details where Date between '" & DateTimePicker1.Value.Date.ToString("dd-MM-yyyy") & "'and'" & DateTimePicker2.Value.Date.ToString("dd-MM-yyyy") & "' and buyer_details.status='" + ordstatus + "'", con)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader()
            myreader.Read()
            amounttext.Text = myreader("tot")
            quantity_count.Text = myreader("quant")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("No product yet", "Info")

        End Try

    End Sub


    Private Sub Student_data_Click(sender As Object, e As EventArgs) Handles Student_data.Click

        dtCustomers = ReadFromDatabase("Select buyer_details.Ref_no As Refno,buyer_details.spr_no As sprno,buyer_details.product_id As productid,items.product_name As productname,buyer_details.quantity,buyer_details.total,bill.billing_no As billno,buyer_details.status,buyer_details.Date,buyer_details.month,buyer_details.token from Buyer_Details Inner Join items On items.Product_id =Buyer_Details.Product_Id inner join Bill on Buyer_details.bill_no = Bill.bill_no   Where buyer_details.spr_no='" & search_sales.Text & "'and buyer_details.Date between '" & DateTimePicker1.Value.Date.ToString("dd-MM-yyyy") & "'and'" & DateTimePicker2.Value.Date.ToString("dd-MM-yyyy") & "' and buyer_details.status='" + ordstatus + "'")
        DataGridView1.DataSource = dtCustomers
        RichTextBox1.Text = dtCustomers.Rows.Count
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        con.Open()
        Dim cmd1 As New SqlCommand("select sum(quantity) as quant From buyer_details where Date between '" & DateTimePicker1.Value.Date.ToString("dd-MM-yyyy") & "'and'" & DateTimePicker2.Value.Date.ToString("dd-MM-yyyy") & "' and spr_no='" + search_sales.Text + "' and buyer_details.status='" + ordstatus + "'", con)
        Dim myreader As SqlDataReader
        myreader = cmd1.ExecuteReader()
        If myreader.HasRows Then
            myreader.Read()
            Dim quan = myreader("quant")
            con.Close()
            If (quan.Equals(DBNull.Value)) Then
                MsgBox("NO DATA FOUND")
                quantity_count.Text = "0"
                amounttext.Text = "0"
            Else

                quantity_count.Text = quan

            End If
        End If




        con.Open()
        Dim cmd2 As New SqlCommand("select sum(total) as tot From buyer_details where Date between '" & DateTimePicker1.Value.Date.ToString("dd-MM-yyyy") & "'and'" & DateTimePicker2.Value.Date.ToString("dd-MM-yyyy") & "' and spr_no='" + search_sales.Text + "' and buyer_details.status='" + ordstatus + "'", con)
        Dim myread As SqlDataReader
        myread = cmd2.ExecuteReader()
        If myread.HasRows Then
            myread.Read()
            Dim amt = myread("tot")
            If (amt.Equals(DBNull.Value)) Then

            Else
                amounttext.Text = amt
            End If
            con.Close()
        Else
            con.Close()
            amounttext.Text = 0
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class