using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ImageMapDemo : Page
{
   protected void imgmapYesNoMaybe_Click(object sender, ImageMapEventArgs e) 
   { 
      lblMessage.Text = "The PostBackValue is " + e.PostBackValue; 
   }
}
