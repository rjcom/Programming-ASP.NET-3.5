using System;

public partial class ButtonDemo : System.Web.UI.Page
{
   protected void btnLink_Click(object sender, EventArgs e)
   {
      Response.Redirect("http://www.ora.com");
   }
}
