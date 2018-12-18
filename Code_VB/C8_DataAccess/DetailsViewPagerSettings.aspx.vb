
Partial Class DetailsViewPagerSettings
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If IsPostBack Then
            Dim info As New StringBuilder()
            info.AppendFormat("You are viewing record {0} of {1}<br />", CustomerDetails.DataItemIndex.ToString(), CustomerDetails.DataItemCount.ToString())

            For i As Integer = 0 To CustomerDetails.DataKeyNames.Length - 1
                info.AppendFormat("{0} : {1}<br />", CustomerDetails.DataKeyNames(i), CustomerDetails.DataKey.Values(i))
            Next

            info.AppendFormat("Selected Value : {0}", CustomerDetails.SelectedValue.ToString())

            lblInfo.Text = info.ToString()
        End If
    End Sub


End Class
