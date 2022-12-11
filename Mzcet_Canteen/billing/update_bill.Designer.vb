<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_bill
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.produ = New System.Windows.Forms.TextBox()
        Me.produname = New System.Windows.Forms.TextBox()
        Me.quantitytext = New System.Windows.Forms.TextBox()
        Me.pricetext = New System.Windows.Forms.TextBox()
        Me.totaltext = New System.Windows.Forms.TextBox()
        Me.upd = New System.Windows.Forms.Button()
        Me.del = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ref_no"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product_id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Product_name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total"
        '
        'produ
        '
        Me.produ.Location = New System.Drawing.Point(98, 11)
        Me.produ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.produ.Name = "produ"
        Me.produ.ReadOnly = True
        Me.produ.Size = New System.Drawing.Size(110, 23)
        Me.produ.TabIndex = 8
        '
        'produname
        '
        Me.produname.Location = New System.Drawing.Point(99, 52)
        Me.produname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.produname.Name = "produname"
        Me.produname.ReadOnly = True
        Me.produname.Size = New System.Drawing.Size(110, 23)
        Me.produname.TabIndex = 9
        '
        'quantitytext
        '
        Me.quantitytext.Location = New System.Drawing.Point(99, 95)
        Me.quantitytext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.quantitytext.Name = "quantitytext"
        Me.quantitytext.Size = New System.Drawing.Size(110, 23)
        Me.quantitytext.TabIndex = 2
        '
        'pricetext
        '
        Me.pricetext.Location = New System.Drawing.Point(99, 136)
        Me.pricetext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pricetext.Name = "pricetext"
        Me.pricetext.ReadOnly = True
        Me.pricetext.Size = New System.Drawing.Size(110, 23)
        Me.pricetext.TabIndex = 11
        '
        'totaltext
        '
        Me.totaltext.Location = New System.Drawing.Point(99, 175)
        Me.totaltext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.totaltext.Name = "totaltext"
        Me.totaltext.ReadOnly = True
        Me.totaltext.Size = New System.Drawing.Size(110, 23)
        Me.totaltext.TabIndex = 12
        '
        'upd
        '
        Me.upd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.upd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.upd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.upd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.upd.Location = New System.Drawing.Point(57, 219)
        Me.upd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.upd.Name = "upd"
        Me.upd.Size = New System.Drawing.Size(64, 31)
        Me.upd.TabIndex = 77
        Me.upd.Text = "Update"
        Me.upd.UseVisualStyleBackColor = True
        '
        'del
        '
        Me.del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.del.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.del.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.del.Location = New System.Drawing.Point(144, 219)
        Me.del.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(64, 31)
        Me.del.TabIndex = 78
        Me.del.Text = "Delete"
        Me.del.UseVisualStyleBackColor = True
        '
        'update_bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 260)
        Me.Controls.Add(Me.del)
        Me.Controls.Add(Me.upd)
        Me.Controls.Add(Me.totaltext)
        Me.Controls.Add(Me.pricetext)
        Me.Controls.Add(Me.quantitytext)
        Me.Controls.Add(Me.produname)
        Me.Controls.Add(Me.produ)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "update_bill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "update_bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents produ As TextBox
    Friend WithEvents produname As TextBox
    Friend WithEvents quantitytext As TextBox
    Friend WithEvents pricetext As TextBox
    Friend WithEvents totaltext As TextBox
    Friend WithEvents upd As Button
    Friend WithEvents del As Button
End Class
