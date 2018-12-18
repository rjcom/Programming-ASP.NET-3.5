using System;
using System.Web;
using System.Web.UI;

public partial class Programming : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       try
       {
          lblCurrentNode.Text = SiteMap.CurrentNode.Title;

          if (SiteMap.CurrentNode.HasChildNodes)
          {
             foreach (SiteMapNode childNode in SiteMap.CurrentNode.ChildNodes)
             {
                lblChildNodes.Text += childNode.Title + "<br/>";
             }
          }
       }
       catch (System.NullReferenceException)
       {
          lblCurrentNode.Text = "The xml file is not in the site map!";
       }
       catch (Exception ex)
       {
          lblCurrentNode.Text = "Exception! " + ex.Message;
       }
    }
}
