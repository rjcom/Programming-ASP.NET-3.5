
Partial Class AdRotator_AdRotatorDemo
    Inherits System.Web.UI.Page

    Protected Sub ad_AdCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AdCreatedEventArgs) Handles ad.AdCreated
        If DirectCast(e.AdProperties("Animal"), String) <> "" Then
            lblAnimal.Text = DirectCast(e.AdProperties("Animal"), String)
        Else
            lblAnimal.Text = "Not available."
        End If
    End Sub
End Class
