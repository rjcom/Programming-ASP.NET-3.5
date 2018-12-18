
Partial Class GridView
    Inherits System.Web.UI.Page

    Protected Sub gvwCustomers_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim info As New StringBuilder()
        info.AppendFormat("You are viewing record {0} of {1} (SelectedIndex)<br />", gvwCustomers.SelectedIndex.ToString(), gvwCustomers.Rows.Count.ToString())
        info.AppendFormat("You are viewing record {0} of {1} (DataKeys)<br />", gvwCustomers.SelectedIndex.ToString(), gvwCustomers.DataKeys.Count)
        info.AppendFormat("You are viewing page {0} of {1} (PageCount)<br />", gvwCustomers.PageIndex.ToString(), gvwCustomers.PageCount.ToString())

        info.AppendFormat("<p>Using SelectedRow, Email Address= {0}<br />", gvwCustomers.SelectedRow.Cells(4).Text)

        info.Append("Using SelectedDataKey<br />")

        For i As Integer = 0 To gvwCustomers.DataKeyNames.Length - 1
            info.AppendFormat("{0} : {1}<br />", gvwCustomers.DataKeyNames(i), gvwCustomers.SelectedDataKey.Values(i))
        Next

        info.AppendFormat("Selected Value : {0}", gvwCustomers.SelectedValue.ToString())

        lblInfo.Text = info.ToString()
    End Sub


End Class
