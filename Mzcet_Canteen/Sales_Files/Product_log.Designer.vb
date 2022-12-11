<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_log
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
        Me.pro_table = New System.Windows.Forms.DataGridView()
        CType(Me.pro_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pro_table
        '
        Me.pro_table.AllowUserToDeleteRows = False
        Me.pro_table.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.pro_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pro_table.Location = New System.Drawing.Point(1, 2)
        Me.pro_table.Name = "pro_table"
        Me.pro_table.ReadOnly = True
        Me.pro_table.RowHeadersWidth = 51
        Me.pro_table.RowTemplate.Height = 29
        Me.pro_table.Size = New System.Drawing.Size(1434, 572)
        Me.pro_table.TabIndex = 0
        '
        'Product_log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1437, 576)
        Me.Controls.Add(Me.pro_table)
        Me.Name = "Product_log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product_log"
        CType(Me.pro_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pro_table As DataGridView
End Class
