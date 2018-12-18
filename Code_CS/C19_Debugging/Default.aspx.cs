﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AtChapterStart : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      // Initialise list of books for DropDownList
      if (!IsPostBack)
      {
         string[,] bookList = {
            {"9780596513979", "Learning ASP.NET 2.0 with AJAX"},
            {"9780596510503", "Building a Web 2.0 Portal with ASP.NET 3.5"},
            {"9780596514822", "Head First C#"},
            {"9780596514242", "Programming ASP.NET AJAX"},
            {"059652756X", "Programming .NET 3.5"},
            {"9780596526993", "Programming WCF Services"}
         };

         // Now populate the list
         for (int i = 0; i < bookList.GetLength(0); i++)
         {
            ddlBooks.Items.Add(new ListItem(bookList[i, 1], bookList[i, 0]));
         }
      }
   }

   protected void ddlBooks_SelectedIndexChanged(object sender, EventArgs e)
   {
      // Check to verify an item has been selected
      if (ddlBooks.SelectedIndex != -1)
      {
         lblBooks.Text = String.Format("{0}, ISBN : {1}",
            ddlBooks.SelectedItem.Text, ddlBooks.SelectedValue);
      }
   }
}
