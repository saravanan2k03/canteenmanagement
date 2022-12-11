

Imports System.Net.Mail
Public Class student_db




    Private Sub student_db_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtCustomers = ReadFromDatabase("SELECT * FROM buyer")
        DataGridView1.DataSource = dtCustomers
        DataGrid = DataGridView1
        DataGridView1.ClearSelection()


    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        id_up = DataGridView1.CurrentRow.Cells(0).Value.ToString
        spr_up = DataGridView1.CurrentRow.Cells(1).Value.ToString
        name_up = DataGridView1.CurrentRow.Cells(2).Value.ToString
        dept_up = DataGridView1.CurrentRow.Cells(3).Value.ToString
        year_up = DataGridView1.CurrentRow.Cells(4).Value.ToString
        type_up = DataGridView1.CurrentRow.Cells(8).Value.ToString
        balance_up = DataGridView1.CurrentRow.Cells(5).Value.ToString
        pin_up = DataGridView1.CurrentRow.Cells(6).Value.ToString
        email_up = DataGridView1.CurrentRow.Cells(7).Value.ToString
        Dim frm2 As New update_data
        frm2.Show()
        frm2.MdiParent = admin_panel_one


    End Sub



    Private Sub student_db_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        dtCustomers = ReadFromDatabase("select * from buyer where Name Like '" & RichTextBox1.Text & "'+'%' ")
        DataGridView1.DataSource = dtCustomers
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim temp As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1

                If CStr(DataGridView1.Rows(i).Cells(j).Value) = RichTextBox1.Text Then
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

    Private Sub Reset_Password_To_All_Click(sender As Object, e As EventArgs) Handles Reset_Password_To_All.Click
        SendAll()
    End Sub


    Public Function SendAll()
        Dim row As DataRow
        For Each row In dtCustomers.Rows
            Dim strDetail As String
            Dim spr_detail As String
            strDetail = row("email")
            spr_detail = row("Spr_no")
            SendEmailToReset(strDetail.ToString(), spr_detail.ToString())
        Next row

        MsgBox(Email_status)
    End Function


    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        dtCustomers = ReadFromDatabase("Select email from buyer")
    End Sub

    Private Sub import_Click(sender As Object, e As EventArgs) Handles import.Click
        CSVLoadForStudent(DataGridView1)
    End Sub



    Private Sub Refresh_Click(sender As Object, e As EventArgs)
        dtCustomers = ReadFromDatabase("SELECT * FROM buyer")
        DataGridView1.DataSource = dtCustomers

    End Sub

    Private Sub Add_data_Click(sender As Object, e As EventArgs) Handles Add_data.Click
        Dim frm2 As New Add_Student_Data
        frm2.Show()
        frm2.MdiParent = admin_panel_one

    End Sub

    Private Sub refu_Click(sender As Object, e As EventArgs) Handles refu.Click
        dtCustomers = ReadFromDatabase("SELECT * FROM buyer")
        DataGridView1.DataSource = dtCustomers
    End Sub
End Class