Imports System.Data.SqlClient

Public Class token
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tokengrid.CellContentClick
        tokes()
        'tokenid = tokengrid.CurrentRow.Cells(0).Value.ToString

    End Sub

    Public Sub tokes()
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        Dim command As New SqlCommand("select distinct token_id,gtotal from token", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        tokengrid.DataSource = dt
        tokengrid.ClearSelection()
    End Sub

    Private Sub token_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tokes()
    End Sub

    Private Sub tokengrid_MouseClick(sender As Object, e As MouseEventArgs) Handles tokengrid.MouseClick
        Try
            tokenid = tokengrid.CurrentRow.Cells(0).Value.ToString
            tokengrid.ClearSelection()
            tokes()
            'MessageBox.Show(tokenid)
            Dim frm5 As New Form3
            frm5.Id_scan_field.Visible = False
            frm5.spr_field.Text = "1111"
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
            frm5.MdiParent = admin_panel_one
            tokes()
        Catch ex As Exception
            MessageBox.Show("Please Close Billing ")
        End Try

    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        tokes()
    End Sub
End Class