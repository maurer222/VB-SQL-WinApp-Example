<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.Button_Search = New System.Windows.Forms.Button()
        Me.TextBox_Inventory = New System.Windows.Forms.TextBox()
        Me.DataGrid_InventoryData = New System.Windows.Forms.DataGridView()
        Me.Combo_Items = New System.Windows.Forms.ComboBox()
        CType(Me.DataGrid_InventoryData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Search
        '
        Me.Button_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Search.Location = New System.Drawing.Point(161, 13)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(75, 23)
        Me.Button_Search.TabIndex = 0
        Me.Button_Search.Text = "Seach"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'TextBox_Inventory
        '
        Me.TextBox_Inventory.Location = New System.Drawing.Point(12, 15)
        Me.TextBox_Inventory.Name = "TextBox_Inventory"
        Me.TextBox_Inventory.Size = New System.Drawing.Size(143, 20)
        Me.TextBox_Inventory.TabIndex = 1
        '
        'DataGrid_InventoryData
        '
        Me.DataGrid_InventoryData.AllowUserToAddRows = False
        Me.DataGrid_InventoryData.AllowUserToDeleteRows = False
        Me.DataGrid_InventoryData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid_InventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_InventoryData.Location = New System.Drawing.Point(13, 42)
        Me.DataGrid_InventoryData.Name = "DataGrid_InventoryData"
        Me.DataGrid_InventoryData.ReadOnly = True
        Me.DataGrid_InventoryData.Size = New System.Drawing.Size(846, 203)
        Me.DataGrid_InventoryData.TabIndex = 2
        '
        'Combo_Items
        '
        Me.Combo_Items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Items.FormattingEnabled = True
        Me.Combo_Items.Location = New System.Drawing.Point(272, 13)
        Me.Combo_Items.Name = "Combo_Items"
        Me.Combo_Items.Size = New System.Drawing.Size(151, 21)
        Me.Combo_Items.TabIndex = 3
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 257)
        Me.Controls.Add(Me.Combo_Items)
        Me.Controls.Add(Me.DataGrid_InventoryData)
        Me.Controls.Add(Me.TextBox_Inventory)
        Me.Controls.Add(Me.Button_Search)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        CType(Me.DataGrid_InventoryData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Search As Button
    Friend WithEvents TextBox_Inventory As TextBox
    Friend WithEvents DataGrid_InventoryData As DataGridView
    Friend WithEvents Combo_Items As ComboBox
End Class
