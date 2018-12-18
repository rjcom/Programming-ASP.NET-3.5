using System;
using System.Web.UI;

public partial class OutputCaching : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       lblTime.Text = String.Format("Page posted at {0}",
          DateTime.Now.ToLongTimeString());
       lblUserName.Text = String.Format("UserName : {0}",
          Request.QueryString["UserName"]);
       lblState.Text = String.Format("State : {0}",
          Request.QueryString["State"]);
    }
}
