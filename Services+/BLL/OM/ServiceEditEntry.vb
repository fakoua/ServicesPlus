Namespace BLL.OM
    Friend Class ServiceEditEntry

        Sub New(systemName As String, serviceName As String)
            _systemName = systemName
            _serviceName = serviceName
        End Sub

        Private _systemName As String
        ReadOnly Property SystemName As String
            Get
                Return _systemName
            End Get
        End Property

        Private _serviceName As String
        ReadOnly Property ServiceName As String
            Get
                Return _serviceName
            End Get
        End Property
        Property DisplayName As String
        Property StartMode As String
        Property ErrorControl As String
        Property StartName As String

        Private _startPassword As String
        Public Property StartPassword() As String
            Get
                If {"LocalSystem", "NT AUTHORITY\LocalService", "NT AUTHORITY\NetworkService"}.Contains(StartName) Then
                    _startPassword = ""
                Else
                    _startPassword = If(String.IsNullOrEmpty(_startPassword), Nothing, _startPassword)
                End If
                Return _startPassword
            End Get
            Set(ByVal value As String)
                _startPassword = value
            End Set
        End Property

        Private _desktopInteract As Boolean
        Public Property DesktopInteract() As Boolean
            Get
                _desktopInteract = If(StartName = "LocalSystem", _desktopInteract, False)
                Return _desktopInteract
            End Get
            Set(ByVal value As Boolean)
                _desktopInteract = value
            End Set
        End Property

    End Class
End Namespace
