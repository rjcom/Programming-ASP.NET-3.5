
Partial Class FragmentCaching
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblPageTime.Text = String.Format("Page time is {0}", DateTime.Now.ToLongTimeString())

    End Sub

End Class
