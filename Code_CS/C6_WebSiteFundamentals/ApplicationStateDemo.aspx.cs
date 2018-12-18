using System;
using System.Web.UI;
using System.Text;

public partial class ApplicationStateDemo : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}<br />", (string)Application["strStartMsg"]);
        sb.AppendFormat("{0}<br />", (string)Application["strEndMsg"]);

        string[] arTest = (string[])Application["arBooks"];
        sb.AppendFormat("{0}<br />", arTest[1].ToString());

        lblText.Text = sb.ToString();
    }
}
