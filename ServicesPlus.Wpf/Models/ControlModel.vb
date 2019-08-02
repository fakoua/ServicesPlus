Friend Class ControlModel
    Property ServiceRefresh As ServiceViewModel
    Property WmiValue As WmiReturn
    ''' <summary>
    ''' Indicate the handled error if WMIValue value is HandledError
    ''' </summary>
    ''' <value>String of ex.ToString()</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property LastError As String = String.Empty
End Class