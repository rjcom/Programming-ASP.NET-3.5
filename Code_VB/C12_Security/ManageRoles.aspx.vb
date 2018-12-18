
Partial Class ManageRoles
    Inherits System.Web.UI.Page

    Private rolesArray As String()
    Private usersInRole As String()
    Private users As MembershipUserCollection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Msg.Text = String.Empty

        If Not IsPostBack Then
            rolesArray = Roles.GetAllRoles()
            RolesListBox.DataSource = rolesArray
            RolesListBox.DataBind()

            users = Membership.GetAllUsers()
            UsersListBox.DataSource = users
            UsersListBox.DataBind()
        End If

        If RolesListBox.SelectedItem IsNot Nothing Then
            usersInRole = Roles.GetUsersInRole(RolesListBox.SelectedItem.Value)
            UsersInRoleGrid.DataSource = usersInRole
            UsersInRoleGrid.DataBind()
        End If

    End Sub

    Protected Sub btnAddUsersToRole_Click(ByVal sender As Object, ByVal e As EventArgs)

        If RolesListBox.SelectedItem Is Nothing Then
            Me.Msg.Text = "Please select a role."
            Exit Sub
        End If
        If UsersListBox.SelectedItem Is Nothing Then
            Msg.Text = "Please select one or more users"
            Exit Sub
        End If

        Dim sizeOfArray As Integer = UsersListBox.GetSelectedIndices().Length
        Dim newUsers As String() = New String(sizeOfArray - 1) {}

        ' get the array of selected indices from the (multiselect) list box 
        Dim selectedIndices As Integer() = UsersListBox.GetSelectedIndices()

        For i As Integer = 0 To newUsers.Length - 1
            ' get the selectedIndex that corresponds to the counter[i] 
            Dim selectedIndex As Integer = selectedIndices(i)
            'get the ListItem in the UserListBox Items collection at that offset 
            Dim myListItem As ListItem = UsersListBox.Items(selectedIndex)
            'get the string that is that ListItem's value property 
            Dim newUser As String = myListItem.Value
            'add that string to the newUsers collection of string 
            newUsers(i) = newUser
        Next

        ' Add users to the selected role 
        Roles.AddUsersToRole(newUsers, RolesListBox.SelectedItem.Value)
        usersInRole = Roles.GetUsersInRole(RolesListBox.SelectedItem.Value)
        UsersInRoleGrid.DataSource = usersInRole
        UsersInRoleGrid.DataBind()

    End Sub

    Protected Sub btnCreateRole_Click(ByVal sender As Object, ByVal e As EventArgs)

        pnlCreateRole.Visible = True

    End Sub

    Protected Sub UsersInRoleGrid_RemoveFromRole(ByVal sender As Object, ByVal e As GridViewCommandEventArgs)

        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim userLabel As Label = DirectCast(UsersInRoleGrid.Rows(index).FindControl("lblUserName"), Label)

        Roles.RemoveUserFromRole(userLabel.Text, RolesListBox.SelectedItem.Value)
        usersInRole = Roles.GetUsersInRole(RolesListBox.SelectedItem.Value)
        UsersInRoleGrid.DataSource = usersInRole
        UsersInRoleGrid.DataBind()

    End Sub

    Protected Sub btnAddRole_Click(ByVal sender As Object, ByVal e As EventArgs)

        If txtNewRole.Text.Length > 0 Then
            Dim newRole As String = txtNewRole.Text

            If Roles.RoleExists(newRole) Then
                Msg.Text = "Role already exists!"
            Else
                Roles.CreateRole(newRole)
                rolesArray = Roles.GetAllRoles()
                RolesListBox.DataSource = rolesArray
                RolesListBox.DataBind()
            End If
        End If

        txtNewRole.Text = String.Empty
        pnlCreateRole.Visible = False

    End Sub

End Class
