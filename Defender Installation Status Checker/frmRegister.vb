﻿Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmRegister
    Dim connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.db;Version=3;"
    Dim allOffice As New List(Of String)
    Private adminUser As List(Of String)

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf frmRegister_FormClosing
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
        cboType.Items.Add("PC")
        cboType.Items.Add("Laptop")
        txtAssetNum.Select()
        LoadComboBoxData()
    End Sub
    'Function to prevent admin close the window without logging out
    Private Sub frmRegister_FormClosing(sender As Object, e As FormClosingEventArgs)
        ' Assuming you have a global variable like `isAdminLoggedIn` to check if admin is logged in
        If adminUser.Contains(GlobalVariables.currentUser) Then
            ' Display a confirmation message
            Dim result As DialogResult = MessageBox.Show("You are still logged in as an admin. Please log out before closing the application.", "Logout Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Cancel the closing event
            e.Cancel = True
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Show the previous form
        frmAdminMenu.Show()
        ' Close the current form
        Me.Hide()
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
        Dim searchText As String = cboOffice.Text.Trim()

        ' Clear the current items
        cboOffice.Items.Clear()

        ' Filter the items that match the search text
        Dim filteredItems = allOffice.Where(Function(item) item.ToLower().Contains(searchText.ToLower())).ToArray()

        ' Populate the ComboBox with the filtered items
        cboOffice.Items.AddRange(filteredItems)

        ' Open the drop-down list to show the filtered results
        cboOffice.DroppedDown = True
        ' Set the cursor to the end of the text to avoid resetting
        cboOffice.SelectionStart = cboOffice.Text.Length
    End Sub
    Private Sub btnRegister_MouseHover(sender As Object, e As EventArgs) Handles btnRegister.MouseHover
        btnRegister.BackColor = Color.DarkOrange
    End Sub
    Private Sub btnRegister_MouseLeave(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        btnRegister.BackColor = Color.Orange
    End Sub

    Private Sub btnView_MouseHover(sender As Object, e As EventArgs) Handles btnView.MouseHover
        btnView.BackColor = Color.DarkOrange
    End Sub
    Private Sub btnView_MouseLeave(sender As Object, e As EventArgs) Handles btnView.MouseLeave
        btnView.BackColor = Color.Orange
    End Sub

    Private Sub btnUpdate_MouseHover(sender As Object, e As EventArgs) Handles btnUpdate.MouseHover
        btnUpdate.BackColor = Color.DarkOrange
    End Sub
    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.BackColor = Color.Orange
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
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validate input
        If txtAssetNum.Text = "" Or cboType.Text = "" Or cboOffice.Text = "" Or txtSAP.Text = "" Then
            MessageBox.Show("Please fill out all required fields.")
            Exit Sub
        End If

        Dim assetTypeS As String = cboType.SelectedItem.ToString()
        Dim statVal As Integer = If(chkStatus.Checked, 1, 0)
        Dim office As String = cboOffice.SelectedItem.ToString()

        ' Prepare SQLite query
        Dim sql As String = "INSERT INTO asset (assetNum, assetType, assetStatus, assetSAP, officeID) 
                             VALUES (@assetNum, @assetType, @statVal, @assetSAP, (SELECT officeID FROM office WHERE officeName = @officeName));"

        Try
            Using connection As New SQLiteConnection(connString)
                connection.Open()
                Using command As New SQLiteCommand(sql, connection)
                    ' Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@assetNum", txtAssetNum.Text.Trim())
                    command.Parameters.AddWithValue("@assetType", assetTypeS)
                    command.Parameters.AddWithValue("@statVal", statVal)
                    command.Parameters.AddWithValue("@assetSAP", txtSAP.Text.Trim())
                    command.Parameters.AddWithValue("@officeName", office)

                    ' Execute the insert
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        enterLog.LogActivity("Registration", $"'{GlobalVariables.currentUser}' registered asset '{txtAssetNum.Text.Trim()}' ")
                        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
                        MessageBox.Show("Asset registered successfully!")
                    Else
                        MessageBox.Show("Asset already existed!")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
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
End Class