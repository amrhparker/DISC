Public Class frmMap
    Private loc As Integer
    Private stateToolTip As New ToolTip()
    Private perlisRectangle As Rectangle() = {
        New Rectangle(99, 105, 15, 16),  ' Rectangle 1
        New Rectangle(77, 115, 20, 20),   ' Rectangle 2
        New Rectangle(99, 121, 7, 8),
        New Rectangle(106, 120, 6, 3)
    }
    Private ppinangRectangle As Rectangle() = {
        New Rectangle(113, 162, 8, 19),  ' Rectangle 1
        New Rectangle(104, 166, 6, 9)   ' Rectangle 2
    }
    Private kedahRectangle As Rectangle() = {
        New Rectangle(110, 123, 24, 7),  ' Rectangle 1
        New Rectangle(112, 131, 27, 30),   ' Rectangle 2
        New Rectangle(121, 161, 14, 9),     ' Rectangle 3
        New Rectangle(122, 172, 7, 10),
        New Rectangle(160, 226, 9, 19),
        New Rectangle(114, 117, 21, 6),
        New Rectangle(106, 124, 7, 18),
        New Rectangle(139, 128, 9, 26)
    }
    Private perakRectangle As Rectangle() = {
        New Rectangle(113, 184, 47, 59),  ' Rectangle 1
        New Rectangle(140, 152, 33, 18),   ' Rectangle 2
        New Rectangle(130, 172, 36, 10),     ' Rectangle 3
        New Rectangle(164, 147, 9, 7),
        New Rectangle(155, 150, 9, 4),
        New Rectangle(146, 243, 15, 5)
    }
    Private selangorRectangle As Rectangle() = {
        New Rectangle(145, 251, 34, 20),
        New Rectangle(153, 271, 18, 17),
        New Rectangle(178, 226, 5, 20),
        New Rectangle(162, 288, 15, 10),
        New Rectangle(133, 243, 13, 8),
        New Rectangle(146, 248, 33, 3)
    }
    Private klRectangle As Rectangle() = {
        New Rectangle(172, 271, 6, 15)
    }
    Private nsemRectangle As Rectangle() = {
        New Rectangle(177, 288, 40, 18),
        New Rectangle(186, 280, 26, 8),
        New Rectangle(187, 275, 21, 5),
        New Rectangle(212, 283, 8, 11)
    }
    Private melakaRectangle As Rectangle() = {
        New Rectangle(189, 307, 24, 6),
        New Rectangle(193, 314, 19, 5),
        New Rectangle(303, 319, 11, 4)
    }
    Private johorRectangle As Rectangle() = {
        New Rectangle(220, 290, 7, 10),
        New Rectangle(218, 300, 36, 8),
        New Rectangle(227, 293, 3, 6),
        New Rectangle(214, 308, 50, 13),
        New Rectangle(252, 303, 5, 5),
        New Rectangle(264, 297, 9, 55),
        New Rectangle(214, 321, 7, 6),
        New Rectangle(217, 327, 47, 8),
        New Rectangle(230, 335, 34, 4),
        New Rectangle(239, 339, 26, 4),
        New Rectangle(255, 346, 10, 11),
        New Rectangle(274, 307, 8, 46),
        New Rectangle(286, 348, 10, 9),
        New Rectangle(282, 334, 12, 14),
        New Rectangle(282, 321, 5, 12)
    }
    Private pahangRectangle As Rectangle() = {
        New Rectangle(288, 286, 5, 9),
        New Rectangle(254, 285, 10, 17),
        New Rectangle(220, 283, 36, 8),
        New Rectangle(230, 290, 24, 9),
        New Rectangle(215, 254, 41, 29),
        New Rectangle(209, 275, 5, 5),
        New Rectangle(184, 254, 30, 20),
        New Rectangle(179, 254, 5, 12),
        New Rectangle(179, 239, 75, 15),
        New Rectangle(170, 234, 77, 4),
        New Rectangle(170, 229, 73, 4),
        New Rectangle(170, 213, 61, 16),
        New Rectangle(231, 213, 5, 6),
        New Rectangle(164, 208, 6, 18),
        New Rectangle(179, 204, 50, 8),
        New Rectangle(170, 208, 8, 4)
    }
    Private kelantanRectangle As Rectangle() = {
        New Rectangle(160, 199, 19, 9),
        New Rectangle(179, 199, 38, 4),
        New Rectangle(162, 193, 57, 6),
        New Rectangle(164, 183, 49, 9),
        New Rectangle(185, 142, 23, 41),
        New Rectangle(174, 150, 12, 33),
        New Rectangle(166, 173, 8, 9),
        New Rectangle(187, 138, 22, 3),
        New Rectangle(192, 130, 15, 7),
        New Rectangle(209, 142, 3, 9)
    }
    Private tganuRectangle As Rectangle() = {
        New Rectangle(209, 152, 11, 31),
        New Rectangle(220, 155, 10, 28),
        New Rectangle(213, 182, 39, 9),
        New Rectangle(230, 178, 17, 4),
        New Rectangle(230, 163, 10, 15),
        New Rectangle(219, 192, 38, 11),
        New Rectangle(229, 203, 28, 9),
        New Rectangle(236, 212, 21, 14),
        New Rectangle(235, 225, 15, 3),
        New Rectangle(240, 167, 7, 10),
        New Rectangle(250, 225, 7, 13)
    }
    Private srwkRectangle As Rectangle() = {
        New Rectangle(399, 358, 44, 13),
        New Rectangle(385, 342, 14, 23),
        New Rectangle(366, 323, 19, 32),
        New Rectangle(398, 337, 11, 20),
        New Rectangle(410, 342, 33, 15),
        New Rectangle(398, 370, 37, 3),
        New Rectangle(405, 374, 22, 7),
        New Rectangle(440, 308, 49, 67),
        New Rectangle(489, 308, 67, 56),
        New Rectangle(556, 308, 44, 46),
        New Rectangle(600, 308, 13, 39),
        New Rectangle(448, 300, 181, 8),
        New Rectangle(453, 287, 170, 12),
        New Rectangle(484, 280, 146, 8),
        New Rectangle(546, 246, 104, 33),
        New Rectangle(530, 267, 16, 12),
        New Rectangle(547, 234, 103, 13),
        New Rectangle(571, 205, 15, 27),
        New Rectangle(587, 222, 14, 11),
        New Rectangle(601, 219, 49, 15),
        New Rectangle(607, 192, 16, 26),
        New Rectangle(626, 191, 21, 28)
    }
    Private sabahRectangle As Rectangle() = {
        New Rectangle(650, 164, 117, 63),
        New Rectangle(636, 159, 14, 31),
        New Rectangle(627, 170, 5, 7),
        New Rectangle(659, 147, 87, 16),
        New Rectangle(688, 118, 58, 30),
        New Rectangle(669, 142, 19, 6),
        New Rectangle(672, 134, 16, 8),
        New Rectangle(674, 130, 14, 3),
        New Rectangle(679, 121, 9, 8),
        New Rectangle(695, 95, 9, 22),
        New Rectangle(693, 111, 3, 6),
        New Rectangle(705, 113, 27, 5),
        New Rectangle(711, 106, 14, 6),
        New Rectangle(713, 95, 10, 10),
        New Rectangle(706, 79, 19, 8),
        New Rectangle(746, 156, 21, 8),
        New Rectangle(745, 144, 9, 12),
        New Rectangle(755, 139, 9, 12),
        New Rectangle(767, 150, 18, 40),
        New Rectangle(785, 166, 14, 25),
        New Rectangle(799, 168, 18, 19),
        New Rectangle(767, 202, 14, 17),
        New Rectangle(781, 210, 14, 8)
    }

    ' Define the clickable states on the image
    Private Function perlis(x As Integer, y As Integer) As Boolean
        ' Example state 1 (a rectangular area on the map)
        For Each rect As Rectangle In perlisRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function ppinang(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In ppinangRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function kedah(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In kedahRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function perak(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In perakRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function selangor(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In selangorRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function kl(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In klRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function nsem(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In nsemRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function melaka(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In melakaRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function johor(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In johorRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function pahang(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In pahangRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function kelantan(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In kelantanRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function tganu(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In tganuRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function srwk(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In srwkRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function sabah(x As Integer, y As Integer) As Boolean
        ' Example state 2 (another rectangular area on the map)
        For Each rect As Rectangle In sabahRectangle
            If rect.Contains(x, y) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        ' Get the X and Y coordinates of the mouse
        Dim mouseX As Integer = e.X
        Dim mouseY As Integer = e.Y

        ' Check if the mouse is hovering over specific states
        If perlis(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Perlis")
        ElseIf kedah(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Kedah")
        ElseIf ppinang(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Pulau Pinang")
        ElseIf perak(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Perak")
        ElseIf selangor(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Selangor")
        ElseIf kl(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "W.P. Kuala Lumpur")
        ElseIf nsem(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Negeri Sembilan")
        ElseIf melaka(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Melaka")
        ElseIf johor(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Johor")
        ElseIf pahang(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Pahang")
        ElseIf kelantan(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Kelantan")
        ElseIf tganu(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Terengganu")
        ElseIf sabah(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Sabah")
        ElseIf srwk(mouseX, mouseY) Then
            stateToolTip.SetToolTip(PictureBox1, "Sarawak")
        Else
            ' Clear the ToolTip if the mouse is not over any state
            stateToolTip.SetToolTip(PictureBox1, "")
        End If
    End Sub
    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        Dim mouseX As Integer = e.X
        Dim mouseY As Integer = e.Y

        ' Check if the click is inside any of the rectangles
        If perlis(mouseX, mouseY) Then
            loc = 1
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf kedah(mouseX, mouseY) Then
            loc = 2
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf ppinang(mouseX, mouseY) Then
            loc = 3
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf perak(mouseX, mouseY) Then
            loc = 4
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf selangor(mouseX, mouseY) Then
            loc = 5
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf kl(mouseX, mouseY) Then
            loc = 14
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf nsem(mouseX, mouseY) Then
            loc = 6
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf melaka(mouseX, mouseY) Then
            loc = 7
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf johor(mouseX, mouseY) Then
            loc = 8
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf pahang(mouseX, mouseY) Then
            loc = 9
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf kelantan(mouseX, mouseY) Then
            loc = 10
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf tganu(mouseX, mouseY) Then
            loc = 11
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf sabah(mouseX, mouseY) Then
            loc = 12
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        ElseIf srwk(mouseX, mouseY) Then
            loc = 13
            Dim nextForm As New frmList(Me, loc)
            nextForm.Show()
            Me.Hide()
        Else
            ' Clear the ToolTip if the mouse is not over any state
            stateToolTip.SetToolTip(PictureBox1, "")
        End If
    End Sub
    Private previousForm As Form
    ' Constructor to accept the previous form as a parameter
    Public Sub New(previous As Form)
        InitializeComponent()
        previousForm = previous
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Show the previous form
        previousForm.Show()
        ' Close the current form
        Me.Hide()
    End Sub

    Private Sub frmMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable resizing
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub
End Class
