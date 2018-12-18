﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class SimpleWhere : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       IEnumerable<Book> books = Book.GetBookList();
       IEnumerable<BookStats> stats = BookStats.GetBookStats();

       // Using the DataSource property
       var bookTitles =
          from b in books
          join s in stats on b.ISBN equals s.ISBN
          where s.Sales > 60000
          select new { Name = b.Title, Sales = s.Sales};

       lvwBooks.DataSource = bookTitles;
       this.DataBind();
    }
}
