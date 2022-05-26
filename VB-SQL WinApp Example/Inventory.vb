Public Class Inventory
    Public SQL As New SQLController

    'GRAB ALL DATA FROM InventoryControl TABLE AND DISPLAY IN FORM DATAGRID
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecuteQuery("SELECT * FROM InventoryControl;")
        Else
            SQL.ExecuteQuery(Query)
        End If

        'ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

        DataGrid_InventoryData.DataSource = SQL.DBDataTable
    End Sub

    Private Sub LoadComboBox()
        'REFRESH COMBOBOX
        Combo_Items.Items.Clear()

        'RUN QUERY
        SQL.ExecuteQuery("SELECT Name FROM EmployeeInformation ORDER BY Name ASC")

        If SQL.HasException(True) Then Exit Sub

        'LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In SQL.DBDataTable.Rows
            Combo_Items.Items.Add(r("Name".ToString))
        Next
    End Sub

    Private Sub FindItem()
        SQL.AddParam("@item", "%" & TextBox_Inventory.Text & "%")
        LoadGrid("SELECT * FROM InventoryControl WHERE Name LIKE @item;")
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        LoadGrid()
        LoadComboBox()
    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        FindItem()
    End Sub
End Class