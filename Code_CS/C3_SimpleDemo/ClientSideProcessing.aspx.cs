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

public partial class ClientSideProcessing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnHTML_ServerClick(object sender, EventArgs e)
    {
       txtHTML.Value = "An HTML server control";
    }

    protected void btnServer_Click(object sender, EventArgs e)
    {
       txtHTML.Value = "An ASP.NET server control";
    }
}
