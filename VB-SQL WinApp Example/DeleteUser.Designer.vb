<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteUser
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
        Me.TextBox_Filter = New System.Windows.Forms.TextBox()
        Me.CheckedListBox_Users = New System.Windows.Forms.CheckedListBox()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_Filter
        '
        Me.TextBox_Filter.Location = New System.Drawing.Point(13, 13)
        Me.TextBox_Filter.Name = "TextBox_Filter"
        Me.TextBox_Filter.Size = New System.Drawing.Size(142, 20)
        Me.TextBox_Filter.TabIndex = 0
        '
        'CheckedListBox_Users
        '
        Me.CheckedListBox_Users.FormattingEnabled = True
        Me.CheckedListBox_Users.Location = New System.Drawing.Point(13, 39)
        Me.CheckedListBox_Users.Name = "CheckedListBox_Users"
        Me.CheckedListBox_Users.Size = New System.Drawing.Size(142, 199)
        Me.CheckedListBox_Users.TabIndex = 1
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(12, 244)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(143, 23)
        Me.Button_Delete.TabIndex = 2
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'DeleteUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 275)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.CheckedListBox_Users)
        Me.Controls.Add(Me.TextBox_Filter)
        Me.Name = "DeleteUser"
        Me.Text = "DeleteUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Filter As TextBox
    Friend WithEvents CheckedListBox_Users As CheckedListBox
    Friend WithEvents Button_Delete As Button
End Class
