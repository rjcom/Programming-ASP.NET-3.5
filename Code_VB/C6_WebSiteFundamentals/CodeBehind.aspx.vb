
Partial Class CodeBehind
    Inherits System.Web.UI.Page

    Protected Sub btnHello_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHello.Click
        lblMessage.Text = "Hello. The time is " & DateTime.Now.ToLongTimeString()
    End Sub
End Class
