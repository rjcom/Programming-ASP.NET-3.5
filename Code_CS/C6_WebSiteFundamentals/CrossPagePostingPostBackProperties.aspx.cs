using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CrossPagePostingPostBackProperties : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      lblIsPostBack.Text = IsPostBack.ToString(); 
      lblIsCrossPagePostBack.Text = IsCrossPagePostBack.ToString();
      if (Page.PreviousPage != null)
      {
         lblPreviousPage.Text = Page.PreviousPage.Title;
      }
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
