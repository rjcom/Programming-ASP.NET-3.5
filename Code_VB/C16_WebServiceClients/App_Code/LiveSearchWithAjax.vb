Imports System 
Imports System.Collections.Generic 
Imports System.Runtime.Serialization 
Imports System.ServiceModel 
Imports System.ServiceModel.Activation 
Imports MSLiveSearch 


<ServiceContract([Namespace] := "")> _ 
<AspNetCompatibilityRequirements(RequirementsMode := AspNetCompatibilityRequirementsMode.Allowed)> _ 
Public Class LiveSearchWithAjax 
    
    <OperationContract()> _ 
    Public Function Search(ByVal query As String) As List(Of LinkInfo) 
        Dim srchClient As New MSNSearchPortTypeClient() 
        
        Dim req As New SearchRequest() 
        req.AppID = "EFEA049AE142119C58D7EF7B258EDA65763436A3" 
        ' replace with your App ID 
        req.Query = query 
        
        Dim srcReq As SourceRequest() = New SourceRequest(0) {} 
        srcReq(0) = New SourceRequest() 
        srcReq(0).Source = SourceType.Web 
        srcReq(0).ResultFields = ResultFieldMask.Url Or ResultFieldMask.Title 
        
        req.Requests = srcReq 
        req.CultureInfo = "en-US" 
        
        Dim srchResponse As SearchResponse = srchClient.Search(req) 
        
        ' create links based on the search results 
        Dim li As New List(Of LinkInfo)() 
        For Each res As Result In srchResponse.Responses(0).Results 
            Dim link As New LinkInfo() 
            link.url = res.Url 
            link.title = res.Title 
            li.Add(link) 
        Next 
        Return li 
    End Function 
End Class 

<DataContract()> _ 
Public Class LinkInfo 
Private _url As String 
    <DataMember()> _ 
    Public Property url() As String 
        Get 
            Return _url 
        End Get 
        Set(ByVal value As String) 
            _url = value 
        End Set 
    End Property 
Private _title As String 
    <DataMember()> _ 
    Public Property title() As String 
        Get 
            Return _title 
        End Get 
        Set(ByVal value As String) 
            _title = value 
        End Set 
    End Property 
End Class 
