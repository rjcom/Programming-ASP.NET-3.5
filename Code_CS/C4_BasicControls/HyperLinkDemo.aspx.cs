using System;

public partial class HyperLinkDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        hypLink.Target = ddlTarget.SelectedValue;
    }
}
