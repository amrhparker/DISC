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
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        txtAssetNum = New TextBox()
        btnRegister = New Button()
        chkStatus = New CheckBox()
        Label7 = New Label()
        cboOffice = New ComboBox()
        txtSAP = New TextBox()
        Label5 = New Label()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial Narrow", 16F)
        Label1.Location = New Point(443, 118)
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
        Label2.Location = New Point(0, 27)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 4
        Label2.Text = "Enter asset number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 9F)
        Label4.Location = New Point(11, 189)
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
        Label6.Location = New Point(23, 270)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 20)
        Label6.TabIndex = 8
        Label6.Text = "Office Location"
        ' 
        ' txtAssetNum
        ' 
        txtAssetNum.Font = New Font("Arial Narrow", 9F)
        txtAssetNum.Location = New Point(160, 27)
        txtAssetNum.Margin = New Padding(2, 3, 2, 3)
        txtAssetNum.Name = "txtAssetNum"
        txtAssetNum.Size = New Size(430, 25)
        txtAssetNum.TabIndex = 9
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Orange
        btnRegister.Font = New Font("Arial Narrow", 9F)
        btnRegister.Location = New Point(506, 559)
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
        chkStatus.Location = New Point(160, 188)
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
        Label7.Location = New Point(241, 191)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(130, 20)
        Label7.TabIndex = 16
        Label7.Text = "(Untick if not installed)"
        ' 
        ' cboOffice
        ' 
        cboOffice.Font = New Font("Arial Narrow", 9F)
        cboOffice.FormattingEnabled = True
        cboOffice.Location = New Point(160, 269)
        cboOffice.Margin = New Padding(2, 3, 2, 3)
        cboOffice.Name = "cboOffice"
        cboOffice.Size = New Size(430, 28)
        cboOffice.TabIndex = 57
        ' 
        ' txtSAP
        ' 
        txtSAP.Font = New Font("Arial Narrow", 9F)
        txtSAP.Location = New Point(160, 108)
        txtSAP.Margin = New Padding(2, 3, 2, 3)
        txtSAP.Name = "txtSAP"
        txtSAP.Size = New Size(430, 25)
        txtSAP.TabIndex = 59
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 9F)
        Label5.Location = New Point(52, 108)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 58
        Label5.Text = "Asset SAP"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {strHome, ToolStripMenuItem1, AdministrationToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1094, 28)
        MenuStrip1.TabIndex = 64
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
        GroupBox1.CausesValidation = False
        GroupBox1.Controls.Add(cboOffice)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtSAP)
        GroupBox1.Controls.Add(chkStatus)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtAssetNum)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Location = New Point(252, 189)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(590, 303)
        GroupBox1.TabIndex = 65
        GroupBox1.TabStop = False
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(MenuStrip1)
        Controls.Add(btnRegister)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Font = New Font("Arial Narrow", 9F)
        Margin = New Padding(2, 3, 2, 3)
        MaximizeBox = False
        Name = "frmRegister"
        Text = "frmAdmin"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAssetNum As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents chkStatus As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboOffice As ComboBox
    Friend WithEvents txtSAP As TextBox
    Friend WithEvents Label5 As Label
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
