
Partial Class ThreeSourceJoin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim bookList As List(Of Book) = Book.GetBookList()
        Dim doc As XElement = XElement.Load(Server.MapPath("~/authors.xml"))

        Using db As New AwltCustomerDataContext()
            Dim authorsByBooks = From book In doc.DescendantsAndSelf("book") _
                Join bookInfo In bookList On book.Attribute("isbn").Value Equals bookInfo.ISBN _
                Join authorInfo In db.Customers On book.Parent.Attribute("id").Value Equals authorInfo.CustomerID.ToString() _
                Let authorName = (authorInfo.FirstName & " ") + authorInfo.LastName _
                Order By bookInfo.Title _
                Group New With {.Name = authorName} By key = bookInfo.Title _
                Into Group _
                    Select New With {.Title = key, .Authors = Group}

            For Each book In authorsByBooks
                lblBooks.Text += String.Format("<h2>{0}</h2>", book.Title)
                For Each author In book.Authors
                    lblBooks.Text += String.Format("Author: {0} <br />", author.Name)
                Next
            Next
        End Using
    End Sub


End Class
