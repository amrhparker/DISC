<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogs
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
        Label1 = New Label()
        dataGridViewLogs = New DataGridView()
        CType(dataGridViewLogs, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.Location = New Point(11, 12)
        btnBack.Margin = New Padding(2, 3, 2, 3)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(40, 40)
        btnBack.TabIndex = 3
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial Narrow", 16F)
        Label1.Location = New Point(470, 88)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(9, 4, 9, 4)
        Label1.Size = New Size(155, 39)
        Label1.TabIndex = 4
        Label1.Text = "Activity Logs"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dataGridViewLogs
        ' 
        dataGridViewLogs.AllowUserToAddRows = False
        dataGridViewLogs.AllowUserToDeleteRows = False
        dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridViewLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dataGridViewLogs.BackgroundColor = SystemColors.Control
        dataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewLogs.GridColor = Color.PeachPuff
        dataGridViewLogs.Location = New Point(96, 185)
        dataGridViewLogs.Name = "dataGridViewLogs"
        dataGridViewLogs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dataGridViewLogs.Size = New Size(902, 406)
        dataGridViewLogs.TabIndex = 5
        ' 
        ' frmLogs
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(dataGridViewLogs)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        MaximizeBox = False
        Name = "frmLogs"
        Text = "frmLogs"
        CType(dataGridViewLogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dataGridViewLogs As DataGridView
End Class
