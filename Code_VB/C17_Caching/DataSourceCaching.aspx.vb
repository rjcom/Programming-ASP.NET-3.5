
Partial Class DataSourceCaching
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblTime.Text = String.Format("Page posted at {0}", DateTime.Now.ToLongTimeString())

    End Sub

End Class
