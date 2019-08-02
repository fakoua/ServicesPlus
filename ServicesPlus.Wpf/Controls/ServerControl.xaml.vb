Public Class ServerControl

    Public Shared ReadOnly ModelProperty As DependencyProperty = DependencyProperty.Register(NameOf(Model), GetType(List(Of ServiceViewModel)), GetType(ServerControl), New FrameworkPropertyMetadata(Nothing))
    Property Model As List(Of ServiceViewModel)
        Get
            Return GetValue(ModelProperty)
        End Get
        Set(value As List(Of ServiceViewModel))
            SetValue(ModelProperty, value)
        End Set
    End Property


    Private _manager As ServiceManager

    Private Property Services As List(Of ServiceViewModel)

    Public Async Function FetchAsync() As Task
        loader.Visibility = Visibility.Visible
        _manager = New ServiceManager("production", New IdentityModel With {.Domain = "osd", .Password = "pavimato", .UserName = "sameh"})
        Await _manager.GetServicesByMachineAsync()
        Services = _manager.Services
        Model = Services.ToList
        loader.Visibility = Visibility.Collapsed
    End Function

    Private Sub BtnShowHideDependent_Click(sender As Object, e As RoutedEventArgs)
        Dim btn = TryCast(sender, Button)
        Dim ico = TryCast(btn.Content, MahApps.Metro.IconPacks.PackIconMaterial)

        Dim vis = TryCast(sender, Visual)
        While vis IsNot Nothing
            If TypeOf vis Is DataGridRow Then
                Dim row = CType(vis, DataGridRow)
                row.DetailsVisibility = If(row.DetailsVisibility = Visibility.Visible, Visibility.Collapsed, Visibility.Visible)
                ico.Kind = If(ico.Kind = MahApps.Metro.IconPacks.PackIconMaterialKind.ChevronRight, MahApps.Metro.IconPacks.PackIconMaterialKind.ChevronDown, MahApps.Metro.IconPacks.PackIconMaterialKind.ChevronRight)
                Exit While
            End If
            vis = TryCast(VisualTreeHelper.GetParent(vis), Visual)
        End While
    End Sub

    Private Sub TxtFilter_TextChanged(sender As Object, e As TextChangedEventArgs)
        Dim term = TxtFilter.Text.Trim
        If String.IsNullOrEmpty(term) Then
            Model = Services.ToList
        Else
            Model = (From u In Services
                     Where u.DisplayName.ToUpperInvariant.Contains(term.ToUpperInvariant)
                     Select u).ToList
        End If
    End Sub
End Class
