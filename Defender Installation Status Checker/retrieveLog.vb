Imports System.Data.SQLite

Module retrieveLog
    Dim connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.vb; Version=3;BusyTimeout=5000;"

    Public Function GetLogs() As DataTable
        Dim selectQuery As String = "SELECT * FROM logs ORDER BY timestamp DESC"
        Dim dataTable As New DataTable()

        dataTable.Columns.Add("Admin", GetType(String))
        dataTable.Columns.Add("Asset", GetType(String))
        dataTable.Columns.Add("Action", GetType(String))
        dataTable.Columns.Add("Timestamp", GetType(DateTime))
        dataTable.Columns.Add("Details", GetType(String))

        Using connection As New SQLiteConnection(connString)
            connection.Open()
            Using command As New SQLiteCommand(selectQuery, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim newRow As DataRow = dataTable.NewRow()
                        newRow("Admin") = reader("uid")
                        newRow("Asset") = reader("assetNum")
                        newRow("Action") = reader("action")
                        newRow("Timestamp") = reader("timestamp")
                        newRow("Details") = reader("details")
                        dataTable.Rows.Add(newRow)
                    End While
                End Using
            End Using
        End Using

        Return dataTable
    End Function
End Module
