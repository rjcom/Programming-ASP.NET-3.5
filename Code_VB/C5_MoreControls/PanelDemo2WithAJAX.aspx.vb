
Partial Class PanelDemo2WithAJAX
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsPostBack) Then
            lblChoices.Text = "Selected: " & rblWebsites.SelectedValue
        End If
    End Sub
End Class
