Imports System.Data.SQLite

Module retrieveLog
    Dim connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.db;Version=3;BusyTimeout=5000;"
    Public Function GetLogs() As DataTable
        Dim selectQuery As String = "SELECT * FROM logs ORDER BY timestamp DESC"
        Dim dataTable As New DataTable()

        ' Manually define the columns
        dataTable.Columns.Add("No.", GetType(Integer))
        dataTable.Columns.Add("Action", GetType(String))
        dataTable.Columns.Add("Timestamp", GetType(DateTime))
        dataTable.Columns.Add("Details", GetType(String))

        Using connection As New SQLiteConnection(connString)
            connection.Open()

            ' Create a command to execute the query
            Using command As New SQLiteCommand(selectQuery, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    ' Read data and populate the DataTable
                    While reader.Read()
                        ' Create a new row
                        Dim newRow As DataRow = dataTable.NewRow()

                        ' Populate the row with values
                        newRow("No.") = reader("logID")
                        newRow("Action") = reader("action")
                        newRow("Timestamp") = reader("timestamp")
                        newRow("Details") = reader("details")
                        ' Add the row to the DataTable
                        dataTable.Rows.Add(newRow)
                    End While
                End Using
            End Using
        End Using

        Return dataTable
    End Function

End Module
