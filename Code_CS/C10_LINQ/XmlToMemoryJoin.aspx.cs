﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

public partial class XmlToMemoryJoin : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       List<Book> bookList = Book.GetBookList();
       XElement doc = XElement.Load(Request.ApplicationPath + "\\authors.xml");

       var authorsByBooks =
          from book in doc.DescendantsAndSelf("book")
          join bookInfo in bookList on book.Attribute("isbn").Value equals bookInfo.ISBN
          let authorId = book.Parent.Attribute("id").Value
          orderby bookInfo.Title
          group new { AuthorId = authorId }
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
             lblBooks.Text += String.Format("Author ID: {0}<br />", author.AuthorId);
          }
       }
    }
}
