using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ImageDemo : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      switch (ddlAlign.SelectedIndex)
      {
         case 0:
            img1.ImageAlign = ImageAlign.NotSet;
            img2.ImageAlign = ImageAlign.NotSet;
            break;
         case 1:
            img1.ImageAlign = ImageAlign.AbsBottom;
            img2.ImageAlign = ImageAlign.AbsBottom;
            break;
         case 2:
            img1.ImageAlign = ImageAlign.AbsMiddle;
            img2.ImageAlign = ImageAlign.AbsMiddle;
            break;
         case 3:
            img1.ImageAlign = ImageAlign.Top;
            img2.ImageAlign = ImageAlign.Top;
            break;
         case 4:
            img1.ImageAlign = ImageAlign.Bottom;
            img2.ImageAlign = ImageAlign.Bottom;
            break;
         case 5:
            img1.ImageAlign = ImageAlign.Baseline;
            img2.ImageAlign = ImageAlign.Baseline;
            break;
         case 6:
            img1.ImageAlign = ImageAlign.Middle;
            img2.ImageAlign = ImageAlign.Middle;
            break;
         case 7:
            img1.ImageAlign = ImageAlign.TextTop;
            img2.ImageAlign = ImageAlign.TextTop;
            break;
         case 8:
            img1.ImageAlign = ImageAlign.Left;
            img2.ImageAlign = ImageAlign.Left;
            break;
         case 9:
            img1.ImageAlign = ImageAlign.Right;
            img2.ImageAlign = ImageAlign.Right;
            break;
         default:
            img1.ImageAlign = ImageAlign.NotSet;
            img2.ImageAlign = ImageAlign.NotSet;
            break;
      }
   }
}
