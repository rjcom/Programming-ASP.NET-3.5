using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControls
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:CountedButton runat=server></{0}:CountedButton>")]
    public class CountedButton : Button
    {
        public CountedButton()
        {
            Text = "Click me";
            ViewState["Count"] = 0;
        }

        public int Count
        {
            get { return Convert.ToInt32(ViewState["Count"]); }
            set { ViewState["Count"] = value; }
        }

        protected override void OnClick(EventArgs e)
        {
            Count = Count + 1;
            Text = Count.ToString() + " clicks";
            base.OnClick(e);
        }
    }
}
