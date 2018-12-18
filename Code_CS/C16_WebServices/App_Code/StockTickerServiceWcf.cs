using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the class name "StockTickerServiceWcf" here, you must also update the reference to "StockTickerServiceWcf" in Web.config.
public class StockTickerServiceWcf : IStockTickerServiceWcf 
{
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

    public int GetStockTickerCount() {
        return stocks.GetLength(0);
    }

    public string GetTickerSymbol(int index) {
        return stocks[index, 0];
    }

    public StockInfo GetStockInfo(string ticker) {
        StockInfo info = new StockInfo();
        for (int i = 0; i < stocks.GetLength(0); ++i) {
            if (stocks[i, 0] != ticker) continue;
            info.Ticker = stocks[i, 0];
            info.Name = stocks[i, 1];
            info.Price = Double.Parse(stocks[i, 2]);
            return info;
        }
        return null;
    }
}
