<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAddbookAndAuthor = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TxtBookName = New System.Windows.Forms.TextBox()
        Me.LblBookName = New System.Windows.Forms.Label()
        Me.hasanAuthor = New System.Windows.Forms.CheckBox()
        Me.lblauthorFName = New System.Windows.Forms.Label()
        Me.TxtFirstNameAuthor = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Price = New System.Windows.Forms.Label()
        Me.cboBindiing = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAuthroLName = New System.Windows.Forms.Label()
        Me.TxtLname = New System.Windows.Forms.TextBox()
        Me.TxtLookupTitle = New System.Windows.Forms.TextBox()
        Me.TxtLookupFirstName = New System.Windows.Forms.TextBox()
        Me.TextLookUpLName = New System.Windows.Forms.TextBox()
        Me.btn_LookUpBook = New System.Windows.Forms.Button()
        Me.btn_SellBook = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddbookAndAuthor
        '
        Me.btnAddbookAndAuthor.Location = New System.Drawing.Point(92, 360)
        Me.btnAddbookAndAuthor.Name = "btnAddbookAndAuthor"
        Me.btnAddbookAndAuthor.Size = New System.Drawing.Size(75, 23)
        Me.btnAddbookAndAuthor.TabIndex = 0
        Me.btnAddbookAndAuthor.Text = "Add Book"
        Me.btnAddbookAndAuthor.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(70, 227)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(214, 108)
        Me.ListBox1.TabIndex = 1
        '
        'TxtBookName
        '
        Me.TxtBookName.Location = New System.Drawing.Point(137, 12)
        Me.TxtBookName.Name = "TxtBookName"
        Me.TxtBookName.Size = New System.Drawing.Size(100, 20)
        Me.TxtBookName.TabIndex = 2
        '
        'LblBookName
        '
        Me.LblBookName.AutoSize = True
        Me.LblBookName.Location = New System.Drawing.Point(40, 22)
        Me.LblBookName.Name = "LblBookName"
        Me.LblBookName.Size = New System.Drawing.Size(85, 13)
        Me.LblBookName.TabIndex = 3
        Me.LblBookName.Text = "Add Book Name"
        '
        'hasanAuthor
        '
        Me.hasanAuthor.AutoSize = True
        Me.hasanAuthor.Location = New System.Drawing.Point(14, 202)
        Me.hasanAuthor.Name = "hasanAuthor"
        Me.hasanAuthor.Size = New System.Drawing.Size(91, 17)
        Me.hasanAuthor.TabIndex = 4
        Me.hasanAuthor.Text = "has an author"
        Me.hasanAuthor.UseVisualStyleBackColor = True
        '
        'lblauthorFName
        '
        Me.lblauthorFName.AutoSize = True
        Me.lblauthorFName.Location = New System.Drawing.Point(30, 55)
        Me.lblauthorFName.Name = "lblauthorFName"
        Me.lblauthorFName.Size = New System.Drawing.Size(113, 13)
        Me.lblauthorFName.TabIndex = 5
        Me.lblauthorFName.Text = "Add Author First Name"
        '
        'TxtFirstNameAuthor
        '
        Me.TxtFirstNameAuthor.Location = New System.Drawing.Point(149, 48)
        Me.TxtFirstNameAuthor.Name = "TxtFirstNameAuthor"
        Me.TxtFirstNameAuthor.Size = New System.Drawing.Size(100, 20)
        Me.TxtFirstNameAuthor.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(137, 136)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 7
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Location = New System.Drawing.Point(24, 139)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(101, 13)
        Me.Price.TabIndex = 8
        Me.Price.Text = "Add Price             :$"
        '
        'cboBindiing
        '
        Me.cboBindiing.FormattingEnabled = True
        Me.cboBindiing.Items.AddRange(New Object() {"Hard Cover", "Soft Cover"})
        Me.cboBindiing.Location = New System.Drawing.Point(137, 176)
        Me.cboBindiing.Name = "cboBindiing"
        Me.cboBindiing.Size = New System.Drawing.Size(121, 21)
        Me.cboBindiing.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "HardCover or soft cover"
        '
        'lblAuthroLName
        '
        Me.lblAuthroLName.AutoSize = True
        Me.lblAuthroLName.Location = New System.Drawing.Point(29, 101)
        Me.lblAuthroLName.Name = "lblAuthroLName"
        Me.lblAuthroLName.Size = New System.Drawing.Size(114, 13)
        Me.lblAuthroLName.TabIndex = 11
        Me.lblAuthroLName.Text = "Add Author Last Name"
        '
        'TxtLname
        '
        Me.TxtLname.Location = New System.Drawing.Point(149, 94)
        Me.TxtLname.Name = "TxtLname"
        Me.TxtLname.Size = New System.Drawing.Size(100, 20)
        Me.TxtLname.TabIndex = 12
        '
        'TxtLookupTitle
        '
        Me.TxtLookupTitle.Location = New System.Drawing.Point(515, 22)
        Me.TxtLookupTitle.Name = "TxtLookupTitle"
        Me.TxtLookupTitle.Size = New System.Drawing.Size(100, 20)
        Me.TxtLookupTitle.TabIndex = 13
        '
        'TxtLookupFirstName
        '
        Me.TxtLookupFirstName.Location = New System.Drawing.Point(515, 67)
        Me.TxtLookupFirstName.Name = "TxtLookupFirstName"
        Me.TxtLookupFirstName.Size = New System.Drawing.Size(100, 20)
        Me.TxtLookupFirstName.TabIndex = 14
        '
        'TextLookUpLName
        '
        Me.TextLookUpLName.Location = New System.Drawing.Point(515, 123)
        Me.TextLookUpLName.Name = "TextLookUpLName"
        Me.TextLookUpLName.Size = New System.Drawing.Size(100, 20)
        Me.TextLookUpLName.TabIndex = 15
        '
        'btn_LookUpBook
        '
        Me.btn_LookUpBook.Location = New System.Drawing.Point(515, 173)
        Me.btn_LookUpBook.Name = "btn_LookUpBook"
        Me.btn_LookUpBook.Size = New System.Drawing.Size(100, 23)
        Me.btn_LookUpBook.TabIndex = 16
        Me.btn_LookUpBook.Text = "Look Up Book"
        Me.btn_LookUpBook.UseVisualStyleBackColor = True
        '
        'btn_SellBook
        '
        Me.btn_SellBook.Location = New System.Drawing.Point(515, 226)
        Me.btn_SellBook.Name = "btn_SellBook"
        Me.btn_SellBook.Size = New System.Drawing.Size(100, 23)
        Me.btn_SellBook.TabIndex = 17
        Me.btn_SellBook.Text = "Sell Book"
        Me.btn_SellBook.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Look up title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "look up first name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(417, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(417, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Look First Name"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(329, 260)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(162, 95)
        Me.ListBox2.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(329, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Looked Up Books"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 424)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_SellBook)
        Me.Controls.Add(Me.btn_LookUpBook)
        Me.Controls.Add(Me.TextLookUpLName)
        Me.Controls.Add(Me.TxtLookupFirstName)
        Me.Controls.Add(Me.TxtLookupTitle)
        Me.Controls.Add(Me.TxtLname)
        Me.Controls.Add(Me.lblAuthroLName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboBindiing)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.TxtFirstNameAuthor)
        Me.Controls.Add(Me.lblauthorFName)
        Me.Controls.Add(Me.hasanAuthor)
        Me.Controls.Add(Me.LblBookName)
        Me.Controls.Add(Me.TxtBookName)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnAddbookAndAuthor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddbookAndAuthor As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TxtBookName As System.Windows.Forms.TextBox
    Friend WithEvents LblBookName As System.Windows.Forms.Label
    Friend WithEvents hasanAuthor As System.Windows.Forms.CheckBox
    Friend WithEvents lblauthorFName As System.Windows.Forms.Label
    Friend WithEvents TxtFirstNameAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Price As System.Windows.Forms.Label
    Friend WithEvents cboBindiing As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAuthroLName As System.Windows.Forms.Label
    Friend WithEvents TxtLname As System.Windows.Forms.TextBox
    Friend WithEvents TxtLookupTitle As System.Windows.Forms.TextBox
    Friend WithEvents TxtLookupFirstName As System.Windows.Forms.TextBox
    Friend WithEvents TextLookUpLName As System.Windows.Forms.TextBox
    Friend WithEvents btn_LookUpBook As System.Windows.Forms.Button
    Friend WithEvents btn_SellBook As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
