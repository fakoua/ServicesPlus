Imports System.Globalization

Public Class ServiceToFontStyleConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Dim svc = DirectCast(value, ServiceViewModel)
        If svc.IsSystem Then
            Return FontWeights.Thin
        End If
        Return FontWeights.SemiBold
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
