using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMasterPage : MasterPage
{
   public Image AnimalImage
   {
      get { return imgAnimal; }
      set { imgAnimal = value; }
   }


   protected void Page_Load(object sender, EventArgs e)
   {
   }
}
