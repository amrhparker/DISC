<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        lblState = New Label()
        Label8 = New Label()
        Label7 = New Label()
        chkStatus = New CheckBox()
        btnUpdate = New Button()
        cboType = New ComboBox()
        txtAssetNum = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnLogout = New Button()
        btnDelete = New Button()
        btnRegister = New Button()
        btnView = New Button()
        btnSearch = New Button()
        Label1 = New Label()
        cboOffice = New ComboBox()
        txtSAP = New TextBox()
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
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(40, 40)
        btnBack.TabIndex = 7
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.BackColor = Color.Transparent
        lblState.Cursor = Cursors.Hand
        lblState.Font = New Font("Arial Narrow", 16F)
        lblState.Location = New Point(408, 94)
        lblState.Name = "lblState"
        lblState.Padding = New Padding(10, 5, 10, 5)
        lblState.Size = New Size(279, 41)
        lblState.TabIndex = 8
        lblState.Text = "Update Asset Information"
        lblState.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Narrow", 9F)
        Label8.Location = New Point(46, 271)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(1003, 20)
        Label8.TabIndex = 32
        Label8.Text = "______________________________________________________________________________________________________________________________________________"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 9F)
        Label7.ForeColor = SystemColors.GrayText
        Label7.Location = New Point(473, 442)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(130, 20)
        Label7.TabIndex = 30
        Label7.Text = "(Untick if not installed)"
        ' 
        ' chkStatus
        ' 
        chkStatus.AutoSize = True
        chkStatus.Font = New Font("Arial Narrow", 9F)
        chkStatus.Location = New Point(392, 441)
        chkStatus.Margin = New Padding(2, 3, 2, 3)
        chkStatus.Name = "chkStatus"
        chkStatus.Size = New Size(77, 24)
        chkStatus.TabIndex = 29
        chkStatus.Text = "Installed"
        chkStatus.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Orange
        btnUpdate.Font = New Font("Arial Narrow", 9F)
        btnUpdate.Location = New Point(506, 553)
        btnUpdate.Margin = New Padding(2, 3, 2, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Padding = New Padding(2)
        btnUpdate.Size = New Size(82, 32)
        btnUpdate.TabIndex = 28
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' cboType
        ' 
        cboType.Font = New Font("Arial Narrow", 9F)
        cboType.FormattingEnabled = True
        cboType.Location = New Point(392, 316)
        cboType.Margin = New Padding(2, 3, 2, 3)
        cboType.Name = "cboType"
        cboType.Size = New Size(430, 28)
        cboType.TabIndex = 25
        ' 
        ' txtAssetNum
        ' 
        txtAssetNum.Font = New Font("Arial Narrow", 9F)
        txtAssetNum.Location = New Point(392, 225)
        txtAssetNum.Margin = New Padding(2, 3, 2, 3)
        txtAssetNum.Name = "txtAssetNum"
        txtAssetNum.Size = New Size(430, 25)
        txtAssetNum.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 9F)
        Label6.Location = New Point(275, 380)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 23
        Label6.Text = "Asset SAP"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 9F)
        Label4.Location = New Point(234, 441)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 20)
        Label4.TabIndex = 21
        Label4.Text = "Installation Status"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9F)
        Label3.Location = New Point(270, 319)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 20
        Label3.Text = "Asset Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9F)
        Label2.Location = New Point(223, 225)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 19
        Label2.Text = "Enter asset number"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.OrangeRed
        btnLogout.Font = New Font("Arial Narrow", 9F)
        btnLogout.Location = New Point(678, 12)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(122, 40)
        btnLogout.TabIndex = 56
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Orange
        btnDelete.Font = New Font("Arial Narrow", 9F)
        btnDelete.Location = New Point(550, 12)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(122, 40)
        btnDelete.TabIndex = 55
        btnDelete.Text = "Delete Asset"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Orange
        btnRegister.Font = New Font("Arial Narrow", 9F)
        btnRegister.Location = New Point(422, 12)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(122, 40)
        btnRegister.TabIndex = 54
        btnRegister.Text = "Register Asset"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnView
        ' 
        btnView.BackColor = Color.Orange
        btnView.Font = New Font("Arial Narrow", 9F)
        btnView.Location = New Point(294, 12)
        btnView.Name = "btnView"
        btnView.Size = New Size(122, 40)
        btnView.TabIndex = 53
        btnView.Text = "View Asset"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Orange
        btnSearch.Font = New Font("Arial Narrow", 9F)
        btnSearch.Location = New Point(856, 221)
        btnSearch.Margin = New Padding(2, 3, 2, 3)
        btnSearch.Name = "btnSearch"
        btnSearch.Padding = New Padding(2)
        btnSearch.Size = New Size(82, 32)
        btnSearch.TabIndex = 31
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 9F)
        Label1.Location = New Point(246, 502)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 20)
        Label1.TabIndex = 59
        Label1.Text = "Office Location"
        ' 
        ' cboOffice
        ' 
        cboOffice.Font = New Font("Arial Narrow", 9F)
        cboOffice.FormattingEnabled = True
        cboOffice.Location = New Point(392, 502)
        cboOffice.Margin = New Padding(2, 3, 2, 3)
        cboOffice.Name = "cboOffice"
        cboOffice.Size = New Size(430, 28)
        cboOffice.TabIndex = 58
        ' 
        ' txtSAP
        ' 
        txtSAP.Font = New Font("Arial Narrow", 9F)
        txtSAP.Location = New Point(392, 380)
        txtSAP.Margin = New Padding(2, 3, 2, 3)
        txtSAP.Name = "txtSAP"
        txtSAP.Size = New Size(430, 25)
        txtSAP.TabIndex = 60
        ' 
        ' frmUpdate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(txtSAP)
        Controls.Add(Label1)
        Controls.Add(cboOffice)
        Controls.Add(btnLogout)
        Controls.Add(btnDelete)
        Controls.Add(btnRegister)
        Controls.Add(btnView)
        Controls.Add(Label8)
        Controls.Add(btnSearch)
        Controls.Add(Label7)
        Controls.Add(chkStatus)
        Controls.Add(btnUpdate)
        Controls.Add(cboType)
        Controls.Add(txtAssetNum)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblState)
        Controls.Add(btnBack)
        MaximizeBox = False
        Name = "frmUpdate"
        Text = "frmUpdate"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblState As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chkStatus As CheckBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtAssetNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboOffice As ComboBox
    Friend WithEvents txtSAP As TextBox
End Class
