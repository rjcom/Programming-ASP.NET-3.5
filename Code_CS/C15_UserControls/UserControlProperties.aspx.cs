using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControlProperties : Page
{
   protected void btnSubmit_Click(object sender, EventArgs e)
   {
      CustomerDL1.NumOfColumns = Convert.ToInt32(ddlColumns.SelectedValue);

      switch (ddlDirection.SelectedValue)
      { 
         case "Horizontal":
            CustomerDL1.Direction = RepeatDirection.Horizontal;
            break;
         case "Vertical":
            CustomerDL1.Direction = RepeatDirection.Vertical;
            break;
      }
   }
}
