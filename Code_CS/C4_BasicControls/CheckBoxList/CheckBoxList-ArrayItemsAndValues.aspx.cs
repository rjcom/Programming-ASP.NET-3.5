using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class CheckBoxList_ArrayItemsAndValues : System.Web.UI.Page
{
   protected void cblItems_Init(object sender, EventArgs e)
   {
      // create an array of items to add
      string[] Categories = { "SciFi", "Novels", "Computers", "History", "Religion" };
      string[] Code = { "sf", "nvl", "cmp", "his", "rel" };

      for (int i=0; i<Categories.Length; i++)
      {
         cblItems.Items.Add(new ListItem(Categories[i], Code[i]));
      }
   }
}