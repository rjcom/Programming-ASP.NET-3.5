
Partial Class PopupControlExtenderDemo
    Inherits System.Web.UI.Page


    Protected Sub rblWebsites_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rblWebsites.SelectedIndexChanged
        'Popup result is the selected task
        Dim list As RadioButtonList = DirectCast(sender, RadioButtonList)
        Me.Popup1.Commit(list.Text)
    End Sub
End Class
