using System;
using System.Web.UI;

public partial class ControlStateControl : Page
{
   protected void btnSize_Click(object sender, EventArgs e)
   {
      sizeControl.Size += 2;
   }
}
