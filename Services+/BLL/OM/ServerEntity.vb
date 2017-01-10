Namespace BLL.OM
    Public Class ServerEntity
        Property ComputerName As String
        Property Identity As Identity
    End Class

    Public Class RecentServerEntity
        Property Server As ServerEntity
        Property OpenCount As Integer
    End Class
End Namespace
