
Partial Class MultiViewDemo
    Inherits System.Web.UI.Page

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
        lblCurrentIndex.Text = MultiView1.ActiveViewIndex.ToString()
    End Sub

    Protected Sub rblView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rblView.SelectedIndexChanged
        MultiView1.ActiveViewIndex = Convert.ToInt32(rblView.SelectedValue)
    End Sub

    Protected Sub MultiView1_ActiveViewChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MultiView1.ActiveViewChanged
        lblFirstTextBox.Text = txtFirstView.Text
        lblSecondTextBox.Text = txtSecondView.Text
        rblView.SelectedIndex = MultiView1.ActiveViewIndex + 1
    End Sub

    Protected Sub ActivateView(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = lblViewActivation.Text
        Dim v As View = DirectCast(sender, View)
        str += "View " & v.ID & " activated <br/>"
        lblViewActivation.Text = str
    End Sub

    Protected Sub DeactivateView(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = lblViewActivation.Text
        Dim v As View = DirectCast(sender, View)
        str += "View " & v.ID & " deactivated <br/>"
        lblViewActivation.Text = str
    End Sub


End Class
