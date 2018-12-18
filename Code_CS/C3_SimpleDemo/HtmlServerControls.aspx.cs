using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class HtmlServerControls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_OnServerClick(object sender, EventArgs e)
    {
       string strHtml = "";
       strHtml += txtName.Value + "<br/>";
       strHtml += txtStreet.Value + "<br/>";
       strHtml += txtCity.Value + ", " + txtState.Value;
       tdInnerHtml.InnerHtml = strHtml;
    }
}
