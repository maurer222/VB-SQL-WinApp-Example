Public Class DeleteUser
    Private SQL As New SQLController

    Private Sub DeleteUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1

        FetchUsers()
    End Sub

    Private Sub FetchUsers()
        'REFRESH USER LIST
        CheckedListBox_Users.Items.Clear()

        'ADD PARAMS & RUN QUERY
        SQL.AddParam("@users", "%" & TextBox_Filter.Text & "%")
        SQL.ExecuteQuery("SELECT Users " &
                         "FROM Users " &
                         "WHERE Users LIKE @users " &
                         "ORDER BY Users Asc;")

        'LOOP ROWS & RETURN USERS TO THE LIST
        For Each row As DataRow In SQL.DBDataTable.Rows
            CheckedListBox_Users.Items.Add(row("Users"))
        Next
    End Sub

    Private Sub DeleteUsers()
        If MsgBox("The selected users will be deleted. Are you sure you wish to continue?", MsgBoxStyle.YesNo, "Delete user?") = MsgBoxResult.Yes Then
            'GENERATE A MASS DELETE COMMAND
            Dim c As Integer 'UNIQUE ID FOR AUTO GENERATED NUMBERS
            Dim DelString As String = "" 'QUERY STRING BUILDER

            For Each i As String In CheckedListBox_Users.CheckedItems
                SQL.AddParam("@user" & c, i)
                DelString += "DELETE FROM Users WHERE Users=@user" & c & ";"
                c += 1
            Next

            SQL.ExecuteQuery(DelString)

            'REPORT & ABORT ON ERRORS
            If SQL.HasException(True) Then Exit Sub

            'REPORT SUCCESS
            MsgBox("The selected users have been deleted successfully.")

            'REFRESH USER LIST
            FetchUsers()
        End If
    End Sub

    Private Sub TextBox_Filter_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Filter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchUsers()
            e.Handled = True
            e.SuppressKeyPress = True 'SUPPRESS DING NOISE
        End If
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If CheckedListBox_Users.CheckedItems.Count > 0 Then DeleteUsers()
    End Sub
End Class