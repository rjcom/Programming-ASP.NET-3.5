using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdRotatorDemo : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {

   }
   protected void ad_AdCreated(object sender, AdCreatedEventArgs e)
   {
      if ((string)e.AdProperties["Animal"] != "")
         lblAnimal.Text = (string)e.AdProperties["Animal"];
      else
         lblAnimal.Text = "Not available.";
   }
}