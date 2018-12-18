
Partial Class StateHistoryDemo
    Inherits System.Web.UI.Page

    Protected Sub SaveHistoryPoint(ByVal sender As Object, ByVal e As EventArgs)

        Dim state As New NameValueCollection()
        state.Add("book", rblBooks.SelectedValue)
        state.Add("author", ddlAuthors.SelectedValue)

        Dim newTitle As String = String.Format("Demo : {0} by {1}", rblBooks.SelectedValue, ddlAuthors.SelectedValue)
        sm.AddHistoryPoint(state, newTitle)

    End Sub

    Protected Sub RestoreHistoryPoint(ByVal sender As Object, ByVal e As HistoryEventArgs)

        If e.State IsNot Nothing Then
            If String.IsNullOrEmpty(e.State("author")) Then
                ddlAuthors.SelectedIndex = 0
            Else
                ddlAuthors.SelectedIndex = ddlAuthors.Items.IndexOf(ddlAuthors.Items.FindByValue(e.State("author")))
            End If

            If [String].IsNullOrEmpty(e.State("book")) Then
                rblBooks.SelectedIndex = 0
            Else
                rblBooks.SelectedIndex = rblBooks.Items.IndexOf(rblBooks.Items.FindByValue(e.State("book")))
            End If
        End If

    End Sub

End Class
