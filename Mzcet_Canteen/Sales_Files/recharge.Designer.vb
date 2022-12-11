<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recharge
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.id_rc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.spr_rc = New System.Windows.Forms.TextBox()
        Me.name_rc = New System.Windows.Forms.TextBox()
        Me.balance_rc = New System.Windows.Forms.TextBox()
        Me.rc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sub_rc = New System.Windows.Forms.Button()
        Me.rc_table = New System.Windows.Forms.DataGridView()
        Me.print_rc = New System.Windows.Forms.Button()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.today_btn = New System.Windows.Forms.Button()
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.getdata = New System.Windows.Forms.Button()
        CType(Me.rc_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id_rc
        '
        Me.id_rc.Location = New System.Drawing.Point(148, 199)
        Me.id_rc.MaxLength = 13
        Me.id_rc.Name = "id_rc"
        Me.id_rc.PlaceholderText = "         SCAN HERE"
        Me.id_rc.Size = New System.Drawing.Size(180, 27)
        Me.id_rc.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(36, 197)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'spr_rc
        '
        Me.spr_rc.BackColor = System.Drawing.Color.White
        Me.spr_rc.Location = New System.Drawing.Point(148, 277)
        Me.spr_rc.Name = "spr_rc"
        Me.spr_rc.ReadOnly = True
        Me.spr_rc.Size = New System.Drawing.Size(180, 27)
        Me.spr_rc.TabIndex = 85
        '
        'name_rc
        '
        Me.name_rc.BackColor = System.Drawing.Color.White
        Me.name_rc.Location = New System.Drawing.Point(148, 360)
        Me.name_rc.Name = "name_rc"
        Me.name_rc.ReadOnly = True
        Me.name_rc.Size = New System.Drawing.Size(180, 27)
        Me.name_rc.TabIndex = 86
        '
        'balance_rc
        '
        Me.balance_rc.BackColor = System.Drawing.Color.White
        Me.balance_rc.Location = New System.Drawing.Point(148, 448)
        Me.balance_rc.Name = "balance_rc"
        Me.balance_rc.ReadOnly = True
        Me.balance_rc.Size = New System.Drawing.Size(180, 27)
        Me.balance_rc.TabIndex = 87
        '
        'rc
        '
        Me.rc.BackColor = System.Drawing.Color.White
        Me.rc.Location = New System.Drawing.Point(148, 542)
        Me.rc.Name = "rc"
        Me.rc.Size = New System.Drawing.Size(180, 27)
        Me.rc.TabIndex = 88
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(25, 275)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 28)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "SprNo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(25, 358)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 28)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(25, 446)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 28)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Balance"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(15, 540)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 28)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = " Amount"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sub_rc
        '
        Me.sub_rc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sub_rc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sub_rc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.sub_rc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sub_rc.Location = New System.Drawing.Point(148, 626)
        Me.sub_rc.Margin = New System.Windows.Forms.Padding(4)
        Me.sub_rc.Name = "sub_rc"
        Me.sub_rc.Size = New System.Drawing.Size(180, 42)
        Me.sub_rc.TabIndex = 93
        Me.sub_rc.Text = "Submit"
        Me.sub_rc.UseVisualStyleBackColor = True
        '
        'rc_table
        '
        Me.rc_table.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.rc_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.rc_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.rc_table.DefaultCellStyle = DataGridViewCellStyle2
        Me.rc_table.Location = New System.Drawing.Point(364, 193)
        Me.rc_table.Margin = New System.Windows.Forms.Padding(4)
        Me.rc_table.Name = "rc_table"
        Me.rc_table.ReadOnly = True
        Me.rc_table.RowHeadersWidth = 62
        Me.rc_table.RowTemplate.Height = 28
        Me.rc_table.Size = New System.Drawing.Size(987, 471)
        Me.rc_table.TabIndex = 94
        '
        'print_rc
        '
        Me.print_rc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.print_rc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.print_rc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.print_rc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.print_rc.Location = New System.Drawing.Point(815, 671)
        Me.print_rc.Margin = New System.Windows.Forms.Padding(4)
        Me.print_rc.Name = "print_rc"
        Me.print_rc.Size = New System.Drawing.Size(180, 42)
        Me.print_rc.TabIndex = 95
        Me.print_rc.Text = "Print "
        Me.print_rc.UseVisualStyleBackColor = True
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(592, 9)
        Me.DatePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(157, 27)
        Me.DatePicker.TabIndex = 96
        '
        'today_btn
        '
        Me.today_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.today_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.today_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.today_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.today_btn.Location = New System.Drawing.Point(975, 120)
        Me.today_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.today_btn.Name = "today_btn"
        Me.today_btn.Size = New System.Drawing.Size(180, 42)
        Me.today_btn.TabIndex = 97
        Me.today_btn.Text = "Today"
        Me.today_btn.UseVisualStyleBackColor = True
        '
        'DateTime1
        '
        Me.DateTime1.Location = New System.Drawing.Point(978, 9)
        Me.DateTime1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(157, 27)
        Me.DateTime1.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(891, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 28)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "TO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(445, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 28)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "FROM"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'getdata
        '
        Me.getdata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.getdata.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.getdata.ForeColor = System.Drawing.SystemColors.ControlText
        Me.getdata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.getdata.Location = New System.Drawing.Point(589, 120)
        Me.getdata.Margin = New System.Windows.Forms.Padding(4)
        Me.getdata.Name = "getdata"
        Me.getdata.Size = New System.Drawing.Size(180, 42)
        Me.getdata.TabIndex = 101
        Me.getdata.Text = "GETDATA"
        Me.getdata.UseVisualStyleBackColor = True
        '
        'recharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 752)
        Me.Controls.Add(Me.getdata)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.today_btn)
        Me.Controls.Add(Me.DatePicker)
        Me.Controls.Add(Me.print_rc)
        Me.Controls.Add(Me.rc_table)
        Me.Controls.Add(Me.sub_rc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rc)
        Me.Controls.Add(Me.balance_rc)
        Me.Controls.Add(Me.name_rc)
        Me.Controls.Add(Me.spr_rc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id_rc)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "recharge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "recharge"
        CType(Me.rc_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents id_rc As TextBox
    Friend WithEvents Label1 As Label
    Public WithEvents spr_rc As TextBox
    Public WithEvents name_rc As TextBox
    Public WithEvents balance_rc As TextBox
    Public WithEvents rc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sub_rc As Button
    Friend WithEvents rc_table As DataGridView
    Friend WithEvents print_rc As Button
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents today_btn As Button
    Friend WithEvents DateTime1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents getdata As Button
End Class
