<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cancel
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
        Me.display_Product_id = New System.Windows.Forms.TextBox()
        Me.display_Product_qunatity = New System.Windows.Forms.TextBox()
        Me.display_Product_total = New System.Windows.Forms.TextBox()
        Me.display_Product_spr_no = New System.Windows.Forms.TextBox()
        Me.display_Product_date = New System.Windows.Forms.TextBox()
        Me.Abort_Purchased = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product_Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product_Qunatity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product_Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Spr_No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date"
        '
        'display_Product_id
        '
        Me.display_Product_id.Location = New System.Drawing.Point(185, 57)
        Me.display_Product_id.Name = "display_Product_id"
        Me.display_Product_id.Size = New System.Drawing.Size(197, 23)
        Me.display_Product_id.TabIndex = 5
        '
        'display_Product_qunatity
        '
        Me.display_Product_qunatity.Location = New System.Drawing.Point(185, 114)
        Me.display_Product_qunatity.Name = "display_Product_qunatity"
        Me.display_Product_qunatity.Size = New System.Drawing.Size(197, 23)
        Me.display_Product_qunatity.TabIndex = 6
        '
        'display_Product_total
        '
        Me.display_Product_total.Location = New System.Drawing.Point(185, 161)
        Me.display_Product_total.Name = "display_Product_total"
        Me.display_Product_total.Size = New System.Drawing.Size(197, 23)
        Me.display_Product_total.TabIndex = 7
        '
        'display_Product_spr_no
        '
        Me.display_Product_spr_no.Location = New System.Drawing.Point(185, 213)
        Me.display_Product_spr_no.Name = "display_Product_spr_no"
        Me.display_Product_spr_no.Size = New System.Drawing.Size(197, 23)
        Me.display_Product_spr_no.TabIndex = 8
        '
        'display_Product_date
        '
        Me.display_Product_date.Location = New System.Drawing.Point(185, 265)
        Me.display_Product_date.Name = "display_Product_date"
        Me.display_Product_date.Size = New System.Drawing.Size(197, 23)
        Me.display_Product_date.TabIndex = 9
        '
        'Abort_Purchased
        '
        Me.Abort_Purchased.Location = New System.Drawing.Point(232, 314)
        Me.Abort_Purchased.Name = "Abort_Purchased"
        Me.Abort_Purchased.Size = New System.Drawing.Size(130, 37)
        Me.Abort_Purchased.TabIndex = 10
        Me.Abort_Purchased.Text = "Cancel"
        Me.Abort_Purchased.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 393)
        Me.Controls.Add(Me.Abort_Purchased)
        Me.Controls.Add(Me.display_Product_date)
        Me.Controls.Add(Me.display_Product_spr_no)
        Me.Controls.Add(Me.display_Product_total)
        Me.Controls.Add(Me.display_Product_qunatity)
        Me.Controls.Add(Me.display_Product_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cancel"
        Me.Text = "cancel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents display_Product_id As TextBox
    Friend WithEvents display_Product_qunatity As TextBox
    Friend WithEvents display_Product_total As TextBox
    Friend WithEvents display_Product_spr_no As TextBox
    Friend WithEvents display_Product_date As TextBox
    Friend WithEvents Abort_Purchased As Button
End Class
