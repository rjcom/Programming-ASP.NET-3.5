Imports System 
Imports System.Web.Services 

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
' [System.Web.Script.Services.ScriptService] 
<WebService([Namespace] := "http://tempuri.org/")> _ 
<WebServiceBinding(ConformsTo := WsiProfiles.BasicProfile1_1)> _ 
Public Class StockTickerSimple 
    Inherits WebService 
    ' Construct and fill an array of stock symbols and prices. 
    ' Note: the stock prices are as of 7/30/08. 
    Private stocks As String(,) = {{"MSFT", "Microsoft", "26.23"}, {"DELL", "Dell Inc", "24.00"}, {"HPQ", "Hewlett-Packard", "45.06"}, {"GOOG", "Google", "482.70"}, {"YHOO", "Yahoo!", "20.03"}, {"GE", "General Electric", "28.97"}, _ 
    {"IBM", "International Business Machines", "128.86"}, {"GM", "General Motors", "11.40"}, {"F", "Ford Motor Company", "4.84"}} 
    
    <WebMethod()> _ 
    Public Function GetPrice(ByVal StockSymbol As String) As Double 
        ' Given a stock symbol, return the price. 
        ' Iterate through the array, looking for the symbol. 
        For i As Integer = 0 To stocks.GetLength(0) - 1 
            ' Do a case-insensitive string compare. 
            If [String].Compare(StockSymbol, stocks(i, 0), True) = 0 Then 
                Return Convert.ToDouble(stocks(i, 2)) 
            End If 
        Next 
        Return 0 
    End Function 
    
    <WebMethod()> _ 
    Public Function GetName(ByVal StockSymbol As String) As String 
        ' Given a stock symbol, return the name. 
        ' Iterate through the array, looking for the symbol. 
        For i As Integer = 0 To stocks.GetLength(0) - 1 
            ' Do a case-insensitive string compare. 
            If [String].Compare(StockSymbol, stocks(i, 0), True) = 0 Then 
                Return stocks(i, 1) 
            End If 
        Next 
        Return "Symbol not found." 
    End Function 
End Class 