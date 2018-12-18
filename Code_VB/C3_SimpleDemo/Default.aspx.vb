
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnBookName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBookName.Click
        litBookName.Text = txtBookName.Text
    End Sub
End Class
