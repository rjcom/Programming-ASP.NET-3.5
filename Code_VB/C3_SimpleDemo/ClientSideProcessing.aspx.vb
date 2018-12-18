
Partial Class ClientSideProcessing
    Inherits System.Web.UI.Page

    Protected Sub btnHTML_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHTML.ServerClick
        txtHTML.Value = "An HTML server control"
    End Sub

    Protected Sub btnServer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnServer.Click
        txtHTML.Value = "An ASP.NET server control"
    End Sub
End Class
