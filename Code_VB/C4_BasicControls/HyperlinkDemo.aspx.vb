
Partial Class HyperlinkDemo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hypLink.Target = ddlTarget.SelectedValue
    End Sub
End Class
