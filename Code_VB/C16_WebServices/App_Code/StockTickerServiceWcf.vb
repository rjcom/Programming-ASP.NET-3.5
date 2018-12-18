Imports System 
Imports System.Collections.Generic 
Imports System.Linq 
Imports System.Runtime.Serialization 
Imports System.ServiceModel 
Imports System.Text 

' NOTE: If you change the class name "StockTickerServiceWcf" here, you must also update the reference to "StockTickerServiceWcf" in Web.config. 
Public Class StockTickerServiceWcf 
    Implements IStockTickerServiceWcf 
    Private stocks As String(,) = {{"MSFT", "Microsoft", "26.23"}, {"DELL", "Dell Inc", "24.00"}, {"HPQ", "Hewlett-Packard", "45.06"}, {"GOOG", "Google", "482.70"}, {"YHOO", "Yahoo!", "20.03"}, {"GE", "General Electric", "28.97"}, _ 
    {"IBM", "International Business Machines", "128.86"}, {"GM", "General Motors", "11.40"}, {"F", "Ford Motor Company", "4.84"}} 
    
    Public Function GetStockTickerCount() As Integer 
        Return stocks.GetLength(0) 
    End Function 
    
    Public Function GetTickerSymbol(ByVal index As Integer) As String 
        Return stocks(index, 0) 
    End Function 
    
    Public Function GetStockInfo(ByVal ticker As String) As StockInfo 
        Dim info As New StockInfo() 
        For i As Integer = 0 To stocks.GetLength(0) - 1 
            If stocks(i, 0) <> ticker Then 
                Continue For 
            End If 
            info.Ticker = stocks(i, 0) 
            info.Name = stocks(i, 1) 
            info.Price = [Double].Parse(stocks(i, 2)) 
            Return info 
        Next 
        Return Nothing 
    End Function 
End Class 
