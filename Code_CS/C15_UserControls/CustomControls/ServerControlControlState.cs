using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControls
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControlControlState runat=server></{0}:ServerControlControlState>")]
    public class ServerControlControlState : WebControl
    {
        #region Control State properties

        [Serializable()]
        private struct ControlStateProperties
        {
            public int fontSize;
        }

        private ControlStateProperties controlState = new ControlStateProperties();

        #endregion


        #region Public Properties
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
            get 
            { 
                return controlState.fontSize; 
            }
            set 
            { 
                controlState.fontSize = value;
                SaveControlState();
            }
        }
        #endregion

        public ServerControlControlState()
        {
            controlState.fontSize = 9;
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.AddStyleAttribute("color", "fuchsia");
            output.AddStyleAttribute("font-size", String.Format("{0}pt", Size.ToString()));
            output.RenderBeginTag("p");
            output.Write(Text);
            output.RenderEndTag();
        }

        protected override void OnInit(EventArgs e)
        {
            Page.RegisterRequiresControlState(this);
            base.OnInit(e);
        }

        protected override object SaveControlState()
        {
            return controlState;
        }

        protected override void LoadControlState(object savedState)
        {
            controlState = new ControlStateProperties();
            controlState = (ControlStateProperties)savedState;
        }
    }
}
