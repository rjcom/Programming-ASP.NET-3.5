
Partial Class OutputCaching
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        lblTime.Text = String.Format("Page posted at {0}", DateTime.Now.ToLongTimeString())
        lblUserName.Text = String.Format("UserName : {0}", Request.QueryString("UserName"))
        lblState.Text = String.Format("State : {0}", Request.QueryString("State"))

    End Sub

End Class
