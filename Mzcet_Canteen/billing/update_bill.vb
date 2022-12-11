Imports System.Data.SqlClient

Public Class update_bill
    Public Sub update_bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        quantitytext.Focus()
        produ.Text = item_f
        produname.Text = pd_name_f
        quantitytext.Text = quant_f
        pricetext.Text = price_f
        totaltext.Text = total_f
        'MessageBox.Show(bill_num)
        LoadData()
    End Sub


    Private Sub quantitytext_KeyDown(sender As Object, e As KeyEventArgs) Handles quantitytext.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim ase As Integer
            Dim StringToInteger1 As Integer = Convert.ToInt32(quantitytext.Text)
            ase = 1
            Dim checke As String = ase * StringToInteger1
            If String.IsNullOrWhiteSpace(quantitytext.Text) Or checke = "0" Then
                MessageBox.Show("Please Fill The Field")
            Else
                upd.PerformClick()

            End If
        End If
    End Sub

    Public Sub quantitytext_TextChanged(sender As Object, e As EventArgs) Handles quantitytext.TextChanged
        Try
            Dim StringToInteger As Integer = Convert.ToInt32(quantitytext.Text)
            Dim StringToInteger1 As Integer = Convert.ToInt32(pricetext.Text)

            Dim tot As String

            tot = StringToInteger * StringToInteger1
            totaltext.Text = tot
        Catch
        End Try

    End Sub

    Public Sub upd_Click(sender As Object, e As EventArgs) Handles upd.Click
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        con.Open()

        Dim cmd As SqlCommand = New SqlCommand("select Quantity from items where Product_id='" + produ.Text + "'", con)
        Dim myreader As SqlDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()
        Dim res = myreader("Quantity")
        con.Close()
        Dim a As Integer = Convert.ToInt32(res)
        Dim b As Integer = Convert.ToInt32(quantitytext.Text)

        If (b > a) Then
            MessageBox.Show("Item Out of Stocks", "Error")
            quantitytext.Focus()
        Else
            dtCustomers = ReadFromDatabase("update buyer_details set quantity='" + quantitytext.Text + "',total='" + totaltext.Text + "'where ref_no='" + ref_f + "'")
            LoadData()
            dtCustomers = ReadFromDatabase("alter view g_tot as select sum(total) as grand_tot from buyer_details where bill_no='" + bill_num + "'")
            LoadData()
            con.Open()
            Dim cmd2 As SqlCommand = New SqlCommand("select * from g_tot", con)
            Dim myreader2 As SqlDataReader
            myreader2 = cmd2.ExecuteReader
            myreader2.Read()
            Dim g_total = myreader2("grand_tot")
            con.Close()
            LoadData()
            Me.Close()
        End If





    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        dtCustomers = ReadFromDatabase("delete from buyer_details where Ref_No='" + ref_f + "'")
        LoadData()
        Me.Close()
        LoadData()
    End Sub

    Public Function LoadData()

        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        Dim command As New SqlCommand("select buyer_details.Ref_no As RefNo, items.Product_id As Productid,items.Product_name As Productname ,Buyer_details.Quantity,items.Price,Buyer_Details.Total from Buyer_Details inner join items on items.Product_Id = Buyer_Details.Product_Id where Buyer_Details.bill_no='" + bill_num + "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        sa.DataSource = dt
        sa.ClearSelection()
        dtCustomers = ReadFromDatabase("select sum(total) From buyer_details where bill_no='" + bill_num + "'")
    End Function
End Class