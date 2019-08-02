Imports System.Globalization

Public Class ServiceToBrushConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Dim svc = DirectCast(value, ServiceViewModel)
        If svc.StartMode.ToLowerInvariant = "disabled" Then
            Return Brushes.Gray
        End If
        'Stopped
        If svc.State.ToLowerInvariant = "stopped" Then
            Return Brushes.Red
        End If
        Return Brushes.Black
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
