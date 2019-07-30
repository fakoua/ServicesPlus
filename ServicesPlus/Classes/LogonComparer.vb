Namespace Classes
    Friend Class LogonComparer
        Implements IEqualityComparer(Of String)

        Public Function [Equals1](x As String, y As String) As Boolean Implements IEqualityComparer(Of String).Equals
            Return CBool(x.ToUpperInvariant = y.ToUpperInvariant)
        End Function

        Public Function GetHashCode1(obj As String) As Integer Implements IEqualityComparer(Of String).GetHashCode
            Return obj.ToUpperInvariant.GetHashCode
        End Function
    End Class
End Namespace

