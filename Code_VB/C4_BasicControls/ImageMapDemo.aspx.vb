
Partial Class ImageMapDemo
    Inherits System.Web.UI.Page

    Protected Sub imgmapYesNoMaybe_Click(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ImageMapEventArgs) Handles imgmapYesNoMaybe.Click
        lblMessage.Text = "The PostBackValue is " + e.PostBackValue
    End Sub
End Class
