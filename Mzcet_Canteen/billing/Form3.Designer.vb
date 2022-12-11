<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Id_scan_field = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.name_field = New System.Windows.Forms.TextBox()
        Me.dp_field = New System.Windows.Forms.TextBox()
        Me.year_field = New System.Windows.Forms.TextBox()
        Me.type_field = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grand_field = New System.Windows.Forms.TextBox()
        Me.balance_field = New System.Windows.Forms.TextBox()
        Me.Billingno_field = New System.Windows.Forms.TextBox()
        Me.total_field = New System.Windows.Forms.TextBox()
        Me.price_field = New System.Windows.Forms.TextBox()
        Me.quant_field = New System.Windows.Forms.TextBox()
        Me.pd_name = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.print_btn = New System.Windows.Forms.Button()
        Me.data_table = New System.Windows.Forms.DataGridView()
        Me.transaction = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.spr_field = New System.Windows.Forms.TextBox()
        Me.item_field = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pin_field = New System.Windows.Forms.TextBox()
        Me.pin_lable = New System.Windows.Forms.Label()
        Me.billing = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.token_field = New System.Windows.Forms.TextBox()
        CType(Me.data_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_scan_field
        '
        resources.ApplyResources(Me.Id_scan_field, "Id_scan_field")
        Me.Id_scan_field.Name = "Id_scan_field"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'name_field
        '
        Me.name_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.name_field, "name_field")
        Me.name_field.Name = "name_field"
        Me.name_field.ReadOnly = True
        '
        'dp_field
        '
        Me.dp_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.dp_field, "dp_field")
        Me.dp_field.Name = "dp_field"
        Me.dp_field.ReadOnly = True
        '
        'year_field
        '
        Me.year_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.year_field, "year_field")
        Me.year_field.Name = "year_field"
        Me.year_field.ReadOnly = True
        '
        'type_field
        '
        Me.type_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.type_field, "type_field")
        Me.type_field.Name = "type_field"
        Me.type_field.ReadOnly = True
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'grand_field
        '
        Me.grand_field.AcceptsReturn = True
        Me.grand_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.grand_field, "grand_field")
        Me.grand_field.Name = "grand_field"
        Me.grand_field.ReadOnly = True
        '
        'balance_field
        '
        Me.balance_field.AcceptsReturn = True
        Me.balance_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.balance_field, "balance_field")
        Me.balance_field.Name = "balance_field"
        Me.balance_field.ReadOnly = True
        '
        'Billingno_field
        '
        Me.Billingno_field.AcceptsReturn = True
        Me.Billingno_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Billingno_field, "Billingno_field")
        Me.Billingno_field.Name = "Billingno_field"
        Me.Billingno_field.ReadOnly = True
        '
        'total_field
        '
        Me.total_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.total_field, "total_field")
        Me.total_field.Name = "total_field"
        Me.total_field.ReadOnly = True
        '
        'price_field
        '
        Me.price_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.price_field, "price_field")
        Me.price_field.Name = "price_field"
        Me.price_field.ReadOnly = True
        '
        'quant_field
        '
        resources.ApplyResources(Me.quant_field, "quant_field")
        Me.quant_field.Name = "quant_field"
        '
        'pd_name
        '
        Me.pd_name.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.pd_name, "pd_name")
        Me.pd_name.Name = "pd_name"
        Me.pd_name.ReadOnly = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'add_btn
        '
        Me.add_btn.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.add_btn, "add_btn")
        Me.add_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.add_btn.Name = "add_btn"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'print_btn
        '
        Me.print_btn.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.print_btn, "print_btn")
        Me.print_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.print_btn.Name = "print_btn"
        Me.print_btn.UseVisualStyleBackColor = True
        '
        'data_table
        '
        Me.data_table.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_table.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.data_table, "data_table")
        Me.data_table.Name = "data_table"
        Me.data_table.ReadOnly = True
        Me.data_table.RowTemplate.Height = 28
        '
        'transaction
        '
        Me.transaction.AllowUserToDeleteRows = False
        Me.transaction.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.transaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.transaction.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.transaction, "transaction")
        Me.transaction.Name = "transaction"
        Me.transaction.ReadOnly = True
        Me.transaction.RowTemplate.Height = 28
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'spr_field
        '
        Me.spr_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.spr_field, "spr_field")
        Me.spr_field.Name = "spr_field"
        Me.spr_field.ReadOnly = True
        '
        'item_field
        '
        Me.item_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.item_field, "item_field")
        Me.item_field.Name = "item_field"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'pin_field
        '
        resources.ApplyResources(Me.pin_field, "pin_field")
        Me.pin_field.Name = "pin_field"
        Me.pin_field.UseSystemPasswordChar = True
        '
        'pin_lable
        '
        resources.ApplyResources(Me.pin_lable, "pin_lable")
        Me.pin_lable.Name = "pin_lable"
        '
        'billing
        '
        Me.billing.AcceptsReturn = True
        Me.billing.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.billing, "billing")
        Me.billing.Name = "billing"
        Me.billing.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'token_field
        '
        Me.token_field.AcceptsReturn = True
        Me.token_field.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.token_field, "token_field")
        Me.token_field.Name = "token_field"
        '
        'Form3
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.token_field)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.billing)
        Me.Controls.Add(Me.pin_lable)
        Me.Controls.Add(Me.item_field)
        Me.Controls.Add(Me.pin_field)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.spr_field)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.transaction)
        Me.Controls.Add(Me.data_table)
        Me.Controls.Add(Me.print_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.total_field)
        Me.Controls.Add(Me.price_field)
        Me.Controls.Add(Me.quant_field)
        Me.Controls.Add(Me.pd_name)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.grand_field)
        Me.Controls.Add(Me.balance_field)
        Me.Controls.Add(Me.Billingno_field)
        Me.Controls.Add(Me.type_field)
        Me.Controls.Add(Me.year_field)
        Me.Controls.Add(Me.dp_field)
        Me.Controls.Add(Me.name_field)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Id_scan_field)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        CType(Me.data_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Id_scan_field As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents name_field As TextBox
    Friend WithEvents dp_field As TextBox
    Friend WithEvents year_field As TextBox
    Friend WithEvents type_field As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents grand_field As TextBox
    Friend WithEvents balance_field As TextBox
    Friend WithEvents Billingno_field As TextBox
    Friend WithEvents total_field As TextBox
    Friend WithEvents price_field As TextBox
    Friend WithEvents quant_field As TextBox
    Friend WithEvents pd_name As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents add_btn As Button
    Friend WithEvents print_btn As Button
    Friend WithEvents data_table As DataGridView
    Friend WithEvents transaction As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents item_field As TextBox
    Friend WithEvents Label5 As Label
    Public WithEvents spr_field As TextBox
    Friend WithEvents pin_field As TextBox
    Friend WithEvents pin_lable As Label
    Friend WithEvents billing As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BTPRINT As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents token_field As TextBox
End Class
