Public Class Piece
    Public x_pos, y_pos As Integer
    Public piece_val As Integer

    Public Sub New(ByVal x, ByVal y, ByVal p_value)
        x_pos = x
        y_pos = y
        piece_val = p_value

    End Sub

    Public board(7, 7) As Integer
    'Public P As String = "P"
    Public Sub boards()
        board = {{1, 0, 1, 0, 1, 0, 1, 0},
                {0, 1, 0, 1, 0, 1, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {-1, 0, -1, 0, -1, 0, -1, 0},
                {0, -1, 0, -1, 0, -1, 0, -1}}

    End Sub
    Public Sub shows()
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                Select Case board(i, j)
                    Case 1
                        Form2.P(i, j).image = My.Resources.g
                    Case -1
                        Form2.P(i, j).image = My.Resources.r
                End Select
            Next
        Next
    End Sub
End Class
