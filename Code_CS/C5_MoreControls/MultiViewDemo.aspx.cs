using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MultiViewDemo : Page
{
   protected void Page_PreRender(object sender, EventArgs e)
   {
      lblCurrentIndex.Text = MultiView1.ActiveViewIndex.ToString();
   }

   protected void rblView_SelectedIndexChanged(object sender, EventArgs e)
   {
      MultiView1.ActiveViewIndex = Convert.ToInt32(rblView.SelectedValue);
   }

   protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
   {
      lblFirstTextBox.Text = txtFirstView.Text;
      lblSecondTextBox.Text = txtSecondView.Text;
      rblView.SelectedIndex = MultiView1.ActiveViewIndex + 1;
   }

   protected void ActivateView(object sender, EventArgs e)
   {
      string str = lblViewActivation.Text;
      View v = (View)sender;
      str += "View " + v.ID + " activated <br/>";
      lblViewActivation.Text = str;
   }

   protected void DeactivateView(object sender, EventArgs e)
   {
      string str = lblViewActivation.Text;
      View v = (View)sender;
      str += "View " + v.ID + " deactivated <br/>";
      lblViewActivation.Text = str;
   }
}