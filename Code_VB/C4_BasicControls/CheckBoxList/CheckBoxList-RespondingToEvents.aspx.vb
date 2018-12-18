
Partial Class CheckBoxList_CheckBoxList_RespondingToEvents
    Inherits System.Web.UI.Page

    Protected Sub cblItems_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles cblItems.Init
        'create an array of items to add
        Dim Genres() As String = {"SciFi", "Novels", "Computers", "History", "Religion"}
        cblItems.DataSource = Genres
        cblItems.DataBind()
    End Sub

    Protected Sub cblItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cblItems.SelectedIndexChanged
        If cblItems.SelectedItem Is Nothing Then
            lblCategory.Text = "<br />No genres selected."
        Else
            Dim sb As New StringBuilder()
            For Each li As ListItem In cblItems.Items
                If li.Selected Then
                    sb.Append("<br/>" + li.Value + " - " + li.Text)
                End If
                lblCategory.Text = sb.ToString()
            Next
        End If
    End Sub
End Class
