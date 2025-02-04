<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMap
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
        components = New ComponentModel.Container()
        btnBack = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.TabIndex = 0
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Orange
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial Narrow", 16F)
        Label1.Location = New Point(416, 83)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10, 5, 10, 5)
        Label1.Size = New Size(222, 41)
        Label1.TabIndex = 1
        Label1.Text = "View by Office Map"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Orange
        PictureBox1.BackgroundImage = My.Resources.Resources.map_flag_real
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(96, 149)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(902, 458)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' frmMap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 691)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        MaximizeBox = False
        Name = "frmMap"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Map"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
