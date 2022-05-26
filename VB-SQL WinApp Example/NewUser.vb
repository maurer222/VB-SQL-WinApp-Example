Public Class NewUser
    Public SQL As New SQLController

    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
    End Sub

    Private Sub InsertUser()
        'ADD SQL PARAMS & RUN THE COMMAND
        SQL.ExecuteQuery("SELECT MAX(id) FROM Users;")
        Dim idRow As DataRow = SQL.DBDataTable.Rows(0)
        SQL.AddParam("@user", TextBox_User.Text)
        SQL.AddParam("@pass", TextBox_Password.Text)
        SQL.AddParam("@active", CheckBox_Active.Checked)
        SQL.AddParam("@admin", CheckBox_Admin.Checked)
        SQL.AddParam("id", idRow(0) + 1)

        SQL.ExecuteQuery("INSERT INTO Users (Users, Password, Active, Admin, JoinDate, ID) " &
                         "VALUES (@user,@pass,@active,@admin,GETDATE(), @id);", True)

        'REPORT AND ABORT ON ERROR
        If SQL.HasException(True) Then Exit Sub

        MsgBox("User created successfully!")
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        InsertUser()

        'CLEAR FIELDS AFTER SAVE
        TextBox_User.Clear()
        TextBox_Password.Clear()
        CheckBox_Active.Checked = False
        CheckBox_Admin.Checked = False
        Button_Save.Enabled = False
    End Sub

    Private Sub TextBoxes_TextChanged(sender As Object, e As EventArgs) Handles TextBox_User.TextChanged, TextBox_Password.TextChanged
        'BASIC VALIDATION
        If Not String.IsNullOrWhiteSpace(TextBox_User.Text) AndAlso Not String.IsNullOrWhiteSpace(TextBox_Password.Text) Then
            Button_Save.Enabled = True
        End If
    End Sub
End Class