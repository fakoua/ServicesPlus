Namespace BLL
    Friend Class EditServiceModel
        Private Shared _startupTypeList As List(Of BLL.OM.ComboEntity(Of String))
        Private Shared _errorControlList As List(Of BLL.OM.ComboEntity(Of String))
        Private Shared _accountList As List(Of BLL.OM.ComboEntity(Of String))

        Public Shared ReadOnly Property StartupTypeList() As List(Of BLL.OM.ComboEntity(Of String))
            Get
                If _startupTypeList Is Nothing Then
                    _startupTypeList = New List(Of BLL.OM.ComboEntity(Of String))
                    _startupTypeList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "Automatic", .Value = "Automatic"})
                    _startupTypeList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "Manual", .Value = "Manual"})
                    _startupTypeList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "Disabled", .Value = "Disabled"})
                End If
                Return _startupTypeList
            End Get
        End Property

        Public Shared ReadOnly Property ErrorControlList() As List(Of BLL.OM.ComboEntity(Of String))
            Get
                If _errorControlList Is Nothing Then
                    _errorControlList = New List(Of BLL.OM.ComboEntity(Of String))
                    _errorControlList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "Ignore", .Value = "Ignore"})
                    _errorControlList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "Normal", .Value = "Normal"})
                    _errorControlList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "Severe", .Value = "Severe"})
                    _errorControlList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "Critical", .Value = "Critical"})
                End If
                Return _errorControlList
            End Get
        End Property

        Public Shared ReadOnly Property AccountList() As List(Of BLL.OM.ComboEntity(Of String))
            Get
                If _accountList Is Nothing Then
                    _accountList = New List(Of BLL.OM.ComboEntity(Of String))
                    _accountList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "LocalSystem", .Value = "LocalSystem"})
                    _accountList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "LocalService", .Value = "NT AUTHORITY\LocalService"})
                    _accountList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "NetworkService", .Value = "NT AUTHORITY\NetworkService"})
                    _accountList.Add(New BLL.OM.ComboEntity(Of String) With {.Display = "Custom Account ...", .Value = "custom"})
                End If
                Return _accountList
            End Get
        End Property
    End Class
End Namespace