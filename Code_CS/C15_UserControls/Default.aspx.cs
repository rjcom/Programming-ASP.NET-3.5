using System;
using System.Web.UI;

public partial class _Default : Page 
{
    protected void Button1_Click(object sender, EventArgs e)
    {
       Label1.Text = "Changed!";
    }
}
