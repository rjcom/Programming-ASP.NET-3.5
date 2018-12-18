
Partial Class TargetPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblIsPostBack.Text = IsPostBack.ToString()
        lblIsCrossPagePostBack.Text = IsCrossPagePostBack.ToString()
        If PreviousPage IsNot Nothing Then
            Dim ddl As DropDownList = TryCast(PreviousPage.FindControl("ddlFavoriteActivity"), DropDownList)
            If ddl IsNot Nothing Then
                lblActivity.Text = ddl.SelectedItem.ToString() & " (late-bound)"
            End If
            lblPreviousPage.Text = Page.PreviousPage.Title
        End If
    End Sub
End Class
