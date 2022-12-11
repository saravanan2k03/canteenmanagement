<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class token
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
        Me.tokengrid = New System.Windows.Forms.DataGridView()
        Me.Refresh = New System.Windows.Forms.Button()
        CType(Me.tokengrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tokengrid
        '
        Me.tokengrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tokengrid.Location = New System.Drawing.Point(2, 1)
        Me.tokengrid.Name = "tokengrid"
        Me.tokengrid.RowHeadersWidth = 51
        Me.tokengrid.RowTemplate.Height = 29
        Me.tokengrid.Size = New System.Drawing.Size(308, 493)
        Me.tokengrid.TabIndex = 0
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(80, 517)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(129, 35)
        Me.Refresh.TabIndex = 1
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'token
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 564)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.tokengrid)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "token"
        Me.Text = "token"
        CType(Me.tokengrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tokengrid As DataGridView
    Friend WithEvents Refresh As Button
End Class
