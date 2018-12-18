using System;
using System.Web.UI.WebControls;

public partial class DropDownListDemo : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      if (!IsPostBack)
      {
         //  Build 2 dimensional array for the lists       
         //  First dimension contains bookname       
         //  2nd dimension contains ISBN number       
         string[,] books = { 
            {"Learning ASP.NET 2.0 with AJAX", "9780596513976"},
            {"Beginning ASP.NET 2.0 with C#", "9780470042583"},          
            {"Programming C#","9780596527433"},            
            {"Programming .NET 3.5","978059652756X"},            
            {"Programming .NET Windows Applications","0596003218"},            
            {"Programming ASP.NET 3e","0596001711"},            
            {"WebClasses From Scratch","0789721260"},            
            {"Teach Yourself C++ in 21 Days","067232072X"},            
            {"Teach Yourself C++ in 10 Minutes","067231603X"},            
            {"XML & Java From Scratch","0789724766"},            
            {"Complete Idiot’s Guide to a Career in Computer Programming", "0789719959"},            
            {"XML Web Documents From Scratch","0789723166"},            
            {"Clouds To Code","1861000952"},            
            {"C++ Unleashed","0672312395"}         
        };

         //  Now populate the list.       
         for (int i = 0; i < books.GetLength(0); i++)
         {
            //  Add both Text and Value          
            ddlBooks.Items.Add(new ListItem(books[i, 0], books[i, 1]));
         }
      }
   }

   protected void ddlBooks_SelectedIndexChanged(object sender, EventArgs e)
   {
      //  Check to verify that something has been selected.
      if (ddlBooks.SelectedIndex != -1)
      {
         lblBookInfo.Text = ddlBooks.SelectedItem.Text + " --->ISBN: " + ddlBooks.SelectedValue;
      }
   }
}
