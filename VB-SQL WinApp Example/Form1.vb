Public Class Form1

    Private Sub MenuItem_Inventory_Click(sender As Object, e As EventArgs) Handles MenuItem_Inventory.Click
        Inventory.Show()
    End Sub

    Private Sub MenuStrip_User_Add_Click(sender As Object, e As EventArgs) Handles MenuStrip_User_Add.Click
        NewUser.Show()
    End Sub

    Private Sub MenuStrip_User_Edit_Click(sender As Object, e As EventArgs) Handles MenuStrip_User_Edit.Click
        EditUser.Show()
    End Sub

    Private Sub MenuStrip_User_Delete_Click(sender As Object, e As EventArgs) Handles MenuStrip_User_Delete.Click
        DeleteUser.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
