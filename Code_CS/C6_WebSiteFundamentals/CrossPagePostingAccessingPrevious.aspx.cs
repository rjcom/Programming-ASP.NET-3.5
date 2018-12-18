using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CrossPagePostingAccessingPrevious : Page
{
   public DropDownList FavoriteActivity 
   {
      get { return ddlFavoriteActivity; }
   }

   protected void btnServerTransfer_Click(object sender, EventArgs e)
   {
      Server.Transfer("TargetPage.aspx");
   }
   protected void btnRedirect_Click(object sender, EventArgs e)
   {
      Response.Redirect("TargetPage.aspx");
   }
}
