using System;
using System.Web.UI;

public partial class CrossPagePostingSimple : Page
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
