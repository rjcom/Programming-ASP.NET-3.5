using System;
using System.Web.UI;
using System.Web;

public partial class OutputCachingLowLevel : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       Response.Cache.SetExpires(DateTime.Now.AddSeconds(10)); 
       Response.Cache.SetCacheability(HttpCacheability.Public);

       lblTime.Text = String.Format("Page posted at {0}",
          DateTime.Now.ToLongTimeString());
       lblUserName.Text = String.Format("UserName : {0}",
          Request.QueryString["UserName"]);
       lblState.Text = String.Format("State : {0}",
          Request.QueryString["State"]);
    }
}
