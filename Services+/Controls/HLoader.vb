Imports ServicesPlus.Modules

Namespace Controls
    Friend Class HLoader
        Private _callerNumber As Integer = 0
        Private _currentPosition As Integer = 0
        Property [Step] As Integer = 2

        Sub Start()
            _callerNumber += 1
            _currentPosition = 0
            Refresh()
            Timer1.Enabled = True
            Timer1.Start()
        End Sub

        Sub Done()
            _callerNumber -= 1
            If _callerNumber = 0 Then
                Timer1.Stop()
                Timer1.Enabled = False
                _currentPosition = Width
                Refresh()
            End If
        End Sub

        Private Sub HLoader_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
            If DesignMode Then
                _currentPosition = Width
            End If
            Using b As New SolidBrush(ColorBlue)
                e.Graphics.FillRectangle(b, 0, 0, _currentPosition, Height)
            End Using
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            _currentPosition += [Step]
            If _currentPosition > Width Then
                _currentPosition = Me.Step
            End If
            Refresh()
        End Sub

    End Class
End Namespace