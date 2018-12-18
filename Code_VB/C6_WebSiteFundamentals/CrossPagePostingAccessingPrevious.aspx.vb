
Partial Class CrossPagePostingAccessingPrevious
    Inherits System.Web.UI.Page

    Public ReadOnly Property FavoriteActivity() As DropDownList
        Get
            Return ddlFavoriteActivity
        End Get
    End Property


    Protected Sub btnServerTransfer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnServerTransfer.Click
        Server.Transfer("TargetPage.aspx")
    End Sub


    Protected Sub btnRedirect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRedirect.Click
        Response.Redirect("TargetPage.aspx")
    End Sub
End Class
