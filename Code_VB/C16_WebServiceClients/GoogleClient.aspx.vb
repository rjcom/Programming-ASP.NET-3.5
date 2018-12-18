Imports System 
Imports System.IO 
Imports System.Net 
Imports System.Runtime.Serialization 
Imports System.Runtime.Serialization.Json 
Imports System.Text 
Imports System.Web.UI 

<DataContract()> _ 
Public Class GoogleResult 
    <DataMember()> _ 
    Public GsearchResultClass As String 
    <DataMember()> _ 
    Public unescapedUrl As String 
    <DataMember()> _ 
    Public url As String 
    <DataMember()> _ 
    Public visibleUrl As String 
    <DataMember()> _ 
    Public cacheUrl As String 
    <DataMember()> _ 
    Public title As String 
    <DataMember()> _ 
    Public titleNoFormatting As String 
    <DataMember()> _ 
    Public content As String 
End Class 

<DataContract()> _ 
Public Class GooglePage 
    <DataMember()> _ 
    Public start As String 
    <DataMember()> _ 
    Public label As Integer 
End Class 

<DataContract()> _ 
Public Class GoogleCursor 
    <DataMember()> _ 
    Public pages As GooglePage() 
    <DataMember()> _ 
    Public estimatedResultCount As String 
    <DataMember()> _ 
    Public currentPageIndex As Integer 
    <DataMember()> _ 
    Public moreResultsUrl As String 
End Class 

<DataContract()> _ 
Public Class GoogleResponseData 
    <DataMember()> _ 
    Public results As GoogleResult() 
    <DataMember()> _ 
    Public cursor As GoogleCursor 
End Class 

<DataContract()> _ 
Public Class GoogleSearchResponse 
    <DataMember()> _ 
    Public responseData As GoogleResponseData 
    <DataMember()> _ 
    Public responseDetails As String 
    <DataMember()> _ 
    Public responseStatus As Integer 
End Class 

Public Partial Class GoogleClient 
    Inherits Page 
    Protected Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) 
        Dim wc As New WebClient() 
        
        ' Google requires that you provide an accurate referer 
        wc.Headers.Add(HttpRequestHeader.Referer, Request.Url.ToString()) 
        
        Dim url As String = [String].Format("http://ajax.googleapis.com/ajax/services/search/web?v=1.0&q={0}", Server.UrlEncode(txtSearchFor.Text)) 
        
        Dim json As String = wc.DownloadString(url) 
        
        ' Parse the JSON with DataContractJsonSerializer 
        Dim srchResponse As GoogleSearchResponse = Nothing 
        Using ms As New MemoryStream(Encoding.ASCII.GetBytes(json)) 
            Dim jsonSerializer As New DataContractJsonSerializer(GetType(GoogleSearchResponse)) 
            srchResponse = TryCast(jsonSerializer.ReadObject(ms), GoogleSearchResponse) 
        End Using 
        
        ' create links based on the search results 
        Dim sb As New StringBuilder() 
        
        
        For Each res As GoogleResult In srchResponse.responseData.results 
            sb.AppendFormat("<a href='{0}'>{1}</a><br />", res.unescapedUrl, res.title) 
        Next 
        lblResults.Text = sb.ToString() 
    End Sub 
End Class 
