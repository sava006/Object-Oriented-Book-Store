Imports System.IO
Imports System.IO.StreamReader

Public Class Form1
    Dim MastForSaleBookList As New ArrayList
    'this calls the collection class '
    'i think this could be done better but i am still am unsure about this
    'I just took the method we were taught in clas and called the collection class
    'again as inventory to make a double inventory. 
    Private Inventory As List(Of inventory) = New List(Of inventory)
    Private Sub btnAddbookAndAuthor_Click(sender As Object, e As EventArgs) Handles btnAddbookAndAuthor.Click
        Dim var1 As Integer = 5
        Dim objCompleteBook As New Book
        Dim objDiffNames As New author 'this the structure for the seperate name 
        objCompleteBook.TitleName = TxtBookName.Text
        If TxtBookName.Text = "" Then
            MessageBox.Show("Please enter a title")
            Return
        End If
        objDiffNames.FirstName = TxtFirstNameAuthor.Text
        If TxtFirstNameAuthor.Text = "" Then
            MessageBox.Show("please enter the authors first Name")
            Return
        End If
        objDiffNames.LastName = TxtLname.Text
        If TxtLname.Text = "" Then
            MessageBox.Show("please enter the authors last name")
            Return
        End If
        'this way we add the book to the inventory
        objCompleteBook.Name = objDiffNames.FirstName & ", " & objDiffNames.LastName
        objCompleteBook.Bookprice = CDbl(CStr(txtPrice.Text))
        If cboBindiing.Text Is Null Then
            MessageBox.Show("Please select if the type of cover")
        End If
        objCompleteBook.HardCover = CBool(CStr(cboBindiing.Text))
        If CBool(cboBindiing.Text) = True Then
            cboBindiing.SelectedItem = "Hard Cover"
        Else
            cboBindiing.SelectedItem = "Soft Cover"
        End If

        objCompleteBook.HardCover = CBool(cboBindiing.Text) = False
        ListBox1.Items.Add(objCompleteBook)
        MastForSaleBookList.Add(objCompleteBook)

        Try
            If CDbl(txtPrice.Text) <> CDbl(txtPrice.Text) Then

                Throw New SystemException()
            End If
        Catch ex As Exception When CDbl(txtPrice.Text) <> CDbl(txtPrice.Text)
            MessageBox.Show("You mus enter a valid price", "error")
        End Try
        Try
            If CDbl(cboBindiing.SelectedText) = 0 Then
                Throw New SystemException()
            End If

        Catch ex As Exception
            MessageBox.Show("you must select a bookbinding")

        End Try
    End Sub

    ' Dim R As IO.StreamReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As IO.StreamReader
        R = New IO.StreamReader("C:\Users\Harry\Desktop\Booklist.txt")
        While (R.Peek() > -1)
            ListBox1.Items.Add(R.ReadLine)
            MastForSaleBookList.Add(R.ReadLine)

        End While
        R.Close()
    End Sub

    Private Sub btn_LookUpBook_Click(sender As Object, e As EventArgs) Handles btn_LookUpBook.Click
        Dim objLookup As New Book
        Dim objLookupAuthor As New author
        objLookup.TitleName = TxtLookupTitle.Text
        objLookupAuthor.FirstName = TxtLookupFirstName.Text
        objLookupAuthor.LastName = TxtLname.Text
        objLookup.Name = objLookupAuthor.LastName & ", " & objLookupAuthor.FirstName
        If TxtLookupTitle.Text <> "" Or TxtLookupFirstName.Text <> "" Or TxtLname.Text <> "" Then
            'clear the item in the list
            ListBox2.ClearSelected()
            For Each forsalebook In Inventory
                'running through selected list
                ListBox2.Items.Add(objLookup)

                '
            Next
        End If
    End Sub
    Public ReadOnly Property SelectedBooklookUp() As Book
        Get
            If ListBox2.SelectedIndex <> -1 Or ListBox1.SelectedIndex <> -1 Then
                'Return the selected customer                 Return CType(MastForSaleBookList(ListBox1.SelectedIndex), Book)

            End If
        End Get
    End Property
    Private Sub btn_SellBook_Click(sender As Object, e As EventArgs) Handles btn_SellBook.Click
        'If no item
        If ListBox2.SelectedIndex = -1 Then
            'display a message
            MessageBox.Show("you must select an item that you want to sell!", "selected error message")
            'exit this method
            Exit Sub
        Else
            'Prompt the user to delete the selected book 
            Dim objCustomertoSell As Book = SelectedBooklookUp
            'Remove the book the list and decreace the count 
            MastForSaleBookList.Remove(objCustomertoSell)
            'Remove the book from the list 
            ListBox1.Items.Remove(objCustomertoSell)
        End If


    End Sub
End Class

