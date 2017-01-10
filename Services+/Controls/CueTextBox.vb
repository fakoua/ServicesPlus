Namespace Controls
    Friend Class CueTextBox
        Inherits TextBox

        Private _cue As String
        Public Property Cue() As String
            Get
                Return _cue
            End Get
            Set(ByVal value As String)
                _cue = value
                UpdateCue()
            End Set
        End Property

        Private Sub UpdateCue()
            If IsHandleCreated AndAlso Not String.IsNullOrEmpty(Cue) Then
                NativeMethods.SendMessage(Handle, &H1501, New IntPtr(1), Cue)
            End If
        End Sub

        Protected Overrides Sub OnHandleCreated(e As EventArgs)
            MyBase.OnHandleCreated(e)
            UpdateCue()
        End Sub

    End Class
End Namespace