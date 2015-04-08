Public Class inventory
    Inherits CollectionBase
    Public Sub Add(Bookstorebook As Book)
        List.Add(Bookstorebook)
    End Sub
    Public Sub Remove(Index As Integer)
        'Remove itme from the collection
        If Index >= 0 And Index < Count Then
            List.Remove(Index)
        End If
    End Sub

    Public ReadOnly Property Item(Index As Integer) As Book
        Get
            'Get an item from the collection by its index
            Return CType(List.Item(Index), Book)

        End Get
    End Property
End Class
