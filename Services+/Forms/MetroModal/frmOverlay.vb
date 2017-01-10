Namespace Forms.MetroModal
    Friend Class FrmOverlay

        Private Sub FrmOverlay_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDoubleClick
            If Debugger.IsAttached Then Close()
        End Sub
    End Class
End Namespace