
Partial Class SimpleXmlQuery2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim doc As XElement = XElement.Load(Server.MapPath("~/authors.xml"))

        Dim authorIds = From authors In doc.DescendantsAndSelf("author") _
            Select New With {.AuthorId = authors.Attribute("id").Value}




        lvwAuthors.DataSource = authorIds
        lvwAuthors.DataBind()
    End Sub


End Class
