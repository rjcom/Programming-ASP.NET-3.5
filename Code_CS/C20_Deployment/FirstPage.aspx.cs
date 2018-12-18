using System;
using System.Web.UI;

public partial class FirstPage : Page
{
    protected void btnHomePage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btn2ndPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("SecondPage.aspx");
    }

}
