Public Class EditUser

    Private SQL As New SQLController

    Private Sub FetchUsers()
        'REFRESH USERS LIST
        ListBox_Users.Items.Clear()

        'ADD PARAMS & RUN QUERY
        SQL.AddParam("@users", "%" & TextBox_Filter.Text & "%")
        SQL.ExecuteQuery("SELECT Users " &
                         "FROM Users " &
                         "WHERE Users LIKE @users " &
                         "ORDER BY Users ASC;")

        'REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        'LOOP ROWS & RETURN USERS TO LIST
        For Each r As DataRow In SQL.DBDataTable.Rows
            ListBox_Users.Items.Add(r("Users"))
        Next

    End Sub

    Private Sub GetUserDetails(Username As String)
        SQL.AddParam("@user", Username)
        SQL.ExecuteQuery("SELECT TOP 1 * " &
                         "FROM Users " &
                         "WHERE Users = @user;")

        If SQL.RecordCount < 1 Then Exit Sub

        'POPULATE USERS INFORMATION TO RESPECTIVE FIELDS
        For Each r As DataRow In SQL.DBDataTable.Rows
            TextBox_ID.Text = r("ID")
            TextBox_Username.Text = r("Users")
            TextBox_Password.Text = r("Password")
            CheckBox_Active.Checked = r("Active")
            CheckBox_Admin.Checked = r("Admin")
            TextBox_JoinDate.Text = r("JoinDate")
        Next
    End Sub

    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1

        FetchUsers()
    End Sub

    Private Sub TextBox_Filter_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Filter.KeyDown
        'ENTER KEY WILL PERFORM SEARCH FROM THE FILTER TEXTBOX
        If e.KeyCode = Keys.Enter Then
            FetchUsers()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub UpdateUser()
        'SET PARAMETERS AND EXECUTE QUERY
        SQL.AddParam("@pass", TextBox_Password.Text)
        SQL.AddParam("@active", CheckBox_Active.Checked)
        SQL.AddParam("@admin", CheckBox_Admin.Checked)
        SQL.AddParam("@id", TextBox_ID.Text)
        SQL.ExecuteQuery("UPDATE Users " &
                         "SET Password=@pass, Active=@active, Admin=@admin " &
                         "WHERE ID=@id;")

        'REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        MsgBox("User has been updated.")
    End Sub

    Private Sub ListBox_Users_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Users.SelectedIndexChanged
        GetUserDetails(ListBox_Users.Text)
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        UpdateUser()
    End Sub
End Class