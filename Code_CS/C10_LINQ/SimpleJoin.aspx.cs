using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class SimpleJoin : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       IEnumerable<Book> books = Book.GetBookList();
       IEnumerable<BookStats> stats = BookStats.GetBookStats();

       // Using the DataSource property
       var bookTitles =
          from b in books
          join s in stats on b.ISBN equals s.ISBN
          select new { Name = b.Title, Pages = s.Pages };

       lvwBooks.DataSource = bookTitles;
       this.DataBind();
    }
}
