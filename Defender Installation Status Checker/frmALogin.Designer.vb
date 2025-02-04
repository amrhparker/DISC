<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmALogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnBack = New Button()
        Label1 = New Label()
        btnLogin = New Button()
        txtUID = New TextBox()
        Label6 = New Label()
        Label2 = New Label()
        txtUPW = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.BackgroundImage = My.Resources.Resources.back_icon1
        btnBack.BackgroundImageLayout = ImageLayout.Zoom
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Location = New Point(12, 12)
        btnBack.Margin = New Padding(2, 3, 2, 3)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(40, 40)
        btnBack.TabIndex = 3
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Orange
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial Narrow", 16F)
        Label1.Location = New Point(455, 146)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(9, 4, 9, 4)
        Label1.Size = New Size(153, 39)
        Label1.TabIndex = 4
        Label1.Text = "Admin Login"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Arial Narrow", 9F)
        btnLogin.Location = New Point(506, 515)
        btnLogin.Margin = New Padding(2, 3, 2, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(82, 29)
        btnLogin.TabIndex = 19
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtUID
        ' 
        txtUID.Font = New Font("Arial Narrow", 9F)
        txtUID.Location = New Point(385, 289)
        txtUID.Margin = New Padding(2, 3, 2, 3)
        txtUID.Name = "txtUID"
        txtUID.Size = New Size(430, 25)
        txtUID.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 9F)
        Label6.Location = New Point(279, 375)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 20)
        Label6.TabIndex = 16
        Label6.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9F)
        Label2.Location = New Point(292, 294)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 15
        Label2.Text = "User ID"
        ' 
        ' txtUPW
        ' 
        txtUPW.Font = New Font("Arial Narrow", 9F)
        txtUPW.Location = New Point(385, 377)
        txtUPW.Margin = New Padding(2, 3, 2, 3)
        txtUPW.Name = "txtUPW"
        txtUPW.ShortcutsEnabled = False
        txtUPW.Size = New Size(430, 25)
        txtUPW.TabIndex = 18
        txtUPW.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Orange
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(96, 116)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(902, 458)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' frmALogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(btnLogin)
        Controls.Add(txtUPW)
        Controls.Add(txtUID)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Name = "frmALogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUPW As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
