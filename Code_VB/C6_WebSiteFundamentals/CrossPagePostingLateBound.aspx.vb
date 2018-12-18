
Partial Class CrossPagePostingLateBound
    Inherits System.Web.UI.Page

    Protected Sub btnServerTransfer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnServerTransfer.Click
        Server.Transfer("TargetPage.aspx")
    End Sub


    Protected Sub btnRedirect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRedirect.Click
        Response.Redirect("TargetPage.aspx")
    End Sub
End Class
