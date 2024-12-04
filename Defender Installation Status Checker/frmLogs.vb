Public Class frmLogs
    Private adminUser As List(Of String)
    Private Sub frmLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, AddressOf frmLoad_FormClosing
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
        ' Bind the DataTable to the DataGridView
        dataGridViewLogs.DataSource = retrieveLog.GetLogs()
    End Sub
    'Function to prevent admin close the window without logging out
    Private Sub frmLoad_FormClosing(sender As Object, e As FormClosingEventArgs)
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
End Class