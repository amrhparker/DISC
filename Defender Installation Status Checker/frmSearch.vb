Imports System.Data.SQLite

Public Class frmSearch
    Dim connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.db;Version=3;"
    Dim connection As New SQLiteConnection(connString)
    Private previousForm As Form

    ' Constructor to accept the previous form as a parameter
    Public Sub New(previous As Form)
        InitializeComponent()
        previousForm = previous
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Show the previous form
        previousForm.Show()
        ' Close the current form
        Me.Hide()
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Select()
        ClearResults()
    End Sub

    Private Sub btnSearch_MouseHover(sender As Object, e As EventArgs) Handles btnSearch.MouseHover
        btnSearch.BackColor = Color.DarkOrange
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.BackColor = Color.Orange
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim assetNum = txtSearch.Text.Trim ' Get the search input

        Try
            connection.Open()
            Dim sql = "SELECT a.assetNum, a.assetStatus, a.assetType, a.assetSAP, l.locationName, o.officeName
                       FROM asset a
                       INNER JOIN office o ON a.officeID = o.officeID
                       INNER JOIN location l ON o.locationID = l.locationID
                       WHERE a.assetNum = @assetNum;"

            Using command As New SQLiteCommand(sql, connection)
                command.Parameters.AddWithValue("@assetNum", assetNum)
                Using reader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Display the asset details
                        lblNum.Text = reader("assetNum").ToString
                        lblType.Text = reader("assetType").ToString
                        If reader("assetStatus") = 1 Then
                            lblStatus.Text = "Installed"
                        ElseIf reader("assetStatus") = 0 Then
                            lblStatus.Text = "Not Installed"
                        End If
                        lblSAP.Text = reader("assetSAP").ToString
                        lblLoc.Text = reader("locationName").ToString
                        lblOff.Text = reader("officeName").ToString
                    Else
                        ' Handle case where asset is not found
                        ClearResults()
                        lblNum.Text = "Not found"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to retrieve data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        ' Check if the "Enter" key is pressed while focused on txtSearch
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick() ' Simulate a click on btnSearch
        End If
    End Sub
    Private Sub ClearResults()
        lblNum.Text = ""
        lblType.Text = ""
        lblStatus.Text = ""
        lblSAP.Text = ""
        lblLoc.Text = ""
        lblOff.Text = ""
    End Sub
End Class