Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Module Connection
    Public cha As String
    Public ordstatus As String
    Public changes As String
    Public mess As String
    Public tokenid As String
    Public shortkey
    Public database_query_status As String
    Public DataGrid1
    Public DataGrid
    Public product_id_data As String
    Public product_name_data As String
    Public product_price_data As String
    Public product_quantity_data As String
    Public guest
    Public guest_nm As String
    Public reff
    Public mails As String
    Public bill_num
    Public g_tot
    Public ref_f As String
    Public item_f As String
    Public pd_name_f As String
    Public quant_f As String
    Public price_f As String
    Public total_f As String
    Public quant As String
    Public price As String
    Public total As String
    Public quan As String
    Public sa
    Public number As String
    Public ren
    Public finalrender
    Public up
    Public upbtn As Form3
    Public Scanner As String

    Public id_up As String
    Public name_up As String
    Public password_up As String
    Public year_up As String
    Public dept_up As String
    Public gender_up As String
    Public spr_up As String
    Public email_up As String
    Public type_up As String
    Public pin_up As String
    Public balance_up As String

    Public Cancel_Spr_No As String
    Public Cancel_Product_id As String
    Public Cancel_Qunatity As String
    Public Cancel_Total As String
    Public Cancel_Status As String
    Public Cancel_Date As String
    Public Cancel_Ref_No As String

    Public formcloss As Boolean

    Public smtp_user_email As String = ""
    Public smtp_user_passsword As String = ""

   
    Public dtCustomers As New DataTable
    Public DBConnectionString As String = "Data Source=;Initial Catalog=canteen;User ID=mzcanteen;Password="

    Public Function ReadFromDatabase(ByVal SQL As String) As DataTable
        Dim dtReturn As New DataTable
        Try
            'Open the connection using the connection string
            Using conn As New SqlClient.SqlConnection(DBConnectionString)
                conn.Open()

                Using cmd As New SqlClient.SqlCommand()
                    cmd.Connection = conn
                    cmd.CommandText = SQL
                    Dim da As New SqlClient.SqlDataAdapter(cmd)
                    da.Fill(dtReturn)
                    database_query_status = "Successfuly"
                End Using


            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
            database_query_status = ex.Message.ToString()

        End Try


        'Return the result data set
        Return dtReturn
    End Function




    Public Function EncryptString(ByVal text As String) As String
        Dim encrypted As String = ""
        Dim bytes As Byte()
        Try
            bytes = New Byte(text.Length - 1) {}
            bytes = System.Text.Encoding.UTF8.GetBytes(text)
            encrypted = Convert.ToBase64String(bytes)
            MsgBox(encrypted)
        Catch ex As Exception
            encrypted = ""
        End Try

        Return encrypted
    End Function









End Module
