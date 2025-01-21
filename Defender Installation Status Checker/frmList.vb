Imports System.Data.SQLite
Imports System.Drawing.Printing

Public Class frmList
    Dim databasePath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "disc.db")
    Dim connString As String = $"Data Source={databasePath};Version=3;"
    Dim connection As New SQLiteConnection(connString)
    Dim currentPage As Integer = 1
    Dim pageSize As Integer = 15 ' Number of items per page
    Dim offset As Integer = (currentPage - 1) * pageSize
    Dim totalRecords As Integer
    Dim totalPages As Integer

    Dim locID As Integer
    Private previousForm As Form
    ' Constructor to accept the previous form as a parameter
    Public Sub New(previous As Form, loc As Integer)
        InitializeComponent()
        previousForm = previous
        locID = loc
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Show the previous form
        previousForm.Show()
        ' Close the current form
        Me.Hide()
    End Sub
    Private Sub frmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable resizing
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        getTotalOffice()
        getTotalAsset()
        getTotalAssetNoDefend()
        ' Set up the columns in the ListView
        ListView1.Columns.Add("Asset Number", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Defender Installation Status", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Asset SAP", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Office", 200, HorizontalAlignment.Center)
        If locID = 1 Then
            GroupBox1.Text = "Perlis"
        ElseIf locID = 2 Then
            GroupBox1.Text = "Kedah"
        ElseIf locID = 3 Then
            GroupBox1.Text = "Pulau Pinang"
        ElseIf locID = 4 Then
            GroupBox1.Text = "Perak"
        ElseIf locID = 5 Then
            GroupBox1.Text = "Headquarters"
        ElseIf locID = 6 Then
            GroupBox1.Text = "Negeri Sembilan"
        ElseIf locID = 7 Then
            GroupBox1.Text = "Melaka"
        ElseIf locID = 8 Then
            GroupBox1.Text = "Johor"
        ElseIf locID = 9 Then
            GroupBox1.Text = "Pahang"
        ElseIf locID = 10 Then
            GroupBox1.Text = "Kelantan"
        ElseIf locID = 11 Then
            GroupBox1.Text = "Terengganu"
        ElseIf locID = 12 Then
            GroupBox1.Text = "Sabah"
        ElseIf locID = 13 Then
            GroupBox1.Text = "Sarawak"
        End If

        retrieveData()

        ' Calculate total pages
        calculateTotalPages()

        ' Retrieve the data for the first page
        retrieveData()

        ' Display the current page and total pages in the label
        lblPageInfo.Text = "Page " & currentPage & " of " & totalPages
    End Sub

    Private Sub calculateTotalPages()
        Try
            connection.Open()
            ' Calculate total number of records
            Dim countCommand As New SQLiteCommand("SELECT COUNT(*) FROM asset a JOIN office o ON a.officeID = o.officeID JOIN location l ON o.locationID = l.locationID WHERE l.locationID = @locID;", connection)
            countCommand.Parameters.AddWithValue("@locID", locID)
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
                Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
                Dim selectedSubItemText As String = selectedItem.SubItems(0).Text ' Change index for other subitems

                ' Copy the selected subitem text to clipboard
                Clipboard.SetText(selectedSubItemText)
            Else
                MessageBox.Show("Please select an item to copy.")
            End If
        End If
    End Sub
    Private Sub getTotalOffice()
        Try
            connection.Open()
            Dim sql As String = "SELECT COUNT(*) AS totalOffices FROM office WHERE locationID = @locID;"
            Dim command As New SQLiteCommand(sql, connection)
            command.Parameters.AddWithValue("@locID", locID)
            Dim reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                'display total number of offices
                lblNumOff.Text = reader("totalOffices").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("An error occured on GTO: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub getTotalAsset()
        Try
            connection.Open() ' Open the database connection
            Dim sql As String = "SELECT COUNT(*) AS totalAssets FROM asset a JOIN office o ON a.officeID = o.officeID JOIN location l ON l.locationID = o.locationID
                                                  WHERE  l.locationID = @locID;"
            Dim command As New SQLiteCommand(sql, connection)
            command.Parameters.AddWithValue("@locID", locID)
            Dim reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                ' Display total number of assets
                lblTotPC.Text = reader("totalAssets").ToString()
            End If
            reader.Close() ' Close the reader
        Catch ex As Exception
            MessageBox.Show("An error occurred on GTA: " & ex.Message)
        Finally
            connection.Close() ' Close the database connection
        End Try
    End Sub

    Private Sub getTotalAssetNoDefend()
        Try
            connection.Open()
            Dim sql As String = "SELECT COUNT(*) AS totalNoDefend FROM asset a JOIN office o ON a.officeID = o.officeID JOIN location l ON l.locationID = o.locationID
                                                  WHERE  l.locationID = @locID AND a.assetStatus = 0;"
            Dim command As New SQLiteCommand(sql, connection)
            command.Parameters.AddWithValue("@locID", locID)
            Dim reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                ' Display total number of assets
                lblTotPCDef.Text = reader("totalNoDefend").ToString()
            End If

            reader.Close() ' Close the reader
        Catch ex As Exception
            MessageBox.Show("An error occurred on GTAND: " & ex.Message)
        Finally
            connection.Close() ' Close the database connection
        End Try
    End Sub

    Private Sub retrieveData()
        Dim reader As SQLiteDataReader = Nothing
        Try
            ' Ensure the connection is open before executing the query
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            ' SQL Query to calculate total records and pages
            Dim totalRecords As Integer
            Dim sql As String = "SELECT COUNT(*) FROM asset a 
                             JOIN office o ON a.officeID = o.officeID 
                             JOIN location l ON o.locationID = l.locationID 
                             WHERE l.locationID = @locID;"
            Dim countCommand As New SQLiteCommand(sql, connection)
            countCommand.Parameters.AddWithValue("@locID", locID)
            totalRecords = Convert.ToInt32(countCommand.ExecuteScalar())

            ' Calculate total pages
            Dim totalPages As Integer = Math.Ceiling(totalRecords / Convert.ToDouble(pageSize))

            ' Update page info label
            lblPageInfo.Text = "Page " & currentPage & " of " & totalPages

            ' SQL Query with pagination
            Dim sql1 As String = "SELECT a.assetNum, a.assetStatus, a.assetSAP, o.officeName 
                              FROM asset a 
                              JOIN office o ON a.officeID = o.officeID
                              JOIN location l ON o.locationID = l.locationID 
                              WHERE l.locationID = @locID 
                              LIMIT " & pageSize & " OFFSET " & (currentPage - 1) * pageSize & ";"

            Dim command As New SQLiteCommand(sql1, connection)
            command.Parameters.AddWithValue("@locID", locID)

            ' Execute the query and read the data
            reader = command.ExecuteReader()

            ' Clear existing items in the ListView
            ListView1.Items.Clear()

            ' Loop through the data and add it to the ListView
            While reader.Read()
                Dim item As New ListViewItem(reader("assetNum").ToString())
                item.SubItems.Add(If(reader("assetStatus") = 1, "Installed", "Not Installed"))
                item.SubItems.Add(reader("assetSAP").ToString())
                item.SubItems.Add(reader("officeName").ToString())
                ListView1.Items.Add(item) ' Add the row to the ListView
            End While

        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Failed to retrieve data: " & ex.Message)

        Finally
            ' Ensure that the reader is closed if it was opened
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then
                reader.Close()
            End If
            ' Ensure the connection is closed
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Calculate total records and total pages
        calculateTotalPages()

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
            ' Recalculate total records and total pages for the current location
            connection.Open()

            ' Query to get the total number of records for the current location (using locID filter)
            Dim countCommand As New SQLiteCommand("SELECT COUNT(*) FROM asset a 
                                                JOIN office o ON a.officeID = o.officeID 
                                                JOIN location l ON o.locationID = l.locationID 
                                                WHERE l.locationID = @locID;", connection)
            countCommand.Parameters.AddWithValue("@locID", locID)
            totalRecords = Convert.ToInt32(countCommand.ExecuteScalar())
            totalPages = Math.Ceiling(totalRecords / pageSize)

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

End Class