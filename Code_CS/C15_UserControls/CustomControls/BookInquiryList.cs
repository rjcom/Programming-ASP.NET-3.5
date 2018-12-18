using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace CustomControls
{
    [ToolboxData("<{0}:BookInquiryList runat=server></{0}:BookInquiryList>")]
    [ControlBuilderAttribute(typeof(BookCounterBuilder)), ParseChildren(false)]
    public class BookInquiryList : WebControl, INamingContainer
    {
        protected override void Render(HtmlTextWriter output)
        {
            int totalInquiries = 0;
            BookCounter current;


            // Write the header
            output.Write("<Table border='1' width='90%' cellpadding='1'" +
               "cellspacing='1' align = 'center' >");
            output.Write("<tr><td colspan = '2' align='center'>");
            output.Write("<b> Inquiries </b></td></tr>");

            // if you have no contained controls, write the default msg.
            if (Controls.Count == 0)
            {
                output.Write("<tr><td colspan='2' align='center'>");
                output.Write("<b> No books listed </b></td></tr>");
            }
            // otherwise render each of the contained controls
            else
            {
                // iterate over the controls colelction and
                // display the book name for each
                // then tell each contained control to render itself
                for (int i = 0; i < Controls.Count; i++)
                {
                    current = Controls[i] as BookCounter;

                    if (current != null)
                    {
                        totalInquiries += current.Count;
                        output.Write("<tr><td align='left'>" +
                           current.BookName + "</td>");
                        output.RenderBeginTag("td");
                        current.RenderControl(output);
                        output.RenderEndTag();  // end td
                        output.Write("</tr>");
                    }
                }
                output.Write("<tr><td colspan='2' align='center'> " +
                   " Total Inquiries: " +
                   totalInquiries + "</td></tr>");
            }
            output.Write("</table>");
        }
    }




    internal class BookCounterBuilder : ControlBuilder
    {
        public override Type GetChildControlType(
           string tagName, IDictionary attributes)
        {
            if (tagName == "BookCounter")
                return typeof(BookCounter);
            else
                return null;
        }

        public override void AppendLiteralString(string s)
        {
        }
    }

}
