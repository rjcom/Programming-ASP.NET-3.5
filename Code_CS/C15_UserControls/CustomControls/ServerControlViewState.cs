using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControls
{
   [DefaultProperty("Text")]
   [ToolboxData("<{0}:ServerControlViewState runat=server></{0}:ServerControlViewState>")]
   public class ServerControlViewState : WebControl
   {
      [Bindable(true)]
      [Category("Appearance")]
      [DefaultValue("")]
      [Localizable(true)]
      public string Text
      {
         get
         {
            String s = (String)ViewState["Text"];
            return ((s == null) ? "[" + this.ID + "]" : s);
         }

         set
         {
            ViewState["Text"] = value;
         }
      }


      public int Size
      {
         get { return Convert.ToInt32(ViewState["Size"]); }
         set { ViewState["Size"] = value; }
      }

      public ServerControlViewState()
      {
         ViewState["Size"] = 9;
      }

      protected override void RenderContents(HtmlTextWriter output)
      {
         output.AddStyleAttribute("color", "fuchsia");
         output.AddStyleAttribute("font-size", String.Format("{0}pt", Size.ToString()));
         output.RenderBeginTag("p");
         output.Write(Text);
         output.RenderEndTag();
      }
   }
}
