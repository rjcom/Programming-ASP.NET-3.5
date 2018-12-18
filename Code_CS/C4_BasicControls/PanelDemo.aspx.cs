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

public partial class PanelDemo : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      //  First do the panel w/ the dynamically generated controls
      // Show/Hide Panel Contents
      if (chkHide.Checked)
      {
         pnlDynamic.Visible = false;
      }
      else
      {
         pnlDynamic.Visible = true;
      }

      // Generate label controls
      int numlabels = Int32.Parse(ddlLabels.SelectedItem.Value);
      for (int i = 1; i <= numlabels; i++)
      {
         Label lbl = new Label();
         lbl.Text = "Label" + i.ToString();
         lbl.ID = "Label" + i.ToString();
         pnlDynamic.Controls.Add(lbl);
         pnlDynamic.Controls.Add(new LiteralControl("<br />"));
      }

      // Generate textbox controls
      int numBoxes = Int32.Parse(ddlBoxes.SelectedItem.Value);
      for (int i = 1; i <= numBoxes; i++)
      {
         TextBox txt = new TextBox();
         txt.Text = "TextBox" + i.ToString();
         txt.ID = "TextBox" + i.ToString();
         pnlDynamic.Controls.Add(txt);
         pnlDynamic.Controls.Add(new LiteralControl("<br />"));
      }

      // Next take care of the Scrollbar panel.
      string strText = "<p>Four score and seven years ago our fathers brought forth, upon this continent, a new nation, conceived in liberty, and dedicated to the proposition that &#8220;all men are created equal.&#8221;</p>";
      strText += "<p>Now we are engaged in a great civil war, testing whether that nation, or any nation so conceived, and so dedicated, can long endure. We are met on a great battle field of that war. We have come to dedicate a portion of it, as a final resting place for those who died here, that the nation might live. This we may, in all propriety do. But, in a larger sense, we can not dedicate -- we can not consecrate -- we can not hallow, this ground -- The brave men, living and dead, who struggled here, have hallowed it, far above our poor power to add or detract. The world will little note, nor long remember what we say here; while it can never forget what they did here.</p>";
      strText += "<p>It is rather for us, the living, we here be dedicated to the great task remaining before us -- that, from these honored dead we take increased devotion to that cause for which they here, gave the last full measure of devotion -- that we here highly resolve these dead shall not have died in vain; that the nation, shall have a new birth of freedom, and that government of the people by the people for the people, shall not perish from the earth.</p>";

      lblPanelContent.Text = strText;


   }

   protected void ddlScrollBars_SelectedIndexChanged(object sender, EventArgs e) 
   { 
      DropDownList ddl = (DropDownList)sender; 
      string strValue = ddl.SelectedValue; 
      ScrollBars scrollBar = (ScrollBars)Enum.Parse(typeof(ScrollBars), strValue); 
      pnlScroll.ScrollBars = scrollBar; 
   }
   
   protected void rblWrap_SelectedIndexChanged(object sender, EventArgs e) 
   { 
      RadioButtonList rbl = (RadioButtonList)sender; 
      pnlScroll.Wrap = Convert.ToBoolean(rbl.SelectedValue); 
   }

}
