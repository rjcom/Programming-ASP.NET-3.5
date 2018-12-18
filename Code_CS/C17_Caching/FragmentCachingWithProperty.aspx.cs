using System;
using System.Web.UI;

public partial class FragmentCachingWithProperty : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       lblPageTime.Text = String.Format("Page time is {0}",
          DateTime.Now.ToLongTimeString());
       lblUserName.Text = CachedControl1.UserName;
    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
      CachedControl1.UserName = "Janey";
    }
}
