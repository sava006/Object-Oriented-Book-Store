Public Structure author
    'this is for the author full name being stored as function in the book class

    Public LastName As String
    Public FirstName As String
    Public ReadOnly Property Name() As String
        Get
            Return LastName & ", " & FirstName

        End Get
    End Property
    Public Overrides Function ToString() As String
        Return LastName & "," & FirstName
    End Function
End Structure
