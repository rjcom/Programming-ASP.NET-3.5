using System;
using System.Web.UI;

public partial class StateBagDemo : Page
{
   public int Counter 
   { 
      get
      {
         if (ViewState["intCounter"] != null)
         {
            return ((int)ViewState["intCounter"]);
         }
         else
         {
            return 0;
         }
      } 
      set
      {
         ViewState["intCounter"] = value;         
      }
   }


   protected void Page_Load(object sender, EventArgs e)
   {
      lblCounter.Text = Counter.ToString();
      Counter++;
   }
}
