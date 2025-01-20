Imports System.Data.SQLite

Public Module enterLog
    Dim databasePath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "disc.db")
    Dim connString As String = $"Data Source={databasePath};Version=3;"
    ' Method to log admin actions
    Public Sub LogActivity(uid As String, action As String, details As String, assetNum As String)
        Dim insertQuery As String = "INSERT INTO logs (uid, action, details, assetNum) VALUES (@uid, @action, @details, @assetNum)"

        Using connection As New SQLiteConnection(connString)
            connection.Open()
            Using command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@uid", uid)
                command.Parameters.AddWithValue("@action", action)
                command.Parameters.AddWithValue("@details", details)
                command.Parameters.AddWithValue("@assetNum", assetNum)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub


End Module
