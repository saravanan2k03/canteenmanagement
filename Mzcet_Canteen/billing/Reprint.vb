Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Reprint
    Private Sub Reprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bill_enter.Focus()
    End Sub

    Public Sub bill_enter_KeyDown(sender As Object, e As KeyEventArgs) Handles bill_enter.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If bill_enter.Text = 0 And bill_enter.Text = "" Then
                    MessageBox.Show("Please Enter Field")
                Else
                    LoadDataInGrid()
                    renderFunction()
                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try



    End Sub
    Public Sub renderFunction()
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        con.Open()
        Dim cmd1 As New SqlCommand("select sum(total) as tot From buyer_details inner join bill on buyer_details.bill_no = bill.bill_no where bill.billing_no='" + bill_enter.Text + "'", con)
        Dim myreader As SqlDataReader
        myreader = cmd1.ExecuteReader()
        myreader.Read()
        Try
            grand_field.Text = myreader("tot")

        Catch ex As Exception
            'MessageBox.Show("grand Total Error")
        End Try
        con.Close()
    End Sub
    Public Sub LoadDataInGrid()

        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        Dim command As New SqlCommand("select buyer_details.Ref_no As RefNo, items.Product_id As Productid,items.Product_name As Productname ,Buyer_details.Quantity,items.Price,Buyer_Details.Total from Buyer_Details inner join items on items.Product_Id = Buyer_Details.Product_Id inner join bill on buyer_details.bill_no = bill.bill_no where bill.billing_no='" + bill_enter.Text + "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        bill_data.DataSource = dt
        bill_data.ClearSelection()

    End Sub
    Dim WithEvents PD As New PrintDocument
    'Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = bill_data.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 200
    End Sub


    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint

        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage

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
        b = bill_enter.Text
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
        bill_data.AllowUserToAddRows = False
        'If bill_data.CurrentCell.Value Is Nothing Then
        '    Exit Sub
        'Else
        For row As Integer = 0 To bill_data.RowCount - 1
                height += 15
                e.Graphics.DrawString(bill_data.Rows(row).Cells(3).Value.ToString, f10, Brushes.Black, 170, 100 + height)
                e.Graphics.DrawString(bill_data.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, 25, 100 + height)
            Next
        'End If

        Dim height2 As Integer
        height2 = 110 + height
        sumprice() 'call sub
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 170, 10 + height2)
        e.Graphics.DrawString("Total:" + "" + grand_field.Text, f10b, Brushes.Black, 25, 10 + height2)
        e.Graphics.DrawString("~ Thanks for ordering ~", f10, Brushes.Black, centermargin, 35 + height2, center)
    End Sub
    Dim t_price As Integer
    Dim t_qty As Integer
    Sub sumprice()
        Dim countprice As Integer = 0
        For rowitem As Integer = 0 To bill_data.RowCount - 1
            countprice = countprice + Val(bill_data.Rows(rowitem).Cells(4).Value * bill_data.Rows(rowitem).Cells(1).Value)
        Next
        t_price = countprice

        Dim countqty As Integer = 0
        For rowitem As Integer = 0 To bill_data.RowCount - 1
            countqty = countqty + bill_data.Rows(rowitem).Cells(3).Value
        Next
        t_qty = countqty
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        changelongpaper()
        PD.PrinterSettings = PrintDialog1.PrinterSettings
        PD.Print()
        MessageBox.Show("Your Order Sucessfully")
        bill_enter.Clear()
        grand_field.Clear()
        LoadDataInGrid()
        renderFunction()
    End Sub
End Class