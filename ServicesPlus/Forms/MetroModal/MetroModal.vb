Namespace Forms.MetroModal

    Friend Class MetroModal
        Dim _formModal As FrmModal
        Dim _startTick As Integer

        Public Sub Show(line1 As String, line2 As String)
            _startTick = My.Computer.Clock.TickCount
            _formModal = New FrmModal With {.Line1 = line1, .Line2 = line2}
            '_formModal.Width = Screen.PrimaryScreen.Bounds.Width
            _formModal.Show()
            If Debugger.IsAttached Then
                '_formModal.TopMost = False
            End If
        End Sub

        Public Sub Update(message As String, Optional hideLoader As Boolean = False)
            _formModal.Line2 = message
            If hideLoader Then
                _formModal.HideLoader()
            End If
        End Sub

        Public Sub Done()
            Dim currentTick = My.Computer.Clock.TickCount

            If (currentTick - _startTick) > 1500 Then
                _formModal.Close()
                _formModal.Dispose()
            Else
                _formModal.CloseAfter()
            End If
        End Sub

    End Class
End Namespace