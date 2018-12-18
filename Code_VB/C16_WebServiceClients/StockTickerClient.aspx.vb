Imports System 
Imports System.Web.UI 
Imports localhost 

Public Partial Class StockTickerClient 
    Inherits Page 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) 
        If Not IsPostBack Then 
            lblMessage.Text = "First loaded at " & DateTime.Now.ToLongTimeString() 
        Else 
            lblMessage.Text = "Postback at " & DateTime.Now.ToLongTimeString() 
        End If 
    End Sub 
    
    Protected Sub btnWebService_Click(ByVal sender As Object, ByVal e As EventArgs) 
        Dim proxy As New StockTickerSimple() 
        lblMessage.Text = [String].Format("Current MSFT Price: {0}", proxy.GetPrice("MSFT").ToString()) 
    End Sub 
End Class 
