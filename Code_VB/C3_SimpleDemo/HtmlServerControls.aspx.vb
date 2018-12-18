
Partial Class HtmlServerControls
    Inherits System.Web.UI.Page

    Protected Sub Button1_OnServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        Dim strHtml = ""
        strHtml += txtName.Value + "<br/>"
        strHtml += txtStreet.Value + "<br/>"
        strHtml += txtCity.Value + ", " + txtState.Value
        tdInnerHtml.InnerHtml = strHtml
    End Sub
End Class
