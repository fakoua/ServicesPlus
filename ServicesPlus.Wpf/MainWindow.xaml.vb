Class MainWindow

    Private Async Sub MainWindow_LoadedAsync(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Await temp.FetchAsync
    End Sub

    'Private Sub BtnShowHideDependent_Click(sender As Object, e As RoutedEventArgs)
    '    Dim vis = TryCast(sender, Visual)
    '    While vis IsNot Nothing

    '        If TypeOf vis Is DataGridRow Then
    '            Dim row = CType(vis, DataGridRow)
    '            row.DetailsVisibility = If(row.DetailsVisibility = Visibility.Visible, Visibility.Collapsed, Visibility.Visible)
    '            Exit While
    '        End If

    '        vis = TryCast(VisualTreeHelper.GetParent(vis), Visual)
    '    End While
    'End Sub
End Class
