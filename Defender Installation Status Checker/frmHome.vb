Imports System.Data.SQLite

Public Class frmHome
    Dim databasePath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "disc.db")
    Dim connString As String = $"Data Source={databasePath};Version=3;"
    Dim connection As New SQLiteConnection(connString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable resizing
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        getTotalOffice()
        getTotalAsset()
        getTotalAssetNoDefend()
    End Sub
    Private Sub getTotalOffice()
        Try
            connection.Open()
            Dim sql As String = "SELECT COUNT(*) AS totalOffices FROM office;"
            Dim command As New SQLiteCommand(sql, connection)
            Dim reader As SQLiteDataReader = command.ExecuteReader()

            If reader.Read() Then
                'display total number of offices
                lblNumOff.Text = reader("totalOffices").ToString()
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("An error occured: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub getTotalAsset()
        Try
            connection.Open() ' Open the database connection
            Dim sql As String = "SELECT COUNT(*) AS totalAssets FROM asset;"
            Dim command As New SQLiteCommand(sql, connection)
            Dim reader As SQLiteDataReader = command.ExecuteReader()

            If reader.Read() Then
                ' Display total number of assets
                lblTotPC.Text = reader("totalAssets").ToString()
            End If

            reader.Close() ' Close the reader
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close() ' Close the database connection
        End Try
    End Sub

    Private Sub getTotalAssetNoDefend()
        Try
            connection.Open()
            Dim sql As String = "SELECT COUNT(*) AS totalNoDefend FROM asset WHERE assetStatus = 0"
            Dim command As New SQLiteCommand(sql, connection)
            Dim reader As SQLiteDataReader = command.ExecuteReader()

            If reader.Read() Then
                ' Display total number of assets
                lblTotPCDef.Text = reader("totalNoDefend").ToString()
            End If

            reader.Close() ' Close the reader
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close() ' Close the database connection
        End Try
    End Sub

    Private Sub btnAsset_MouseHover(sender As Object, e As EventArgs) Handles btnAsset.MouseHover
        btnAsset.BackColor = Color.DarkOrange
    End Sub
    Private Sub btnAsset_MouseLeave(sender As Object, e As EventArgs) Handles btnAsset.MouseLeave
        btnAsset.BackColor = Color.Orange
    End Sub

    Private Sub btnMap_MouseHover(sender As Object, e As EventArgs) Handles btnMap.MouseHover
        btnMap.BackColor = Color.DarkOrange
    End Sub

    Private Sub btnMap_MouseLeave(sender As Object, e As EventArgs) Handles btnMap.MouseLeave
        btnMap.BackColor = Color.Orange
    End Sub

    Private Sub btnMap_MouseClick(sender As Object, e As MouseEventArgs) Handles btnMap.MouseClick
        Dim frm1 As New frmMap(Me)
        frm1.Show
        Hide
    End Sub

    Private Sub btnAsset_Click(sender As Object, e As EventArgs) Handles btnAsset.Click
        Dim frm2 As New frmSearch(Me)
        frm2.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm3 As New frmALogin(Me)
        frm3.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.DarkOrange
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Orange
    End Sub
End Class
