Public Class ListViewItemComparer
    Implements IComparer

    Private col As Integer
    Private ascending As Boolean

    Public Sub New(column As Integer, asc As Boolean)
        col = column
        ascending = asc
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Dim result = String.Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        Return If(ascending, result, -result)
    End Function
End Class