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
        btnBack = New Button()
        txtSearch = New TextBox()
        ListView2 = New ListView()
        Label1 = New Label()
        lblPageInfo = New Label()
        btnLastPage = New Button()
        btnFirstPage = New Button()
        btnNext = New Button()
        btnPrevious = New Button()
        btnSearch = New Button()
        btnLogout = New Button()
        btnDelete = New Button()
        btnRegister = New Button()
        btnUpdate = New Button()
        btnExport = New Button()
        SaveFileDialog1 = New SaveFileDialog()
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
        btnBack.TabIndex = 5
        btnBack.UseVisualStyleBackColor = False
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
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.OrangeRed
        btnLogout.Font = New Font("Arial Narrow", 9F)
        btnLogout.Location = New Point(678, 12)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(122, 40)
        btnLogout.TabIndex = 60
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
        btnDelete.TabIndex = 59
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
        btnRegister.TabIndex = 58
        btnRegister.Text = "Register Asset"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Orange
        btnUpdate.Font = New Font("Arial Narrow", 9F)
        btnUpdate.Location = New Point(294, 12)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(122, 40)
        btnUpdate.TabIndex = 57
        btnUpdate.Text = "Update Asset"
        btnUpdate.UseVisualStyleBackColor = False
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
        ' frmView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(btnExport)
        Controls.Add(btnLogout)
        Controls.Add(btnDelete)
        Controls.Add(btnRegister)
        Controls.Add(btnUpdate)
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
        Controls.Add(btnBack)
        MaximizeBox = False
        Name = "frmView"
        Text = "frmView"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnBack As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPageInfo As Label
    Friend WithEvents btnLastPage As Button
    Friend WithEvents btnFirstPage As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
