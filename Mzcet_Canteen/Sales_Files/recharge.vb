Imports System.Data.SqlClient
Imports System.Net

Imports System.Configuration
Imports System.IO
Imports CsvHelper
Imports FxResources.System.Configuration

Imports System.Data
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.DirectoryServices.AccountManagement
Imports System.DirectoryServices
Imports System.Net.Mail

Public Class recharge
    Private Sub recharge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
        dtCustomers = ReadFromDatabase("SELECT recharge_log.Sno,buyer.id,recharge_log.spr_no,buyer.name,recharge_log.balance,recharge_log.Recharge,recharge_log.date,recharge_log.month FROM recharge_log inner join buyer on recharge_log.spr_no=buyer.spr_no where date='" + d + "'")
        rc_table.DataSource = dtCustomers
        rc_table.ClearSelection()
        id_rc.Focus()

    End Sub

    Private Sub id_rc_KeyDown(sender As Object, e As KeyEventArgs) Handles id_rc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If id_rc.Text = "" Then
                MessageBox.Show("Please scan here", "Error")
                id_rc.Focus()
            Else
                Dim con As SqlConnection = New SqlConnection(DBConnectionString)
                con.Open()
                Dim checkid As SqlCommand = New SqlCommand("select id from buyer where id='" + id_rc.Text + "'", con)
                Dim checkreader As SqlDataReader
                checkreader = checkid.ExecuteReader
                checkreader.Read()
                Try
                    If id_rc.Text.Equals(checkreader("id")) Then
                        con.Close()

                        Try
                            con.Open()
                            Dim cmd As SqlCommand = New SqlCommand("select spr_no,name,balance from buyer where id='" + id_rc.Text + "'", con)
                            Dim myreader As SqlDataReader
                            myreader = cmd.ExecuteReader
                            myreader.Read()
                            spr_rc.Text = myreader("spr_no")
                            name_rc.Text = myreader("name")
                            balance_rc.Text = myreader("balance")
                            rc.Focus()


                        Catch ex As Exception

                        End Try
                    End If


                Catch ex As Exception
                    MessageBox.Show("Invalid ID", "Error")
                    id_rc.Clear()
                    id_rc.Focus()
                End Try
            End If
        End If
    End Sub

    Private Sub sub_rc_Click(sender As Object, e As EventArgs) Handles sub_rc.Click
        Try
            Dim StringToInteger As Integer = Convert.ToInt32(balance_rc.Text)
            Dim StringToInteger1 As Integer = Convert.ToInt32(rc.Text)
            Dim tot As String

            tot = StringToInteger + StringToInteger1
            dtCustomers = ReadFromDatabase("update buyer set balance=" + tot.ToString + "where Spr_no=" + spr_rc.Text + "")
            insert()
            MessageBox.Show("Recharge Successfully", "info")
            id_rc.Clear()
            spr_rc.Clear()
            name_rc.Clear()
            balance_rc.Clear()
            rc.Clear()
            id_rc.Focus()
        Catch ex As Exception
            MessageBox.Show("Please Fill The Field", "Error")
            rc.Focus()
        End Try

    End Sub

    Public Sub insert()
        Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
        Dim m As String = DateTime.Now.ToString("MMMM")
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        dtCustomers = ReadFromDatabase("Insert into recharge_log(spr_no,Balance,Recharge,date,month)values('" + spr_rc.Text + "','" + balance_rc.Text + "','" + rc.Text + "','" + d + "','" + m + "')")
        dtCustomers = ReadFromDatabase("SELECT recharge_log.Sno,buyer.id,recharge_log.spr_no,buyer.name,recharge_log.balance,recharge_log.Recharge,recharge_log.date,recharge_log.month FROM recharge_log inner join buyer on recharge_log.spr_no=buyer.spr_no where date='" & d & "'")
        rc_table.DataSource = dtCustomers
        rc_table.ClearSelection()
    End Sub


    Private Sub rc_KeyDown(sender As Object, e As KeyEventArgs) Handles rc.KeyDown
        If e.KeyCode = Keys.Enter Then

            If rc.Text = "" Then

                MessageBox.Show("Please Fill The Field", "Error")
                rc.Focus()
            Else
                sub_rc.PerformClick()
            End If
        End If
    End Sub

    Private Sub print_rc_Click(sender As Object, e As EventArgs) Handles print_rc.Click
        Try
            Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
            'Creating iTextSharp Table from the DataTable data
            Dim pdfTable As New PdfPTable(rc_table.ColumnCount)
            pdfTable.DefaultCell.Padding = 3
            pdfTable.WidthPercentage = 70
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
            pdfTable.DefaultCell.BorderWidth = 1

            'Adding Header row
            For Each column As DataGridViewColumn In rc_table.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
                pdfTable.AddCell(cell)
            Next

            'Adding DataRow
            Dim cellvalue As String = ""
            Dim i As Integer = 0
            For Each row As DataGridViewRow In rc_table.Rows
                For Each cell As DataGridViewCell In row.Cells
                    cellvalue = cell.FormattedValue
                    pdfTable.AddCell(Convert.ToString(cellvalue))
                Next
            Next

            Dim folderPath As String = "C:\recharge_log\"
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
            Using stream As New FileStream(folderPath & "recharge.pdf", FileMode.Create)
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



    Private Sub today_btn_Click(sender As Object, e As EventArgs) Handles today_btn.Click
        Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
        dtCustomers = ReadFromDatabase("SELECT recharge_log.Sno,buyer.id,recharge_log.spr_no,buyer.name,recharge_log.balance,recharge_log.Recharge,recharge_log.date,recharge_log.month FROM recharge_log inner join buyer on recharge_log.spr_no=buyer.spr_no where date='" + d + "'")
        rc_table.DataSource = dtCustomers
        rc_table.ClearSelection()
        DatePicker.ResetText()
        DateTime1.ResetText()

    End Sub




    Private Sub getdata_Click(sender As Object, e As EventArgs) Handles getdata.Click
        dtCustomers = ReadFromDatabase("SELECT recharge_log.Sno,buyer.id,recharge_log.spr_no,buyer.name,recharge_log.balance,recharge_log.Recharge,recharge_log.date,recharge_log.month FROM recharge_log inner join buyer on recharge_log.spr_no=buyer.spr_no  where date Between'" & DatePicker.Value.Date.ToString("dd-MM-yyyy") & "'And '" & DateTime1.Value.ToString("dd-MM-yyyy") & "'")
        rc_table.DataSource = dtCustomers
        rc_table.ClearSelection()
    End Sub

    Private Sub rc_table_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles rc_table.CellContentClick

    End Sub
End Class