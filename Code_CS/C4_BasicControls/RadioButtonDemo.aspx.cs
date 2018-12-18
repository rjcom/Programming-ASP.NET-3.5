using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RadioButtonDemo : Page
{
   protected void grpSize_CheckedChanged(object sender, EventArgs e)
   {
      //if (rdoSize10.Checked)
      //   lblTime.Font.Size = 10;
      //else if (rdoSize14.Checked)
      //   lblTime.Font.Size = 14;
      //else
      //   lblTime.Font.Size = 16;

       RadioButton rb = (RadioButton)sender;

       switch (rb.ID)
       {
           case "rdoSize10":
               lblTime.Font.Size = 10;
               break;
           case "rdoSize14":
               lblTime.Font.Size = 14;
               break;
           case "rdoSize16":
               lblTime.Font.Size = 16;
               break;
       }
   }

   protected void lblTime_Init(object sender, EventArgs e)
   {
      lblTime.Font.Name = "Verdana";
      lblTime.Font.Size = 20;
      lblTime.Font.Bold = true;
      lblTime.Font.Italic = true;
      lblTime.Text = DateTime.Now.ToString();
   }
}