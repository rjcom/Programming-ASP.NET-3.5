using System;

public partial class TextBoxes : System.Web.UI.Page
{
    protected void txtInput_TextChanged(object sender, EventArgs e)
    {
       txtEcho.Text = txtInput.Text;
    }
}
