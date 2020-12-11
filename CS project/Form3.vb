Public Class Form3
    Public board(7, 7) As Integer
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
    Public Sub shows()
        P11.Image = Image.FromFile("g.png")
        P11.SizeMode = PictureBoxSizeMode.StretchImage
        P13.Image = Image.FromFile("g.png")
        P13.SizeMode = PictureBoxSizeMode.StretchImage
        P15.Image = Image.FromFile("g.png")
        P15.SizeMode = PictureBoxSizeMode.StretchImage
        P17.Image = Image.FromFile("g.png")
        P17.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'P11.Image = Image.FromFile("g.png")
        'P11.SizeMode = PictureBoxSizeMode.StretchImage
        shows()

    End Sub
End Class