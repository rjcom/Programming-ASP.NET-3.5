using System;
using System.Web.UI;

public partial class SimpleUserControl : UserControl
{
    public string UserName
    {
        get { return lblUserName.Text; }
        set { lblUserName.Text = value; }
    }

   protected void Page_Load(object sender, EventArgs e)
   {
      lblTime.Text = String.Format("Control time is {0}",
         DateTime.Now.ToLongTimeString());
   }

   protected void btnChange_Click(object sender, EventArgs e)
   {
       lblUserName.Text = "Janey";
   }
}
