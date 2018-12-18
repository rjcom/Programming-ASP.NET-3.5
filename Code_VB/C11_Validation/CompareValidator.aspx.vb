
Partial Class CompareValidator
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If Page.IsValid Then
            lblMsg.Text = "Page is valid"
        Else
            lblMsg.Text = "Some of the fields still have no value"
        End If
    End Sub
End Class
