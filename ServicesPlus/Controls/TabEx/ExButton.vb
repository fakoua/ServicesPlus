Namespace Controls.TabEx
    Friend Class ExButton

        Dim _state As ButtonState = ButtonState.Normal
        ReadOnly Property State As ButtonState
            Get
                Return _State
            End Get
        End Property

        Property ImageNormal As Image
        Property ImageOver As Image
        Property ImageDown As Image

        Private Sub ExButton_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
            _state = ButtonState.Down
            Refresh()
        End Sub

        Private Sub ExButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
            _state = ButtonState.Over
            Refresh()
        End Sub

        Private Sub ExButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
            _state = ButtonState.Normal
            Refresh()
        End Sub

        Private Sub ExButton_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
            _state = ButtonState.Over
            Refresh()
        End Sub

        Private Sub ExButton_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

            Select Case State
                Case ButtonState.Down
                    If ImageDown IsNot Nothing Then
                        BackgroundImage = ImageDown
                    End If
                Case ButtonState.Normal
                    If ImageNormal IsNot Nothing Then
                        BackgroundImage = ImageNormal
                    End If
                Case ButtonState.Over
                    If ImageOver IsNot Nothing Then
                        BackgroundImage = ImageOver
                    End If
            End Select

        End Sub

        Public Enum ButtonState
            Normal
            Over
            Down
        End Enum
    End Class
End Namespace