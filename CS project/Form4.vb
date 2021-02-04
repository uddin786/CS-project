Public Class Form4
    Dim P71red, P82red, P73red, P84red, P75red, P86red, P77red, P88red As Boolean
    Dim selected As Boolean = False
    Dim selectedname As String = ""
    Dim StopWatch As New Diagnostics.Stopwatch
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
        Timer1.Start()
        Me.StopWatch.Start()

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

    'Public Sub AI()
    '    Dim pick As Integer = CInt(Int((32 * Rnd()) + 1))
    '    If pick = 1 Then
    '        If P11.Tag = "g.png" Or "gk.png" Then
    '            If P22.Tag = "g.png" Or "gk.png" Then
    '                AI()
    '            ElseIf P22.Tag = String.Empty Then
    '                P22.Image = Image.FromFile("g.png")
    '                P22.Tag = "g.png"
    '            End If
    '        End If
    '    ElseIf pick = 2 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 3 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 4 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 5 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 6 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 7 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 8 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 9 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 10 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 11 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 12 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 13 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 14 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 15 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 16 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 17 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 18 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 19 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 20 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 21 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 22 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 23 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 24 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 25 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 26 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 27 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 28 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 29 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 30 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 31 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    ElseIf pick = 32 Then
    '        P37.Image = Image.FromFile("g.png")
    '        P37.Tag = "g.png"
    '    End If
    'End Sub

    Public Sub P71_Click(sender As Object, e As EventArgs) Handles P71.Click
        If P71.Tag = "r.png" Then
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

        End If
        'P62.SizeMode = PictureBoxSizeMode.StretchImage
        'P62.Image = P71.Image
        'If P71red = True Then
        '    P71.Image = Nothing
        '    P62.Image = Image.FromFile("r.png")
        '    P62.SizeMode = PictureBoxSizeMode.StretchImage

        'End If
    End Sub

    Private Sub P55_Click(sender As Object, e As EventArgs) Handles P55.Click
        If P73.Tag = "rs.png" Then
            If P64.Tag = "g.png" Then
                If P55.Tag = String.Empty Then
                    P73.Image = Nothing
                    P73.Tag = String.Empty
                    P64.Image = Nothing
                    P64.Tag = String.Empty
                    P55.Image = Image.FromFile("r.png")
                    P55.Tag = "r.png"
                End If
            End If
        ElseIf P73.Tag = "rks.png" Then
            If P64.Tag = "g.png" Then
                If P55.Tag = String.Empty Then
                    P73.Image = Nothing
                    P73.Tag = String.Empty
                    P64.Image = Nothing
                    P64.Tag = String.Empty
                    P55.Image = Image.FromFile("rk.png")
                    P55.Tag = "rk.png"
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.StopWatch.Elapsed
        timerbox.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds)
    End Sub

    Private Sub P82_Click(sender As Object, e As EventArgs) Handles P82.Click
        If P82.Tag = "r.png" Then
            P82.Image = Image.FromFile("rs.png")
            P82.Tag = "rs.png"
        ElseIf P82.Tag = "rs.png" Then
            P82.Image = Image.FromFile("r.png")
            P82.Tag = "r.png"
        End If

    End Sub

    Private Sub P73_Click(sender As Object, e As EventArgs) Handles P73.Click
        If P73.Tag = "r.png" Then
            P73.Image = Image.FromFile("rs.png")
            P73.Tag = "rs.png"
        ElseIf P73.Tag = "rs.png" Then
            P73.Image = Image.FromFile("r.png")
            P73.Tag = "r.png"
        End If
        P64.Image = Image.FromFile("g.png")
        P64.Tag = "g.png"
    End Sub



    Private Sub P84_Click(sender As Object, e As EventArgs) Handles P84.Click
        If P84.Tag = "r.png" Then
            P84.Image = Image.FromFile("rs.png")
            P84.Tag = "rs.png"
        ElseIf P84.Tag = "rs.png" Then
            P84.Image = Image.FromFile("r.png")
            P84.Tag = "r.png"
        End If
    End Sub

    Private Sub P75_Click(sender As Object, e As EventArgs) Handles P75.Click
        If P75.Tag = "r.png" Then
            P75.Image = Image.FromFile("rs.png")
            P75.Tag = "rs.png"
        ElseIf P75.Tag = "rs.png" Then
            P75.Image = Image.FromFile("r.png")
            P75.Tag = "r.png"
        End If
    End Sub

    Private Sub P86_Click(sender As Object, e As EventArgs) Handles P86.Click
        If P86.Tag = "r.png" Then
            P86.Image = Image.FromFile("rs.png")
            P86.Tag = "rs.png"
        ElseIf P86.Tag = "rs.png" Then
            P86.Image = Image.FromFile("r.png")
            P86.Tag = "r.png"
        End If
    End Sub

    Private Sub P77_Click(sender As Object, e As EventArgs) Handles P77.Click
        If P77.Tag = "r.png" Then
            P77.Image = Image.FromFile("rs.png")
            P77.Tag = "rs.png"
        ElseIf P77.Tag = "rs.png" Then
            P77.Image = Image.FromFile("r.png")
            P77.Tag = "r.png"
        End If
    End Sub

    Private Sub P88_Click(sender As Object, e As EventArgs) Handles P88.Click
        If P88.Tag = "r.png" Then
            P88.Image = Image.FromFile("rs.png")
            P88.Tag = "rs.png"
        ElseIf P88.Tag = "rs.png" Then
            P88.Image = Image.FromFile("r.png")
            P88.Tag = "r.png"
        End If
    End Sub
End Class