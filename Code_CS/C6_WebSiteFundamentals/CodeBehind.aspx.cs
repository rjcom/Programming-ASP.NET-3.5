using System;
using System.Web.UI;

public partial class CodeBehind : Page
{
    protected void btnHello_Click(object sender, EventArgs e)
    {
       lblMessage.Text = "Hello. The time is " +
                DateTime.Now.ToLongTimeString();
    }
}
