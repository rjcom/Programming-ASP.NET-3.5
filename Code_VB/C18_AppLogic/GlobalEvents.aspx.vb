
Partial Class GlobalEvents
    Inherits System.Web.UI.Page

    Protected Sub btnEndSession_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEndSession.Click

        Session.Abandon()

    End Sub


    Protected Sub btnError_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnError.Click

        Dim a As Integer = 5
        Dim b As Integer = 0
        Dim c As Integer
        c = a / b

    End Sub

End Class
