using System;
using System.Web.UI;

public partial class RoleRestricted : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if (User.IsInRole("Member"))
       {
          Response.Redirect("NoPrivs.aspx");
       }
    }
}
