<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reprint
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
        Me.bill_data = New System.Windows.Forms.DataGridView()
        Me.bill_enter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grand_field = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.add_btn = New System.Windows.Forms.Button()
        CType(Me.bill_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bill_data
        '
        Me.bill_data.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bill_data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.bill_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bill_data.DefaultCellStyle = DataGridViewCellStyle2
        Me.bill_data.Location = New System.Drawing.Point(42, 125)
        Me.bill_data.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.bill_data.Name = "bill_data"
        Me.bill_data.ReadOnly = True
        Me.bill_data.RowHeadersWidth = 62
        Me.bill_data.RowTemplate.Height = 28
        Me.bill_data.Size = New System.Drawing.Size(760, 359)
        Me.bill_data.TabIndex = 78
        '
        'bill_enter
        '
        Me.bill_enter.Location = New System.Drawing.Point(136, 58)
        Me.bill_enter.Name = "bill_enter"
        Me.bill_enter.Size = New System.Drawing.Size(102, 27)
        Me.bill_enter.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Bill.No"
        '
        'grand_field
        '
        Me.grand_field.Location = New System.Drawing.Point(436, 62)
        Me.grand_field.Name = "grand_field"
        Me.grand_field.Size = New System.Drawing.Size(102, 27)
        Me.grand_field.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Grand Total"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'add_btn
        '
        Me.add_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.add_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.add_btn.Location = New System.Drawing.Point(368, 509)
        Me.add_btn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(108, 43)
        Me.add_btn.TabIndex = 83
        Me.add_btn.Text = "Print"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'Reprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 565)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grand_field)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bill_enter)
        Me.Controls.Add(Me.bill_data)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reprint"
        CType(Me.bill_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bill_data As DataGridView
    Friend WithEvents bill_enter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grand_field As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents add_btn As Button
End Class
