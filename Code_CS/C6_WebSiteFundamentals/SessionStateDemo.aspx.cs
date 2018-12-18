using System;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SessionStateDemo : Page
{
   protected void rbl_SelectedIndexChanged(object sender, EventArgs e)
   {
      if (rbl.SelectedIndex != -1)
      {
         string[] Books = new string[3];
         Session["cattext"] = rbl.SelectedItem.Text;
         Session["catcode"] = rbl.SelectedItem.Value;
         switch (rbl.SelectedItem.Value)
         {
            case "n":
               Books[0] = "Programming C#"; 
               Books[1] = "Programming ASP.NET"; 
               Books[2] = "C# Essentials"; 
               break;
            case "d": 
               Books[0] = "Oracle & Open Source"; 
               Books[1] = "SQL in a Nutshell"; 
               Books[2] = "Transact-SQL Programming"; 
               break;
            case "h": 
               Books[0] = "PC Hardware in a Nutshell"; 
               Books[1] = "Dictionary of PC Hardware and Data Communications Terms"; 
               Books[2] = "Linux Device Drivers"; 
               break;
         } 
         Session["books"] = Books;
      }
   }
   protected void btn_Click(object sender, EventArgs e)
   {
      {
         if (rbl.SelectedIndex == -1) 
         { 
            lblMessage.Text = "You must select a book category."; 
         }
         else
         {
            StringBuilder sb = new StringBuilder(); 
            sb.Append("You have selected the category "); 
            sb.Append((string)Session["cattext"]); 
            sb.Append(" with code \""); 
            sb.Append((string)Session["catcode"]); 
            sb.Append("\"."); 
            lblMessage.Text = sb.ToString(); 
            ddl.Visible = true; 
            string[] CatBooks = (string[])Session["books"];             
            
            //  Populate the DropDownList.          
            int i; 
            ddl.Items.Clear(); 
            for (i = 0; i < CatBooks.GetLength(0); i++) 
            { 
               ddl.Items.Add(new ListItem(CatBooks[i])); 
            }
         }
      }
   }
}
