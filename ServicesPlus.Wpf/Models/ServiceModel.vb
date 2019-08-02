Public Class ServiceModel
    Property ServiceName As String
    Property DisplayName As String
    Property Description As String
    Property AcceptPause As Boolean
    Property AcceptStop As Boolean
    Property DesktopInteract As Boolean
    Property ErrorControl As String
    Property IsSystem As Boolean
    Property ProcessId As UInt32
    ''' <summary>
    ''' Type of the process, OwnProcess ...
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property ServiceType As String
    Property Started As Boolean
    ''' <summary>
    ''' Values: OK ..
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Status As String
    ''' <summary>
    ''' Log On As
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property StartName As String
    ''' <summary>
    ''' Values: Running, Stopped ...
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property State As String

    Property SystemName As String
    ''' <summary>
    ''' Values: Manual, Auto, Disabled
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property StartMode As String

End Class
