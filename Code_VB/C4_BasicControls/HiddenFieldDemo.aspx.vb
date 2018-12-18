
Partial Class HiddenFieldDemo
    Inherits System.Web.UI.Page

    Protected Sub hdnSecretValue_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hdnSecretValue.ValueChanged
        Dim hdn As HiddenField = CType(sender, HiddenField)
        lblSecretValue.Text = hdn.Value
    End Sub
End Class
