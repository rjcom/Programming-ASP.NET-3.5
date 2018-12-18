using System;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

public partial class SimpleXmlQuery : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
       XElement doc = XElement.Load(Request.ApplicationPath + "\\authors.xml");

       var authorIds = from authors in doc.Elements("author")
                       select authors.Attribute("id").Value;

       foreach (var id in authorIds)
       {
          lblAuthors.Text += String.Format("<p>{0}</p>", id);
       }
    }
}
