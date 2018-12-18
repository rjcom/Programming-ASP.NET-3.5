using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopupControlExtenderDemo : Page
{
   protected void rblWebsites_SelectedIndexChanged(object sender, EventArgs e)
   {
      // Popup result is the selected task
      RadioButtonList list = (RadioButtonList)sender;
      this.Popup1.Commit(list.Text);
   }
}
