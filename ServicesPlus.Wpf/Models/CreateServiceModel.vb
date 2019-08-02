Friend Class CreateServiceModel
    Inherits EditServiceModel

    Property PathName As String

    Overloads Property ServiceName As String

    Public Sub New(systemName As String)
        MyBase.New(systemName, "")
    End Sub

End Class