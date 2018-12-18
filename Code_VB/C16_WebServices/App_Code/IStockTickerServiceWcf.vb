Imports System 
Imports System.Collections.Generic 
Imports System.Linq 
Imports System.Runtime.Serialization 
Imports System.ServiceModel 
Imports System.Text 

' NOTE: If you change the interface name "IStockTickerServiceWcf" here, you must also update the reference to "IStockTickerServiceWcf" in Web.config. 
<ServiceContract()> _ 
Public Interface IStockTickerServiceWcf 
    <OperationContract()> _ 
    Function GetStockTickerCount() As Integer 
    
    <OperationContract()> _ 
    Function GetTickerSymbol(ByVal index As Integer) As String 
    
    <OperationContract()> _ 
    Function GetStockInfo(ByVal ticker As String) As StockInfo 
End Interface 

<DataContract()> _ 
Public Class StockInfo 
Private _Ticker As String 
    <DataMember()> _ 
    Public Property Ticker() As String 
        Get 
            Return _Ticker 
        End Get 
        Set(ByVal value As String) 
            _Ticker = value 
        End Set 
    End Property 
Private _Name As String 
    <DataMember()> _ 
    Public Property Name() As String 
        Get 
            Return _Name 
        End Get 
        Set(ByVal value As String) 
            _Name = value 
        End Set 
    End Property 
Private _Price As Double 
    <DataMember()> _ 
    Public Property Price() As Double 
        Get 
            Return _Price 
        End Get 
        Set(ByVal value As Double) 
            _Price = value 
        End Set 
    End Property 
End Class 
