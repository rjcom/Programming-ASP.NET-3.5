
Partial Class ButtonDemoWithAJAX
    Inherits System.Web.UI.Page


    Protected Sub btnLink_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLink.Click
        Response.Redirect("//localhost/404.htm")
    End Sub
End Class
