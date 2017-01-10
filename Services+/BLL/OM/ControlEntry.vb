Namespace BLL.OM
    Friend Class ControlEntry
        Property ServiceRefresh As Service
        Property WmiValue As WMIReturn
        ''' <summary>
        ''' Indicate the handled error if WMIValue value is HandledError
        ''' </summary>
        ''' <value>String of ex.ToString()</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property LastError As String = String.Empty
    End Class
End Namespace