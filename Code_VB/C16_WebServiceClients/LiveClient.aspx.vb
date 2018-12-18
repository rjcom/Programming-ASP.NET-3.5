Imports System 
Imports System.Web.UI 
Imports MSLiveSearch 
Imports System.Text 

Public Partial Class LiveClient 
    Inherits Page 
    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) 
        Dim srchClient As New MSNSearchPortTypeClient() 
        
        Dim req As New SearchRequest() 
        req.AppID = "EFEA049AE142119C58D7EF7B258EDA65763436A3" 
        ' update with your App ID 
        req.Query = txtSearchFor.Text 
        
        Dim srcReq As SourceRequest() = New SourceRequest(0) {} 
        srcReq(0) = New SourceRequest() 
        srcReq(0).Source = SourceType.Web 
        srcReq(0).ResultFields = ResultFieldMask.Url Or ResultFieldMask.Title 
        
        req.Requests = srcReq 
        req.CultureInfo = "en-US" 
        
        Dim srchResponse As SearchResponse = srchClient.Search(req) 
        
        ' create links based on the search results 
        Dim sb As New StringBuilder() 
        
        For Each res As Result In srchResponse.Responses(0).Results 
            sb.AppendFormat("<a href='{0}'>{1}</a><br />", res.Url, res.Title) 
        Next 
        
        lblResults.Text = sb.ToString() 
        
    End Sub 
End Class 
