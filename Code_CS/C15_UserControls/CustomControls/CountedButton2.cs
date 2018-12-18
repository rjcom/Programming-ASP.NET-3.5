using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControls
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:CountedButton2 runat=server></{0}:CountedButton2>")]
    public class CountedButton2 : Button
    {
        private string displayString;

        // default constructor
        public CountedButton2()
        {
            displayString = "clicks";
            InitValues();
        }

        // overloaded, takes string to display (e.g., 5 books)
        public CountedButton2(string text)
        {
            displayString = text;
            InitValues();
        }

        // called by constructors
        private void InitValues()
        {
            if (ViewState["Count"] == null)
            {
                Count = 0;
            }
            Text = "Click me";
        }

        // count as property maintained in view state
        public int Count
        {
            get
            {
                return (int)ViewState["Count"];
            }

            set
            {
                ViewState["Count"] = value;
            }
        }

        // override the OnClick to increment the count,
        // update the button text and then invoke the base method
        protected override void OnClick(EventArgs e)
        {
            Count = Count + 1;
            Text = Count.ToString() + " " + displayString;
            base.OnClick(e);
        }
    }
}
