using System;
using System.Web.UI;

public partial class SecondPage : Page
{
    protected void btnHomePage_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }

    protected void btn1stPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("FirstPage.aspx");
    }

}