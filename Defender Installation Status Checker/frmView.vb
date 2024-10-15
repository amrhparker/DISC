Imports System.Data.SQLite
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class frmView
    Dim connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.db;Version=3;"
    Dim connection As New SQLiteConnection(connString)
    Private adminUser As List(Of String)
    Dim currentPage As Integer = 1
    Dim pageSize As Integer = 15 ' Number of items per page
    Dim offset As Integer = (currentPage - 1) * pageSize

    Dim totalRecords As Integer
    Dim totalPages As Integer

    Dim locID As Integer
    ' Add a boolean flag to track the sort order
    Dim ascending As Boolean = True

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Show the previous form
        frmAdminMenu.Show()
        ' Close the current form
        Me.Hide()
    End Sub

    Private Sub frmView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf frmView_FormClosing
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
        ' Set up the columns in the ListView
        ListView1.Columns.Add("Asset Number", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Asset SAP", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Asset Type", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Asset Status", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Office", 300, HorizontalAlignment.Center)
        ListView1.Columns.Add("State", 150, HorizontalAlignment.Center)

        ' Calculate the total records and pages when the form loads
        calculateTotalPages()

        ' Display the current page and total pages in the label
        lblPageInfo.Text = "Page " & currentPage & " of " & totalPages

        retrieveData()

        ' Set up ListView2 similarly
        ListView2.Columns.Add("Asset Number", 120, HorizontalAlignment.Center)
        ListView2.Columns.Add("Asset SAP", 120, HorizontalAlignment.Center)
        ListView2.Columns.Add("Asset Type", 50, HorizontalAlignment.Center)
        ListView2.Columns.Add("Asset Status", 100, HorizontalAlignment.Center)
        ListView2.Columns.Add("Office", 300, HorizontalAlignment.Center)
        ListView2.Columns.Add("State", 150, HorizontalAlignment.Center)
    End Sub
    'Function to prevent admin close the window without logging out
    Private Sub frmView_FormClosing(sender As Object, e As FormClosingEventArgs)
        ' Assuming you have a global variable like `isAdminLoggedIn` to check if admin is logged in
        If adminUser.Contains(GlobalVariables.currentUser) Then
            ' Display a confirmation message
            Dim result As DialogResult = MessageBox.Show("You are still logged in as an admin. Please log out before closing the application.", "Logout Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' Cancel the closing event
            e.Cancel = True
        End If
    End Sub
    Private Sub calculateTotalPages()
        Try
            connection.Open()
            ' Calculate total number of records
            Dim countCommand As New SQLiteCommand("SELECT COUNT(*) FROM asset", connection)
            totalRecords = Convert.ToInt32(countCommand.ExecuteScalar())

            ' Calculate total number of pages
            totalPages = Math.Ceiling(totalRecords / pageSize)

        Catch ex As Exception
            MessageBox.Show("Failed to calculate total pages: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        ' Check if Ctrl + C is pressed
        If e.Control AndAlso e.KeyCode = Keys.C Then
            ' Check if there is a selected item
            If ListView1.SelectedItems.Count > 0 Then
                ' Get the first selected item's subitem text (you can specify which subitem to copy)
                Dim selectedItem = ListView1.SelectedItems(0)
                Dim selectedSubItemText = selectedItem.SubItems(0).Text ' Change index for other subitems

                ' Copy the selected subitem text to clipboard
                Clipboard.SetText(selectedSubItemText)
            Else
                MessageBox.Show("Please select an item to copy.")
            End If
        End If
    End Sub

    Private Sub ListView2_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView2.KeyDown
        ' Check if Ctrl + C is pressed
        If e.Control AndAlso e.KeyCode = Keys.C Then
            ' Check if there is a selected item
            If ListView2.SelectedItems.Count > 0 Then
                ' Get the first selected item's subitem text (you can specify which subitem to copy)
                Dim selectedItem = ListView2.SelectedItems(0)
                Dim selectedSubItemText = selectedItem.SubItems(0).Text ' Change index for other subitems

                ' Copy the selected subitem text to clipboard
                Clipboard.SetText(selectedSubItemText)
            Else
                MessageBox.Show("Please select an item to copy.")
            End If
        End If
    End Sub

    Private Sub retrieveData()
        Try
            connection.Open()

            ' SQL Query with pagination
            Dim sql As String = "SELECT a.assetNum, a.assetType, a.assetStatus, a.assetSAP, o.officeName, l.locationName " &
                            "FROM asset a " &
                            "JOIN office o ON a.officeID = o.officeID " &
                            "JOIN location l ON o.locationID = l.locationID " &
                            "LIMIT @pageSize OFFSET @offset;"
            Dim command As New SQLiteCommand(sql, connection)
            command.Parameters.AddWithValue("@pageSize", pageSize)
            command.Parameters.AddWithValue("@offset", (currentPage - 1) * pageSize)

            Dim reader As SQLiteDataReader = command.ExecuteReader()

            ' Clear existing items in the ListView
            ListView1.Items.Clear()

            ' Loop through the data and add it to the ListView
            While reader.Read()
                Dim item As New ListViewItem(reader("assetNum").ToString())
                item.SubItems.Add(reader("assetSAP").ToString())
                item.SubItems.Add(reader("assetType").ToString())
                item.SubItems.Add(If(reader("assetStatus") = 1, "Installed", "Not Installed"))
                item.SubItems.Add(reader("officeName").ToString())
                item.SubItems.Add(reader("locationName").ToString())
                ListView1.Items.Add(item) ' Add the row to the ListView
            End While

        Catch ex As Exception
            MessageBox.Show("Failed to retrieve data: " & ex.Message)
        Finally
            connection.Close()
        End Try
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
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim assetNum = txtSearch.Text.Trim ' Get the search input

        Try
            connection.Open()
            Dim sql = "SELECT a.assetNum, a.assetStatus, a.assetType, a.assetSAP, l.locationName, o.officeName FROM asset a INNER JOIN office o ON a.officeID = o.officeID INNER JOIN location l ON o.locationID = l.locationID WHERE a.assetNum = @assetNum;"

            Dim command As New SQLiteCommand(sql, connection)
            command.Parameters.AddWithValue("@assetNum", assetNum)
            Dim reader = command.ExecuteReader

            ' Clear existing items in ListView2
            ListView2.Items.Clear()

            If reader.Read Then
                Dim item As New ListViewItem(reader("assetNum").ToString)
                item.SubItems.Add(reader("assetSAP").ToString())
                item.SubItems.Add(reader("assetType").ToString)
                item.SubItems.Add(If(reader("assetStatus") = 1, "Installed", "Not Installed"))
                item.SubItems.Add(reader("officeName").ToString)
                item.SubItems.Add(reader("locationName").ToString)

                ListView2.Items.Add(item) ' Add the row to the ListView
            Else
                Dim item As New ListViewItem("Not Found")
                item.SubItems.Add("-")
                item.SubItems.Add("-")
                item.SubItems.Add("-")
                item.SubItems.Add("-")
                item.SubItems.Add("-")

                ListView2.Items.Add(item) ' Add the row to the ListView
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to retrieve data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim frm1 As New frmUpdate()
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
    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        ' Toggle sort order when the same column is clicked
        If ListView1.ListViewItemSorter IsNot Nothing Then
            ascending = Not ascending
        Else
            ascending = True
        End If

        Dim sorter As New ListViewItemComparer(e.Column, ascending)
        ListView1.ListViewItemSorter = sorter
        ListView1.Sort()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' Recalculate total records and total pages
        connection.Open()
        Dim countCommand As New SQLiteCommand("SELECT COUNT(*) FROM asset", connection)
        totalRecords = Convert.ToInt32(countCommand.ExecuteScalar)
        totalPages = Math.Ceiling(totalRecords / pageSize)
        connection.Close()

        ' Move to the next page only if we haven't exceeded the total pages
        If currentPage < totalPages Then
            currentPage += 1
            retrieveData()
        Else
            MessageBox.Show("You are already on the last page.")
        End If
        ' Update the page info label after the page changes
        lblPageInfo.Text = "Page " & currentPage & " of " & totalPages
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ' Move to the previous page only if we're above the first page
        If currentPage > 1 Then
            currentPage -= 1
            retrieveData()
        Else
            MessageBox.Show("You are already on the first page.")
        End If

        ' Update the page info label after the page changes
        lblPageInfo.Text = "Page " & currentPage & " of " & totalPages
    End Sub
    Private Sub btnFirstPage_Click(sender As Object, e As EventArgs) Handles btnFirstPage.Click
        ' Navigate to the first page
        currentPage = 1
        retrieveData()

        ' Update the page info label
        lblPageInfo.Text = "Page " & currentPage & " of " & totalPages
    End Sub
    Private Sub btnLastPage_Click(sender As Object, e As EventArgs) Handles btnLastPage.Click
        Try
            ' Recalculate total records and total pages
            connection.Open()

            ' General query to get total records (remove location filtering if not needed)
            Dim countCommand As New SQLiteCommand("SELECT COUNT(*) FROM asset", connection)
            totalRecords = Convert.ToInt32(countCommand.ExecuteScalar())
            totalPages = Math.Ceiling(totalRecords / pageSize)

            ' Ensure connection is closed
            connection.Close()

            ' Navigate to the last page
            If totalPages > 0 Then
                currentPage = totalPages
                retrieveData() ' Retrieve data for the last page
            Else
                currentPage = 1 ' Default to page 1 if no records are found
            End If

            ' Update the page info label
            lblPageInfo.Text = "Page " & currentPage & " of " & totalPages

        Catch ex As Exception
            MessageBox.Show("Failed to navigate to last page: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportListViewToCSV(ListView1)
    End Sub

    Private Sub ExportListViewToCSV(listView As ListView)
        ' Get the current date and time in a format suitable for filenames
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")

        ' Initialize SaveFileDialog to prompt the user for file save location
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
        saveFileDialog.Title = "Save Asset Data as CSV"

        ' Set the default filename with the current date/time
        saveFileDialog.FileName = "AssetsData (" & currentDate & ").csv"

        ' If user clicks 'Save'
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Open a StreamWriter to write to the chosen file path
                Using writer As New StreamWriter(saveFileDialog.FileName)

                    ' Open connection to the SQLite database
                    connection.Open()

                    ' Query to fetch all assets
                    Dim sql = "SELECT a.assetNum, a.assetStatus, a.assetType, a.assetSAP l.locationName, o.officeName 
                           FROM asset a 
                           INNER JOIN office o ON a.officeID = o.officeID
                           INNER JOIN location l ON o.locationID = l.locationID;"

                    Dim command As New SQLiteCommand(sql, connection)
                    Dim reader = command.ExecuteReader()

                    ' Write the CSV headers
                    writer.WriteLine("Asset Number,Asset Status,Asset Type,Location Name,Office Name")

                    ' Write the data rows
                    While reader.Read()
                        Dim assetNum As String = reader("assetNum").ToString()
                        Dim assetSAP As String = reader("assetSAP").ToString()
                        Dim assetStatus As String = If(reader("assetStatus") = 1, "Installed", "Not Installed")
                        Dim assetType As String = reader("assetType").ToString()
                        Dim locationName As String = reader("locationName").ToString()
                        Dim officeName As String = reader("officeName").ToString()

                        ' Write the row to the CSV
                        writer.WriteLine(String.Join(",", assetNum, assetStatus, assetType, assetSAP, locationName, officeName))
                    End While

                    ' Notify user of successful export

                    enterLog.LogActivity("Export", $"'{GlobalVariables.currentUser}' exported all data to CSV.")
                    My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
                    MessageBox.Show("All assets exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using

            Catch ex As Exception
                ' Handle any errors that may occur
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure that the connection is closed
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub

End Class
