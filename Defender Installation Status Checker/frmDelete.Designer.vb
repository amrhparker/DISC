<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelete
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
        btnSearch = New Button()
        txtAssetNum = New TextBox()
        Label2 = New Label()
        lblState = New Label()
        lblOff = New Label()
        Label6 = New Label()
        Label5 = New Label()
        lblLoc = New Label()
        lblStatus = New Label()
        lblNum = New Label()
        lblType = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        btnDelete = New Button()
        btnView = New Button()
        btnRegister = New Button()
        btnUpdate = New Button()
        btnLogout = New Button()
        Label7 = New Label()
        lblSAP = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.TabIndex = 8
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Orange
        btnSearch.Font = New Font("Arial Narrow", 9F)
        btnSearch.Location = New Point(818, 147)
        btnSearch.Margin = New Padding(2, 3, 2, 3)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(82, 29)
        btnSearch.TabIndex = 35
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtAssetNum
        ' 
        txtAssetNum.Font = New Font("Arial Narrow", 9F)
        txtAssetNum.Location = New Point(354, 147)
        txtAssetNum.Margin = New Padding(2, 3, 2, 3)
        txtAssetNum.Name = "txtAssetNum"
        txtAssetNum.Size = New Size(430, 25)
        txtAssetNum.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9F)
        Label2.Location = New Point(194, 147)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 33
        Label2.Text = "Enter asset number"
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.BackColor = Color.Transparent
        lblState.Cursor = Cursors.Hand
        lblState.Font = New Font("Arial Narrow", 16F)
        lblState.Location = New Point(468, 74)
        lblState.Name = "lblState"
        lblState.Padding = New Padding(10, 5, 10, 5)
        lblState.Size = New Size(158, 41)
        lblState.TabIndex = 32
        lblState.Text = "Delete Asset"
        lblState.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOff
        ' 
        lblOff.AutoSize = True
        lblOff.BackColor = Color.Orange
        lblOff.Font = New Font("Arial", 9F)
        lblOff.Location = New Point(452, 502)
        lblOff.Name = "lblOff"
        lblOff.Size = New Size(12, 17)
        lblOff.TabIndex = 46
        lblOff.Text = " "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 9F)
        Label6.Location = New Point(220, 498)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 45
        Label6.Text = "Office"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 9F)
        Label5.Location = New Point(220, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 44
        Label5.Text = "Asset SAP"
        ' 
        ' lblLoc
        ' 
        lblLoc.AutoSize = True
        lblLoc.BackColor = Color.Orange
        lblLoc.Font = New Font("Arial", 9F)
        lblLoc.Location = New Point(452, 447)
        lblLoc.Name = "lblLoc"
        lblLoc.Size = New Size(12, 17)
        lblLoc.TabIndex = 43
        lblLoc.Text = " "
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BackColor = Color.Orange
        lblStatus.Font = New Font("Arial", 9F)
        lblStatus.Location = New Point(452, 396)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(12, 17)
        lblStatus.TabIndex = 42
        lblStatus.Text = " "
        ' 
        ' lblNum
        ' 
        lblNum.AutoSize = True
        lblNum.BackColor = Color.Orange
        lblNum.Font = New Font("Arial", 9F)
        lblNum.Location = New Point(452, 243)
        lblNum.Name = "lblNum"
        lblNum.Size = New Size(12, 17)
        lblNum.TabIndex = 41
        lblNum.Text = " "
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.BackColor = Color.Orange
        lblType.Font = New Font("Arial", 9F)
        lblType.ForeColor = Color.Black
        lblType.Location = New Point(452, 345)
        lblType.Name = "lblType"
        lblType.Size = New Size(12, 17)
        lblType.TabIndex = 40
        lblType.Text = " "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 9F)
        Label4.Location = New Point(220, 447)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 39
        Label4.Text = "Location"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9F)
        Label3.Location = New Point(220, 345)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 38
        Label3.Text = "Asset Type"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 9F)
        Label1.Location = New Point(220, 243)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 37
        Label1.Text = "Asset No."
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Orange
        PictureBox2.Location = New Point(199, 198)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(696, 366)
        PictureBox2.TabIndex = 36
        PictureBox2.TabStop = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Orange
        btnDelete.Font = New Font("Arial Narrow", 9F)
        btnDelete.Location = New Point(505, 590)
        btnDelete.Margin = New Padding(2, 3, 2, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(82, 29)
        btnDelete.TabIndex = 47
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnView
        ' 
        btnView.BackColor = Color.Orange
        btnView.Font = New Font("Arial Narrow", 9F)
        btnView.Location = New Point(294, 12)
        btnView.Name = "btnView"
        btnView.Size = New Size(122, 40)
        btnView.TabIndex = 48
        btnView.Text = "View Asset"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Orange
        btnRegister.Font = New Font("Arial Narrow", 9F)
        btnRegister.Location = New Point(422, 12)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(122, 40)
        btnRegister.TabIndex = 49
        btnRegister.Text = "Register Asset"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Orange
        btnUpdate.Font = New Font("Arial Narrow", 9F)
        btnUpdate.Location = New Point(550, 12)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(122, 40)
        btnUpdate.TabIndex = 50
        btnUpdate.Text = "Update Asset"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.OrangeRed
        btnLogout.Font = New Font("Arial Narrow", 9F)
        btnLogout.Location = New Point(678, 12)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(122, 40)
        btnLogout.TabIndex = 52
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 9F)
        Label7.Location = New Point(220, 396)
        Label7.Name = "Label7"
        Label7.Size = New Size(159, 20)
        Label7.TabIndex = 53
        Label7.Text = "Defender Installation Status"
        ' 
        ' lblSAP
        ' 
        lblSAP.AutoSize = True
        lblSAP.BackColor = Color.Orange
        lblSAP.Font = New Font("Arial", 9F)
        lblSAP.Location = New Point(452, 294)
        lblSAP.Name = "lblSAP"
        lblSAP.Size = New Size(12, 17)
        lblSAP.TabIndex = 54
        lblSAP.Text = " "
        ' 
        ' frmDelete
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(lblSAP)
        Controls.Add(Label7)
        Controls.Add(btnLogout)
        Controls.Add(btnUpdate)
        Controls.Add(btnRegister)
        Controls.Add(btnView)
        Controls.Add(btnDelete)
        Controls.Add(lblOff)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblLoc)
        Controls.Add(lblStatus)
        Controls.Add(lblNum)
        Controls.Add(lblType)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btnSearch)
        Controls.Add(txtAssetNum)
        Controls.Add(Label2)
        Controls.Add(lblState)
        Controls.Add(btnBack)
        Controls.Add(PictureBox2)
        MaximizeBox = False
        Name = "frmDelete"
        Text = "frmDelete"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtAssetNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblOff As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblLoc As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblType As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSAP As Label
End Class
