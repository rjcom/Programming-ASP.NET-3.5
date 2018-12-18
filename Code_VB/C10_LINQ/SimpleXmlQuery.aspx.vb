
Partial Class SimpleXmlQuery
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        Dim doc As XElement = XElement.Load(Server.MapPath("~/authors.xml"))

        Dim authorIds = From authors In doc.Elements("author") _
            Select authors.Attribute("id").Value

        For Each authorId In authorIds
            lblAuthors.Text += String.Format("<p>{0}</p>", authorId)
        Next
    End Sub


End Class
