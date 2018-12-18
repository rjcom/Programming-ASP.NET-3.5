using System;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

public partial class SimpleXmlQuery2 : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      XElement doc = XElement.Load(@"file:///D:\CodeSvn\ProgASPNET4e\Chapter10\C10_LINQ\Authors.xml");

      var authorIds = from authors in doc.DescendantsAndSelf("author")
                      select new { AuthorId = authors.Attribute("id").Value };

      
      

      lvwAuthors.DataSource = authorIds;
      lvwAuthors.DataBind();
   }
}
