
Partial Class RoleRestricted
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If User.IsInRole("Member") Then
            Response.Redirect("NoPrivs.aspx")
        End If

    End Sub

End Class
