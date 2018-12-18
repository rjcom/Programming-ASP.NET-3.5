
Partial Class TextBoxDemoWithAJAX
    Inherits System.Web.UI.Page

    Protected Sub txtInput_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInput.TextChanged
        txtEcho.Text = txtInput.Text
    End Sub
End Class
