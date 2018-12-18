using System;
using System.Web.UI;
using MSLiveSearch;
using System.Text;

public partial class LiveClient : Page
{
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        MSNSearchPortTypeClient srchClient = new MSNSearchPortTypeClient();

        SearchRequest req = new SearchRequest();
        req.AppID = "EFEA049AE142119C58D7EF7B258EDA65763436A3"; // update with your App ID
        req.Query = txtSearchFor.Text;

        SourceRequest[] srcReq = new SourceRequest[1];
        srcReq[0] = new SourceRequest();
        srcReq[0].Source = SourceType.Web;
        srcReq[0].ResultFields = ResultFieldMask.Url | ResultFieldMask.Title;

        req.Requests = srcReq;
        req.CultureInfo = "en-US";

        SearchResponse srchResponse = srchClient.Search(req);

        // create links based on the search results
        StringBuilder sb = new StringBuilder();

        foreach (Result res in srchResponse.Responses[0].Results) 
        {
            sb.AppendFormat("<a href='{0}'>{1}</a><br />", res.Url, res.Title);
        }

        lblResults.Text = sb.ToString();
      
    }
}
