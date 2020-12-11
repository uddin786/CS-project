Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P11.Image = Image.FromFile("g.png")
        P11.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
End Class