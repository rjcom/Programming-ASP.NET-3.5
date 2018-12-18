using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class SimpleGroupBy : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      IEnumerable<Book> books = Book.GetBookList();
      IEnumerable<BookStats> stats = BookStats.GetBookStats();

      // Using the DataSource property
      var bookTitles =
         from b in books
         join s in stats on b.ISBN equals s.ISBN
         let outYet =
            (b.ReleaseDate < DateTime.Now ? "Out now" : "Coming Soon")
         orderby s.Rank
         group new { Title = b.Title, Price = b.Price, Pages = s.Pages }
         by outYet
            into groupedBooks
            select new
            {
               Status = groupedBooks.Key,
               Values = groupedBooks
            };

      foreach (var group in bookTitles)
      {
         lblBooks.Text += String.Format("<h2>{0}</h2>", group.Status);
         foreach (var book in group.Values)
         {
            lblBooks.Text += String.Format(
               "<p>{0}, {1:c} : {2} pages</p>", 
               book.Title, book.Price, book.Pages);
         }
      }
   }
}
