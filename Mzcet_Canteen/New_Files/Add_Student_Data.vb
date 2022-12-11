Public Class Add_Student_Data


    Private Sub name_TextChanged(sender As Object, e As EventArgs) Handles name.TextChanged

    End Sub

    Private Sub dept_TextChanged(sender As Object, e As EventArgs) Handles dept.TextChanged

    End Sub

    Private Sub gender_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub year_TextChanged(sender As Object, e As EventArgs) Handles year.TextChanged

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click

        Try
            dtCustomers = ReadFromDatabase("INSERT INTO buyer([id],[Spr_no],[Name],[Department],[Year],[Type],[balance],[Pin],[email]) VALUES ('" & TextBox1.Text & "','" & sprno.Text & "','" & name.Text & "','" & dept.Text & "','" & year.Text & "','" & ComboBox1.Text & "','" & balance.Text & "','" & password.Text & "','" & email_text.Text & "')")
            MsgBox(database_query_status)
            Me.Close()
            student_db.DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub sprno_TextChanged(sender As Object, e As EventArgs) Handles sprno.TextChanged

    End Sub

    Private Sub Add_Student_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Text = "Student"
    End Sub

    Private Sub balance_TextChanged(sender As Object, e As EventArgs) Handles balance.TextChanged

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sprno.Focus()
        End If
    End Sub

    Private Sub sprno_KeyDown(sender As Object, e As KeyEventArgs) Handles sprno.KeyDown
        If e.KeyCode = Keys.Enter Then
            name.Focus()
        End If
    End Sub

    Private Sub name_KeyDown(sender As Object, e As KeyEventArgs) Handles name.KeyDown
        If e.KeyCode = Keys.Enter Then
            dept.Focus()
        End If
    End Sub

    Private Sub dept_KeyDown(sender As Object, e As KeyEventArgs) Handles dept.KeyDown
        If e.KeyCode = Keys.Enter Then
            password.Focus()
        End If
    End Sub

    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            year.Focus()
        End If
    End Sub

    Private Sub year_KeyDown(sender As Object, e As KeyEventArgs) Handles year.KeyDown
        If e.KeyCode = Keys.Enter Then
            balance.Focus()
        End If
    End Sub

    Private Sub balance_KeyDown(sender As Object, e As KeyEventArgs) Handles balance.KeyDown
        If e.KeyCode = Keys.Enter Then
            email_text.Focus()
        End If
    End Sub


    Private Sub email_text_TextChanged(sender As Object, e As EventArgs) Handles email_text.TextChanged

    End Sub

    Private Sub email_text_KeyDown(sender As Object, e As KeyEventArgs) Handles email_text.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                dtCustomers = ReadFromDatabase("INSERT INTO buyer([id],[Spr_no],[Name],[Department],[Year],[Type],[balance],[Pin],[email]) VALUES ('" & TextBox1.Text & "','" & sprno.Text & "','" & name.Text & "','" & dept.Text & "','" & year.Text & "','" & ComboBox1.Text & "','" & balance.Text & "','" & password.Text & "','" & email_text.Text & "')")
                MsgBox(database_query_status)
                Me.Close()
                student_db.DataGridView1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class