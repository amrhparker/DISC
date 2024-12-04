Imports System.Data.SQLite
Imports System.Transactions

Public Class frmDelete
    Dim connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.db;Version=3;BusyTimeout=5000;"
    Dim connection As New SQLiteConnection(connString)
    Private adminUser As List(Of String)

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        ' Show the previous form
        frmAdminMenu.Show
        ' Close the current form
        Hide
    End Sub
    Private Sub frmDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf frmDelete_FormClosing
        adminUser = retrieveUID.GetadminUser()
        ' Check if the current user is the admin
        If Not adminUser.Contains(GlobalVariables.currentUser) Then
            MessageBox.Show("Access denied. Only the admin can access this page.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' Optionally redirect to login form or close the admin page
            Me.Close()

            ' You can also show the login form again
            Dim loginForm As New frmALogin(frmHome)
            loginForm.Show()
        End If
        txtAssetNum.Select()
    End Sub
    'Function to prevent admin close the window without logging out
    Private Sub frmDelete_FormClosing(sender As Object, e As FormClosingEventArgs)
        ' Assuming you have a global variable like `isAdminLoggedIn` to check if admin is logged in
        If adminUser.Contains(GlobalVariables.currentUser) Then
            ' Display a confirmation message
            Dim result As DialogResult = MessageBox.Show("You are still logged in as an admin. Please log out before closing the application.", "Logout Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Cancel the closing event
            e.Cancel = True
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim assetNum As String = txtAssetNum.Text.Trim() ' Get the search input

        Try
            Using connection As New SQLiteConnection(connString)
                connection.Open()

                Dim sql As String = "SELECT a.assetNum, a.assetStatus, a.assetSAP, l.locationName, o.officeName 
                                 FROM asset a 
                                 INNER JOIN office o ON a.officeID = o.officeID
                                 INNER JOIN location l ON o.locationID = l.locationID
                                 WHERE a.assetNum = @assetNum;"

                Using command As New SQLiteCommand(sql, connection)
                    command.Parameters.AddWithValue("@assetNum", assetNum)

                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Display the asset details
                            lblNum.Text = reader("assetNum").ToString()

                            If reader("assetStatus") = 1 Then
                                lblStatus.Text = "Installed"
                            ElseIf reader("assetStatus") = 0 Then
                                lblStatus.Text = "Not Installed"
                            End If
                            lblSAP.Text = reader("assetSAP").ToString
                            lblLoc.Text = reader("locationName").ToString()
                            lblOff.Text = reader("officeName").ToString()
                        Else
                            ' Handle case where asset is not found
                            lblNum.Text = "Not found"
                            lblStatus.Text = ""
                            lblSAP.Text = ""
                            lblLoc.Text = ""
                            lblOff.Text = ""
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to retrieve data: " & ex.Message)
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this asset?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            deleteAsset()
            MessageBox.Show("Asset deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' User clicked No, cancel the deletion
            MessageBox.Show("Deletion canceled.", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub deleteAsset()
        Dim assetNum As String = txtAssetNum.Text.Trim()
        Try
            Using connection As New SQLiteConnection(connString)
                connection.Open()

                ' Step 1: Delete the asset
                Using command1 As New SQLiteCommand("DELETE FROM asset WHERE assetNum = @assetNum;", connection)
                    command1.Parameters.AddWithValue("@assetNum", assetNum)
                    Dim rowsAffected As Integer = command1.ExecuteNonQuery()

                    ' Check if the asset was deleted
                    If rowsAffected > 0 Then
                        ' Step 2: Reset the AUTOINCREMENT value
                        Using command2 As New SQLiteCommand("UPDATE sqlite_sequence SET seq = (SELECT MAX(assetID) FROM asset) WHERE name = 'asset';", connection)
                            command2.ExecuteNonQuery()
                        End Using

                        ' Step 3: Perform VACUUM outside of the transaction
                        Using vacuumCommand As New SQLiteCommand("VACUUM;", connection)
                            vacuumCommand.ExecuteNonQuery()
                        End Using

                        enterLog.LogActivity(GlobalVariables.currentUser, "Delete", $"'{txtAssetNum.Text.Trim()}' is deleted from the database")
                        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
                        MessageBox.Show("Asset deleted successfully!")
                    Else
                        MessageBox.Show("Asset not found or already deleted.")
                    End If
                End Using
            End Using
            ' Show the previous form
            frmAdminMenu.Show()
            ' Close the current form
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub strView_Click(sender As Object, e As EventArgs) Handles strView.Click
        Dim frm1 As New frmView
        frm1.Show()
        Hide()
    End Sub

    Private Sub strUpdate_Click(sender As Object, e As EventArgs) Handles strUpdate.Click
        Dim frm2 As New frmUpdate
        frm2.Show()
        Hide()
    End Sub
    Private Sub strRegister_Click(sender As Object, e As EventArgs) Handles strRegister.Click
        MessageBox.Show("You are already on the page")
    End Sub
    Private Sub strDelete_Click(sender As Object, e As EventArgs) Handles strDelete.Click
        Dim frm4 As New frmDelete
        frm4.Show()
        Hide()
    End Sub
    Private Sub strHome_Click(sender As Object, e As EventArgs) Handles strHome.Click
        ' Show the previous form
        frmAdminMenu.Show()
        ' Close the current form
        Hide()
    End Sub

    Private Sub strLogs_Click(sender As Object, e As EventArgs) Handles strLogs.Click
        frmLogs.Show()
        Hide()
    End Sub
    Private Sub strLogout_Click(sender As Object, e As EventArgs) Handles strLogout.Click
        ' Optional: Ask for logout confirmation
        Dim confirmLogout = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmLogout = DialogResult.Yes Then
            enterLog.LogActivity(GlobalVariables.currentUser, "Logout", $"'{GlobalVariables.currentUser}' logged out successfully.")
            ' Optional: Clear any session data here
            ' For example, clearing user-related data
            currentUser = ""
            currentPassword = ""
            ' Show the login form again 
            Dim loginForm As New frmALogin(frmHome)
            loginForm.Show()

            ' Close the current form completely
            Close()
        End If
    End Sub
    Private Sub btnDelete_MouseHover(sender As Object, e As EventArgs) Handles btnDelete.MouseHover
        btnDelete.BackColor = Color.DarkOrange
    End Sub
    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        btnDelete.BackColor = Color.Orange
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class