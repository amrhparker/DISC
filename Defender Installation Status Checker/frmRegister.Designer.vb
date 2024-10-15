<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        txtAssetNum = New TextBox()
        cboType = New ComboBox()
        btnRegister = New Button()
        chkStatus = New CheckBox()
        Label7 = New Label()
        btnLogout = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnView = New Button()
        cboOffice = New ComboBox()
        txtSAP = New TextBox()
        Label5 = New Label()
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
        btnBack.TabIndex = 2
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial Narrow", 16F)
        Label1.Location = New Point(443, 120)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(9, 4, 9, 4)
        Label1.Size = New Size(209, 39)
        Label1.TabIndex = 3
        Label1.Text = "Asset Registration"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9F)
        Label2.Location = New Point(252, 206)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 4
        Label2.Text = "Enter asset number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9F)
        Label3.Location = New Point(299, 331)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 5
        Label3.Text = "Asset Type"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 9F)
        Label4.Location = New Point(263, 389)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 20)
        Label4.TabIndex = 6
        Label4.Text = "Installation Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 9F)
        Label6.Location = New Point(275, 450)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 20)
        Label6.TabIndex = 8
        Label6.Text = "Office Location"
        ' 
        ' txtAssetNum
        ' 
        txtAssetNum.Font = New Font("Arial Narrow", 9F)
        txtAssetNum.Location = New Point(412, 206)
        txtAssetNum.Margin = New Padding(2, 3, 2, 3)
        txtAssetNum.Name = "txtAssetNum"
        txtAssetNum.Size = New Size(430, 25)
        txtAssetNum.TabIndex = 9
        ' 
        ' cboType
        ' 
        cboType.Font = New Font("Arial Narrow", 9F)
        cboType.FormattingEnabled = True
        cboType.Location = New Point(412, 331)
        cboType.Margin = New Padding(2, 3, 2, 3)
        cboType.Name = "cboType"
        cboType.Size = New Size(430, 28)
        cboType.TabIndex = 10
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Orange
        btnRegister.Font = New Font("Arial Narrow", 9F)
        btnRegister.Location = New Point(505, 542)
        btnRegister.Margin = New Padding(2, 3, 2, 3)
        btnRegister.Name = "btnRegister"
        btnRegister.Padding = New Padding(2)
        btnRegister.Size = New Size(82, 32)
        btnRegister.TabIndex = 14
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' chkStatus
        ' 
        chkStatus.AutoSize = True
        chkStatus.Font = New Font("Arial Narrow", 9F)
        chkStatus.Location = New Point(412, 389)
        chkStatus.Margin = New Padding(2, 3, 2, 3)
        chkStatus.Name = "chkStatus"
        chkStatus.Size = New Size(77, 24)
        chkStatus.TabIndex = 15
        chkStatus.Text = "Installed"
        chkStatus.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 9F)
        Label7.ForeColor = SystemColors.GrayText
        Label7.Location = New Point(493, 392)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(130, 20)
        Label7.TabIndex = 16
        Label7.Text = "(Untick if not installed)"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.OrangeRed
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
        btnDelete.Location = New Point(550, 12)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(122, 40)
        btnDelete.TabIndex = 55
        btnDelete.Text = "Delete Asset"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Orange
        btnUpdate.Location = New Point(422, 12)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(122, 40)
        btnUpdate.TabIndex = 54
        btnUpdate.Text = "Update Asset"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnView
        ' 
        btnView.BackColor = Color.Orange
        btnView.Location = New Point(294, 12)
        btnView.Name = "btnView"
        btnView.Size = New Size(122, 40)
        btnView.TabIndex = 53
        btnView.Text = "View Asset"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' cboOffice
        ' 
        cboOffice.Font = New Font("Arial Narrow", 9F)
        cboOffice.FormattingEnabled = True
        cboOffice.Location = New Point(412, 448)
        cboOffice.Margin = New Padding(2, 3, 2, 3)
        cboOffice.Name = "cboOffice"
        cboOffice.Size = New Size(430, 28)
        cboOffice.TabIndex = 57
        ' 
        ' txtSAP
        ' 
        txtSAP.Font = New Font("Arial Narrow", 9F)
        txtSAP.Location = New Point(412, 270)
        txtSAP.Margin = New Padding(2, 3, 2, 3)
        txtSAP.Name = "txtSAP"
        txtSAP.Size = New Size(430, 25)
        txtSAP.TabIndex = 59
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 9F)
        Label5.Location = New Point(304, 270)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 58
        Label5.Text = "Asset SAP"
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(cboOffice)
        Controls.Add(btnLogout)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnView)
        Controls.Add(Label7)
        Controls.Add(chkStatus)
        Controls.Add(btnRegister)
        Controls.Add(txtAssetNum)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Controls.Add(txtSAP)
        Controls.Add(cboType)
        Controls.Add(Label5)
        Font = New Font("Arial Narrow", 9F)
        Margin = New Padding(2, 3, 2, 3)
        MaximizeBox = False
        Name = "frmRegister"
        Text = "frmAdmin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAssetNum As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents chkStatus As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents cboOffice As ComboBox
    Friend WithEvents txtSAP As TextBox
    Friend WithEvents Label5 As Label
End Class
