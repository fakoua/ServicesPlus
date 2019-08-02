Friend Class Util
    ''' <summary>
    ''' Due to WMI inconsistancy, ErrorControl is String during read but integer during change operation
    ''' </summary>
    ''' <param name="errorControl">ErrorControl String: Ignore, Normal, Severe and Critical</param>
    ''' <returns>0 to 3</returns>
    ''' <remarks>You best convert it to Enum</remarks>
    Friend Shared Function ErrorControlToNumber(errorControl As String) As UInt16
        Dim lstError = {New With {.ErrorControl = "Ignore", .Index = 0},
                        New With {.ErrorControl = "Normal", .Index = 1},
                        New With {.ErrorControl = "Severe", .Index = 2},
                        New With {.ErrorControl = "Critical", .Index = 3}}.ToList

        Return lstError.Where(Function(p) p.ErrorControl = errorControl).Single.Index
    End Function
End Class
