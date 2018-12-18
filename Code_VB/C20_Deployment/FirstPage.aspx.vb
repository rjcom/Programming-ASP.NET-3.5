
Partial Class FirstPage
    Inherits System.Web.UI.Page

    Protected Sub btnHomePage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHomePage.Click
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub btn2ndPage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2ndPage.Click
        Response.Redirect("SecondPage.aspx")
    End Sub
End Class
