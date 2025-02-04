<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnMap = New Button()
        btnAsset = New Button()
        GroupBox1 = New GroupBox()
        lblTotPCDef = New Label()
        lblTotPC = New Label()
        lblNumOff = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnMap
        ' 
        btnMap.BackColor = Color.Orange
        btnMap.Cursor = Cursors.Hand
        btnMap.Font = New Font("Microsoft Sans Serif", 9F)
        btnMap.ForeColor = SystemColors.ControlText
        btnMap.Location = New Point(280, 270)
        btnMap.Name = "btnMap"
        btnMap.Padding = New Padding(5)
        btnMap.Size = New Size(222, 38)
        btnMap.TabIndex = 0
        btnMap.Text = "View by Office Map"
        btnMap.UseVisualStyleBackColor = False
        ' 
        ' btnAsset
        ' 
        btnAsset.BackColor = Color.Orange
        btnAsset.Cursor = Cursors.Hand
        btnAsset.Font = New Font("Microsoft Sans Serif", 9F)
        btnAsset.ForeColor = SystemColors.ControlText
        btnAsset.Location = New Point(595, 270)
        btnAsset.Name = "btnAsset"
        btnAsset.Padding = New Padding(5)
        btnAsset.Size = New Size(222, 38)
        btnAsset.TabIndex = 1
        btnAsset.Text = "Search by Asset No."
        btnAsset.UseVisualStyleBackColor = False
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
        GroupBox1.Font = New Font("Microsoft Sans Serif", 9F)
        GroupBox1.Location = New Point(331, 336)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(433, 182)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Overview"
        ' 
        ' lblTotPCDef
        ' 
        lblTotPCDef.AutoSize = True
        lblTotPCDef.Location = New Point(248, 132)
        lblTotPCDef.Name = "lblTotPCDef"
        lblTotPCDef.Size = New Size(16, 18)
        lblTotPCDef.TabIndex = 5
        lblTotPCDef.Text = "0"
        ' 
        ' lblTotPC
        ' 
        lblTotPC.AutoSize = True
        lblTotPC.Location = New Point(248, 85)
        lblTotPC.Name = "lblTotPC"
        lblTotPC.Size = New Size(16, 18)
        lblTotPC.TabIndex = 4
        lblTotPC.Text = "0"
        ' 
        ' lblNumOff
        ' 
        lblNumOff.AutoSize = True
        lblNumOff.Location = New Point(248, 38)
        lblNumOff.Name = "lblNumOff"
        lblNumOff.Size = New Size(16, 18)
        lblNumOff.TabIndex = 3
        lblNumOff.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(209, 18)
        Label3.TabIndex = 2
        Label3.Text = "Total Assets without Defender:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(137, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 18)
        Label2.TabIndex = 1
        Label2.Text = "Total Assets:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(94, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 18)
        Label1.TabIndex = 0
        Label1.Text = "Number of Offices: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 40F, FontStyle.Bold)
        Label4.Location = New Point(449, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(196, 76)
        Label4.TabIndex = 3
        Label4.Text = "DISC"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Orange
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Microsoft Sans Serif", 9F)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(436, 546)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(5)
        Button1.Size = New Size(222, 38)
        Button1.TabIndex = 5
        Button1.Text = "Administration Access"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold)
        Label5.Location = New Point(205, 211)
        Label5.Name = "Label5"
        Label5.Size = New Size(684, 31)
        Label5.TabIndex = 6
        Label5.Text = "FGV Prodata Defender Installation Checker System"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(btnAsset)
        Controls.Add(btnMap)
        MaximizeBox = False
        Name = "frmHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnMap As Button
    Friend WithEvents btnAsset As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotPCDef As Label
    Friend WithEvents lblTotPC As Label
    Friend WithEvents lblNumOff As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label

End Class
