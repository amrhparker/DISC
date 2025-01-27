<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
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
        ListView1 = New ListView()
        GroupBox1 = New GroupBox()
        lblTotPCDef = New Label()
        lblTotPC = New Label()
        lblNumOff = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnNext = New Button()
        btnPrevious = New Button()
        lblPageInfo = New Label()
        btnFirstPage = New Button()
        btnLastPage = New Button()
        GroupBox1.SuspendLayout()
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
        btnBack.TabIndex = 1
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.Orange
        ListView1.Font = New Font("Arial Narrow", 9F)
        ListView1.FullRowSelect = True
        ListView1.Location = New Point(96, 186)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(902, 406)
        ListView1.TabIndex = 3
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Orange
        GroupBox1.Controls.Add(lblTotPCDef)
        GroupBox1.Controls.Add(lblTotPC)
        GroupBox1.Controls.Add(lblNumOff)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Arial Narrow", 12F)
        GroupBox1.Location = New Point(366, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(354, 129)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' lblTotPCDef
        ' 
        lblTotPCDef.AutoSize = True
        lblTotPCDef.Font = New Font("Arial Narrow", 9F)
        lblTotPCDef.Location = New Point(241, 91)
        lblTotPCDef.Name = "lblTotPCDef"
        lblTotPCDef.Size = New Size(16, 20)
        lblTotPCDef.TabIndex = 5
        lblTotPCDef.Text = "0"
        ' 
        ' lblTotPC
        ' 
        lblTotPC.AutoSize = True
        lblTotPC.Font = New Font("Arial Narrow", 9F)
        lblTotPC.Location = New Point(241, 59)
        lblTotPC.Name = "lblTotPC"
        lblTotPC.Size = New Size(16, 20)
        lblTotPC.TabIndex = 4
        lblTotPC.Text = "0"
        ' 
        ' lblNumOff
        ' 
        lblNumOff.AutoSize = True
        lblNumOff.Font = New Font("Arial Narrow", 9F)
        lblNumOff.Location = New Point(241, 27)
        lblNumOff.Name = "lblNumOff"
        lblNumOff.Size = New Size(16, 20)
        lblNumOff.TabIndex = 3
        lblNumOff.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9F)
        Label3.Location = New Point(42, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 20)
        Label3.TabIndex = 2
        Label3.Text = "Total PCs without Defender:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9F)
        Label2.Location = New Point(138, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 1
        Label2.Text = "Total PCs:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 9F)
        Label1.Location = New Point(90, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 20)
        Label1.TabIndex = 0
        Label1.Text = "Number of Offices: "
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.Transparent
        btnNext.BackgroundImage = My.Resources.Resources._next
        btnNext.BackgroundImageLayout = ImageLayout.Zoom
        btnNext.FlatAppearance.BorderSize = 0
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Location = New Point(552, 632)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(25, 25)
        btnNext.TabIndex = 26
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Transparent
        btnPrevious.BackgroundImage = My.Resources.Resources.previous
        btnPrevious.BackgroundImageLayout = ImageLayout.Zoom
        btnPrevious.FlatAppearance.BorderSize = 0
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Location = New Point(517, 632)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(25, 25)
        btnPrevious.TabIndex = 25
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' lblPageInfo
        ' 
        lblPageInfo.AutoSize = True
        lblPageInfo.Location = New Point(498, 602)
        lblPageInfo.Name = "lblPageInfo"
        lblPageInfo.Size = New Size(99, 20)
        lblPageInfo.TabIndex = 27
        lblPageInfo.Text = "Page 1 of 410"
        ' 
        ' btnFirstPage
        ' 
        btnFirstPage.BackColor = Color.Transparent
        btnFirstPage.BackgroundImage = My.Resources.Resources.first_page
        btnFirstPage.BackgroundImageLayout = ImageLayout.Zoom
        btnFirstPage.FlatAppearance.BorderSize = 0
        btnFirstPage.FlatStyle = FlatStyle.Flat
        btnFirstPage.Location = New Point(482, 632)
        btnFirstPage.Name = "btnFirstPage"
        btnFirstPage.Size = New Size(25, 25)
        btnFirstPage.TabIndex = 28
        btnFirstPage.UseVisualStyleBackColor = False
        ' 
        ' btnLastPage
        ' 
        btnLastPage.BackColor = Color.Transparent
        btnLastPage.BackgroundImage = My.Resources.Resources.last_page
        btnLastPage.BackgroundImageLayout = ImageLayout.Zoom
        btnLastPage.FlatAppearance.BorderSize = 0
        btnLastPage.FlatStyle = FlatStyle.Flat
        btnLastPage.Location = New Point(587, 632)
        btnLastPage.Name = "btnLastPage"
        btnLastPage.Size = New Size(25, 25)
        btnLastPage.TabIndex = 29
        btnLastPage.UseVisualStyleBackColor = False
        ' 
        ' frmList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(btnLastPage)
        Controls.Add(btnFirstPage)
        Controls.Add(lblPageInfo)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(GroupBox1)
        Controls.Add(ListView1)
        Controls.Add(btnBack)
        MaximizeBox = False
        Name = "frmList"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotPCDef As Label
    Friend WithEvents lblTotPC As Label
    Friend WithEvents lblNumOff As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblPageInfo As Label
    Friend WithEvents btnFirstPage As Button
    Friend WithEvents btnLastPage As Button
End Class
