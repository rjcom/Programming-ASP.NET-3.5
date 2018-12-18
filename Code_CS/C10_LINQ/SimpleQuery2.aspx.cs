using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class SimpleQuery2 : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      List<Book> books = Book.GetBookList();

      // Using the DataSource property
      var bookTitles =
         from b in books
         select new { Title = b.Title };

      lvwBooks.DataSource = bookTitles;
      this.DataBind();
   }
}
