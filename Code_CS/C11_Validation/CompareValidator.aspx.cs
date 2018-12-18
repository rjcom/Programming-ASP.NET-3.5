using System;
using System.Web.UI;

public partial class CompareValidator : Page
{
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       if (Page.IsValid)
       {
          lblMsg.Text = "Page is valid";
       }
       else
       {
          lblMsg.Text = "Some of the fields still have no value";
       }
    }
}
