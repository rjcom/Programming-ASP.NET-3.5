
Partial Class ButtonDemo
    Inherits System.Web.UI.Page

    Protected Sub btnLink_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLink.Click
        Response.Redirect("http://www.ora.com")
    End Sub
End Class
