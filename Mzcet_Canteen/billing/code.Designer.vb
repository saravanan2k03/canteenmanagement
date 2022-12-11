<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class code
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
        Me.checkgriddata = New System.Windows.Forms.DataGridView()
        Me.product_name_search = New System.Windows.Forms.TextBox()
        CType(Me.checkgriddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkgriddata
        '
        Me.checkgriddata.AllowUserToAddRows = False
        Me.checkgriddata.AllowUserToDeleteRows = False
        Me.checkgriddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.checkgriddata.Location = New System.Drawing.Point(5, 86)
        Me.checkgriddata.Name = "checkgriddata"
        Me.checkgriddata.ReadOnly = True
        Me.checkgriddata.RowHeadersWidth = 51
        Me.checkgriddata.RowTemplate.Height = 29
        Me.checkgriddata.Size = New System.Drawing.Size(868, 416)
        Me.checkgriddata.TabIndex = 0
        '
        'product_name_search
        '
        Me.product_name_search.Location = New System.Drawing.Point(12, 39)
        Me.product_name_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.product_name_search.Name = "product_name_search"
        Me.product_name_search.Size = New System.Drawing.Size(187, 27)
        Me.product_name_search.TabIndex = 2
        '
        'code
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 514)
        Me.Controls.Add(Me.product_name_search)
        Me.Controls.Add(Me.checkgriddata)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "code"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "code"
        CType(Me.checkgriddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkgriddata As DataGridView
    Friend WithEvents product_name_search As TextBox
End Class
