using System;
using System.Collections.Generic;

public class Book
{
   public string ISBN { get; set; }
   public string Title { get; set; }
   public decimal Price { get; set; }
   public DateTime ReleaseDate { get; set; }

   public static List<Book> GetBookList()
   {
      List<Book> list = new List<Book>();
      list.Add(new Book { ISBN = "0596529562", ReleaseDate = Convert.ToDateTime("2008-07-15"), 
         Price = 30.0m, Title = "Programming ASP.NET 3.5" });
      list.Add(new Book { ISBN = "059652756X", ReleaseDate = Convert.ToDateTime("2008-06-15"), 
         Price = 26.0m, Title = "Programming .NET 3.5" });
      list.Add(new Book { ISBN = "0596518455", ReleaseDate = Convert.ToDateTime("2008-07-15"), 
         Price = 28.0m, Title = "Learning ASP.NET 3.5" });
      list.Add(new Book { ISBN = "0596518439", ReleaseDate = Convert.ToDateTime("2008-03-15"), 
         Price = 25.0m, Title = "Programming Visual Basic 2008" });
      list.Add(new Book { ISBN = "0596527438", ReleaseDate = Convert.ToDateTime("2008-01-15"), 
         Price = 31.0m, Title = "Programming C# 3.0" });

      return list;
   }
}
