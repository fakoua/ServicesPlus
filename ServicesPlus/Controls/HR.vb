Namespace Controls
    Friend Class Hr
        Private _thickness As Integer
        Public Property Thickness() As Integer
            Get
                Return _thickness
            End Get
            Set(ByVal value As Integer)
                _thickness = value
                Height = Thickness
            End Set
        End Property

        Private Sub HR_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
            Height = Thickness
        End Sub
    End Class
End Namespace