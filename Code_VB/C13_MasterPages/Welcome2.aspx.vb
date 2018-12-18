
Partial Class Welcome2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Master.AnimalImage.ImageUrl = "~/images/progcs.gif"

        Dim ctrl As Control = Master.FindControl("imgAnimal")
        Dim img As Image = TryCast(ctrl, Image)
        If img IsNot Nothing Then
            img.ImageUrl = "~/images/progcs.gif"
        End If

    End Sub

End Class
