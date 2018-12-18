using System;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class StockTickerSimple : WebService
{
    //  Construct and fill an array of stock symbols and prices.
    //  Note: the stock prices are as of 7/30/08.
    string[,] stocks =
      {
         {"MSFT","Microsoft","26.23"},
         {"DELL","Dell Inc","24.00"},
         {"HPQ","Hewlett-Packard","45.06"},         
		 {"GOOG","Google","482.70"},
         {"YHOO","Yahoo!","20.03"},
         {"GE","General Electric","28.97"},
         {"IBM","International Business Machines","128.86"},
         {"GM","General Motors","11.40"},
         {"F","Ford Motor Company","4.84"}
      };

    [WebMethod]
    public double GetPrice(string StockSymbol)
        //  Given a stock symbol, return the price.
    {
        //  Iterate through the array, looking for the symbol.
        for (int i = 0; i < stocks.GetLength(0); i++) {
            //  Do a case-insensitive string compare.
            if (String.Compare(StockSymbol, stocks[i, 0], true) == 0)
                return Convert.ToDouble(stocks[i, 2]);
        }
        return 0;
    }

    [WebMethod]
    public string GetName(string StockSymbol)
        //  Given a stock symbol, return the name.
    {
        //  Iterate through the array, looking for the symbol.
        for (int i = 0; i < stocks.GetLength(0); i++) {
            //  Do a case-insensitive string compare.
            if (String.Compare(StockSymbol, stocks[i, 0], true) == 0)
                return stocks[i, 1];
        }
        return "Symbol not found.";
    }
}
