using System;
using System.Web.UI;

public partial class GlobalEvents : Page
{
    protected void btnEndSession_Click(object sender, EventArgs e)
    {
        Session.Abandon();
    }

    protected void btnError_Click(object sender, EventArgs e)
    {
        int a = 5;
        int b = 0;
        int c;
        c = a / b;
    }
}
