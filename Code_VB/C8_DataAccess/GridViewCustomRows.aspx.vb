
Partial Class GridViewCustomRows
    Inherits System.Web.UI.Page

    Protected Sub gvwCustomers_RowEditing(ByVal sender As Object, ByVal e As GridViewEditEventArgs)
        SwitchVisibleColumns(False)
    End Sub

    Protected Sub gvwCustomers_RowCancelingEdit(ByVal sender As Object, ByVal e As GridViewCancelEditEventArgs)
        SwitchVisibleColumns(True)
    End Sub

    Protected Sub gvwCustomers_RowUpdated(ByVal sender As Object, ByVal e As GridViewUpdatedEventArgs)
        SwitchVisibleColumns(True)
    End Sub

    Private Sub SwitchVisibleColumns(ByVal inReadOnlyMode As Boolean)
        gvwCustomers.Columns(1).Visible = inReadOnlyMode
        'FullName
        gvwCustomers.Columns(2).Visible = Not inReadOnlyMode
        'NameStyle
        gvwCustomers.Columns(3).Visible = Not inReadOnlyMode
        'Title
        gvwCustomers.Columns(4).Visible = Not inReadOnlyMode
        'FirstName
        gvwCustomers.Columns(5).Visible = Not inReadOnlyMode
        'MiddleName
        gvwCustomers.Columns(6).Visible = Not inReadOnlyMode
        'LastName
        gvwCustomers.Columns(7).Visible = Not inReadOnlyMode
        'Suffix
        gvwCustomers.Columns(12).Visible = inReadOnlyMode
        'ModifiedDate
        gvwCustomers.Columns(13).Visible = inReadOnlyMode
        'PasswordHash
        gvwCustomers.Columns(14).Visible = inReadOnlyMode
        'PasswordSalt
    End Sub


End Class
