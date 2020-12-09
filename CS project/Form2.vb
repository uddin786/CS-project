Public Class Form2
    Public board(7, 7) As Integer
    'Public P As String = "P"
    Public Sub New()
        board = {{1, 0, 1, 0, 1, 0, 1, 0},
                {0, 1, 0, 1, 0, 1, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {-1, 0, -1, 0, -1, 0, -1, 0},
                {0, -1, 0, -1, 0, -1, 0, -1}}

    End Sub
    'Public Sub Shows()

    '    For i As Integer = 0 To 7
    '        For j As Integer = 0 To 7
    '            Select Case board(i, j)
    '                Case 1
    '                    Me.P11.Image = My.Resources.g
    '                    Me.P13.Image = My.Resources.g
    '                    Me.P15.Image = My.Resources.g
    '                    Me.P17.Image = My.Resources.g
    '                    Me.P22.Image = My.Resources.g
    '                    Me.P24.Image = My.Resources.g
    '                    Me.P26.Image = My.Resources.g
    '                    Me.P28.Image = My.Resources.g
    '                Case -1
    '                    Me.P71.Image = My.Resources.r
    '                    Me.P73.Image = My.Resources.r
    '                    Me.P75.Image = My.Resources.r
    '                    Me.P77.Image = My.Resources.r
    '                    Me.P82.Image = My.Resources.r
    '                    Me.P84.Image = My.Resources.r
    '                    Me.P86.Image = My.Resources.r
    '                    Me.P88.Image = My.Resources.r
    '            End Select
    '        Next
    '    Next
    'End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P11.Image = Image.FromFile("escape room character.png")
    End Sub

    'a
End Class