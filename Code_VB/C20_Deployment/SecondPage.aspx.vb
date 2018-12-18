
Partial Class SecondPage
    Inherits System.Web.UI.Page

    Protected Sub btnHomePage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHomePage.Click
        Response.Redirect("default.aspx")
    End Sub

    Protected Sub btn1stPage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1stPage.Click
        Response.Redirect("firstpage.aspx")
    End Sub
End Class
