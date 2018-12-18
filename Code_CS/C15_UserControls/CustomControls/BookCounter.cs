using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControls
{
   [ToolboxData("<{0}:BookCounter runat=server></{0}:BookCounter>")]
   public class BookCounter : WebControl, INamingContainer
   {
      // intialize the counted button member
      CountedButton2 btn = new CountedButton2("inquiries");

      public string BookName
      {
         get
         {
            return (string)ViewState["BookName"];
         }

         set
         {
            ViewState["BookName"] = value;
         }
      }

      public int Count
      {
         get
         {
            return btn.Count;
         }
         set
         {
            btn.Count = value;
         }
      }

      public void Reset()
      {
         btn.Count = 0;
      }

      protected override void CreateChildControls()
      {
         Controls.Add(btn);
      }
   }
}
