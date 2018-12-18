using System;
using System.Web.UI;

public partial class PanelDemo2WithAJAX : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if (Page.IsPostBack)
       {
          lblChoices.Text = "Selected : " + rblWebsites.SelectedValue;
       }
    }
}
