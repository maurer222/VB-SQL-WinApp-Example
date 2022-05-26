Imports System.Data.SqlClient
Public Class SQLController
    'HARD CODED USER NAME AND PASSWORD FOR EXAMPLE PURPOSES ONLY
    Private DBConnection As New SqlConnection("Server=DESKTOP-9S3EALC\SQLEXPRESS;Database=VB.NET-TEST-SERVER;User=TEST-LIMITED;Pwd=12345678")
    Private DBCommand As SqlCommand

    'DB DATA
    Public DBDataAdapter As SqlDataAdapter
    Public DBDataTable As DataTable

    'QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)

    'QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    'ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ConnectionString As String)
        DBConnection = New SqlConnection(ConnectionString)
    End Sub

    'EXECUTE QUERY SUB
    Public Sub ExecuteQuery(Query As String, Optional ReturnIdentity As Boolean = False)
        'RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            DBConnection.Open()

            'CREATE DB COMMAND
            DBCommand = New SqlCommand(Query, DBConnection)

            'LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCommand.Parameters.Add(p))

            'CLEAR PARAM LIST
            Params.Clear()

            'EXECUTE COMMAND & FILL DATASET
            DBDataTable = New DataTable
            DBDataAdapter = New SqlDataAdapter(DBCommand)
            RecordCount = DBDataAdapter.Fill(DBDataTable)

            If ReturnIdentity = True Then
                Dim ReturnQuery As String = "SELECT @@IDENTITY As LastID;"
                DBCommand = New SqlCommand(ReturnQuery, DBConnection)
                DBDataTable = New DataTable
                DBDataAdapter = New SqlDataAdapter(DBCommand)
                RecordCount = DBDataAdapter.Fill(DBDataTable)
            End If

        Catch ex As Exception
            'CAPTURE ERRORS
            Exception = "Execute query error: " & vbNewLine & ex.Message

        Finally
            'CLOSE CONNECTION
            If DBConnection.State = ConnectionState.Open Then DBConnection.Close()

        End Try
    End Sub

    'ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    'ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception: ")
        Return True
    End Function

End Class
