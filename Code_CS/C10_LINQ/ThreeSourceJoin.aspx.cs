using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

public partial class ThreeSourceJoin : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       List<Book> bookList = Book.GetBookList();
       XElement doc = XElement.Load(Request.ApplicationPath + "\\authors.xml");
       //XElement doc = XElement.Load(@"file:///D:\CodeLocal\C10_LINQ\Authors.xml");
       using (AwltCustomersDataContext db = new AwltCustomersDataContext())
       {
          var authorsByBooks =
             from book in doc.DescendantsAndSelf("book")
             join bookInfo in bookList on book.Attribute("isbn").Value equals bookInfo.ISBN
             join authorInfo in db.Customers on book.Parent.Attribute("id").Value equals authorInfo.CustomerID.ToString()
             let authorName = authorInfo.FirstName + " " + authorInfo.LastName
             orderby bookInfo.Title
             group new { Name = authorName}
             by bookInfo.Title
                into groupedAuthors
                select new
                {
                   Title = groupedAuthors.Key,
                   Authors = groupedAuthors
                };

          foreach (var book in authorsByBooks)
          {
             lblBooks.Text += String.Format("<h2>{0}</h2>", book.Title);
             foreach (var author in book.Authors)
             {
                lblBooks.Text += String.Format("Author: {0} <br />", author.Name);
             }
          }
       }
    }
}
