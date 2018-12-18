
Partial Class CrossPagePostingPostBackProperties
    Inherits System.Web.UI.Page

    Protected Sub btnServerTransfer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnServerTransfer.Click
        Server.Transfer("TargetPage.aspx")
    End Sub


    Protected Sub btnRedirect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRedirect.Click
        Response.Redirect("TargetPage.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblIsPostBack.Text = IsPostBack.ToString()
        lblIsCrossPagePostBack.Text = IsCrossPagePostBack.ToString()
        If (Page.PreviousPage IsNot Nothing) Then
            lblPreviousPage.Text = Page.PreviousPage.Title
        End If
    End Sub
End Class
