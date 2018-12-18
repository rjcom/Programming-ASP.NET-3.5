using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SqlDataSourceEvents : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CustomersDataSource_Selected(object sender, SqlDataSourceStatusEventArgs e)
    {
       lblSelectStats.Text = String.Format("Number of rows selected: {0}", e.AffectedRows);
    }
}
