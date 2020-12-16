Public Class Piece
    Public x_pos, y_pos As Integer
    Public piece_val As Integer
    Private flags(7, 7) As Boolean

    Public Sub New(ByVal x, ByVal y, ByVal p_value)
        x_pos = x
        y_pos = y
        piece_val = p_value
        're_flags()
    End Sub

    Public Function ret_x() As Integer
        Return x_pos
    End Function

    Public Function ret_y() As Integer
        Return y_pos
    End Function

    Public Function ret_val() As Integer
        Return piece_val
    End Function

End Class
