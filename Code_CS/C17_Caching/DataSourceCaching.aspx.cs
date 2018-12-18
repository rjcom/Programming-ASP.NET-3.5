using System;
using System.Web.UI;

public partial class DataSourceCaching : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       lblTime.Text = String.Format("Page posted at {0}",
          DateTime.Now.ToLongTimeString());
    }
}
