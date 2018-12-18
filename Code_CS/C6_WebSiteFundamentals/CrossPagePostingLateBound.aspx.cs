using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CrossPagePostingLateBound : Page
{
   protected void btnServerTransfer_Click(object sender, EventArgs e)
   {
      Server.Transfer("TargetPage.aspx");
   }
   protected void btnRedirect_Click(object sender, EventArgs e)
   {
      Response.Redirect("TargetPage.aspx");
   }
}
