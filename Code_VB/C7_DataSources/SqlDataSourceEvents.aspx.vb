
Partial Class SqlDataSourceEvents
    Inherits System.Web.UI.Page

    Protected Sub CustomersDataSource_Selected(ByVal sender As Object, ByVal e As SqlDataSourceStatusEventArgs)
        lblSelectStats.Text = String.Format("Number of rows selected: {0}", e.AffectedRows)
    End Sub

End Class
