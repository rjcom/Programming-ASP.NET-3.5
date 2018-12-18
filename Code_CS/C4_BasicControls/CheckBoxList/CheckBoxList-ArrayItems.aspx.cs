using System;
using System.Web.UI.WebControls;

public partial class CheckBoxList_ArrayItems : System.Web.UI.Page
{
   protected void cblItems_Init(object sender, EventArgs e)
   {
      // create an array of items to add
      string[] Categories = { "SciFi", "Novels", "Computers", "History", "Religion" };
      foreach (string category in Categories)
      {
          cblItems.Items.Add(new ListItem(category));
      }
   }
}
