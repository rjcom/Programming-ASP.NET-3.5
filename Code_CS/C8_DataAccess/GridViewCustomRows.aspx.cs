using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridViewCustomRows : Page
{
   protected void gvwCustomers_RowEditing(object sender, GridViewEditEventArgs e)
   {
      SwitchVisibleColumns(false);
   }

   protected void gvwCustomers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
   {
      SwitchVisibleColumns(true);
   }

   protected void gvwCustomers_RowUpdated(object sender, GridViewUpdatedEventArgs e)
   {
      SwitchVisibleColumns(true);
   }
   
   private void SwitchVisibleColumns(bool inReadOnlyMode)
   {
      gvwCustomers.Columns[1].Visible = inReadOnlyMode;   //FullName
      gvwCustomers.Columns[2].Visible = !inReadOnlyMode;  //NameStyle
      gvwCustomers.Columns[3].Visible = !inReadOnlyMode;  //Title
      gvwCustomers.Columns[4].Visible = !inReadOnlyMode;  //FirstName
      gvwCustomers.Columns[5].Visible = !inReadOnlyMode;  //MiddleName
      gvwCustomers.Columns[6].Visible = !inReadOnlyMode;  //LastName
      gvwCustomers.Columns[7].Visible = !inReadOnlyMode;  //Suffix
      gvwCustomers.Columns[12].Visible = inReadOnlyMode;  //ModifiedDate
      gvwCustomers.Columns[13].Visible = inReadOnlyMode;  //PasswordHash
      gvwCustomers.Columns[14].Visible = inReadOnlyMode;  //PasswordSalt
   }


}
