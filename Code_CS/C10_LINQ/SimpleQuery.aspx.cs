using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class SimpleQuery : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      List<Book> books = Book.GetBookList();

      // Using inline binding
      var bookTitles =
         from b in books
         select b.Title;

      foreach (var title in bookTitles)
      {
         lblBooks.Text += String.Format("{0}<br />", title);
      }
   }
}
