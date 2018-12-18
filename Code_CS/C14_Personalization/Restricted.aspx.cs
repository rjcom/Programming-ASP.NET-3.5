using System;

public partial class Restricted : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (User.Identity.Name == "Jane")
        {
            Response.Redirect("NoPrivs.aspx");
        }
    }
}
