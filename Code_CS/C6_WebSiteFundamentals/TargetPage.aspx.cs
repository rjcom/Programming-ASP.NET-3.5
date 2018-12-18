using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TargetPage : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      lblIsPostBack.Text = IsPostBack.ToString();
      lblIsCrossPagePostBack.Text = IsCrossPagePostBack.ToString();
      if (PreviousPage != null) 
      { 
         DropDownList ddl = 
            PreviousPage.FindControl("ddlFavoriteActivity") 
               as DropDownList;
         if (ddl != null)
         {
            lblActivity.Text =
               ddl.SelectedItem.ToString() + " (late-bound)";
         }
         lblPreviousPage.Text = Page.PreviousPage.Title;
      }
   }
}
