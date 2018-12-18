using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class SimpleLet : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       IEnumerable<Book> books = Book.GetBookList();
       IEnumerable<BookStats> stats = BookStats.GetBookStats();

       // Using the DataSource property
       var bookTitles =
          from b in books
          join s in stats on b.ISBN equals s.ISBN
          let profit = (b.Price * s.Sales)
          select new { Name = b.Title, GrossProfit = profit };

       lvwBooks.DataSource = bookTitles;
       this.DataBind();
    }
}
