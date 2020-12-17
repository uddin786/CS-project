Public Class Form4
    Dim P71red As Boolean
    Public Sub shows()
        P11.Image = Image.FromFile("g.png")
        P11.SizeMode = PictureBoxSizeMode.StretchImage
        P13.Image = Image.FromFile("g.png")
        P13.SizeMode = PictureBoxSizeMode.StretchImage
        P15.Image = Image.FromFile("g.png")
        P15.SizeMode = PictureBoxSizeMode.StretchImage
        P17.Image = Image.FromFile("g.png")
        P17.SizeMode = PictureBoxSizeMode.StretchImage
        P22.Image = Image.FromFile("g.png")
        P22.SizeMode = PictureBoxSizeMode.StretchImage
        P24.Image = Image.FromFile("g.png")
        P24.SizeMode = PictureBoxSizeMode.StretchImage
        P26.Image = Image.FromFile("g.png")
        P26.SizeMode = PictureBoxSizeMode.StretchImage
        P28.Image = Image.FromFile("g.png")
        P28.SizeMode = PictureBoxSizeMode.StretchImage
        P71.Image = Image.FromFile("r.png")
        P71.SizeMode = PictureBoxSizeMode.StretchImage
        P71red = True
        P73.Image = Image.FromFile("r.png")
        P73.SizeMode = PictureBoxSizeMode.StretchImage
        P75.Image = Image.FromFile("r.png")
        P75.SizeMode = PictureBoxSizeMode.StretchImage
        P77.Image = Image.FromFile("r.png")
        P77.SizeMode = PictureBoxSizeMode.StretchImage
        P82.Image = Image.FromFile("r.png")
        P82.SizeMode = PictureBoxSizeMode.StretchImage
        P84.Image = Image.FromFile("r.png")
        P84.SizeMode = PictureBoxSizeMode.StretchImage
        P86.Image = Image.FromFile("r.png")
        P86.SizeMode = PictureBoxSizeMode.StretchImage
        P88.Image = Image.FromFile("r.png")
        P88.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'Public Function selected(ByRef x)
    'f x = True Then
    '       x.image = Image.FromFile("rs.png")
    'End If
    'End Function
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shows()
    End Sub

    Private Sub P71_Click(sender As Object, e As EventArgs) Handles P71.Click
        If P71red = True Then
            P71.Image = Image.FromFile("rs.png")
        End If
        'selected(P71red)
    End Sub

    Private Sub P82_Click(sender As Object, e As EventArgs) Handles P82.Click

    End Sub

    Private Sub P73_Click(sender As Object, e As EventArgs) Handles P73.Click
        selected(P73)
    End Sub

    Private Sub P84_Click(sender As Object, e As EventArgs) Handles P84.Click

    End Sub

    Private Sub P75_Click(sender As Object, e As EventArgs) Handles P75.Click
        selected(P75)
    End Sub

    Private Sub P86_Click(sender As Object, e As EventArgs) Handles P86.Click

    End Sub

    Private Sub P77_Click(sender As Object, e As EventArgs) Handles P77.Click
        selected(P77)
    End Sub

    Private Sub P88_Click(sender As Object, e As EventArgs) Handles P88.Click

    End Sub
End Class