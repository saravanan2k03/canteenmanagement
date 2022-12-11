<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_product
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
        Me.product_name = New System.Windows.Forms.TextBox()
        Me.price = New System.Windows.Forms.TextBox()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.shortkeybox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "shortcutkey"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "productname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "quantity"
        '
        'product_name
        '
        Me.product_name.Location = New System.Drawing.Point(289, 128)
        Me.product_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.product_name.Name = "product_name"
        Me.product_name.Size = New System.Drawing.Size(187, 27)
        Me.product_name.TabIndex = 6
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(289, 199)
        Me.price.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(187, 27)
        Me.price.TabIndex = 7
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(289, 271)
        Me.quantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(187, 27)
        Me.quantity.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 380)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 49)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'shortkeybox
        '
        Me.shortkeybox.Location = New System.Drawing.Point(289, 46)
        Me.shortkeybox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.shortkeybox.Name = "shortkeybox"
        Me.shortkeybox.Size = New System.Drawing.Size(187, 27)
        Me.shortkeybox.TabIndex = 6
        '
        'add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 465)
        Me.Controls.Add(Me.shortkeybox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.product_name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "add_product"
        Me.Text = "add_product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents product_name As TextBox
    Friend WithEvents price As TextBox
    Friend WithEvents quantity As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents shortkeybox As TextBox
End Class
