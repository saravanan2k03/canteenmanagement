<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class student_db
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
        Me.Add_data = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Reset_Password_To_All = New System.Windows.Forms.Button()
        Me.import = New System.Windows.Forms.Button()
        Me.refu = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.Location = New System.Drawing.Point(64, 148)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1093, 508)
        Me.DataGridView1.TabIndex = 0
        '
        'Add_data
        '
        Me.Add_data.Location = New System.Drawing.Point(170, 55)
        Me.Add_data.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Add_data.Name = "Add_data"
        Me.Add_data.Size = New System.Drawing.Size(137, 55)
        Me.Add_data.TabIndex = 1
        Me.Add_data.Text = "Add"
        Me.Add_data.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(522, 56)
        Me.Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(149, 53)
        Me.Search.TabIndex = 2
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(314, 68)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(182, 32)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'Reset_Password_To_All
        '
        Me.Reset_Password_To_All.Location = New System.Drawing.Point(867, 53)
        Me.Reset_Password_To_All.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Reset_Password_To_All.Name = "Reset_Password_To_All"
        Me.Reset_Password_To_All.Size = New System.Drawing.Size(185, 56)
        Me.Reset_Password_To_All.TabIndex = 4
        Me.Reset_Password_To_All.Text = "Reset_Password_To_All"
        Me.Reset_Password_To_All.UseVisualStyleBackColor = True
        '
        'import
        '
        Me.import.Location = New System.Drawing.Point(689, 56)
        Me.import.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.import.Name = "import"
        Me.import.Size = New System.Drawing.Size(147, 53)
        Me.import.TabIndex = 5
        Me.import.Text = "Import"
        Me.import.UseVisualStyleBackColor = True
        '
        'refu
        '
        Me.refu.Location = New System.Drawing.Point(562, 670)
        Me.refu.Name = "refu"
        Me.refu.Size = New System.Drawing.Size(94, 29)
        Me.refu.TabIndex = 6
        Me.refu.Text = "Refresh"
        Me.refu.UseVisualStyleBackColor = True
        '
        'student_db
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 711)
        Me.Controls.Add(Me.refu)
        Me.Controls.Add(Me.import)
        Me.Controls.Add(Me.Reset_Password_To_All)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Add_data)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "student_db"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "student_db"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Add_data As Button
    Friend WithEvents Search As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Reset_Password_To_All As Button
    Friend WithEvents import As Button
    Friend WithEvents refu As Button
End Class
