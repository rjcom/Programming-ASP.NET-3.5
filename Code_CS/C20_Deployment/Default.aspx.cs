using System;
using System.Web.UI;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTime.Text = Class1.GetTime();
    }

    protected void btn1stPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("FirstPage.aspx");
    }

    protected void btn2ndPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("SecondPage.aspx");
    }
}

