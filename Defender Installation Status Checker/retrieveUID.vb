Imports System.Data.SQLite

Module retrieveUID
    Dim connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.db;Version=3;"

    ' Function to get admin usernames from the database
    Public Function GetadminUser() As List(Of String)
        Dim adminUser As New List(Of String)()

        Try
            Using connection As New SQLiteConnection(connString)
                connection.Open()

                ' Query to select all admin usernames
                Dim sql As String = "SELECT uid FROM admin"
                Using command As New SQLiteCommand(sql, connection)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        While reader.Read()
                            adminUser.Add(reader("uid").ToString()) ' Populate the admin usernames list
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading admin usernames: " & ex.Message)
        End Try

        Return adminUser
    End Function
End Module
