Imports MySqlConnector

Module DatabaseConnection
    Public Function GetConnection() As MySqlConnection
        Dim connStr As String = "Server=localhost;Database=dbcamping;Uid=root;Pwd=;"
        Return New MySqlConnection(connStr)
    End Function
End Module