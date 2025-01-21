<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMenu
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
        Panel4 = New Panel()
        btnDelete = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        btnUpdate = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        btnRegister = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        btnView = New Button()
        Label2 = New Label()
        Label1 = New Label()
        lblState = New Label()
        btnLogout = New Button()
        btnLogs = New Button()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Orange
        Panel4.Controls.Add(btnDelete)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(572, 371)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(250, 161)
        Panel4.TabIndex = 9
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.PeachPuff
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(78, 101)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Go"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 9F)
        Label7.Location = New Point(63, 52)
        Label7.Name = "Label7"
        Label7.Size = New Size(123, 20)
        Label7.TabIndex = 2
        Label7.Text = "Delete specific asset"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Narrow", 12F)
        Label8.Location = New Point(71, 13)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 24)
        Label8.TabIndex = 1
        Label8.Text = "Delete Asset"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Orange
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(272, 371)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 161)
        Panel3.TabIndex = 10
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.PeachPuff
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Location = New Point(78, 101)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Go"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 9F)
        Label5.Location = New Point(60, 52)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 20)
        Label5.TabIndex = 2
        Label5.Text = "Update asset’s details"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 12F)
        Label6.Location = New Point(71, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 24)
        Label6.TabIndex = 1
        Label6.Text = "Update Asset"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Orange
        Panel2.Controls.Add(btnRegister)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(572, 158)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 161)
        Panel2.TabIndex = 11
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.PeachPuff
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Location = New Point(78, 101)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(94, 29)
        btnRegister.TabIndex = 3
        btnRegister.Text = "Go"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9F)
        Label3.Location = New Point(28, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(193, 20)
        Label3.TabIndex = 2
        Label3.Text = "Register new assets to the system"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 12F)
        Label4.Location = New Point(67, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 24)
        Label4.TabIndex = 1
        Label4.Text = "Register Asset"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Orange
        Panel1.Controls.Add(btnView)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(272, 158)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 161)
        Panel1.TabIndex = 8
        ' 
        ' btnView
        ' 
        btnView.BackColor = Color.PeachPuff
        btnView.FlatStyle = FlatStyle.Flat
        btnView.Location = New Point(78, 101)
        btnView.Name = "btnView"
        btnView.Size = New Size(94, 29)
        btnView.TabIndex = 3
        btnView.Text = "Go"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9F)
        Label2.Location = New Point(27, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 20)
        Label2.TabIndex = 2
        Label2.Text = "View list of assets and their details"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 12F)
        Label1.Location = New Point(79, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 24)
        Label1.TabIndex = 1
        Label1.Text = "View Asset"
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.BackColor = Color.Transparent
        lblState.Cursor = Cursors.Hand
        lblState.Font = New Font("Arial Narrow", 16F)
        lblState.Location = New Point(431, 88)
        lblState.Name = "lblState"
        lblState.Padding = New Padding(10, 5, 10, 5)
        lblState.Size = New Size(232, 41)
        lblState.TabIndex = 7
        lblState.Text = "Administration Menu"
        lblState.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.OrangeRed
        btnLogout.Location = New Point(550, 563)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(122, 40)
        btnLogout.TabIndex = 56
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnLogs
        ' 
        btnLogs.BackColor = Color.PeachPuff
        btnLogs.Location = New Point(422, 563)
        btnLogs.Name = "btnLogs"
        btnLogs.Size = New Size(122, 40)
        btnLogs.TabIndex = 4
        btnLogs.Text = "Check Logs"
        btnLogs.UseVisualStyleBackColor = False
        ' 
        ' frmAdminMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(btnLogs)
        Controls.Add(btnLogout)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblState)
        Name = "frmAdminMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAdminMenu"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnView As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblState As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLogs As Button
End Class
