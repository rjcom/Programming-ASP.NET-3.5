
Partial Class SelectionList
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        lblSelection.Text = [String].Format("<p>Selected Index : {0}<br />Selected Text : {1}<br />Selected Value : {2}</p>", DropDownList1.SelectedIndex.ToString(), DropDownList1.SelectedItem.Text, DropDownList1.SelectedValue)
    End Sub


End Class
