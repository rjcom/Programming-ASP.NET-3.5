using System;
using System.Web.UI;
using localhost;

public partial class StockTickerClient : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            lblMessage.Text = "First loaded at " +
               DateTime.Now.ToLongTimeString();
        } else {
            lblMessage.Text = "Postback at " +
               DateTime.Now.ToLongTimeString();
        }
    }

    protected void btnWebService_Click(object sender, EventArgs e) 
    {
        StockTickerSimple proxy = new StockTickerSimple();
        lblMessage.Text = String.Format("Current MSFT Price: {0}",
                                        proxy.GetPrice("MSFT").ToString());
    }
}
