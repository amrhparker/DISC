<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmView
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
        ListView1 = New ListView()
        txtSearch = New TextBox()
        ListView2 = New ListView()
        Label1 = New Label()
        lblPageInfo = New Label()
        btnLastPage = New Button()
        btnFirstPage = New Button()
        btnNext = New Button()
        btnPrevious = New Button()
        btnSearch = New Button()
        btnExport = New Button()
        SaveFileDialog1 = New SaveFileDialog()
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
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.Orange
        ListView1.Font = New Font("Arial Narrow", 9F)
        ListView1.FullRowSelect = True
        ListView1.Location = New Point(96, 246)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(902, 343)
        ListView1.TabIndex = 7
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.Orange
        txtSearch.Font = New Font("Arial", 9F)
        txtSearch.Location = New Point(224, 77)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Insert asset number"
        txtSearch.Size = New Size(608, 25)
        txtSearch.TabIndex = 19
        ' 
        ' ListView2
        ' 
        ListView2.BackColor = Color.Orange
        ListView2.Font = New Font("Arial Narrow", 9F)
        ListView2.FullRowSelect = True
        ListView2.Location = New Point(96, 160)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(902, 80)
        ListView2.TabIndex = 21
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 12F)
        Label1.Location = New Point(504, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 24)
        Label1.TabIndex = 22
        Label1.Text = "Search Result"
        ' 
        ' lblPageInfo
        ' 
        lblPageInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPageInfo.AutoSize = True
        lblPageInfo.Location = New Point(498, 596)
        lblPageInfo.Name = "lblPageInfo"
        lblPageInfo.Size = New Size(99, 20)
        lblPageInfo.TabIndex = 25
        lblPageInfo.Text = "Page 1 of 410"
        lblPageInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLastPage
        ' 
        btnLastPage.BackColor = Color.Transparent
        btnLastPage.BackgroundImage = My.Resources.Resources.last_page
        btnLastPage.BackgroundImageLayout = ImageLayout.Zoom
        btnLastPage.FlatAppearance.BorderSize = 0
        btnLastPage.FlatStyle = FlatStyle.Flat
        btnLastPage.Location = New Point(587, 621)
        btnLastPage.Name = "btnLastPage"
        btnLastPage.Size = New Size(25, 25)
        btnLastPage.TabIndex = 33
        btnLastPage.UseVisualStyleBackColor = False
        ' 
        ' btnFirstPage
        ' 
        btnFirstPage.BackColor = Color.Transparent
        btnFirstPage.BackgroundImage = My.Resources.Resources.first_page
        btnFirstPage.BackgroundImageLayout = ImageLayout.Zoom
        btnFirstPage.FlatAppearance.BorderSize = 0
        btnFirstPage.FlatStyle = FlatStyle.Flat
        btnFirstPage.Location = New Point(482, 621)
        btnFirstPage.Name = "btnFirstPage"
        btnFirstPage.Size = New Size(25, 25)
        btnFirstPage.TabIndex = 32
        btnFirstPage.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.Transparent
        btnNext.BackgroundImage = My.Resources.Resources._next
        btnNext.BackgroundImageLayout = ImageLayout.Zoom
        btnNext.FlatAppearance.BorderSize = 0
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Location = New Point(552, 621)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(25, 25)
        btnNext.TabIndex = 31
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Transparent
        btnPrevious.BackgroundImage = My.Resources.Resources.previous
        btnPrevious.BackgroundImageLayout = ImageLayout.Zoom
        btnPrevious.FlatAppearance.BorderSize = 0
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Location = New Point(517, 621)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(25, 25)
        btnPrevious.TabIndex = 30
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Orange
        btnSearch.Font = New Font("Arial Narrow", 9F)
        btnSearch.Location = New Point(837, 75)
        btnSearch.Margin = New Padding(2, 3, 2, 3)
        btnSearch.Name = "btnSearch"
        btnSearch.Padding = New Padding(2)
        btnSearch.Size = New Size(82, 32)
        btnSearch.TabIndex = 34
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.Orange
        btnExport.Font = New Font("Arial Narrow", 9F)
        btnExport.Location = New Point(482, 651)
        btnExport.Margin = New Padding(2, 3, 2, 3)
        btnExport.Name = "btnExport"
        btnExport.Padding = New Padding(2)
        btnExport.Size = New Size(130, 32)
        btnExport.TabIndex = 61
        btnExport.Text = "Export to CSV"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {strHome, ToolStripMenuItem1, AdministrationToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1094, 28)
        MenuStrip1.TabIndex = 62
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
        ' frmView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(btnExport)
        Controls.Add(btnSearch)
        Controls.Add(btnLastPage)
        Controls.Add(btnFirstPage)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblPageInfo)
        Controls.Add(Label1)
        Controls.Add(ListView2)
        Controls.Add(txtSearch)
        Controls.Add(ListView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "frmView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Asset"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPageInfo As Label
    Friend WithEvents btnLastPage As Button
    Friend WithEvents btnFirstPage As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
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
End Class
