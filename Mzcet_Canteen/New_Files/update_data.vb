Public Class update_data




    Public Function SendDatatoUpdateForm()

    End Function



    Private Sub department_TextChanged(sender As Object, e As EventArgs) Handles department.TextChanged

    End Sub

    Private Sub year_TextChanged(sender As Object, e As EventArgs) Handles year.TextChanged

    End Sub

    Private Sub type_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
        password.Enabled = False

    End Sub


    Private Sub Spr_Number_TextChanged(sender As Object, e As EventArgs) Handles Spr_Number.TextChanged
        Spr_Number.Enabled = False
    End Sub


    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Try
            ReadFromDatabase("update buyer set Spr_no='" & Spr_Number.Text & "',Name='" & user_name.Text & "',Department='" & department.Text & "',Year='" & year.Text & "',balance='" & balance.Text & "',Pin='" & password.Text & "',email='" & email_text.Text & "'where Spr_no='" & Spr_Number.Text & "'")
            MsgBox(database_query_status)
            dtCustomers = ReadFromDatabase("SELECT * FROM buyer")
            DataGrid.DataSource = dtCustomers
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub update_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_For_update.Text = id_up
        user_name.Text = name_up
        password.Text = password_up
        year.Text = year_up
        department.Text = dept_up
        Spr_Number.Text = spr_up
        email_text.Text = email_up
        password.Text = pin_up
        balance.Text = balance_up
    End Sub

    Private Sub user_name_TextChanged(sender As Object, e As EventArgs) Handles user_name.TextChanged

    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click

        SendEmailToReset(email_text.Text, spr_up)
        dtCustomers = ReadFromDatabase("SELECT * FROM buyer")
        DataGrid.DataSource = dtCustomers
        Me.Close()
        student_db.Close()
        MsgBox(Email_status)
    End Sub


    Private Sub email_text_TextChanged(sender As Object, e As EventArgs) Handles email_text.TextChanged

    End Sub

    Private Sub balance_TextChanged(sender As Object, e As EventArgs) Handles balance.TextChanged

    End Sub

    Private Sub type_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub balance_KeyDown(sender As Object, e As KeyEventArgs) Handles balance.KeyDown

    End Sub

    Private Sub update_data_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub user_name_KeyDown(sender As Object, e As KeyEventArgs) Handles user_name.KeyDown

    End Sub

    Private Sub department_KeyDown(sender As Object, e As KeyEventArgs) Handles department.KeyDown

    End Sub

    Private Sub year_KeyDown(sender As Object, e As KeyEventArgs) Handles year.KeyDown

    End Sub

    Private Sub email_text_KeyDown(sender As Object, e As KeyEventArgs) Handles email_text.KeyDown

    End Sub

    Private Sub id_For_update_TextChanged(sender As Object, e As EventArgs) Handles id_For_update.TextChanged
        id_For_update.Enabled = False
    End Sub
End Class