using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class SimpleSelect : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      List<Book> books = Book.GetBookList();

      // Using the DataSource property
      var bookTitles =
         from b in books
         select new { ISBN = b.ISBN,
                      Released = (b.ReleaseDate < DateTime.Now ? "Out now" : "Coming soon") };

      lvwBooks.DataSource = bookTitles;
      this.DataBind();
   }
}
