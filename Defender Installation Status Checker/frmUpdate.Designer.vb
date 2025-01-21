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
        lblState = New Label()
        Label8 = New Label()
        Label7 = New Label()
        chkStatus = New CheckBox()
        btnUpdate = New Button()
        txtAssetNum = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        btnSearch = New Button()
        Label1 = New Label()
        cboOffice = New ComboBox()
        txtSAP = New TextBox()
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
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.BackColor = Color.Transparent
        lblState.Cursor = Cursors.Hand
        lblState.Font = New Font("Arial Narrow", 16F)
        lblState.Location = New Point(408, 109)
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
        Label8.Location = New Point(5, 73)
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
        Label7.Location = New Point(431, 179)
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
        chkStatus.Location = New Point(351, 178)
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
        btnUpdate.Location = New Point(506, 550)
        btnUpdate.Margin = New Padding(2, 3, 2, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Padding = New Padding(2)
        btnUpdate.Size = New Size(82, 32)
        btnUpdate.TabIndex = 28
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' txtAssetNum
        ' 
        txtAssetNum.Font = New Font("Arial Narrow", 9F)
        txtAssetNum.Location = New Point(351, 27)
        txtAssetNum.Margin = New Padding(2, 3, 2, 3)
        txtAssetNum.Name = "txtAssetNum"
        txtAssetNum.Size = New Size(430, 25)
        txtAssetNum.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 9F)
        Label6.Location = New Point(234, 117)
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
        Label4.Location = New Point(139, 178)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(159, 20)
        Label4.TabIndex = 21
        Label4.Text = "Defender Installation Status"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9F)
        Label2.Location = New Point(182, 27)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 19
        Label2.Text = "Enter asset number"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Orange
        btnSearch.Font = New Font("Arial Narrow", 9F)
        btnSearch.Location = New Point(815, 23)
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
        Label1.Location = New Point(205, 239)
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
        cboOffice.Location = New Point(351, 239)
        cboOffice.Margin = New Padding(2, 3, 2, 3)
        cboOffice.Name = "cboOffice"
        cboOffice.Size = New Size(430, 28)
        cboOffice.TabIndex = 58
        ' 
        ' txtSAP
        ' 
        txtSAP.Font = New Font("Arial Narrow", 9F)
        txtSAP.Location = New Point(351, 117)
        txtSAP.Margin = New Padding(2, 3, 2, 3)
        txtSAP.Name = "txtSAP"
        txtSAP.Size = New Size(430, 25)
        txtSAP.TabIndex = 60
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {strHome, ToolStripMenuItem1, AdministrationToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1094, 28)
        MenuStrip1.TabIndex = 63
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
        GroupBox1.Controls.Add(txtAssetNum)
        GroupBox1.Controls.Add(txtSAP)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cboOffice)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(chkStatus)
        GroupBox1.Location = New Point(46, 205)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1003, 290)
        GroupBox1.TabIndex = 64
        GroupBox1.TabStop = False
        ' 
        ' frmUpdate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(MenuStrip1)
        Controls.Add(btnUpdate)
        Controls.Add(lblState)
        Controls.Add(GroupBox1)
        MaximizeBox = False
        Name = "frmUpdate"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmUpdate"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblState As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chkStatus As CheckBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtAssetNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboOffice As ComboBox
    Friend WithEvents txtSAP As TextBox
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
