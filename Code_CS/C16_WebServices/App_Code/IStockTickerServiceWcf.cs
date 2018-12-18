using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the interface name "IStockTickerServiceWcf" here, you must also update the reference to "IStockTickerServiceWcf" in Web.config.
[ServiceContract]
public interface IStockTickerServiceWcf
{
    [OperationContract]
    int GetStockTickerCount();

    [OperationContract]
    string GetTickerSymbol(int index);

    [OperationContract]
    StockInfo GetStockInfo(string ticker);
}

[DataContract]
public class StockInfo
{
    [DataMember]
    public string Ticker { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public double Price { get; set; }
}
