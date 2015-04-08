Imports System.IO
Imports System.Collections.Generic

Public Class Book
    'Implements IDisposable
    Public _titleName As String
    Public _bookprice As Double
    Public _hardcover As Boolean
    Public _quantity As Integer
    Public _name As String 'name of the author its first and last name
    'are stored on the author structure see author
    Public Property TitleName() As String
        Get
            Return _titleName
            'called when property is set 
        End Get
        Set(value As String)
            'is the new value a stiring 

            _titleName = value

        End Set

    End Property
    Public Property Name() As String
        Get
            Return _name

        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Bookprice As Double
        Get
            Return _bookprice
        End Get
        Set(value As Double)
            'this sets the book price value as greater than zero, you do not deal with negative money
            If value >= 0 Then
                _bookprice = value
            End If
            '_bookprice = value
        End Set
    End Property
    Public Property HardCover As Boolean
        Get
            Return _hardcover
        End Get
        Set(value As Boolean)
            'we wannt the value set as either a 1 or a zero 
            If CInt(value) = 0 Or CInt(value) = 1 Then
                _hardcover = value
                If value = True Then
                    _hardcover = HardCover
                End If
            End If
            '_hardcover = value
        End Set
    End Property

    Public Property Quantity() As Integer

        Get
            Return _quantity

        End Get
        Set(value As Integer)
            'we do not want to take a negative value, because we cannot have negative books
            If CInt(value) >= 0 Then
                _quantity = value
            End If
            '_quantity = value
        End Set
    End Property

    'the sell book method 
    Public Sub sellBook(titleOfBook As String, writerName As String,
                        saleprice As Double, hardOrSoft As Boolean)
            TitleName = titleOfBook
            Name = writerName
            Bookprice = saleprice
            HardCover = hardOrSoft
    End Sub
    Public Sub instock(quantiy As Integer)
        Quantity += quantiy
    End Sub
    Public Overrides Function ToString() As String
        Return TitleName & ", " & Name & ", " & HardCover & ", " & Bookprice & ", " & Quantity

    End Function
End Class
