Public Class Form2
    Public board(7, 7) As Integer
    Public P As String = "P"
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

    Public Sub Shows()

        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                Select Case board(i, j)
                    Case 1
                        Me.P(i, j).image = My.Resources.g
                    Case -1
                        Me.P(i, j).image = My.Resources.r
                End Select
            Next
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class