using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using MSLiveSearch;


[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class LiveSearchWithAjax {

    [OperationContract]
    public List<LinkInfo> Search(String query) {
        MSNSearchPortTypeClient srchClient = new MSNSearchPortTypeClient();

        SearchRequest req = new SearchRequest();
        req.AppID = "EFEA049AE142119C58D7EF7B258EDA65763436A3"; // replace with your App ID
        req.Query = query;

        SourceRequest[] srcReq = new SourceRequest[1];
        srcReq[0] = new SourceRequest();
        srcReq[0].Source = SourceType.Web;
        srcReq[0].ResultFields = ResultFieldMask.Url | ResultFieldMask.Title;

        req.Requests = srcReq;
        req.CultureInfo = "en-US";

        SearchResponse srchResponse = srchClient.Search(req);

        // create links based on the search results
        List<LinkInfo> li = new List<LinkInfo>();
        foreach (Result res in srchResponse.Responses[0].Results) {
            LinkInfo link = new LinkInfo();
            link.url = res.Url;
            link.title = res.Title;
            li.Add(link);
        }
        return li;
    }
}

[DataContract]
public class LinkInfo {
    [DataMember]
    public string url { get; set; }
    [DataMember]
    public string title { get; set; }
}
