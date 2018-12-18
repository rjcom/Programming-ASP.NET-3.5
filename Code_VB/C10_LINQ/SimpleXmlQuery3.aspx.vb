
Partial Class SimpleXmlQuery3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim doc As XElement = XElement.Load(Server.MapPath("~/authors.xml"))

        Dim authorIds = From book In doc.DescendantsAndSelf("book") _
            Let authorId = book.Ancestors("author").Attributes("id").[Single]() _
            Where book.Attribute("isbn").Value = "059652756X" _
            Select New With {.AuthorId = authorId.Value}


        Dim authorIds2 = From author In doc.DescendantsAndSelf("author") _
            Where author.Elements("book").Attributes("isbn").Any(Function(attr) attr.Value = "059652756X") _
            Select New With {.AuthorId = author.Attribute("id").Value}

        gvwAuthors.DataSource = authorIds
        lvwAuthors.DataSource = authorIds2
        Me.DataBind()
    End Sub


End Class
