Imports System.Net

Imports System.Configuration
Imports System.Data.SqlClient
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
Imports System.Runtime.InteropServices

Module AllFiles



    Public current_user As String
    Public Email_status As String
    Dim encrypted As String = ""

    Public Function Login(ByVal username As String, ByVal password As String)
        '10.201.133.133
        Dim check As String = "10.201.133.133"
        Try

            If My.Computer.Network.Ping(check) Then



                dtCustomers = ReadFromDatabase("SELECT * from admin_data where username='" & username & "' and password='" & password & "'")

                If dtCustomers.Rows.Count > 0 Then
                    If dtCustomers.Rows(0).Item("role") = "1" Then
                        current_user = 1
                        admin_panel_one.Show()
                        Login_Page.Close()
                        IpFinder(username)

                    ElseIf dtCustomers.Rows(0).Item("role") = "2" Then
                        current_user = 2
                        admin_panel_one.Show()
                        Login_Page.Close()
                        IpFinder(username)


                    Else

                        MsgBox("Not Allowed")

                    End If
                Else
                    MsgBox("InValid User")

                End If

            End If

        Catch ex As Exception
            MsgBox("No Internet Connection")
        End Try



    End Function


    Public Function IpFinder(ByVal username As String)
        Dim myHost As String = Dns.GetHostName
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(myHost)
        Dim ip As String = ""
        Dim dt As Date = Today

        For Each tmpIpAddress As IPAddress In ipEntry.AddressList
            If tmpIpAddress.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                Dim ipAddress As String = tmpIpAddress.ToString
                ip = ipAddress
                Exit For
            End If
        Next

        ReadFromDatabase("INSERT INTO log_data (username,ip_address,date,time,Changes)VALUES('" & username & "','" & ip & "','" & dt & "','" & Now.ToLongTimeString & "','" & username & "')")

    End Function



    Public Function LoadLogs()
        dtCustomers = ReadFromDatabase("select * from log_data order by id")
    End Function


    Public Function CSVLoadForProduct(dataGridView1 As DataGridView)

        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "CSV files(*.csv)|*.csv"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName

            Dim dt As New DataTable()
            dt.Columns.AddRange(New DataColumn(4) {
                                New DataColumn("Product_id", GetType(String)),
                                New DataColumn("Product_Name", GetType(String)),
                                New DataColumn("Price", GetType(String)),
                                New DataColumn("Quantity", GetType(String)),
                                New DataColumn("Date", GetType(String))
            })

            Dim csvData As String = File.ReadAllText(strFileName)
            For Each row As String In csvData.Split(ControlChars.Lf)
                If Not String.IsNullOrEmpty(row) Then
                    dt.Rows.Add()
                    Dim i As Integer = 0
                    For Each cell As String In row.Split(","c)
                        dt.Rows(dt.Rows.Count - 1)(i) = cell
                        i += 1
                    Next
                End If
            Next


            Using con As New SqlConnection(DBConnectionString)
                Using sqlBulkCopy As New SqlBulkCopy(con)
                    'Set the database table name.
                    sqlBulkCopy.DestinationTableName = "dbo.items"
                    con.Open()
                    sqlBulkCopy.WriteToServer(dt)
                    con.Close()
                End Using
            End Using
            MsgBox("Database Has Been Added Successfully")



        End If


    End Function


    Public Function CSVLoadForStudent(dataGridView1 As DataGridView)

        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "CSV files(*.csv)|*.csv"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName

            Try

                Dim dt As New DataTable()
                dt.Columns.AddRange(New DataColumn(8) {
                                    New DataColumn("Spr_No", GetType(String)),
                                    New DataColumn("Name", GetType(String)),
                                    New DataColumn("Department", GetType(String)),
                                    New DataColumn("Year", GetType(String)),
                                    New DataColumn("Type", GetType(String)),
                                    New DataColumn("balance", GetType(String)),
                                    New DataColumn("Pin", GetType(String)),
                                    New DataColumn("id", GetType(String)),
                                    New DataColumn("email", GetType(String))
                                    })

                Dim csvData As String = File.ReadAllText(strFileName)
                For Each row As String In csvData.Split(ControlChars.Lf)
                    If Not String.IsNullOrEmpty(row) Then
                        dt.Rows.Add()
                        Dim i As Integer = 0
                        For Each cell As String In row.Split(","c)
                            dt.Rows(dt.Rows.Count - 1)(i) = cell
                            i += 1
                        Next
                    End If
                Next


                Using con As New SqlConnection(DBConnectionString)
                    Using sqlBulkCopy As New SqlBulkCopy(con)
                        'Set the database table name.
                        sqlBulkCopy.DestinationTableName = "dbo.buyer"
                        con.Open()
                        sqlBulkCopy.WriteToServer(dt)
                        con.Close()
                    End Using
                    MsgBox("Database Has Been Added Successfully")
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Function


    Public Function SendEmailToReset(vemail As String, vspr_no As String)




        Try

            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(smtp_user_email, smtp_user_passsword)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(smtp_user_email)
            e_mail.To.Add(vemail)

            Dim s As String = "0123456789"
            Dim r As New Random
            Const passwordLength As Integer = 4
            Dim passwordChars() As Char = New Char(passwordLength - 1) {}
            Dim charIndex As Integer

            For i As Integer = 0 To passwordLength - 1
                charIndex = r.Next(s.Length)
                passwordChars(i) = s(charIndex)
            Next

            Dim password As New String(passwordChars)
            Dim EncryptPassword As String

            EncryptPassword = vspr_no + password


            EncryptString(EncryptPassword, vspr_no)

            e_mail.Subject = "Your Password has been changed Successfully!. Kindly, Use this Password"
            e_mail.IsBodyHtml = False
            e_mail.Body = password
            Smtp_Server.Send(e_mail)
            Email_status = "Mail Sent"

        Catch ep As Exception

            Email_status = ep.Message

        End Try

    End Function


    Public Function EncryptString(ByVal text As String, vspr_no As String) As String

        Dim bytes As Byte()
        Try
            bytes = New Byte(text.Length - 1) {}
            bytes = System.Text.Encoding.UTF8.GetBytes(text)
            encrypted = Convert.ToBase64String(bytes)
            ReadFromDatabase("update buyer set pin='" & encrypted.ToString() & "'where spr_no='" & vspr_no.ToString() & "'")

        Catch ex As Exception
            MsgBox(ex.Message)
            encrypted = ""
        End Try

        Return encrypted
    End Function


    Public Function onlyDigits(e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Function


    Public Function NextBox(e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Function


    Public Function ExitBox(e As KeyEventArgs, login_Page As Login_Page)
        If e.KeyCode = Keys.Escape Then
            login_Page.Close()
        End If
    End Function


    Public Function PrintPdf(dataGridView1 As DataGridView, text1 As String)

        Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
        'Creating iTextSharp Table from the DataTable data
        Try

            'Creating iTextSharp Table from the DataTable data
            Dim pdfTable As New PdfPTable(dataGridView1.ColumnCount)
            pdfTable.DefaultCell.Padding = 3
            pdfTable.WidthPercentage = 70
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
            pdfTable.DefaultCell.BorderWidth = 1

            'Adding Header row
            For Each column As DataGridViewColumn In dataGridView1.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
                pdfTable.AddCell(cell)
            Next

            'Adding DataRow
            Dim cellvalue As String = ""
            Dim i As Integer = 0
            For Each row As DataGridViewRow In dataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    cellvalue = cell.FormattedValue
                    pdfTable.AddCell(Convert.ToString(cellvalue))
                Next
            Next

            'Exporting to PDF
            'Dim folderPath As String = "C:\Users\" + SystemInformation.UserName + "\Downloads"
            Dim folderPath As String = "C:\SalesPdf\"
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
            Using stream As New FileStream(folderPath & d + "SalesData.pdf", FileMode.Create)
                Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
                PdfWriter.GetInstance(pdfDoc, stream)
                pdfDoc.Open()
                pdfDoc.Add(pdfTable)
                pdfDoc.Close()
                stream.Close()

                If text1 IsNot "sales" Then
                    FindEmailToSendPdf(text1)

                End If


            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function



    Public Function FindEmailToSendPdf(text1 As String)
        Try
            Dim possible As String
            dtCustomers = ReadFromDatabase("select email from buyer where Spr_no='" & text1 & "'")
            possible = dtCustomers.Rows(0).Item("email")
            SendEmailWithPdfFile(possible)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function



    Public Function SendEmailWithPdfFile(vemail As String)

        Try

            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(smtp_user_email, smtp_user_passsword)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(smtp_user_email)
            e_mail.To.Add(vemail)

            Dim filePath As String = "C:\SalesPdf\SalesData.pdf"
            Dim attach As New Net.Mail.Attachment(filePath)

            e_mail.Attachments.Add(attach)



            e_mail.Subject = "Your Transactions in MZCET Canteen"
            e_mail.IsBodyHtml = False

            Smtp_Server.Send(e_mail)
            MsgBox("Mail Send Successfully")
            Email_status = "Mail Sent"

        Catch ep As Exception

            Email_status = ep.Message

        End Try

    End Function

End Module
