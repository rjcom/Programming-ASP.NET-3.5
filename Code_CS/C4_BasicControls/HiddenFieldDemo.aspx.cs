using System;
using System.Web.UI.WebControls;

public partial class HiddenFieldDemo : System.Web.UI.Page
{
    protected void hdnSecretValue_ValueChanged(object sender, EventArgs e)
    {
       HiddenField hdn = sender as HiddenField;
       lblSecretValue.Text = hdn.Value;
    }
}
