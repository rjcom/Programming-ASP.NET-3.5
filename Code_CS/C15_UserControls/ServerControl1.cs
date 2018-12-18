using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControls
{
   [DefaultProperty("Text")]
   [ToolboxData("<{0}:ServerControl1 runat=server></{0}:ServerControl1>")]
   public class ServerControl1 : WebControl
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

      protected override void RenderContents(HtmlTextWriter output)
      {
         output.AddStyleAttribute("color", "red");
         output.RenderBeginTag("p");
         output.Write(Text);
         output.RenderEndTag();
      }
   }
}
