<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin_panel_one
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminHomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogdataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentdatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductLogToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesHomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TokenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReprintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminHomeToolStripMenuItem, Me.SalesHomeToolStripMenuItem, Me.ProductManagementToolStripMenuItem, Me.RechargeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1201, 30)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminHomeToolStripMenuItem
        '
        Me.AdminHomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogdataToolStripMenuItem, Me.StudentdatabaseToolStripMenuItem, Me.ProductLogToolStripMenuItem1})
        Me.AdminHomeToolStripMenuItem.Name = "AdminHomeToolStripMenuItem"
        Me.AdminHomeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AdminHomeToolStripMenuItem.ShowShortcutKeys = False
        Me.AdminHomeToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.AdminHomeToolStripMenuItem.Text = "AdminHome"
        '
        'LogdataToolStripMenuItem
        '
        Me.LogdataToolStripMenuItem.Name = "LogdataToolStripMenuItem"
        Me.LogdataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogdataToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.LogdataToolStripMenuItem.Text = "Log_data"
        '
        'StudentdatabaseToolStripMenuItem
        '
        Me.StudentdatabaseToolStripMenuItem.Name = "StudentdatabaseToolStripMenuItem"
        Me.StudentdatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StudentdatabaseToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.StudentdatabaseToolStripMenuItem.Text = "student_database"
        '
        'ProductLogToolStripMenuItem1
        '
        Me.ProductLogToolStripMenuItem1.Name = "ProductLogToolStripMenuItem1"
        Me.ProductLogToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProductLogToolStripMenuItem1.Size = New System.Drawing.Size(258, 26)
        Me.ProductLogToolStripMenuItem1.Text = "ProductLog"
        '
        'SalesHomeToolStripMenuItem
        '
        Me.SalesHomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillingToolStripMenuItem, Me.GuestToolStripMenuItem, Me.TokenToolStripMenuItem, Me.ReprintToolStripMenuItem})
        Me.SalesHomeToolStripMenuItem.Name = "SalesHomeToolStripMenuItem"
        Me.SalesHomeToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.SalesHomeToolStripMenuItem.Text = "SalesHome"
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'GuestToolStripMenuItem
        '
        Me.GuestToolStripMenuItem.Name = "GuestToolStripMenuItem"
        Me.GuestToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuestToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.GuestToolStripMenuItem.Text = "Guest"
        '
        'TokenToolStripMenuItem
        '
        Me.TokenToolStripMenuItem.Name = "TokenToolStripMenuItem"
        Me.TokenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TokenToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.TokenToolStripMenuItem.Text = "Token"
        '
        'ReprintToolStripMenuItem
        '
        Me.ReprintToolStripMenuItem.Name = "ReprintToolStripMenuItem"
        Me.ReprintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ReprintToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.ReprintToolStripMenuItem.Text = "Reprint"
        '
        'ProductManagementToolStripMenuItem
        '
        Me.ProductManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesDateToolStripMenuItem, Me.ProductDataToolStripMenuItem})
        Me.ProductManagementToolStripMenuItem.Name = "ProductManagementToolStripMenuItem"
        Me.ProductManagementToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.ProductManagementToolStripMenuItem.Text = "ProductManagement"
        '
        'SalesDateToolStripMenuItem
        '
        Me.SalesDateToolStripMenuItem.Name = "SalesDateToolStripMenuItem"
        Me.SalesDateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SalesDateToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.SalesDateToolStripMenuItem.Text = "Sales_Data"
        '
        'ProductDataToolStripMenuItem
        '
        Me.ProductDataToolStripMenuItem.Name = "ProductDataToolStripMenuItem"
        Me.ProductDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ProductDataToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ProductDataToolStripMenuItem.Text = "Product_Data"
        '
        'RechargeToolStripMenuItem
        '
        Me.RechargeToolStripMenuItem.Name = "RechargeToolStripMenuItem"
        Me.RechargeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RechargeToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.RechargeToolStripMenuItem.Text = "Recharge"
        '
        'admin_panel_one
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1201, 959)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimizeBox = False
        Me.Name = "admin_panel_one"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_panel_one"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminHomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogdataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentdatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesHomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RechargeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductLogToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TokenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReprintToolStripMenuItem As ToolStripMenuItem
End Class
