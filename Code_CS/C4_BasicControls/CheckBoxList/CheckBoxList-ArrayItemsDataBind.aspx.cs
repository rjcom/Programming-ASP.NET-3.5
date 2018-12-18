using System;

public partial class CheckBoxList_ArrayItemsDataBind : System.Web.UI.Page
{
   protected void cblItems_Init(object sender, EventArgs e)
   {
      // create an array of items to add
      string[] Categories = { "SciFi", "Novels", "Computers", "History", "Religion" };
      cblItems.DataSource = Categories;
      cblItems.DataBind();
   }
}
