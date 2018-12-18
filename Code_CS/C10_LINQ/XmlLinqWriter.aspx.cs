using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

public partial class XmlLinqWriter : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      List<Book> bookList = Book.GetBookList();
      XElement doc = XElement.Load(@"file:///D:\CodeLocal\C10_LINQ\Authors.xml");

      XElement xml = new XElement("books",
         from book in doc.DescendantsAndSelf("book")
         join bookInfo in bookList on book.Attribute("isbn").Value equals bookInfo.ISBN
         let authorId = book.Parent.Attribute("id").Value
         orderby bookInfo.Title
         group new XElement("author", new XAttribute("id", authorId))
         by bookInfo.Title
            into groupedAuthors
            select new XElement("book",
               new XAttribute("title", groupedAuthors.Key),
               groupedAuthors)
               );

      //XElement xml = new XElement("authors",
      //   from author in doc.DescendantsAndSelf("author")
      //   select new XElement("author",
      //      new XAttribute("id", author.Attribute("id").Value)
      //      )
      //   );

      Response.Write(new XDeclaration("1.0", "utf-8", "yes").ToString());
      Response.Write(xml.ToString());

   }
}
