Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mail
Imports System.Drawing.Printing
Public Class Form3
    Public con As SqlConnection = New SqlConnection(DBConnectionString)

    Public Sub Autocomplete()
        Dim command As New SqlCommand("select shortcut_key from items", con)
        Dim da As New SqlDataAdapter(command)
        Dim dt As New DataSet

        da.Fill(dt)

        Dim column1 As New AutoCompleteStringCollection

        For i As Integer = 0 To dt.Tables(0).Rows.Count - 1

            column1.Add(dt.Tables(0).Rows(i)("shortcut_key").ToString())

        Next


        item_field.AutoCompleteSource = AutoCompleteSource.CustomSource
        item_field.AutoCompleteCustomSource = column1
        item_field.AutoCompleteMode = AutoCompleteMode.Suggest





    End Sub

    Public Sub ord()
        Try
            Dim dates As String = DateTime.Now.ToString("dd-MM-yyyy")
            Dim months As String = DateTime.Now.ToString("MMMM")
            Dim times As String = TimeOfDay.ToString("h:mm:ss tt")
            Dim status As String = "unordered"



            'Dim tokkk As Integer = Convert.ToInt32(token_field.Text)

            Dim con As SqlConnection = New SqlConnection(DBConnectionString)
                    con.Open()
            Dim checkid As SqlCommand = New SqlCommand("select token_id from token where token_id='" + tokenid.ToString + "'", con)

            Dim checkreader As SqlDataReader
                    checkreader = checkid.ExecuteReader
                    checkreader.Read()
                    Dim toks As String = checkreader("token_id")
            'MessageBox.Show(toks)


            Try

                If tokenid = (checkreader("token_id")) Then

                    con.Close()


                    'Dim tokk As Integer = Convert.ToInt32(token_field.Text) 

                    con.Open()
                        Dim cmd As SqlCommand = New SqlCommand("select buyer.id as id,buyer.spr_no as spr_no,buyer.name as name,buyer.department as department ,buyer.year as year,buyer.type as type, buyer.balance as balance from buyer inner join token on buyer.spr_no=token.id where token.token_id='" + tokenid.ToString + "'", con)
                        Dim myreader As SqlDataReader
                        myreader = cmd.ExecuteReader
                        myreader.Read()
                        Id_scan_field.Text = myreader("id")
                        spr_field.Text = myreader("spr_no")
                        name_field.Text = myreader("name")
                        type_field.Text = myreader("type")
                        dp_field.Text = myreader("department")
                        year_field.Text = myreader("year")
                        type_field.Text = myreader("type")
                        balance_field.Text = myreader("balance")
                        Dim saro As String = myreader("id")
                        'MessageBox.Show(saro)
                        transdatagrid()

                        con.Close()
                        con.Open()
                        'Dim tok As Integer = Convert.ToInt32(token_field.Text)

                        'MessageBox.Show(Billingno_field.Text)
                        dtCustomers = ReadFromDatabase("insert into buyer_details ( product_id,quantity,total,date,month,bill_no,status,spr_no,token,time,order_time)select product_id,quantity,total,date='" + dates + "',month='" + months + "',bill_no='" + Billingno_field.Text + "',status='" + status + "',id,token_id,time='" + times + "',order_time from token where token_id ='" + tokenid.ToString() + "'")
                        token_field.Clear()
                        dtCustomers = ReadFromDatabase("delete from token where token_id='" + tokenid.ToString() + "'")

                        LoadDataInGrid()
                        renderFunction()
                        con.Close()

                        If balance_field.Text = 0 Then



                            If MessageBox.Show("Insufficent Balance", "Error") Then

                                clear_all_ordered_Click()
                                Id_scan_field.Focus()

                            End If

                        Else
                            item_field.Focus()
                            con.Close()

                        End If





                        Else
                End If


            Catch ex As Exception

                MessageBox.Show("No Data Present")
                Id_scan_field.Clear()
                Id_scan_field.Focus()
                token_field.Clear()


            End Try





        Catch ex As Exception
            MessageBox.Show("No Data Present Please Close")
            token_field.Clear()
        End Try

    End Sub

    Public Sub iprint()




        'print a document  
        Bill_no()
        LoadDataInGrid()
        transaction.DataSource = vbNull
        dtCustomers = ReadFromDatabase("alter view g_tot as select sum(total) as grand_tot from buyer_details where bill_no='" + bill_num + "'")
        clear_all_ordered_Click()
        pin_field.Clear()
        Id_scan_field.Focus()
        transdatagrid()
        '  grand_field.Text = "0"
        pin_field.Visible = False
        pin_lable.Visible = False
        quant_field.Text = "0"
        billing.Clear()



    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Autocomplete()
        dtCustomers = ReadFromDatabase("alter view g_tot as select sum(total) as grand_tot from buyer_details where bill_no='" + bill_num + "'")

        Bill_no()
        'bill_num = Billingno_field.Text
        'MessageBox.Show(bill_num)

        If spr_field.Text = "guest" Then
            LoadDataInGrid()
            pin_field.Visible = False
            pin_lable.Visible = False
            Me.KeyPreview = True
            sa = data_table
            bill_num = Billingno_field.Text
            g_tot = grand_field.Text
            grand_field.Text = g_tot

        Else
            If spr_field.Text = "1111" Then
                ord()
                LoadDataInGrid()
                pin_field.Visible = False
                pin_lable.Visible = False
                Me.KeyPreview = True
                sa = data_table
                bill_num = Billingno_field.Text
                g_tot = grand_field.Text
                grand_field.Text = g_tot

            Else
                LoadDataInGrid()
                transdatagrid()
                pin_field.Visible = False
                pin_lable.Visible = False
                Me.KeyPreview = True
                sa = data_table
                bill_num = Billingno_field.Text
                g_tot = grand_field.Text
                grand_field.Text = g_tot


            End If


        End If



    End Sub

    Dim WithEvents PD As New PrintDocument
    'Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = data_table.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 200
    End Sub


    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        renderFunction()
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        renderFunction()
        Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
        Dim stat As String = TimeOfDay.ToString("h:mm:ss tt")
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width
        Dim rightmarginforto As Integer = PD.DefaultPageSettings.Margins.Right
        Dim rightmarginforpr As Integer = PD.DefaultPageSettings.Margins.Right

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        Dim pr As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center
        pr.Alignment = StringAlignment.Near


        Dim line As String
        line = "--------------------------------------------------------------------------"
        Dim b As String
        b = billing.Text
        'range from top
        e.Graphics.DrawString("BITZ-N-BYTEZ", f14, Brushes.Black, centermargin, 5, center)

        e.Graphics.DrawString(DateTime.Now(), f8, Brushes.Black, 120, 60)


        e.Graphics.DrawString("BillNo", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 60)
        e.Graphics.DrawString(+b, f8, Brushes.Black, 70, 60)

        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString("Admin", f8, Brushes.Black, 70, 75)

        'e.Graphics.DrawString(DateTime.Now(), f8, Brushes.Black, 0, 90)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)

        Dim height As Integer 'DGV Position
        Dim i As Integer
        data_table.AllowUserToAddRows = False
        'If DataGridView1.CurrentCell.Value Is Nothing Then
        '    Exit Sub
        'Else
        For row As Integer = 0 To data_table.RowCount - 1
            height += 15
            e.Graphics.DrawString(data_table.Rows(row).Cells(3).Value.ToString, f10, Brushes.Black, 170, 100 + height)
            e.Graphics.DrawString(data_table.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, 25, 100 + height)
        Next
        'End If

        Dim height2 As Integer
        height2 = 110 + height
        sumprice() 'call sub
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 170, 10 + height2)
        e.Graphics.DrawString("Total:" + "" + grand_field.Text, f10b, Brushes.Black, 25, 10 + height2)
        e.Graphics.DrawString("~ Thanks for ordering ~", f10, Brushes.Black, centermargin, 35 + height2, center)
        'e.Graphics.DrawString("~ Nosware Store ~", f10, Brushes.Black, centermargin, 50 + height2, center)
    End Sub
    Dim t_price As Integer
    Dim t_qty As Integer
    Sub sumprice()
        Dim countprice As Integer = 0
        For rowitem As Integer = 0 To data_table.RowCount - 1
            countprice = countprice + Val(data_table.Rows(rowitem).Cells(4).Value * data_table.Rows(rowitem).Cells(1).Value)
        Next
        t_price = countprice

        Dim countqty As Integer = 0
        For rowitem As Integer = 0 To data_table.RowCount - 1
            countqty = countqty + data_table.Rows(rowitem).Cells(3).Value
        Next
        t_qty = countqty
    End Sub


    Public Sub clear_all_ordered_Click()
        spr_field.Clear()
        name_field.Clear()
        dp_field.Clear()
        year_field.Clear()
        item_field.Clear()
        pd_name.Clear()
        price_field.Clear()
        quant_field.Clear()
        total_field.Clear()
        type_field.Clear()
        grand_field.Clear()
        name_field.Clear()
        dp_field.Clear()
        year_field.Clear()
        item_field.Clear()
        pd_name.Clear()
        price_field.Clear()
        quant_field.Text = 1
        total_field.Clear()
        type_field.Clear()
        grand_field.Clear()
        Id_scan_field.Clear()
        balance_field.Clear()
    End Sub
    Public Sub clear_all_ordered_Clickguest()
        spr_field.Clear()
        name_field.Clear()
        dp_field.Clear()
        year_field.Clear()
        item_field.Clear()
        pd_name.Clear()
        price_field.Clear()
        quant_field.Clear()
        total_field.Clear()
        type_field.Clear()
        grand_field.Clear()
        name_field.Clear()
        dp_field.Clear()
        year_field.Clear()
        item_field.Clear()
        pd_name.Clear()
        price_field.Clear()
        quant_field.Text = 1
        total_field.Clear()
        type_field.Clear()
        grand_field.Clear()
        balance_field.Clear()
    End Sub
    Public Sub add_clear()
        item_field.Clear()
        pd_name.Clear()
        price_field.Clear()
        quant_field.Clear()
        total_field.Clear()
    End Sub
    Public Sub delete_clear()
        item_field.Clear()
        pd_name.Clear()
        price_field.Clear()
        total_field.Clear()
        quant_field.Clear()
        item_field.Clear()
        grand_field.Clear()
    End Sub
    Public Sub guest_check()
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)

        Dim status As String = "unordered"
        Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
        Dim m As String = DateTime.Now.ToString("MMMM")



        Dim cmd2 As SqlCommand = New SqlCommand("select buyer_details.product_id from buyer_details inner join items on buyer_details.product_id=items.product_id where buyer_details.bill_no='" + Billingno_field.Text + "' And items.shortcut_key='" + item_field.Text + "'", con)
        Try
            con.Open()
            Dim myreader2 As SqlDataReader
            myreader2 = cmd2.ExecuteReader
            If myreader2.HasRows Then
                If myreader2.Read() Then
                    con.Close()
                    MsgBox("" + pd_name.Text + " is already added")
                End If
            Else
                con.Close()
                con.Open()
                Dim cmd3 As SqlCommand = New SqlCommand("select product_id from items where shortcut_key='" + item_field.Text + "'", con)
                Dim myread3 As SqlDataReader
                myread3 = cmd3.ExecuteReader
                myread3.Read()
                Dim pro_id As String = myread3("product_id")
                con.Close()
                dtCustomers = ReadFromDatabase("Insert into Buyer_Details(spr_no,Bill_no,status,product_id,quantity,date,month,Total)values('" + spr_field.Text + "','" + Billingno_field.Text + "','" + status + "','" + pro_id + "','" + quant_field.Text + "','" + d + "','" + m + "','" + total_field.Text + "')")

            End If


            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("select Quantity from items where shortcut_key='" + item_field.Text + "'", con)
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Dim result = myreader("Quantity")
            con.Close()

            con.Open()
            Dim cmd1 As SqlCommand = New SqlCommand("select buyer_details.quantity from buyer_details inner join items on buyer_details.product_id=items.product_id where items.shortcut_key='" + item_field.Text + "'And buyer_details.bill_no='" + Billingno_field.Text + "'", con)
            Dim myreader1 As SqlDataReader
            myreader1 = cmd1.ExecuteReader
            If myreader1.HasRows Then
                myreader1.Read()
                Dim results = myreader1("quantity")
                con.Close()

                Dim a As Integer = Convert.ToInt32(result)
                Dim b As Integer = Convert.ToInt32(results)
                If (a < b) Then


                    MessageBox.Show("Item Out of Stocks", "Error")
                    dtCustomers = ReadFromDatabase("Delete from buyer_details  where ref_no=(select Max(ref_no) from buyer_details)")
                    quant_field.Focus()
                    quant_field.Clear()
                End If
                add_btn.Focus()
                item_field.Focus()
                LoadDataInGrid()
                renderFunction()
                add_clear()

            Else
                con.Close()
            End If



        Catch ex As Exception

            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click

        If spr_field.Text = "guest" Or spr_field.Text = "1111" Then
            guest_check()

        Else

            Dim con As SqlConnection = New SqlConnection(DBConnectionString)
            Try
                If (total_field.Text = 0) Then
                    MsgBox("Please Enter Valid fields")
                Else
                    If String.IsNullOrWhiteSpace(Id_scan_field.Text) Then

                        If MessageBox.Show("Please Fill the Fields", "Error") Then

                            Id_scan_field.Focus()

                        End If
                    Else
                        check()
                        If add_btn.Focus() Then
                            item_field.Focus()


                        End If

                        LoadDataInGrid()
                        renderFunction()
                        add_clear()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Re Type The Id ", "error")
                add_clear()
                item_field.Focus()
            End Try

        End If

    End Sub
    Public Sub renderFunction()
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        con.Open()
        Dim cmd1 As New SqlCommand("select sum(total) as tot From buyer_details where bill_no='" + Billingno_field.Text + "'", con)
        Dim myreader As SqlDataReader
        myreader = cmd1.ExecuteReader()
        myreader.Read()
        Try
            grand_field.Text = myreader("tot")

        Catch ex As Exception
            MessageBox.Show("grand Total Error")
        End Try
        con.Close()
    End Sub
    Public Sub check()
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        Dim tot As Integer = Convert.ToInt32(total_field.Text)
        Dim bal As Integer = Convert.ToInt32(balance_field.Text)
        Try
            If (tot > bal) Then
                MsgBox("Insufficient Balance")
            Else
                guest_check()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub transdatagrid()
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        Dim command1 As New SqlCommand("Select TOP 5 bill.Billing_No As Billno,buyer_details.Date, items.product_name As Productname, items.Price, buyer_details.Quantity , buyer_details.Total From Buyer_Details inner join items On items.product_id=buyer_details.product_id inner join bill on bill.bill_no=buyer_details.bill_no where Spr_No= '" + spr_field.Text + "' And buyer_details.Status='ordered'order by buyer_details.ref_no desc", con)
        Dim sda1 As New SqlDataAdapter(command1)
        Dim dt1 As New DataTable
        sda1.Fill(dt1)
        transaction.DataSource = dt1
        transaction.ClearSelection()

    End Sub
    Public Sub LoadDataInGrid()

        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        Dim command As New SqlCommand("select buyer_details.Ref_no As RefNo, items.Product_id As Productid,items.Product_name As Productname ,Buyer_details.Quantity,items.Price,Buyer_Details.Total from Buyer_Details inner join items on items.Product_Id = Buyer_Details.Product_Id where Buyer_Details.bill_no='" + Me.Billingno_field.Text + "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        data_table.DataSource = dt
        data_table.ClearSelection()

    End Sub

    Public Sub insert()
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        dtCustomers = ReadFromDatabase("Insert into bill(bill_no)values('" + Billingno_field.Text + "')")
        con.Open()
        Dim cmd1 As New SqlCommand("select billing_no from bill where bill_no ='" + Billingno_field.Text + "'", con)
        Dim myreader As SqlDataReader
        myreader = cmd1.ExecuteReader()
        myreader.Read()
        Try
            billing.Text = myreader("billing_no")

        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Public Sub guest_insert()
        Dim status = "Ordered"
        dtCustomers = ReadFromDatabase("update items set Quantity= items.quantity-Buyer_Details.quantity from items inner join Buyer_Details on items.Product_id=Buyer_Details.Product_Id where bill_no='" + Billingno_field.Text + "'")
        dtCustomers = ReadFromDatabase("update buyer_details set status = '" + status + "' where bill_no='" + Billingno_field.Text + "'")

    End Sub

    Public Sub app_insert()
        Dim status = "Ordered"
        dtCustomers = ReadFromDatabase("update items set Quantity= items.quantity-Buyer_Details.quantity from items inner join Buyer_Details on items.Product_id=Buyer_Details.Product_Id where bill_no='" + Billingno_field.Text + "'")
        dtCustomers = ReadFromDatabase("update buyer_details set status = '" + status + "' where bill_no='" + Billingno_field.Text + "'")
    End Sub


    Private Sub print_btn_Click(sender As Object, e As EventArgs) Handles print_btn.Click, MyBase.DoubleClick
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        If String.IsNullOrWhiteSpace(Id_scan_field.Text) And String.IsNullOrWhiteSpace(grand_field.Text) And grand_field.Text = 0 Then

            MessageBox.Show("Please Fill the All Fields", "ERROR")




        Else
            Try
                con.Open()
                Dim cmd7 As SqlCommand = New SqlCommand("select ref_no from buyer_details where bill_no='" + Billingno_field.Text + "'", con)
                Dim myread As SqlDataReader
                myread = cmd7.ExecuteReader
                If myread.HasRows Then
                    If myread.Read() Then
                        Dim bill As String
                        bill = myread("ref_no")
                        con.Close()


                        dtCustomers = ReadFromDatabase("ALTER view demo as select distinct items.product_name,items.product_id,items.quantity from items inner join Buyer_Details on items.Product_id=Buyer_Details.Product_Id where bill_no='" + Me.Billingno_field.Text + "'")
                        dtCustomers = ReadFromDatabase("ALTER view demo2 as select distinct buyer_details.product_id,buyer_details.quantity as user_quantity from buyer_details  inner join items on items.Product_id=Buyer_Details.Product_Id where Bill_No='" + Me.Billingno_field.Text + "'")


                        con.Open()
                        Dim cmd1 As SqlCommand = New SqlCommand("SELECT DEMO.PRODUCT_NAME FROM DEMO INNER JOIN DEMO2 ON DEMO.PRODUCT_ID=DEMO2.PRODUCT_ID WHERE DEMO2.USER_QUANTITY>DEMO.QUANTITY ", con)
                        Dim myreader1 As SqlDataReader
                        myreader1 = cmd1.ExecuteReader


                        If myreader1.HasRows Then
                            If myreader1.Read() Then
                                Dim p_name As String
                                p_name = myreader1("product_name")
                                MsgBox("" + p_name.ToString + " is out of stock")
                                con.Close()
                            End If

                        Else
                            con.Close()



                            con.Open()
                            Dim cmd2 As SqlCommand = New SqlCommand("select * from g_tot", con)
                            Dim myreader2 As SqlDataReader
                            myreader2 = cmd2.ExecuteReader
                            myreader2.Read()
                            Dim g_total = myreader2("grand_tot")
                            con.Close()
                            If (g_total.Equals(DBNull.Value)) Then
                                g_total = 0
                            Else


                            End If
                            If (spr_field.Text = "guest") Then

                                insert()
                                guest_insert()
                                changelongpaper()
                                PD.PrinterSettings = PrintDialog1.PrinterSettings
                                PD.Print()

                                Bill_no()
                                LoadDataInGrid()
                                transaction.DataSource = vbNull
                                MessageBox.Show("Your Order Successfull", "Info")
                                clear_all_ordered_Clickguest()
                                dtCustomers = ReadFromDatabase("alter view g_tot as select sum(total) as grand_tot from buyer_details where bill_no='" + bill_num + "'")

                                grand_field.Text = "0"
                                pin_field.Visible = False
                                pin_lable.Visible = False
                                'Billingno_field.Clear()
                                billing.Clear()
                                transdatagrid()

                                spr_field.Text = "guest"
                                quant_field.Text = ""
                                item_field.Focus()
                                'Bill_no()
                                bill_num = Billingno_field.Text




                            Else
                                If spr_field.Text = "1111" Then
                                    insert()
                                    guest_insert()
                                    changelongpaper()
                                    PD.PrinterSettings = PrintDialog1.PrinterSettings
                                    PD.Print()

                                    Bill_no()
                                    LoadDataInGrid()
                                    transaction.DataSource = vbNull
                                    MessageBox.Show("Your Order Successfull", "Info")
                                    clear_all_ordered_Click()
                                    dtCustomers = ReadFromDatabase("alter view g_tot as select sum(total) as grand_tot from buyer_details where bill_no='" + bill_num + "'")

                                    grand_field.Text = "0"
                                    pin_field.Visible = False
                                    pin_lable.Visible = False
                                    'Billingno_field.Clear()
                                    billing.Clear()
                                    transdatagrid()

                                    'spr_field.Text = "guest"
                                    quant_field.Text = ""
                                    item_field.Focus()
                                    'Bill_no()
                                    bill_num = Billingno_field.Text
                                    Me.Close()

                                Else
                                    con.Open()
                                    Dim cmd As SqlCommand = New SqlCommand("select balance from buyer where id='" + Id_scan_field.Text + "'", con)
                                    Dim myreader As SqlDataReader
                                    myreader = cmd.ExecuteReader
                                    myreader.Read()
                                    Dim result = myreader("balance")
                                    con.Close()
                                    Dim grand As Integer = Convert.ToInt32(grand_field.Text)
                                    Dim bal As Integer = Convert.ToInt32(result)

                                    If grand > bal Or grand_field.Text = 0 Then

                                        MessageBox.Show("Insufficient Balance", "Error")
                                    Else
                                        insert()
                                        pin_field.Visible = True
                                        pin_lable.Visible = True
                                        pin_field.Focus()
                                    End If
                                End If

                            End If
                        End If
                    End If
                Else
                    grand_field.Text = "0"
                    MsgBox("Please Add Items")
                End If





            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try


        End If




    End Sub


    Public Sub Bill_no()
        Dim numbers As String = "1234567890"

        Dim characters As String = numbers
        Dim length As Integer = 10
        Dim id As String = String.Empty
        For i As Integer = 0 To length - 1
            Dim character As String = String.Empty
            Do
                Dim index As Integer = New Random().Next(0, characters.Length)
                character = characters.ToCharArray()(index).ToString()
            Loop While id.IndexOf(character) <> -1
            id += character
        Next
        Billingno_field.Text = +id
    End Sub



    Private Sub item_field_KeyDown(sender As Object, e As KeyEventArgs) Handles item_field.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try



                If String.IsNullOrWhiteSpace(item_field.Text) Then

                    MessageBox.Show("Please Fill the Field")


                Else

                    dtCustomers = ReadFromDatabase("alter view g_tot as select sum(total) as grand_tot from buyer_details where bill_no='" + bill_num + "'")

                    Dim con As SqlConnection = New SqlConnection(DBConnectionString)
                    con.Open()



                    Dim cmd As SqlCommand = New SqlCommand("select product_id,product_name,price,Quantity,shortcut_key from items where shortcut_key='" + item_field.Text + "'", con)
                    Dim myreader As SqlDataReader
                    myreader = cmd.ExecuteReader
                    myreader.Read()


                    Dim result = myreader("Quantity")
                    pd_name.Text = myreader("product_name")

                    price_field.Text = myreader("price")

                    quant_field.Text = 1
                    quant_field.Focus()

                    If result = 0 Then
                        con.Close()
                        MessageBox.Show("Item Out of Stocks", "Error")
                        item_field.Clear()
                        quant_field.Clear()
                        price_field.Clear()
                        pd_name.Clear()
                        total_field.Clear()
                        item_field.Focus()

                    End If

                End If
            Catch ex As Exception


                item_field.Clear()
                MessageBox.Show("Item Not Found", "Error")
                item_field.Focus()

            End Try
            con.Close()
            con.Open()

        Else

            Exit Sub

        End If

        e.SuppressKeyPress = True
    End Sub


    Private Sub quant_field_KeyDown(sender As Object, e As KeyEventArgs) Handles quant_field.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim ase As Integer
            Dim StringToInteger1 As Integer = Convert.ToInt32(quant_field.Text)
            ase = 1
            Dim checke As String = ase * StringToInteger1

            If String.IsNullOrWhiteSpace(Id_scan_field.Text) Or String.IsNullOrWhiteSpace(quant_field.Text) Or checke = "0" Then


                If MessageBox.Show("Please Fill All Fields", "Error") Then

                    Id_scan_field.Focus()


                End If


            Else
                add_btn.PerformClick()
                data_table.ClearSelection()

            End If

        Else

            Exit Sub

        End If

        e.SuppressKeyPress = True
    End Sub


    Private Sub Sales_page_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.F3
                print_btn.PerformClick()
        End Select

        Select Case e.KeyCode
            Case Keys.F2
                item_field.Focus()
                item_field.ReadOnly = False
        End Select

        Select Case e.KeyCode
            Case Keys.F1
                Id_scan_field.Focus()
        End Select

        Select Case e.Alt And e.KeyCode

            Case Keys.F4

                Me.Close()

        End Select

        Select Case e.Alt And e.KeyCode

            Case Keys.F5

                item_field.ReadOnly = False
                item_field.Clear()
                price_field.Clear()
                total_field.Clear()
                quant_field.Clear()
                pd_name.Clear()
                item_field.Focus()
        End Select
        Select Case e.Alt And e.KeyCode

            Case Keys.F7

                quant_field.Focus()

        End Select


        Select Case e.Alt And e.KeyCode

            Case Keys.F9

                add_btn.PerformClick()

        End Select

        Select Case e.Alt And e.KeyCode

            Case Keys.F11
                clear_all_ordered_Click()
                Bill_no()
                LoadDataInGrid()
                Id_scan_field.Focus()



        End Select

    End Sub


    Private Sub Id_field_KeyDown(sender As Object, e As KeyEventArgs) Handles Id_scan_field.KeyDown




        If e.KeyCode = Keys.Enter Then


            If Id_scan_field.Text = "" Then

                MessageBox.Show("Please scan here", "Error")

                Id_scan_field.Focus()


            Else
                Dim con As SqlConnection = New SqlConnection(DBConnectionString)
                con.Open()
                Dim checkid As SqlCommand = New SqlCommand("select id from buyer where id='" + Id_scan_field.Text + "'", con)
                Dim checkreader As SqlDataReader
                checkreader = checkid.ExecuteReader
                checkreader.Read()



                Try

                    If Id_scan_field.Text.Equals(checkreader("id")) Then

                        con.Close()

                        con.Open()
                            Dim cmd As SqlCommand = New SqlCommand("select spr_no,name,department,year,type,balance from buyer where id='" + Id_scan_field.Text + "'", con)
                            Dim myreader As SqlDataReader
                            myreader = cmd.ExecuteReader
                            myreader.Read()
                            spr_field.Text = myreader("spr_no")
                            name_field.Text = myreader("name")
                            type_field.Text = myreader("type")
                            dp_field.Text = myreader("department")
                            year_field.Text = myreader("year")
                            type_field.Text = myreader("type")
                            balance_field.Text = myreader("balance")
                            transdatagrid()

                            If balance_field.Text = 0 Then



                                If MessageBox.Show("Insufficent Balance", "Error") Then

                                    clear_all_ordered_Click()
                                    Id_scan_field.Focus()

                                End If

                            Else
                                item_field.Focus()
                                con.Close()

                            End If





                    Else
                    End If


                Catch ex As Exception

                    MessageBox.Show("Invalid ID", "Error")
                    Id_scan_field.Clear()
                    Id_scan_field.Focus()

                End Try




            End If


        Else

            Exit Sub

        End If

        e.SuppressKeyPress = True


    End Sub





    Private Sub quant_field_TextChanged(sender As Object, e As EventArgs) Handles quant_field.TextChanged
        If String.IsNullOrWhiteSpace(quant_field.Text) Then
            total_field.Clear()
        Else
            Dim quantity = quant_field.Text
            Dim price = price_field.Text
            Try
                Dim StringToInteger As Integer = Convert.ToInt32(price)
                Dim StringToInteger1 As Integer = Convert.ToInt32(quantity)

                Dim tot As String

                tot = StringToInteger * StringToInteger1

                total_field.Text = tot
                LoadDataInGrid()
            Catch ex As Exception
            End Try
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        clear_all_ordered_Click()
        add_clear()
        delete_clear()
        transdatagrid()
        Bill_no()
        Id_scan_field.Focus()
        LoadDataInGrid()
        pin_field.Visible = False
        pin_lable.Visible = False
    End Sub


    Private Sub pin_field_KeyDown(sender As Object, e As KeyEventArgs) Handles pin_field.KeyDown
        Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
        Dim t As String = DateTime.Now.ToString("MMMM")
        Dim stat As String = TimeOfDay.ToString("h:mm:ss tt")
        Try

            If e.KeyCode = Keys.Enter Then


                If String.IsNullOrWhiteSpace(pin_field.Text) And grand_field.Text = "0" Then

                    If MessageBox.Show("Please Fill All Fields", "Error") Then

                        pin_field.Focus()

                    End If

                Else

                    Dim con As New SqlConnection(DBConnectionString)
                    con.Open()
                    Dim cmd As New SqlCommand("select pin from buyer where spr_no='" + spr_field.Text + "'", con)
                    Dim myreader1 As SqlDataReader
                    myreader1 = cmd.ExecuteReader
                    myreader1.Read()
                    Dim result1 = myreader1("pin")

                    Dim bytes As Byte()
                    Dim decrypted As String
                    Try
                        bytes = Convert.FromBase64String(result1)
                        decrypted = System.Text.ASCIIEncoding.ASCII.GetString(bytes)
                    Catch fe As FormatException
                        decrypted = ""

                    End Try

                    Dim result

                    result = spr_field.Text + pin_field.Text

                    con.Close()

                    If (decrypted.Equals(result)) Then

                        con.Open()

                        Dim StringToInteger As Integer = Convert.ToInt32(balance_field.Text)
                            Dim StringToInteger1 As Integer = Convert.ToInt32(grand_field.Text)
                            Dim tot As String

                            tot = StringToInteger - StringToInteger1
                            Dim status As String = "Ordered"
                            dtCustomers = ReadFromDatabase("update items set Quantity= items.quantity-Buyer_Details.quantity from items inner join Buyer_Details on items.Product_id=Buyer_Details.Product_Id where bill_no='" + Billingno_field.Text + "'")
                            dtCustomers = ReadFromDatabase("update buyer set balance=" + tot.ToString + "where Spr_no=" + spr_field.Text + "")
                            dtCustomers = ReadFromDatabase("update buyer_details set status = '" + status + "' where bill_no='" + Billingno_field.Text + "'")
                            con.Close()


                        changelongpaper()
                        PD.PrinterSettings = PrintDialog1.PrinterSettings
                        PD.Print()
                        MessageBox.Show("" + name_field.Text + " Your Order Successfully", "Info")


                        con.Open()
                        Dim cmd4 As New SqlCommand("select email from buyer where spr_no='" + spr_field.Text + "'", con)
                        Dim myreader4 As SqlDataReader
                        myreader4 = cmd4.ExecuteReader
                        myreader4.Read()
                        Dim result4 As String = myreader4("email")
                        con.Close()

                        'emailsend(result4)
                        dtCustomers = ReadFromDatabase("insert into email_log (email,status,date,time)values('" + result4 + "','" + stat + "','" + d + "','" + t + "')")
                        dtCustomers = ReadFromDatabase("alter view g_tot as select sum(total) as grand_tot from buyer_details where bill_no='" + bill_num + "'")

                        clear_all_ordered_Click()
                        Bill_no()
                        LoadDataInGrid()
                        pin_field.Clear()
                        bill_num = Billingno_field.Text
                        Id_scan_field.Focus()
                        transdatagrid()
                        grand_field.Text = "0"
                        pin_field.Visible = False
                        pin_lable.Visible = False
                        billing.Clear()
                        quant_field.Text = ""

                    Else

                        If MessageBox.Show("INVALID PIN", "ERROR") Then
                            pin_field.Clear()
                        End If
                    End If

                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub data_table_GotFocus(sender As Object, e As EventArgs) Handles data_table.GotFocus
        Dim con As New SqlConnection(DBConnectionString)
        con.Open()
        Dim cmd2 As SqlCommand = New SqlCommand("select * from g_tot", con)
        Dim myreader2 As SqlDataReader
        myreader2 = cmd2.ExecuteReader
        Try

            If myreader2.HasRows Then
                myreader2.Read()
                Dim g_total = myreader2("grand_tot")
                con.Close()
                grand_field.Text = g_total
                data_table.Focus()
                data_table.ClearSelection()
            Else

                con.Close()

            End If

        Catch ex As Exception
            Return
            MsgBox("")
        End Try
    End Sub
    Private Sub check_btn_Click(sender As Object, e As EventArgs)
        Dim frm2 As New code
        frm2.Show()
        frm2.MdiParent = admin_panel_one

    End Sub

    Private Sub item_field_GotFocus(sender As Object, e As EventArgs) Handles item_field.GotFocus
        pin_field.Visible = False
        pin_lable.Visible = False

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm2 As New code
        frm2.Show()
        frm2.MdiParent = admin_panel_one
    End Sub
    Public Function emailsend(email As String)

        Dim p_name As String
        Dim quantity As String
        Dim price As String
        Dim total As String


        Dim mail As New MailMessage
        For i = 0 To data_table.RowCount - 1
            If Not (data_table.Rows(i).Cells("Ref_no").Value = 0) Then
                p_name = data_table.Rows(i).Cells("Product_name").Value
                quantity = data_table.Rows(i).Cells("Quantity").Value
                price = data_table.Rows(i).Cells("Price").Value
                total = data_table.Rows(i).Cells("Total").Value



                Using writer As New StreamWriter("../../../samu.txt", True)
                    writer.WriteLine("product name:" + p_name + "    Quantity:" + quantity + "      Price:" + price + "       Total:" + total + " ")

                    writer.Close()

                End Using

                Dim reader As StreamReader = New StreamReader("../../../samu.txt")
                Dim txt As String = reader.ReadToEnd()
                reader.Close()
                mail.Body = (txt)




            End If
        Next
        Dim gtotal As String = grand_field.Text
        mail.Subject = "Transactions of mzcet canteen"
        mail.To.Add(email)
        mail.From = New MailAddress(smtp_user_email)
        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential(smtp_user_email, smtp_user_passsword)
        smtp.Port = "587"
        smtp.Send(mail)
        System.IO.File.Delete("../../../samu.txt")

    End Function

    Private Sub quant_field_GotFocus(sender As Object, e As EventArgs) Handles quant_field.GotFocus
        Try
            Dim price As Integer = Convert.ToInt32(price_field.Text)
            Dim res = 1 * price
            total_field.Text = res
        Catch ex As Exception
            MessageBox.Show("server timeout")
        End Try

    End Sub



    Private Sub data_table_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_table.CellContentClick
        ref_f = data_table.CurrentRow.Cells(0).Value.ToString
        item_f = data_table.CurrentRow.Cells(1).Value.ToString
        pd_name_f = data_table.CurrentRow.Cells(2).Value.ToString
        quant_f = data_table.CurrentRow.Cells(3).Value.ToString
        price_f = data_table.CurrentRow.Cells(4).Value.ToString
        total_f = data_table.CurrentRow.Cells(5).Value.ToString
        data_table.ClearSelection()
        pin_field.Visible = False
        pin_lable.Visible = False
        reff = ref_f
        Dim frm2 As New update_bill
        frm2.Show()
        frm2.MdiParent = admin_panel_one
    End Sub

    Private Sub token_field_KeyDown(sender As Object, e As KeyEventArgs) Handles token_field.KeyDown

        Try
            Dim dates As String = DateTime.Now.ToString("dd-MM-yyyy")
            Dim months As String = DateTime.Now.ToString("MMMM")
            Dim times As String = TimeOfDay.ToString("h:mm:ss tt")
            Dim status As String = "unordered"

            If e.KeyCode = Keys.Enter Then


                If spr_field.Text = "" Then

                    MessageBox.Show("Please Fill the Field ", "Error")

                    token_field.Focus()


                Else

                    Dim tokkk As Integer = Convert.ToInt32(token_field.Text)

                    Dim con As SqlConnection = New SqlConnection(DBConnectionString)
                    con.Open()
                    Dim checkid As SqlCommand = New SqlCommand("select token_id from token where token_id='" + tokkk.ToString() + "'", con)

                    Dim checkreader As SqlDataReader
                    checkreader = checkid.ExecuteReader
                    checkreader.Read()
                    Dim toks As String = checkreader("token_id")



                    Try

                        If token_field.Text = (checkreader("token_id")) Then

                            con.Close()
                            Try

                                Dim tokk As Integer = Convert.ToInt32(token_field.Text)

                                con.Open()
                                Dim cmd As SqlCommand = New SqlCommand("select buyer.id as id,buyer.spr_no as spr_no,buyer.name as name,buyer.department as department ,buyer.year as year,buyer.type as type, buyer.balance as balance from buyer inner join token on buyer.spr_no=token.id where token.token_id='" + tokk.ToString() + "'", con)
                                Dim myreader As SqlDataReader
                                myreader = cmd.ExecuteReader
                                myreader.Read()
                                Id_scan_field.Text = myreader("id")
                                spr_field.Text = myreader("spr_no")
                                name_field.Text = myreader("name")
                                type_field.Text = myreader("type")
                                dp_field.Text = myreader("department")
                                year_field.Text = myreader("year")
                                type_field.Text = myreader("type")
                                balance_field.Text = myreader("balance")
                                Dim saro As String = myreader("id")
                                'MessageBox.Show(saro)
                                transdatagrid()

                                con.Close()
                                con.Open()
                                Dim tok As Integer = Convert.ToInt32(token_field.Text)

                                'MessageBox.Show(bill_num)
                                dtCustomers = ReadFromDatabase("insert into buyer_details ( product_id,quantity,total,date,month,bill_no,status,spr_no,token,time,order_time)select product_id,quantity,total,date='" + dates + "',month='" + times + "',bill_no='" + bill_num + "',status='" + status + "',id,token_id,time='" + times + "',order_time from token where token_id ='" + tokk.ToString() + "'")
                                token_field.Clear()
                                LoadDataInGrid()
                                renderFunction()
                                con.Close()

                                If balance_field.Text = 0 Then



                                    If MessageBox.Show("Insufficent Balance", "Error") Then

                                        clear_all_ordered_Click()
                                        Id_scan_field.Focus()

                                    End If

                                Else
                                    item_field.Focus()
                                    con.Close()

                                End If



                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try

                        Else
                        End If


                    Catch ex As Exception

                        MessageBox.Show("Invalid ID", "Error")
                        Id_scan_field.Clear()
                        Id_scan_field.Focus()
                        token_field.Clear()


                    End Try




                End If


            Else

                Exit Sub

            End If

            e.SuppressKeyPress = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            token_field.Clear()
        End Try


    End Sub

    Private Sub item_field_TextChanged(sender As Object, e As EventArgs) Handles item_field.TextChanged

    End Sub

    Private Sub pin_field_TextChanged(sender As Object, e As EventArgs) Handles pin_field.TextChanged

    End Sub
End Class






