Namespace Controls
    Friend Class SearchBox
        Public Event OnSearch As EventHandler(Of FilterEventArgs)

        Private Sub SearchBox_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
            BtnClear.Left = Width - BtnClear.Width - 1
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFilter.Text = ""
            RaiseEvent OnSearch(Me, New FilterEventArgs With {.Text = ""})
        End Sub

        Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles TxtFilter.TextChanged
            RaiseEvent OnSearch(Me, New FilterEventArgs With {.Text = TxtFilter.Text})
        End Sub

        Public Sub ClearText()
            TxtFilter.Text = String.Empty
        End Sub
    End Class

    Friend Class FilterEventArgs
        Inherits EventArgs

        Property Text As String
    End Class
End Namespace