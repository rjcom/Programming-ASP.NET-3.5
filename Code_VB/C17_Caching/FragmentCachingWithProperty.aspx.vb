
Partial Class FragmentCachingWithProperty
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblPageTime.Text = String.Format("Page time is {0}", DateTime.Now.ToLongTimeString())
        lblUserName.Text = CachedControl1.UserName

    End Sub

    Protected Sub btnChange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChange.Click

        CachedControl1.UserName = "Janey"

    End Sub

End Class
