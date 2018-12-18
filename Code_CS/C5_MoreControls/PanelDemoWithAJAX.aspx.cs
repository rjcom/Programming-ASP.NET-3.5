using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PanelDemoWithAJAX : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       //  First take care of the panel w/ the dynamically generated controls
       // Show/Hide Panel Contents
       pnlDynamic.Visible = chkVisible.Checked;

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
