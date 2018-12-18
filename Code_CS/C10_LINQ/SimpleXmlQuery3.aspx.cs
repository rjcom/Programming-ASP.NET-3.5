using System;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

public partial class SimpleXmlQuery3 : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      XElement doc = XElement.Load(@"file:///D:\CodeSvn\ProgASPNET4e\Chapter10\C10_LINQ\Authors.xml");

      var authorIds = from book in doc.DescendantsAndSelf("book")
                      let authorId = book.Ancestors("author").Attributes("id").Single()
                      where book.Attribute("isbn").Value == "059652756X"
                      select new { AuthorId = authorId.Value };


      var authorIds2 = from author in doc.DescendantsAndSelf("author")
                       where author.Elements("book").Attributes("isbn").Any(attr => attr.Value == "059652756X")
                       select new { AuthorId = author.Attribute("id").Value };

      gvwAuthors.DataSource = authorIds;
      lvwAuthors.DataSource = authorIds2;
      this.DataBind();
   }
}
