Public Class ServiceDetailsControl
    Public Shared ReadOnly ModelProperty As DependencyProperty = DependencyProperty.Register(NameOf(Model), GetType(ServiceViewModel), GetType(ServiceDetailsControl), Nothing)

    Property Model As ServiceViewModel
        Get
            Return GetValue(ModelProperty)
        End Get
        Set(value As ServiceViewModel)
            SetValue(ModelProperty, value)
        End Set
    End Property
End Class
