Public Class Form4
    Dim P71red, P82red, P73red, P84red, P75red, P86red, P77red, P88red As Boolean
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
        P73red = True
        P75.Image = Image.FromFile("r.png")
        P75.SizeMode = PictureBoxSizeMode.StretchImage
        P75red = True
        P77.Image = Image.FromFile("r.png")
        P77.SizeMode = PictureBoxSizeMode.StretchImage
        P77red = True
        P82.Image = Image.FromFile("r.png")
        P82.SizeMode = PictureBoxSizeMode.StretchImage
        P82red = True
        P84.Image = Image.FromFile("r.png")
        P84.SizeMode = PictureBoxSizeMode.StretchImage
        P84red = True
        P86.Image = Image.FromFile("r.png")
        P86.SizeMode = PictureBoxSizeMode.StretchImage
        P86red = True
        P88.Image = Image.FromFile("r.png")
        P88.SizeMode = PictureBoxSizeMode.StretchImage
        P88red = True
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
            'If P62.Image.ToString = Nothing Then
            '    P62.Image = Image.FromFile("r.png")

            'End If
        End If
        'selected(P71red)
    End Sub

    Private Sub P62_Click(sender As Object, e As EventArgs) Handles P62.Click
        If P71red = True Then
            P71.Image = Nothing
            P62.Image = Image.FromFile("r.png")
            P62.SizeMode = PictureBoxSizeMode.StretchImage

        End If
    End Sub

    Private Sub P82_Click(sender As Object, e As EventArgs) Handles P82.Click
        If P82red = True Then
            P82.Image = Image.FromFile("rs.png")
        End If
    End Sub

    Private Sub P73_Click(sender As Object, e As EventArgs) Handles P73.Click
        If P73red = True Then
            P73.Image = Image.FromFile("rs.png")
        End If
    End Sub

    Private Sub P84_Click(sender As Object, e As EventArgs) Handles P84.Click
        If P84red = True Then
            P84.Image = Image.FromFile("rs.png")
        End If
    End Sub

    Private Sub P75_Click(sender As Object, e As EventArgs) Handles P75.Click
        If P75red = True Then
            P75.Image = Image.FromFile("rs.png")
        End If
    End Sub

    Private Sub P86_Click(sender As Object, e As EventArgs) Handles P86.Click
        If P86red = True Then
            P86.Image = Image.FromFile("rs.png")
        End If
    End Sub

    Private Sub P77_Click(sender As Object, e As EventArgs) Handles P77.Click
        If P77red = True Then
            P77.Image = Image.FromFile("rs.png")
        End If
    End Sub

    Private Sub P88_Click(sender As Object, e As EventArgs) Handles P88.Click
        If P88red = True Then
            P88.Image = Image.FromFile("rs.png")
        End If
    End Sub
End Class