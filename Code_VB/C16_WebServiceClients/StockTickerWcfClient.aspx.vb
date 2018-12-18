Imports System 
Imports System.Web.UI 
Imports System.Web.UI.WebControls 
Imports ServiceReference1 

Public Partial Class StockTickerWcfClient 
    Inherits Page 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) 
        If Not IsPostBack Then 
            Dim svcClient As New StockTickerServiceWcfClient() 
            Dim stockCount As Integer = svcClient.GetStockTickerCount() 
            For i As Integer = 0 To stockCount - 1 
                ddlStocks.Items.Add(New ListItem(svcClient.GetTickerSymbol(i))) 
            Next 
            svcClient.Close() 
        End If 
    End Sub 
    
    Protected Sub btnGetPrice_Click(ByVal sender As Object, ByVal e As EventArgs) 
        Dim svcClient As New StockTickerServiceWcfClient() 
        lblMessage.Text = svcClient.GetStockInfo(ddlStocks.SelectedValue).Price.ToString() 
        svcClient.Close() 
    End Sub 
End Class 
