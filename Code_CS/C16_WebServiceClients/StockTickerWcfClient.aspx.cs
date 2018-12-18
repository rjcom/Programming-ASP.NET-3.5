using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;

public partial class StockTickerWcfClient : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            StockTickerServiceWcfClient svcClient = new StockTickerServiceWcfClient();
            int stockCount = svcClient.GetStockTickerCount();
            for (int i = 0; i < stockCount; ++i) 
            {
                ddlStocks.Items.Add(
                    new ListItem(svcClient.GetTickerSymbol(i)));
            }
            svcClient.Close();
        }
    }

    protected void btnGetPrice_Click(object sender, EventArgs e)
    {
        StockTickerServiceWcfClient svcClient = new StockTickerServiceWcfClient();
        lblMessage.Text = svcClient.GetStockInfo(ddlStocks.SelectedValue).Price.ToString();
        svcClient.Close();
    }
}
