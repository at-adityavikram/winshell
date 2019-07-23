﻿Public Class OutPfp
    Dim bmp As Bitmap
    Private Sub OutPfp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BringToFront()
        Location = New Point(StartMenu.Location.X + StartMenu.ProfilePic.Location.X, StartMenu.Location.Y - (Height / 2))
        bmp = StartMenu.ProfilePic.BackgroundImage
        roundthethingy(Me, 100)
    End Sub
    Private Sub ProfilePic_MouseEnter(sender As Object, e As EventArgs) Handles ProfilePic.MouseEnter
        ProfilePic.Text = ""
        sender.BackgroundImage = Nothing
    End Sub

    Private Sub ProfilePic_MouseLeave(sender As Object, e As EventArgs) Handles ProfilePic.MouseLeave
        ProfilePic.Text = ""
        ProfilePic.BackgroundImage = bmp
    End Sub
    Private Sub ProfilePic_Click(sender As Object, e As EventArgs) Handles ProfilePic.Click
        Try
            Process.Start("ms-settings:yourinfo")
            Close()
            End
        Catch ex As Exception

        End Try
    End Sub
    Private Sub roundthethingy(oj As Object, rad As Integer)
        If My.Settings.round_edges = True Then
            Dim p As New Drawing2D.GraphicsPath()
            p.StartFigure()
            p.AddArc(New Rectangle(0, 0, rad, rad), 180, 90)
            p.AddLine(rad, 0, oj.Width - rad, 0)
            p.AddArc(New Rectangle(oj.Width - rad, 0, rad, rad), -90, 90)
            p.AddLine(oj.Width, rad, oj.Width, oj.Height - rad)
            p.AddArc(New Rectangle(oj.Width - rad, oj.Height - rad, rad, rad), 0, 90)
            p.AddLine(oj.Width - rad, oj.Height, rad, oj.Height)
            p.AddArc(New Rectangle(0, oj.Height - rad, rad, rad), 90, 90)
            p.CloseFigure()
            oj.Region = New Region(p)
        End If
    End Sub
End Class