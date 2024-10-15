﻿Imports System.Data.SQLite

Public Class frmUpdate
    Dim connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.db;Version=3;BusyTimeout=3000;"
    Dim connection As New SQLiteConnection(connString)
    Dim allOffice As New List(Of String)
    Private adminUser As List(Of String)
    ' Constructor to accept the previous form as a parameter
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Show the previous form
        frmAdminMenu.Show()
        ' Close the current form
        Me.Hide()
    End Sub
    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf frmUpdate_FormClosing
        adminUser = retrieveUID.GetadminUser()
        ' Check if the current user is an admin
        If Not adminUser.Contains(GlobalVariables.currentUser) Then
            MessageBox.Show("Access denied. Only authorized users can access this page.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' Optionally redirect to login form or close the admin page
            Me.Close()

            ' Show the login form again
            Dim loginForm As New frmALogin(frmHome)
            loginForm.Show()
        End If
        ' Enable the form to capture key events even when controls are focused
        Me.KeyPreview = True
        txtAssetNum.Select()
        LoadComboBoxData()
    End Sub
    'Function to prevent admin close the window without logging out
    Private Sub frmUpdate_FormClosing(sender As Object, e As FormClosingEventArgs)
        ' Assuming you have a global variable like `isAdminLoggedIn` to check if admin is logged in
        If adminUser.Contains(GlobalVariables.currentUser) Then
            ' Display a confirmation message
            Dim result As DialogResult = MessageBox.Show("You are still logged in as an admin. Please log out before closing the application.", "Logout Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Cancel the closing event
            e.Cancel = True
        End If
    End Sub
    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Dim assetNum = txtAssetNum.Text.Trim
        If String.IsNullOrEmpty(assetNum) Then
            MessageBox.Show("Please enter an asset number.")
            Return
        End If

        Try
            Using connection As New SQLiteConnection(connString)
                connection.Open()
                Dim sql = "Select a.assetNum, a.assetStatus, a.assetType, a.assetSAP, o.officeName FROM asset a INNER Join office o ON a.officeID = o.officeID WHERE a.assetNum = @assetNum;"
                Using command As New SQLiteCommand(sql, connection)
                    command.Parameters.AddWithValue("@assetNum", assetNum)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            cboType.Text = reader("assetType").ToString
                            chkStatus.Checked = Convert.ToBoolean(reader("assetStatus"))
                            txtSAP.Text = reader("assetSAP").ToString()
                            cboOffice.Text = reader("officeName").ToString()
                        Else
                            MessageBox.Show("Asset not found. Please check the asset number.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim assetNum As String = txtAssetNum.Text.Trim()
        Dim assetType As String = cboType.Text.Trim()
        Dim status As Boolean = chkStatus.Checked
        Dim sap As String = txtSAP.Text.Trim()
        Dim officeLocation As String = cboOffice.Text.Trim()

        Dim Sql As String = "UPDATE asset SET assetType = @assetType, assetStatus = @status, assetSAP = @sap, officeID = (SELECT officeID FROM office WHERE officeName = @officeLocation) WHERE assetNum = @assetNum;"

        Try
            Using connection As New SQLiteConnection(connString)
                connection.Open()
                Using transaction As SQLiteTransaction = connection.BeginTransaction()
                    Using command As New SQLiteCommand(Sql, connection, transaction)
                        command.Parameters.AddWithValue("@assetType", assetType)
                        command.Parameters.AddWithValue("@status", status)
                        command.Parameters.AddWithValue("@officeLocation", officeLocation)
                        command.Parameters.AddWithValue("@sap", sap)
                        command.Parameters.AddWithValue("@assetNum", assetNum)

                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            transaction.Commit() ' commit transaction before executing enterLog.LogActivity
                            enterLog.LogActivity("Update", $"'{GlobalVariables.currentUser}' updated asset '{assetNum}' ")
                            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
                            MessageBox.Show("Asset updated successfully!")
                        Else
                            MessageBox.Show("No asset found with the given asset number.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadComboBoxData()
        Try
            Using connection As New SQLiteConnection(connString)
                connection.Open()

                ' Query to select all the item names from the Items table
                Dim sql As String = "SELECT officeName FROM office"
                Using command As New SQLiteCommand(sql, connection)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim officeName As String = reader("officeName").ToString()
                            allOffice.Add(officeName) ' Store items in the list for filtering
                        End While
                    End Using
                End Using
            End Using

            ' Add all items to the ComboBox initially
            cboOffice.Items.AddRange(allOffice.ToArray())
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub
    Private Sub cboOffice_TextUpdate(sender As Object, e As EventArgs) Handles cboOffice.TextUpdate
        ' Get the current input from the ComboBox
        Dim searchText = cboOffice.Text.Trim

        ' Clear the current items
        cboOffice.Items.Clear

        ' Filter the items that match the search text
        Dim filteredItems = allOffice.Where(Function(item) item.ToLower.Contains(searchText.ToLower)).ToArray

        ' Populate the ComboBox with the filtered items
        cboOffice.Items.AddRange(filteredItems)

        ' Open the drop-down list to show the filtered results
        cboOffice.DroppedDown = True
        ' Set the cursor to the end of the text to avoid resetting
        cboOffice.SelectionStart = cboOffice.Text.Length
    End Sub
    'Private Sub txtOfficeLoc_KeyDown(sender As Object, e As KeyEventArgs)
    ' Check if the "Enter" key is pressed while focused on txtUsername
    '    If e.KeyCode = Keys.Enter Then
    '        btnUpdate.PerformClick() ' Simulate a click on btnLogin
    '    End If
    'End Sub

    Private Sub txtAssetNum_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAssetNum.KeyDown
        ' Check if the "Enter" key is pressed while focused on txtSearch
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick ' Simulate a click on btnSearch
        End If
    End Sub

    Private Sub btnSearch_MouseHover(sender As Object, e As EventArgs) Handles btnSearch.MouseHover
        btnSearch.BackColor = Color.DarkOrange
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.BackColor = Color.Orange
    End Sub

    Private Sub btnUpdate_MouseHover(sender As Object, e As EventArgs) Handles btnUpdate.MouseHover
        btnUpdate.BackColor = Color.DarkOrange
    End Sub
    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.BackColor = Color.Orange
    End Sub

    Private Sub btnView_MouseHover(sender As Object, e As EventArgs) Handles btnView.MouseHover
        btnView.BackColor = Color.DarkOrange
    End Sub
    Private Sub btnView_MouseLeave(sender As Object, e As EventArgs) Handles btnView.MouseLeave
        btnView.BackColor = Color.Orange
    End Sub
    Private Sub btnRegister_MouseHover(sender As Object, e As EventArgs) Handles btnRegister.MouseHover
        btnRegister.BackColor = Color.DarkOrange
    End Sub
    Private Sub btnRegister_MouseLeave(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        btnRegister.BackColor = Color.Orange
    End Sub

    Private Sub btnDelete_MouseHover(sender As Object, e As EventArgs) Handles btnDelete.MouseHover
        btnDelete.BackColor = Color.DarkOrange
    End Sub
    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        btnDelete.BackColor = Color.Orange
    End Sub

    Private Sub btnLogout_MouseHover(sender As Object, e As EventArgs) Handles btnLogout.MouseHover
        btnLogout.BackColor = Color.DarkRed
    End Sub
    Private Sub btnLogout_MouseLeave(sender As Object, e As EventArgs) Handles btnLogout.MouseLeave
        btnLogout.BackColor = Color.OrangeRed
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Optional: Ask for logout confirmation
        Dim confirmLogout As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmLogout = DialogResult.Yes Then
            enterLog.LogActivity("Logout", $"'{GlobalVariables.currentUser}' logged out successfully.")
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
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim frm4 As New frmDelete()
        frm4.Show()
        Me.Hide()
    End Sub
End Class