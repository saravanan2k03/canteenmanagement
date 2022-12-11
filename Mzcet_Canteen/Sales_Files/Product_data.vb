

Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Product_data



    Private Sub Product_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtCustomers = ReadFromDatabase("SELECT * FROM items")
        DataGridView1.DataSource = dtCustomers
        DataGrid1 = DataGridView1
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim temp As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1

                If CStr(DataGridView1.Rows(i).Cells(j).Value) = search_1.Text Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(j)
                    MsgBox("Item found")
                    temp = 1
                End If

            Next
        Next
        If temp = 0 Then
            MsgBox("Item not found")
        End If
    End Sub





    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        product_id_data = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        product_name_data = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        product_quantity_data = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        product_price_data = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        shortkey = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        Dim frm2 As New Update_Product
        frm2.Show()
        frm2.MdiParent = admin_panel_one


    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm2 As New add_product
        frm2.Show()
        frm2.MdiParent = admin_panel_one

    End Sub



    Private Sub search_1_TextChanged(sender As Object, e As EventArgs) Handles search_1.TextChanged
        dtCustomers = ReadFromDatabase("select * from items where Product_Name Like '" & search_1.Text & "'+'%' ")
        DataGridView1.DataSource = dtCustomers
    End Sub

    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Import.Click
        CSVLoadForProduct(DataGridView1)
    End Sub

    Private Sub refresh_button_Click(sender As Object, e As EventArgs)
        dtCustomers = ReadFromDatabase("SELECT * FROM items")
        DataGridView1.DataSource = dtCustomers
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Delete_product_data()
    End Sub

    Public Function Delete_product_data()
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim ref_no As String
            ref_no = DataGridView1.SelectedRows(i).Cells(0).Value.ToString()

            ReadFromDatabase("delete from items where Product_id='" & ref_no & "'")

        Next
        dtCustomers = ReadFromDatabase("SELECT * FROM items")
        DataGridView1.DataSource = dtCustomers
        MessageBox.Show(database_query_status)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
            'Creating iTextSharp Table from the DataTable data
            Dim pdfTable As New PdfPTable(DataGridView1.ColumnCount)
            pdfTable.DefaultCell.Padding = 3
            pdfTable.WidthPercentage = 70
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
            pdfTable.DefaultCell.BorderWidth = 1

            'Adding Header row
            For Each column As DataGridViewColumn In DataGridView1.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
                pdfTable.AddCell(cell)
            Next

            'Adding DataRow
            Dim cellvalue As String = ""
            Dim i As Integer = 0
            For Each row As DataGridViewRow In DataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    cellvalue = cell.FormattedValue
                    pdfTable.AddCell(Convert.ToString(cellvalue))
                Next
            Next

            Dim folderPath As String = "C:\stocks_log\"
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
            Using stream As New FileStream(folderPath & d + "stocks.pdf", FileMode.Create)
                Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
                PdfWriter.GetInstance(pdfDoc, stream)
                pdfDoc.Open()
                pdfDoc.Add(pdfTable)
                pdfDoc.Close()
                stream.Close()
                MessageBox.Show("pdf created successfully", "info")
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class