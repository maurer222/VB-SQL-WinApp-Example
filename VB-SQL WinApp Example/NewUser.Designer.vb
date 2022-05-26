<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewUser
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
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.TextBox_User = New System.Windows.Forms.TextBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.CheckBox_Active = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Admin = New System.Windows.Forms.CheckBox()
        Me.Label_User = New System.Windows.Forms.Label()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Save
        '
        Me.Button_Save.Enabled = False
        Me.Button_Save.Location = New System.Drawing.Point(87, 98)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(125, 32)
        Me.Button_Save.TabIndex = 0
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'TextBox_User
        '
        Me.TextBox_User.Location = New System.Drawing.Point(72, 23)
        Me.TextBox_User.Name = "TextBox_User"
        Me.TextBox_User.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_User.TabIndex = 1
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Location = New System.Drawing.Point(72, 51)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_Password.TabIndex = 2
        Me.TextBox_Password.UseSystemPasswordChar = True
        '
        'CheckBox_Active
        '
        Me.CheckBox_Active.AutoSize = True
        Me.CheckBox_Active.Location = New System.Drawing.Point(228, 26)
        Me.CheckBox_Active.Name = "CheckBox_Active"
        Me.CheckBox_Active.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox_Active.TabIndex = 3
        Me.CheckBox_Active.Text = "Active"
        Me.CheckBox_Active.UseVisualStyleBackColor = True
        '
        'CheckBox_Admin
        '
        Me.CheckBox_Admin.AutoSize = True
        Me.CheckBox_Admin.Location = New System.Drawing.Point(228, 51)
        Me.CheckBox_Admin.Name = "CheckBox_Admin"
        Me.CheckBox_Admin.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox_Admin.TabIndex = 4
        Me.CheckBox_Admin.Text = "Admin"
        Me.CheckBox_Admin.UseVisualStyleBackColor = True
        '
        'Label_User
        '
        Me.Label_User.AutoSize = True
        Me.Label_User.Location = New System.Drawing.Point(8, 26)
        Me.Label_User.Name = "Label_User"
        Me.Label_User.Size = New System.Drawing.Size(58, 13)
        Me.Label_User.TabIndex = 5
        Me.Label_User.Text = "Username:"
        '
        'Label_Password
        '
        Me.Label_Password.AutoSize = True
        Me.Label_Password.Location = New System.Drawing.Point(8, 54)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(56, 13)
        Me.Label_Password.TabIndex = 6
        Me.Label_Password.Text = "Password:"
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 143)
        Me.Controls.Add(Me.Label_Password)
        Me.Controls.Add(Me.Label_User)
        Me.Controls.Add(Me.CheckBox_Admin)
        Me.Controls.Add(Me.CheckBox_Active)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.TextBox_User)
        Me.Controls.Add(Me.Button_Save)
        Me.Name = "NewUser"
        Me.Text = "NewUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Save As Button
    Friend WithEvents TextBox_User As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents CheckBox_Active As CheckBox
    Friend WithEvents CheckBox_Admin As CheckBox
    Friend WithEvents Label_User As Label
    Friend WithEvents Label_Password As Label
End Class
