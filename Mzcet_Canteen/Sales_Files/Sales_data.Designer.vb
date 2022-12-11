<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales_data
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.search_sales = New System.Windows.Forms.TextBox()
        Me.PDF_Print = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Student_data = New System.Windows.Forms.Button()
        Me.quantity_count = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.amounttext = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(58, 133)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1086, 513)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(602, 56)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Get_Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox1.Location = New System.Drawing.Point(58, 63)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(61, 47)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'search_sales
        '
        Me.search_sales.Location = New System.Drawing.Point(769, 65)
        Me.search_sales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.search_sales.Name = "search_sales"
        Me.search_sales.Size = New System.Drawing.Size(206, 27)
        Me.search_sales.TabIndex = 5
        '
        'PDF_Print
        '
        Me.PDF_Print.Location = New System.Drawing.Point(487, 680)
        Me.PDF_Print.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PDF_Print.Name = "PDF_Print"
        Me.PDF_Print.Size = New System.Drawing.Size(129, 53)
        Me.PDF_Print.TabIndex = 6
        Me.PDF_Print.Text = "PDF_Print"
        Me.PDF_Print.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(192, 65)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(157, 27)
        Me.DateTimePicker1.TabIndex = 7
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(409, 65)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(159, 27)
        Me.DateTimePicker2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "To"
        '
        'Student_data
        '
        Me.Student_data.Location = New System.Drawing.Point(993, 63)
        Me.Student_data.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Student_data.Name = "Student_data"
        Me.Student_data.Size = New System.Drawing.Size(129, 53)
        Me.Student_data.TabIndex = 11
        Me.Student_data.Text = "Student Data"
        Me.Student_data.UseVisualStyleBackColor = True
        '
        'quantity_count
        '
        Me.quantity_count.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.quantity_count.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.quantity_count.Location = New System.Drawing.Point(200, 680)
        Me.quantity_count.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.quantity_count.Name = "quantity_count"
        Me.quantity_count.Size = New System.Drawing.Size(119, 53)
        Me.quantity_count.TabIndex = 12
        Me.quantity_count.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 696)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "quantity"
        '
        'amounttext
        '
        Me.amounttext.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.amounttext.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.amounttext.Location = New System.Drawing.Point(907, 680)
        Me.amounttext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.amounttext.Name = "amounttext"
        Me.amounttext.Size = New System.Drawing.Size(119, 53)
        Me.amounttext.TabIndex = 14
        Me.amounttext.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(742, 696)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Amount"
        '
        'Sales_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 749)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.amounttext)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.quantity_count)
        Me.Controls.Add(Me.Student_data)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PDF_Print)
        Me.Controls.Add(Me.search_sales)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Sales_data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales_data"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents search_sales As TextBox
    Friend WithEvents PDF_Print As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Student_data As Button
    Friend WithEvents quantity_count As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents amounttext As RichTextBox
    Friend WithEvents Label4 As Label
End Class
