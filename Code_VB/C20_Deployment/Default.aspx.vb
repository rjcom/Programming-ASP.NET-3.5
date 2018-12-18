
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblTime.Text = Class1.GetTime()
    End Sub

    Protected Sub btn1stPage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1stPage.Click
        Response.Redirect("FirstPage.aspx")
    End Sub

    Protected Sub btn2ndPage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2ndPage.Click
        Response.Redirect("SecondPage.aspx")
    End Sub
End Class
