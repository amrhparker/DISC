Imports System.Data.SQLite

Public Module enterLog
    Private connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.db;Version=3;BusyTimeout=5000;"

    ' Method to log admin actions
    Public Sub LogActivity(action As String, details As String)
        Dim insertQuery As String = "INSERT INTO logs (action, details) VALUES (@action, @details)"

        Using connection As New SQLiteConnection(connString)
            connection.Open()
            Using command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@action", action)
                command.Parameters.AddWithValue("@details", details)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub


End Module
