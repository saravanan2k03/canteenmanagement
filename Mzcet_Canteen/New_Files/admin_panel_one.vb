Imports System.ComponentModel

Public Class admin_panel_one


    Private Sub admin_panel_one_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login_Page.ShowDialog()
        If current_user = 2 Then
            AdminHomeToolStripMenuItem.Enabled = False
            ProductLogToolStripMenuItem1.Enabled = False
            RechargeToolStripMenuItem.Enabled = False
            ProductDataToolStripMenuItem.Enabled = False
            Me.WindowState = FormWindowState.Maximized


        End If
        If current_user = 1 Then
            AdminHomeToolStripMenuItem.Enabled = True
            Me.WindowState = FormWindowState.Maximized

        End If
        If current_user = 0 Then
            Me.Close()
        End If

    End Sub





    Private Sub LogdataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogdataToolStripMenuItem.Click
        Dim frm2 As New Log_data
        frm2.Show()
        frm2.MdiParent = Me

    End Sub

    Private Sub StudentdatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentdatabaseToolStripMenuItem.Click
        Dim frm2 As New student_db
        frm2.Show()
        frm2.MdiParent = Me
    End Sub


    Private Sub AdminHomeToolStripMenuItem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If


    End Sub

    Private Sub SalesDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesDateToolStripMenuItem.Click

        Dim frm2 As New Sales_data
        frm2.Show()
        frm2.MdiParent = Me
    End Sub


    Private Sub ProductDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductDataToolStripMenuItem.Click
        Dim frm2 As New Product_data
        frm2.Show()
        frm2.MdiParent = Me
    End Sub



    Private Sub BillingToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BillingToolStripMenuItem.Click
        Dim frm4 As New Form3
        frm4.Show()
        frm4.MdiParent = Me


    End Sub


    Private Sub RechargeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RechargeToolStripMenuItem.Click
        Dim frm3 As New recharge
        frm3.Show()
        frm3.MdiParent = Me
    End Sub

    Private Sub admin_panel_one_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Dim status As String = "unordered"
        'dtCustomers = ReadFromDatabase("delete from buyer_details where status='" + status + "'")
    End Sub

    Private Sub GuestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestToolStripMenuItem.Click
        Dim frm5 As New Form3
        frm5.Id_scan_field.Visible = False
        frm5.spr_field.Text = "guest"
        frm5.spr_field.Hide()
        frm5.token_field.Hide()
        frm5.Label1.Visible = False
        frm5.name_field.Hide()
        frm5.dp_field.Hide()
        frm5.type_field.Hide()
        frm5.year_field.Hide()
        frm5.balance_field.Hide()
        frm5.Label14.Visible = False
        frm5.Show()
        frm5.MdiParent = Me


    End Sub


    Private Sub ProductLogToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductLogToolStripMenuItem1.Click
        Dim frm2 As New Product_log
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub TokenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TokenToolStripMenuItem.Click
        Dim frm2 As New token
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub ReprintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReprintToolStripMenuItem.Click
        Dim frm2 As New Reprint
        frm2.Show()
        frm2.MdiParent = Me
    End Sub
End Class