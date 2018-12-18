
Partial Class ListView
    Inherits System.Web.UI.Page

    Protected Sub btnSortOnLastName_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Order ascending if data isn't currently ordered by LastName
        If ListView1.SortExpression <> "LastName" Then
            ListView1.Sort("LastName", SortDirection.Ascending)
        Else
            ' If it is, change sortdirection
            ListView1.Sort("LastName", (If(ListView1.SortDirection = SortDirection.Ascending, SortDirection.Descending, SortDirection.Ascending)))
        End If
    End Sub


End Class
