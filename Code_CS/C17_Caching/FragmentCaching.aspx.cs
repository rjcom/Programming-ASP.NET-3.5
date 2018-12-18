using System;
using System.Web.UI;

public partial class FragmentCaching : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       lblPageTime.Text = String.Format("Page time is {0}",
          DateTime.Now.ToLongTimeString());
    }
}
