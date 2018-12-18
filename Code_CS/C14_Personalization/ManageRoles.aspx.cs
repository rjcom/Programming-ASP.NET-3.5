using System;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManageRoles : Page
{
   private string[] rolesArray;
   private string[] usersInRole;
   MembershipUserCollection users;

   protected void Page_Load(object sender, EventArgs e)
   {
      Msg.Text = string.Empty;
      if (!IsPostBack)
      {
         rolesArray = Roles.GetAllRoles();
         RolesListBox.DataSource = rolesArray;
         RolesListBox.DataBind();
         users = Membership.GetAllUsers();
         UsersListBox.DataSource = users;
         UsersListBox.DataBind();
      }
      if (RolesListBox.SelectedItem != null)
      {
         usersInRole = Roles.GetUsersInRole
               (RolesListBox.SelectedItem.Value);
         UsersInRoleGrid.DataSource = usersInRole;
         UsersInRoleGrid.DataBind();
      }
   }

   protected void btnAddUsersToRole_Click(object sender, EventArgs e)
   {
      if (RolesListBox.SelectedItem == null)
      {
         this.Msg.Text = "Please select a role.";
         return;
      }
      if (UsersListBox.SelectedItem == null)
      {
         Msg.Text = "Please select one or more users";
         return;
      }

      int sizeOfArray = UsersListBox.GetSelectedIndices().Length;
      string[] newUsers = new string[sizeOfArray];

      // get the array of selected indices from the (multiselect) list box
      int[] selectedIndices = UsersListBox.GetSelectedIndices();

      for (int i = 0; i < newUsers.Length; i++)
      {
         // get the selectedIndex that corresponds to the counter[i]
         int selectedIndex = selectedIndices[i];
         //get the ListItem in the UserListBox Items collection at that offset
         ListItem myListItem = UsersListBox.Items[selectedIndex];
         //get the string that is that ListItem's value property
         string newUser = myListItem.Value;
         //add that string to the newUsers collection of string
         newUsers[i] = newUser;
      }

      // Add users to the selected role
      Roles.AddUsersToRole(newUsers, RolesListBox.SelectedItem.Value);
      usersInRole = Roles.GetUsersInRole(RolesListBox.SelectedItem.Value);
      UsersInRoleGrid.DataSource = usersInRole;
      UsersInRoleGrid.DataBind();
   }

   protected void btnCreateRole_Click(object sender, EventArgs e)
   {
      pnlCreateRole.Visible = true;
   }

   protected void UsersInRoleGrid_RemoveFromRole(object sender, GridViewCommandEventArgs e)
   {
      int index = Convert.ToInt32(e.CommandArgument);
      DataBoundLiteralControl theControl = (DataBoundLiteralControl)(UsersInRoleGrid.Rows[index].Cells[0].Controls[0]);
      string userName = theControl.Text;
      Roles.RemoveUserFromRole(userName, RolesListBox.SelectedItem.Value);
      usersInRole = Roles.GetUsersInRole(RolesListBox.SelectedItem.Value);
      UsersInRoleGrid.DataSource = usersInRole;
      UsersInRoleGrid.DataBind();
   }

   protected void btnAddRole_Click(object sender, EventArgs e)
   {
      if (txtNewRole.Text.Length > 0)
      {
         string newRole = txtNewRole.Text;
         if (Roles.RoleExists(newRole) == false)
         {
            Roles.CreateRole(newRole);
            rolesArray = Roles.GetAllRoles();
            RolesListBox.DataSource = rolesArray;
            RolesListBox.DataBind();
         }
      }
      txtNewRole.Text = string.Empty;
      pnlCreateRole.Visible = false;
   }
}
