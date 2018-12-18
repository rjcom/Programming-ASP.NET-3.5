using System;
using System.Web.UI;

public partial class SelectionList : Page
{
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       lblSelection.Text =
          String.Format("<p>Selected Index : {0}<br />Selected Text : {1}<br />Selected Value : {2}</p>",
            DropDownList1.SelectedIndex.ToString(), DropDownList1.SelectedItem.Text, DropDownList1.SelectedValue);
    }
}
