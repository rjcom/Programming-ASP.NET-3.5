
Partial Class Restricted
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If User.Identity.Name = "Jane" Then
            Response.Redirect("NoPrivs.aspx")
        End If

    End Sub

End Class
