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
        Label4 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        btnDelete = New Button()
        Label7 = New Label()
        lblSAP = New Label()
        MenuStrip1 = New MenuStrip()
        strHome = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        strView = New ToolStripMenuItem()
        strUpdate = New ToolStripMenuItem()
        strRegister = New ToolStripMenuItem()
        strDelete = New ToolStripMenuItem()
        AdministrationToolStripMenuItem = New ToolStripMenuItem()
        strLogs = New ToolStripMenuItem()
        strLogout = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Orange
        btnSearch.Font = New Font("Arial Narrow", 9F)
        btnSearch.Location = New Point(638, 23)
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
        txtAssetNum.Location = New Point(174, 23)
        txtAssetNum.Margin = New Padding(2, 3, 2, 3)
        txtAssetNum.Name = "txtAssetNum"
        txtAssetNum.Size = New Size(430, 25)
        txtAssetNum.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9F)
        Label2.Location = New Point(14, 23)
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
        lblState.Location = New Point(468, 73)
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
        lblOff.Location = New Point(308, 352)
        lblOff.Name = "lblOff"
        lblOff.Size = New Size(12, 17)
        lblOff.TabIndex = 46
        lblOff.Text = " "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 9F)
        Label6.Location = New Point(40, 352)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 45
        Label6.Text = "Office"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 9F)
        Label5.Location = New Point(40, 163)
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
        lblLoc.Location = New Point(308, 289)
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
        lblStatus.Location = New Point(308, 226)
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
        lblNum.Location = New Point(308, 100)
        lblNum.Name = "lblNum"
        lblNum.Size = New Size(12, 17)
        lblNum.TabIndex = 41
        lblNum.Text = " "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 9F)
        Label4.Location = New Point(40, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 39
        Label4.Text = "Location"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 9F)
        Label1.Location = New Point(40, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 37
        Label1.Text = "Asset No."
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Orange
        PictureBox2.Location = New Point(19, 72)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(696, 317)
        PictureBox2.TabIndex = 36
        PictureBox2.TabStop = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Orange
        btnDelete.Font = New Font("Arial Narrow", 9F)
        btnDelete.Location = New Point(505, 588)
        btnDelete.Margin = New Padding(2, 3, 2, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(82, 29)
        btnDelete.TabIndex = 47
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 9F)
        Label7.Location = New Point(40, 226)
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
        lblSAP.Location = New Point(308, 163)
        lblSAP.Name = "lblSAP"
        lblSAP.Size = New Size(12, 17)
        lblSAP.TabIndex = 54
        lblSAP.Text = " "
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {strHome, ToolStripMenuItem1, AdministrationToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1094, 28)
        MenuStrip1.TabIndex = 65
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' strHome
        ' 
        strHome.Name = "strHome"
        strHome.Size = New Size(64, 24)
        strHome.Text = "Home"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {strView, strUpdate, strRegister, strDelete})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(58, 24)
        ToolStripMenuItem1.Text = "Asset"
        ' 
        ' strView
        ' 
        strView.Name = "strView"
        strView.Size = New Size(146, 26)
        strView.Text = "View"
        ' 
        ' strUpdate
        ' 
        strUpdate.Name = "strUpdate"
        strUpdate.Size = New Size(146, 26)
        strUpdate.Text = "Update"
        ' 
        ' strRegister
        ' 
        strRegister.Name = "strRegister"
        strRegister.Size = New Size(146, 26)
        strRegister.Text = "Register"
        ' 
        ' strDelete
        ' 
        strDelete.Name = "strDelete"
        strDelete.Size = New Size(146, 26)
        strDelete.Text = "Delete"
        ' 
        ' AdministrationToolStripMenuItem
        ' 
        AdministrationToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {strLogs, strLogout})
        AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        AdministrationToolStripMenuItem.Size = New Size(121, 24)
        AdministrationToolStripMenuItem.Text = "Administration"
        ' 
        ' strLogs
        ' 
        strLogs.Name = "strLogs"
        strLogs.Size = New Size(145, 26)
        strLogs.Text = "Logs"
        ' 
        ' strLogout
        ' 
        strLogout.Name = "strLogout"
        strLogout.Size = New Size(145, 26)
        strLogout.Text = "Log Out"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(lblSAP)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtAssetNum)
        GroupBox1.Controls.Add(lblOff)
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(lblLoc)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lblStatus)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(lblNum)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Location = New Point(180, 128)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(735, 446)
        GroupBox1.TabIndex = 66
        GroupBox1.TabStop = False
        ' 
        ' frmDelete
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(MenuStrip1)
        Controls.Add(btnDelete)
        Controls.Add(lblState)
        Controls.Add(GroupBox1)
        MaximizeBox = False
        Name = "frmDelete"
        Text = "frmDelete"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSAP As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents strHome As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents strView As ToolStripMenuItem
    Friend WithEvents strUpdate As ToolStripMenuItem
    Friend WithEvents strRegister As ToolStripMenuItem
    Friend WithEvents strDelete As ToolStripMenuItem
    Friend WithEvents AdministrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents strLogs As ToolStripMenuItem
    Friend WithEvents strLogout As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
End Class
