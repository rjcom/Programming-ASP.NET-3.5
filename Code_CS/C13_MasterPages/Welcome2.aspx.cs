using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome2 : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // Master.AnimalImage.ImageUrl = "~/images/progcs.gif";

       Control ctrl = Master.FindControl("imgAnimal");
       Image img = ctrl as Image;
       if (img != null)
       {
          img.ImageUrl = "~/images/progcs.gif";
       }
    }
}
