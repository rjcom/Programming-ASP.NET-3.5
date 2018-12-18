using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

public partial class StateHistoryDemo : Page
{
    protected void SaveHistoryPoint(object sender, EventArgs e)
    {
        NameValueCollection state = new NameValueCollection();
        state.Add("book", rblBooks.SelectedValue);
        state.Add("author", ddlAuthors.SelectedValue);

        string newTitle = String.Format("Demo : {0} by {1}", rblBooks.SelectedValue, ddlAuthors.SelectedValue);
        sm.AddHistoryPoint(state, newTitle);
    }

    protected void RestoreHistoryPoint(object sender, HistoryEventArgs e)
    {
        if (e.State != null)
        { 
            if (String.IsNullOrEmpty(e.State["author"]))
            {
                ddlAuthors.SelectedIndex = 0;
            }
            else
            {
                ddlAuthors.SelectedIndex = ddlAuthors.Items.IndexOf(ddlAuthors.Items.FindByValue(e.State["author"]));
            }

            if (String.IsNullOrEmpty(e.State["book"]))
            {
                rblBooks.SelectedIndex = 0;
            }
            else
            {
                rblBooks.SelectedIndex = rblBooks.Items.IndexOf(rblBooks.Items.FindByValue(e.State["book"]));
            }
        }
    }
}
