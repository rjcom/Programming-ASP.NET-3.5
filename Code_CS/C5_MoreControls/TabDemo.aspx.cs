using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TabDemo : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // Generate label controls
       int numlabels = Int32.Parse(ddlLabels.SelectedItem.Value);
       for (int i = 1; i <= numlabels; i++)
       {
          Label lbl = new Label();
          lbl.Text = "Label" + (i).ToString();
          lbl.ID = "Label" + (i).ToString();
          pnlDynamic.Controls.Add(lbl);
          pnlDynamic.Controls.Add(new LiteralControl("<br />"));
       }

       // Generate textbox controls
       int numBoxes = Int32.Parse(ddlBoxes.SelectedItem.Value);
       for (int i = 1; i <= numBoxes; i++)
       {
          TextBox txt = new TextBox();
          txt.Text = "TextBox" + (i).ToString();
          txt.ID = "TextBox" + (i).ToString();
          pnlDynamic.Controls.Add(txt);
          pnlDynamic.Controls.Add(new LiteralControl("<br />"));
       }
    }
}
