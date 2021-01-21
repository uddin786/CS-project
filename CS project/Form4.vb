Public Class Form4
    Dim P71red, P82red, P73red, P84red, P75red, P86red, P77red, P88red As Boolean

    Public Sub shows()
        P11.Image = Image.FromFile("g.png")
        P11.SizeMode = PictureBoxSizeMode.StretchImage
        P11.Tag = "g.png"
        P13.Image = Image.FromFile("g.png")
        P13.SizeMode = PictureBoxSizeMode.StretchImage
        P13.Tag = "g.png"
        P15.Image = Image.FromFile("g.png")
        P15.SizeMode = PictureBoxSizeMode.StretchImage
        P15.Tag = "g.png"
        P17.Image = Image.FromFile("g.png")
        P17.SizeMode = PictureBoxSizeMode.StretchImage
        P17.Tag = "g.png"
        P22.Image = Image.FromFile("g.png")
        P22.SizeMode = PictureBoxSizeMode.StretchImage
        P22.Tag = "g.png"
        P24.Image = Image.FromFile("g.png")
        P24.SizeMode = PictureBoxSizeMode.StretchImage
        P24.Tag = "g.png"
        P26.Image = Image.FromFile("g.png")
        P26.SizeMode = PictureBoxSizeMode.StretchImage
        P26.Tag = "g.png"
        P28.Image = Image.FromFile("g.png")
        P28.SizeMode = PictureBoxSizeMode.StretchImage
        P28.Tag = "g.png"
        P71.Image = Image.FromFile("r.png")
        P71.SizeMode = PictureBoxSizeMode.StretchImage
        P71red = True
        P71.Tag = "r.png"
        P73.Image = Image.FromFile("r.png")
        P73.SizeMode = PictureBoxSizeMode.StretchImage
        P73.Tag = "r.png"
        P73red = True
        P75.Image = Image.FromFile("r.png")
        P75.SizeMode = PictureBoxSizeMode.StretchImage
        P75.Tag = "r.png"
        P75red = True
        P77.Image = Image.FromFile("r.png")
        P77.SizeMode = PictureBoxSizeMode.StretchImage
        P77.Tag = "r.png"
        P77red = True
        P82.Image = Image.FromFile("r.png")
        P82.SizeMode = PictureBoxSizeMode.StretchImage
        P82.Tag = "r.png"
        P82red = True
        P84.Image = Image.FromFile("r.png")
        P84.SizeMode = PictureBoxSizeMode.StretchImage
        P84.Tag = "r.png"
        P84red = True
        P86.Image = Image.FromFile("r.png")
        P86.SizeMode = PictureBoxSizeMode.StretchImage
        P86.Tag = "r.png"
        P86red = True
        P88.Image = Image.FromFile("r.png")
        P88.SizeMode = PictureBoxSizeMode.StretchImage
        P88.Tag = "r.png"
        P88red = True
        P31.SizeMode = PictureBoxSizeMode.StretchImage
        P31.Tag = String.Empty
        P33.SizeMode = PictureBoxSizeMode.StretchImage
        P33.Tag = String.Empty
        P35.SizeMode = PictureBoxSizeMode.StretchImage
        P35.Tag = String.Empty
        P37.SizeMode = PictureBoxSizeMode.StretchImage
        P37.Tag = String.Empty
        P42.SizeMode = PictureBoxSizeMode.StretchImage
        P42.Tag = String.Empty
        P44.SizeMode = PictureBoxSizeMode.StretchImage
        P44.Tag = String.Empty
        P46.SizeMode = PictureBoxSizeMode.StretchImage
        P46.Tag = String.Empty
        P48.SizeMode = PictureBoxSizeMode.StretchImage
        P48.Tag = String.Empty
        P51.SizeMode = PictureBoxSizeMode.StretchImage
        P51.Tag = String.Empty
        P53.SizeMode = PictureBoxSizeMode.StretchImage
        P53.Tag = String.Empty
        P55.SizeMode = PictureBoxSizeMode.StretchImage
        P55.Tag = String.Empty
        P57.SizeMode = PictureBoxSizeMode.StretchImage
        P57.Tag = String.Empty
        P62.SizeMode = PictureBoxSizeMode.StretchImage
        P62.Tag = String.Empty
        P64.SizeMode = PictureBoxSizeMode.StretchImage
        P64.Tag = String.Empty
        P66.SizeMode = PictureBoxSizeMode.StretchImage
        P66.Tag = String.Empty
        P68.SizeMode = PictureBoxSizeMode.StretchImage
        P68.Tag = String.Empty
    End Sub

    'Public Function selected(ByRef x)
    'f x = True Then
    '       x.image = Image.FromFile("rs.png")
    'End If
    'End Function
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shows()
    End Sub

    Public Sub AIpick()
        Dim value As Integer = CInt(Int((4 * Rnd()) + 1))
        Select Case value
            Case 1
                P22.Image = Nothing
                P22.Tag = String.Empty
                Dim value1 As Integer = CInt(Int((2 * Rnd()) + 1))
                If value1 = 1 Then
                    P31.Image = Image.FromFile("g.png")
                    P31.Tag = "g.png"
                ElseIf value1 = 2 Then
                    P33.Image = Image.FromFile("g.png")
                    P33.Tag = "g.png"
                End If
            Case 2
                P24.Image = Nothing
                P24.Tag = String.Empty
                Dim value1 As Integer = CInt(Int((2 * Rnd()) + 1))
                If value1 = 1 Then
                    P33.Image = Image.FromFile("g.png")
                    P33.Tag = "g.png"
                ElseIf value1 = 2 Then
                    P35.Image = Image.FromFile("g.png")
                    P35.Tag = "g.png"
                End If
            Case 3
                P26.Image = Nothing
                P26.Tag = String.Empty
                Dim value1 As Integer = CInt(Int((2 * Rnd()) + 1))
                If value1 = 1 Then
                    P35.Image = Image.FromFile("g.png")
                    P35.Tag = "g.png"
                ElseIf value1 = 2 Then
                    P37.Image = Image.FromFile("g.png")
                    P37.Tag = "g.png"
                End If
            Case 4
                P28.Image = Nothing
                P28.Tag = String.Empty
                P37.Image = Image.FromFile("g.png")
                P37.Tag = "g.png"
        End Select

    End Sub


    Public Sub P71_Click(sender As Object, e As EventArgs) Handles P71.Click
        If P71red = True Then
            P71.Image = Image.FromFile("rs.png")
            P71.Tag = "rs.png"
        End If

    End Sub

    Public Sub P62_Click(sender As Object, e As EventArgs) Handles P62.Click
        If P71.Tag = "rs.png" Then
            P62.Image = Image.FromFile("r.png")
            P62.SizeMode = PictureBoxSizeMode.StretchImage
            P62.Tag = "r.png"
            P71.Image = Nothing
            P71.Tag = String.Empty
            AIpick()
        End If
        'P62.SizeMode = PictureBoxSizeMode.StretchImage
        'P62.Image = P71.Image
        'If P71red = True Then
        '    P71.Image = Nothing
        '    P62.Image = Image.FromFile("r.png")
        '    P62.SizeMode = PictureBoxSizeMode.StretchImage

        'End If
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