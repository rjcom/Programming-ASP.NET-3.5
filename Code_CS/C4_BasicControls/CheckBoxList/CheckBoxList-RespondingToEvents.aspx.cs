using System;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckBoxList_RespondingToEvents : Page
{
    protected void cblItems_Init(object sender, EventArgs e)
    {
        // create an array of items to add
        string[] Genre = { "SciFi", "Novels", "Computers", "History", "Religion" };
        cblItems.DataSource = Genre;
        cblItems.DataBind();
    }

    protected void cblItems_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cblItems.SelectedItem == null)
        {
            lblCategory.Text = "<br />No genres selected.";
        }
        else
        {
            StringBuilder sb = new StringBuilder();

            foreach (ListItem li in cblItems.Items)
            {
                if (li.Selected)
                {
                    sb.Append("<br/>" + li.Value + " - " + li.Text);
                }
            }
            lblCategory.Text = sb.ToString();
        }
    }
}
