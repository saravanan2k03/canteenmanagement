<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Product
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
        Me.Product_id = New System.Windows.Forms.Label()
        Me.Product_Name = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.Label()
        Me.product_id1 = New System.Windows.Forms.TextBox()
        Me.product_name1 = New System.Windows.Forms.TextBox()
        Me.Quantity_1 = New System.Windows.Forms.TextBox()
        Me.Price_1 = New System.Windows.Forms.TextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.short_key = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Product_id
        '
        Me.Product_id.AutoSize = True
        Me.Product_id.Location = New System.Drawing.Point(74, 61)
        Me.Product_id.Name = "Product_id"
        Me.Product_id.Size = New System.Drawing.Size(73, 20)
        Me.Product_id.TabIndex = 0
        Me.Product_id.Text = "Productid"
        '
        'Product_Name
        '
        Me.Product_Name.AutoSize = True
        Me.Product_Name.Location = New System.Drawing.Point(74, 115)
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.Size = New System.Drawing.Size(100, 20)
        Me.Product_Name.TabIndex = 1
        Me.Product_Name.Text = "ProductName"
        '
        'Quantity
        '
        Me.Quantity.AutoSize = True
        Me.Quantity.Location = New System.Drawing.Point(74, 238)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(60, 20)
        Me.Quantity.TabIndex = 2
        Me.Quantity.Text = "Quantiy"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Location = New System.Drawing.Point(74, 297)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(41, 20)
        Me.Price.TabIndex = 3
        Me.Price.Text = "Price"
        '
        'product_id1
        '
        Me.product_id1.Location = New System.Drawing.Point(197, 61)
        Me.product_id1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.product_id1.Name = "product_id1"
        Me.product_id1.ReadOnly = True
        Me.product_id1.Size = New System.Drawing.Size(198, 27)
        Me.product_id1.TabIndex = 4
        '
        'product_name1
        '
        Me.product_name1.Location = New System.Drawing.Point(197, 115)
        Me.product_name1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.product_name1.Name = "product_name1"
        Me.product_name1.Size = New System.Drawing.Size(198, 27)
        Me.product_name1.TabIndex = 5
        '
        'Quantity_1
        '
        Me.Quantity_1.Location = New System.Drawing.Point(197, 234)
        Me.Quantity_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Quantity_1.Name = "Quantity_1"
        Me.Quantity_1.Size = New System.Drawing.Size(198, 27)
        Me.Quantity_1.TabIndex = 6
        '
        'Price_1
        '
        Me.Price_1.Location = New System.Drawing.Point(197, 286)
        Me.Price_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Price_1.Name = "Price_1"
        Me.Price_1.Size = New System.Drawing.Size(198, 27)
        Me.Price_1.TabIndex = 7
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(224, 335)
        Me.Submit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(117, 44)
        Me.Submit.TabIndex = 8
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'short_key
        '
        Me.short_key.Location = New System.Drawing.Point(197, 178)
        Me.short_key.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.short_key.Name = "short_key"
        Me.short_key.Size = New System.Drawing.Size(198, 27)
        Me.short_key.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "shortcutkey"
        '
        'Update_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 431)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.short_key)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Price_1)
        Me.Controls.Add(Me.Quantity_1)
        Me.Controls.Add(Me.product_name1)
        Me.Controls.Add(Me.product_id1)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Product_Name)
        Me.Controls.Add(Me.Product_id)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Update_Product"
        Me.Text = "Update_Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Product_id As Label
    Friend WithEvents Product_Name As Label
    Friend WithEvents Quantity As Label
    Friend WithEvents Price As Label
    Friend WithEvents product_id1 As TextBox
    Friend WithEvents product_name1 As TextBox
    Friend WithEvents Quantity_1 As TextBox
    Friend WithEvents Price_1 As TextBox
    Friend WithEvents Submit As Button
    Friend WithEvents short_key As TextBox
    Friend WithEvents Label1 As Label
End Class
