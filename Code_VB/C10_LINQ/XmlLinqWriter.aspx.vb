
Partial Class XmlLinqWriter
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim bookList As List(Of Book) = Book.GetBookList()
        Dim doc As XElement = XElement.Load(Server.MapPath("~/authors.xml"))

        Dim xml As New XElement("books", From book In doc.DescendantsAndSelf("book") _
            Join bookInfo In bookList On book.Attribute("isbn").Value Equals bookInfo.ISBN _
            Let authorId = book.Parent.Attribute("id").Value _
            Order By bookInfo.Title _
            Group New XElement("author", New XAttribute("id", authorId)) By key = bookInfo.Title _
            Into Group _
                Select New XElement("book", New XAttribute("title", key), Group))

        'Dim xml As New XElement("authors", From author In doc.DescendantsAndSelf("author") _
        '    Select New XElement("author", New XAttribute("id", author.Attribute("id").Value)))

        Response.Write(New XDeclaration("1.0", "utf-8", "yes").ToString())
        Response.Write(xml.ToString())

    End Sub


End Class
