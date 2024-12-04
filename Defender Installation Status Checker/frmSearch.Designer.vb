<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        btnBack = New Button()
        txtSearch = New TextBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblNum = New Label()
        lblStatus = New Label()
        lblLoc = New Label()
        Label6 = New Label()
        lblOff = New Label()
        btnSearch = New Button()
        Label7 = New Label()
        lblSAP = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Orange
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial Narrow", 16F)
        Label1.Location = New Point(409, 55)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10, 5, 10, 5)
        Label1.Size = New Size(276, 41)
        Label1.TabIndex = 3
        Label1.Text = "Search by Asset Number"
        Label1.TextAlign = ContentAlignment.MiddleCenter
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
        btnBack.TabIndex = 4
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.Orange
        txtSearch.Font = New Font("Arial", 9F)
        txtSearch.Location = New Point(200, 168)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Insert asset number"
        txtSearch.Size = New Size(608, 25)
        txtSearch.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Orange
        PictureBox2.Location = New Point(199, 265)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(696, 314)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9F)
        Label2.Location = New Point(219, 309)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 8
        Label2.Text = "Asset No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9F)
        Label3.Location = New Point(220, 359)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 20)
        Label3.TabIndex = 9
        Label3.Text = "Defender Installation Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 9F)
        Label4.Location = New Point(219, 468)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 10
        Label4.Text = "Location"
        ' 
        ' lblNum
        ' 
        lblNum.AutoSize = True
        lblNum.BackColor = Color.Orange
        lblNum.Font = New Font("Arial", 9F)
        lblNum.Location = New Point(452, 312)
        lblNum.Name = "lblNum"
        lblNum.Size = New Size(12, 17)
        lblNum.TabIndex = 14
        lblNum.Text = " "
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BackColor = Color.Orange
        lblStatus.Font = New Font("Arial", 9F)
        lblStatus.Location = New Point(452, 365)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(12, 17)
        lblStatus.TabIndex = 15
        lblStatus.Text = " "
        ' 
        ' lblLoc
        ' 
        lblLoc.AutoSize = True
        lblLoc.BackColor = Color.Orange
        lblLoc.Font = New Font("Arial", 9F)
        lblLoc.Location = New Point(452, 471)
        lblLoc.Name = "lblLoc"
        lblLoc.Size = New Size(12, 17)
        lblLoc.TabIndex = 16
        lblLoc.Text = " "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 9F)
        Label6.Location = New Point(219, 518)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 18
        Label6.Text = "Office"
        ' 
        ' lblOff
        ' 
        lblOff.AutoSize = True
        lblOff.BackColor = Color.Orange
        lblOff.Font = New Font("Arial", 9F)
        lblOff.Location = New Point(452, 524)
        lblOff.Name = "lblOff"
        lblOff.Size = New Size(12, 17)
        lblOff.TabIndex = 19
        lblOff.Text = " "
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Orange
        btnSearch.Font = New Font("Arial Narrow", 9F)
        btnSearch.Location = New Point(813, 166)
        btnSearch.Margin = New Padding(2, 3, 2, 3)
        btnSearch.Name = "btnSearch"
        btnSearch.Padding = New Padding(2)
        btnSearch.Size = New Size(82, 32)
        btnSearch.TabIndex = 32
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 9F)
        Label7.Location = New Point(220, 415)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 20)
        Label7.TabIndex = 33
        Label7.Text = "Asset SAP"
        ' 
        ' lblSAP
        ' 
        lblSAP.AutoSize = True
        lblSAP.BackColor = Color.Orange
        lblSAP.Font = New Font("Arial", 9F)
        lblSAP.Location = New Point(452, 418)
        lblSAP.Name = "lblSAP"
        lblSAP.Size = New Size(12, 17)
        lblSAP.TabIndex = 34
        lblSAP.Text = " "
        ' 
        ' frmSearch
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(lblSAP)
        Controls.Add(Label7)
        Controls.Add(btnSearch)
        Controls.Add(lblOff)
        Controls.Add(Label6)
        Controls.Add(lblLoc)
        Controls.Add(lblStatus)
        Controls.Add(lblNum)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(btnBack)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        MaximizeBox = False
        Name = "frmSearch"
        Text = "frmSearch"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLoc As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblOff As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSAP As Label
End Class
