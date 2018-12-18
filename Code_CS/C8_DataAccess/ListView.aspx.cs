using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListView : Page
{

   protected void btnSortOnLastName_Click(object sender, EventArgs e)
   {
      // Order ascending if data isn't currently ordered by LastName
      if (ListView1.SortExpression != "LastName")
      {
         ListView1.Sort("LastName", SortDirection.Ascending);
      }
      // If it is, change sortdirection
      else
      {
         ListView1.Sort("LastName", 
            (ListView1.SortDirection == SortDirection.Ascending ? SortDirection.Descending : SortDirection.Ascending));
      }
   }
}
