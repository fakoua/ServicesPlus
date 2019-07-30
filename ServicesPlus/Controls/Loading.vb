Namespace Controls
    Friend Class Loading
        Public Sub Start()
            Top = 0
            Left = 0
            Width = Parent.Width
            Height = Parent.Height
            Visible = True
        End Sub

        Public Sub Done()
            Visible = False
        End Sub

        Private Sub Loading_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
            PicLoading.Top = (Height - PicLoading.Height) \ 2
            PicLoading.Left = (Width - PicLoading.Width) \ 2
        End Sub

        Public Sub ParentResize()
            Top = 0
            Left = 0
            Width = Parent.Width
            Height = Parent.Height
        End Sub
    End Class
End Namespace