Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SQLite

Public Class frmALogin
    Private previousForm As Form
    Dim connString As String = "Data Source=C:\Users\practicalits.fpssb\Downloads\amirah\disc.db;Version=3;BusyTimeout=5000;"
    Dim connection As New SQLiteConnection(connString)
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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUID.Text = "" Or txtUPW.Text = "" Then
            MessageBox.Show("Please key in your ID/password.")
            Exit Sub
        End If

        Dim uid As String = txtUID.Text.Trim()
        Dim pw As String = txtUPW.Text.Trim()

        ' Hash the entered password
        Dim hashedPW As String = HashPassword(pw)

        ' Validate the admin using the hashed password
        If ValidateAdmin(uid, hashedPW) Then
            ' Set global variables when login is successful
            GlobalVariables.currentUser = uid
            GlobalVariables.currentPassword = hashedPW
            enterLog.LogActivity("Login", $"'{uid}' logged in successfully.")
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)

            ' Show the main form or dashboard
            Dim mainForm As New frmAdminMenu()
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    ' Function to hash the password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2")) ' Convert to hexadecimal
            Next
            Return builder.ToString()
        End Using
    End Function

    ' Function to validate the admin credentials (supports multiple admins)
    Private Function ValidateAdmin(username As String, hashedPassword As String) As Boolean
        Using connection As New SQLiteConnection(connString)
            Try
                connection.Open()

                ' SQL query to check if any admin record matches the given username and hashed password
                Dim sql As String = "SELECT * FROM admin WHERE uid = @username AND pw = @hashedPassword"
                Using command As New SQLiteCommand(sql, connection)
                    ' Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@hashedPassword", hashedPassword)

                    ' Execute the query and read the result
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Credentials match
                            Return True
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
        ' Credentials did not match
        Return False
    End Function

    Private Sub frmALogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUID.Select()
    End Sub
End Class
