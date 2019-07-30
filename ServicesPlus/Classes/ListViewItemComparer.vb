
Namespace Classes
    Class ListViewItemComparer
        Implements IComparer
        Private ReadOnly _col As Integer
        Private ReadOnly _order As SortOrder

        Public Sub New()
            _col = 0
        End Sub

        Public Sub New(column As Integer, order As SortOrder)
            _order = order
            _col = column
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim returnVal As Integer
            returnVal = [String].Compare(CType(x, ListViewItem).SubItems(_col).Text, CType(y, ListViewItem).SubItems(_col).Text, StringComparison.OrdinalIgnoreCase)
            If _order = SortOrder.Descending Then
                ' Invert the value returned by String.Compare.
                returnVal *= -1
            End If
            Return returnVal
        End Function
    End Class
End Namespace