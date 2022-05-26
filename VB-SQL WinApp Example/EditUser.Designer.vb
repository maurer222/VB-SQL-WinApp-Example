<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUser
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
        Me.TextBox_Filter = New System.Windows.Forms.TextBox()
        Me.ListBox_Users = New System.Windows.Forms.ListBox()
        Me.GroupBox_UserDetails = New System.Windows.Forms.GroupBox()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.CheckBox_Admin = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Active = New System.Windows.Forms.CheckBox()
        Me.Text_Password = New System.Windows.Forms.Label()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.Text_Username = New System.Windows.Forms.Label()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Text_ID = New System.Windows.Forms.Label()
        Me.Text_JoinDate = New System.Windows.Forms.Label()
        Me.TextBox_JoinDate = New System.Windows.Forms.TextBox()
        Me.GroupBox_UserDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_Filter
        '
        Me.TextBox_Filter.Location = New System.Drawing.Point(12, 15)
        Me.TextBox_Filter.Name = "TextBox_Filter"
        Me.TextBox_Filter.Size = New System.Drawing.Size(203, 20)
        Me.TextBox_Filter.TabIndex = 0
        '
        'ListBox_Users
        '
        Me.ListBox_Users.FormattingEnabled = True
        Me.ListBox_Users.Location = New System.Drawing.Point(12, 48)
        Me.ListBox_Users.Name = "ListBox_Users"
        Me.ListBox_Users.Size = New System.Drawing.Size(203, 199)
        Me.ListBox_Users.TabIndex = 1
        '
        'GroupBox_UserDetails
        '
        Me.GroupBox_UserDetails.Controls.Add(Me.TextBox_JoinDate)
        Me.GroupBox_UserDetails.Controls.Add(Me.Text_JoinDate)
        Me.GroupBox_UserDetails.Controls.Add(Me.Button_Save)
        Me.GroupBox_UserDetails.Controls.Add(Me.CheckBox_Admin)
        Me.GroupBox_UserDetails.Controls.Add(Me.CheckBox_Active)
        Me.GroupBox_UserDetails.Controls.Add(Me.Text_Password)
        Me.GroupBox_UserDetails.Controls.Add(Me.TextBox_Password)
        Me.GroupBox_UserDetails.Controls.Add(Me.Text_Username)
        Me.GroupBox_UserDetails.Controls.Add(Me.TextBox_Username)
        Me.GroupBox_UserDetails.Controls.Add(Me.TextBox_ID)
        Me.GroupBox_UserDetails.Controls.Add(Me.Text_ID)
        Me.GroupBox_UserDetails.Location = New System.Drawing.Point(232, 15)
        Me.GroupBox_UserDetails.Name = "GroupBox_UserDetails"
        Me.GroupBox_UserDetails.Size = New System.Drawing.Size(246, 232)
        Me.GroupBox_UserDetails.TabIndex = 2
        Me.GroupBox_UserDetails.TabStop = False
        Me.GroupBox_UserDetails.Text = "User Details"
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(79, 203)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 8
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'CheckBox_Admin
        '
        Me.CheckBox_Admin.AutoSize = True
        Me.CheckBox_Admin.Location = New System.Drawing.Point(79, 132)
        Me.CheckBox_Admin.Name = "CheckBox_Admin"
        Me.CheckBox_Admin.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox_Admin.TabIndex = 7
        Me.CheckBox_Admin.Text = "Admin"
        Me.CheckBox_Admin.UseVisualStyleBackColor = True
        '
        'CheckBox_Active
        '
        Me.CheckBox_Active.AutoSize = True
        Me.CheckBox_Active.Location = New System.Drawing.Point(79, 109)
        Me.CheckBox_Active.Name = "CheckBox_Active"
        Me.CheckBox_Active.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox_Active.TabIndex = 6
        Me.CheckBox_Active.Text = "Active"
        Me.CheckBox_Active.UseVisualStyleBackColor = True
        '
        'Text_Password
        '
        Me.Text_Password.AutoSize = True
        Me.Text_Password.Location = New System.Drawing.Point(17, 85)
        Me.Text_Password.Name = "Text_Password"
        Me.Text_Password.Size = New System.Drawing.Size(56, 13)
        Me.Text_Password.TabIndex = 5
        Me.Text_Password.Text = "Password:"
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Location = New System.Drawing.Point(79, 82)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Password.TabIndex = 4
        Me.TextBox_Password.UseSystemPasswordChar = True
        '
        'Text_Username
        '
        Me.Text_Username.AutoSize = True
        Me.Text_Username.Location = New System.Drawing.Point(15, 59)
        Me.Text_Username.Name = "Text_Username"
        Me.Text_Username.Size = New System.Drawing.Size(58, 13)
        Me.Text_Username.TabIndex = 3
        Me.Text_Username.Text = "Username:"
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Location = New System.Drawing.Point(79, 56)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.ReadOnly = True
        Me.TextBox_Username.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Username.TabIndex = 2
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Location = New System.Drawing.Point(79, 30)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ID.TabIndex = 1
        '
        'Text_ID
        '
        Me.Text_ID.AutoSize = True
        Me.Text_ID.Location = New System.Drawing.Point(52, 33)
        Me.Text_ID.Name = "Text_ID"
        Me.Text_ID.Size = New System.Drawing.Size(21, 13)
        Me.Text_ID.TabIndex = 0
        Me.Text_ID.Text = "ID:"
        '
        'Text_JoinDate
        '
        Me.Text_JoinDate.AutoSize = True
        Me.Text_JoinDate.Location = New System.Drawing.Point(18, 172)
        Me.Text_JoinDate.Name = "Text_JoinDate"
        Me.Text_JoinDate.Size = New System.Drawing.Size(55, 13)
        Me.Text_JoinDate.TabIndex = 9
        Me.Text_JoinDate.Text = "Join Date:"
        '
        'TextBox_JoinDate
        '
        Me.TextBox_JoinDate.Location = New System.Drawing.Point(79, 169)
        Me.TextBox_JoinDate.Name = "TextBox_JoinDate"
        Me.TextBox_JoinDate.ReadOnly = True
        Me.TextBox_JoinDate.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_JoinDate.TabIndex = 10
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 262)
        Me.Controls.Add(Me.GroupBox_UserDetails)
        Me.Controls.Add(Me.ListBox_Users)
        Me.Controls.Add(Me.TextBox_Filter)
        Me.Name = "EditUser"
        Me.Text = "EditUser"
        Me.GroupBox_UserDetails.ResumeLayout(False)
        Me.GroupBox_UserDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Filter As TextBox
    Friend WithEvents ListBox_Users As ListBox
    Friend WithEvents GroupBox_UserDetails As GroupBox
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Text_ID As Label
    Friend WithEvents Text_Password As Label
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Text_Username As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents Button_Save As Button
    Friend WithEvents CheckBox_Admin As CheckBox
    Friend WithEvents CheckBox_Active As CheckBox
    Friend WithEvents TextBox_JoinDate As TextBox
    Friend WithEvents Text_JoinDate As Label
End Class
