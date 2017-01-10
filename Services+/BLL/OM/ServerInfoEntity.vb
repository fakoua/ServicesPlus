Namespace BLL.OM
    Friend Class ServerInfoEntity
        Property MachineName As String
        Property OsName As String
        Property Architecture As String
        Property InstallDate As String
        Property TotalMemory As ULong
        Property LastBootupTime As String

        Private _cpu As String
        Public Property Cpu() As String
            Get
                Return _cpu.ToCleanString
            End Get
            Set(ByVal value As String)
                _cpu = value
            End Set
        End Property
    End Class
End Namespace
