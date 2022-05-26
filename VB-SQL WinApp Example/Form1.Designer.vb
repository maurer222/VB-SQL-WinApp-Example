<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MS_Main = New System.Windows.Forms.MenuStrip()
        Me.MenuItem_Inventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_User = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_User_Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_User_Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_User_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'MS_Main
        '
        Me.MS_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_Inventory, Me.MenuItem_User})
        Me.MS_Main.Location = New System.Drawing.Point(0, 0)
        Me.MS_Main.Name = "MS_Main"
        Me.MS_Main.Size = New System.Drawing.Size(1147, 24)
        Me.MS_Main.TabIndex = 1
        Me.MS_Main.Text = "MenuStrip1"
        '
        'MenuItem_Inventory
        '
        Me.MenuItem_Inventory.Name = "MenuItem_Inventory"
        Me.MenuItem_Inventory.Size = New System.Drawing.Size(69, 20)
        Me.MenuItem_Inventory.Text = "Inventory"
        '
        'MenuItem_User
        '
        Me.MenuItem_User.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStrip_User_Add, Me.MenuStrip_User_Edit, Me.MenuStrip_User_Delete})
        Me.MenuItem_User.Name = "MenuItem_User"
        Me.MenuItem_User.Size = New System.Drawing.Size(47, 20)
        Me.MenuItem_User.Text = "Users"
        '
        'MenuStrip_User_Add
        '
        Me.MenuStrip_User_Add.Name = "MenuStrip_User_Add"
        Me.MenuStrip_User_Add.Size = New System.Drawing.Size(180, 22)
        Me.MenuStrip_User_Add.Text = "Add"
        '
        'MenuStrip_User_Edit
        '
        Me.MenuStrip_User_Edit.Name = "MenuStrip_User_Edit"
        Me.MenuStrip_User_Edit.Size = New System.Drawing.Size(180, 22)
        Me.MenuStrip_User_Edit.Text = "Edit "
        '
        'MenuStrip_User_Delete
        '
        Me.MenuStrip_User_Delete.Name = "MenuStrip_User_Delete"
        Me.MenuStrip_User_Delete.Size = New System.Drawing.Size(180, 22)
        Me.MenuStrip_User_Delete.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 531)
        Me.Controls.Add(Me.MS_Main)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MS_Main
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MS_Main.ResumeLayout(False)
        Me.MS_Main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MS_Main As MenuStrip
    Friend WithEvents MenuItem_User As ToolStripMenuItem
    Friend WithEvents MenuItem_Inventory As ToolStripMenuItem
    Friend WithEvents MenuStrip_User_Add As ToolStripMenuItem
    Friend WithEvents MenuStrip_User_Edit As ToolStripMenuItem
    Friend WithEvents MenuStrip_User_Delete As ToolStripMenuItem
End Class
