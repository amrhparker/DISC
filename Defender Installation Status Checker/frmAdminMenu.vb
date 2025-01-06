Imports System.Data.SQLite

Public Class frmAdminMenu
    Private connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.db;Version=3;BusyTimeout=5000;"
    Private adminUser As List(Of String)

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim frm1 As New frmView()
        frm1.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim frm2 As New frmRegister()
        frm2.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim frm3 As New frmUpdate()
        frm3.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim frm4 As New frmDelete()
        frm4.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        Dim frm5 As New frmLogs()
        frm5.Show()
        Me.Hide()
    End Sub

    Private Sub frmAdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf frmAdminMenu_FormClosing
        adminUser = retrieveUID.GetadminUser()
        ' Check if the current user is an admin
        If Not IsUserAdmin(GlobalVariables.currentUser) Then
            MessageBox.Show("Access denied. Only admins can access this page.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' Optionally redirect to login form or close the admin page
            Me.Close()

            ' You can also show the login form again
            Dim loginForm As New frmALogin(frmHome)
            loginForm.Show()
        End If
    End Sub
    'Function to prevent admin close the window without logging out
    Private Sub frmAdminMenu_FormClosing(sender As Object, e As FormClosingEventArgs)
        ' Assuming you have a global variable like `isAdminLoggedIn` to check if admin is logged in
        If IsUserAdmin(GlobalVariables.currentUser) Then
            ' Display a confirmation message
            Dim result As DialogResult = MessageBox.Show("You are still logged in as an admin. Please log out before closing the application.", "Logout Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' Cancel the closing event
            e.Cancel = True
        End If
    End Sub

    ' Function to check if a user is an admin in the database
    Private Function IsUserAdmin(username As String) As Boolean
        Using connection As New SQLiteConnection(connString)
            Try
                connection.Open()

                ' SQL query to check if the user exists in the admin table
                Dim sql As String = "SELECT COUNT(*) FROM admin WHERE uid = @username"
                Using command As New SQLiteCommand(sql, connection)
                    command.Parameters.AddWithValue("@username", username)

                    ' Execute the query
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0 ' Return true if the user is found
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred while checking admin status: " & ex.Message)
            End Try
        End Using
        Return False ' Default to not admin if there's an error
    End Function

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Optional: Ask for logout confirmation
        Dim confirmLogout = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmLogout = DialogResult.Yes Then
            enterLog.LogActivity(GlobalVariables.currentUser, "Logout", $"'{GlobalVariables.currentUser}' logged out successfully.", "")
            ' Optional: Clear any session data here
            ' For example, clearing user-related data
            GlobalVariables.currentUser = ""
            GlobalVariables.currentPassword = ""
            ' Show the login form again 
            Dim loginForm As New frmALogin(frmHome)
            loginForm.Show()

            ' Close the current form completely
            Me.Close()
        End If
    End Sub
End Class