Imports System.Drawing.Drawing2D
Imports ServicesPlus.Modules
Namespace Controls
    Friend Class RoundButton
        Inherits Button

        Public Sub New()
            BackgroundImageLayout = ImageLayout.Center
            FlatAppearance.BorderSize = 0
            FlatAppearance.MouseDownBackColor = Color.Transparent
            FlatAppearance.MouseOverBackColor = Color.Transparent
            BackgroundImageLayout = ImageLayout.Center
            FlatStyle = FlatStyle.Flat
            Size = New Size(32, 32)
            UseVisualStyleBackColor = True
        End Sub

        Dim _bgColor As Color = Color.Transparent

        Private Sub RoundButton_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
            _bgColor = ColorLightblue
        End Sub

        Private Sub RoundButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
            _bgColor = Color.White
        End Sub

        Private Sub RoundButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
            _bgColor = Color.Transparent
        End Sub

        Private Sub RoundButton_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
            _bgColor = Color.White
            Refresh()
        End Sub

        Private Sub RoundButton_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality

            Using b As New SolidBrush(_bgColor)
                e.Graphics.FillEllipse(b, New Rectangle(1, 1, 29, 29))
            End Using

            If BackgroundImage IsNot Nothing Then
                e.Graphics.DrawImage(BackgroundImage, 8, 8)
            End If

            Using objPen As New Pen(If(Enabled, ColorBlue, Color.Silver), 2)
                e.Graphics.DrawEllipse(objPen, New Rectangle(1, 1, 29, 29))
            End Using
        End Sub

        Private Sub RoundButton_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            Size = New Size(32, 32)
        End Sub
    End Class
End Namespace