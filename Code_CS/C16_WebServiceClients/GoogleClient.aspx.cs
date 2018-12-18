using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.UI;

[DataContract]
public class GoogleResult {
    [DataMember]
    public string GsearchResultClass;
    [DataMember]
    public string unescapedUrl;
    [DataMember]
    public string url;
    [DataMember]
    public string visibleUrl;
    [DataMember]
    public string cacheUrl;
    [DataMember]
    public string title;
    [DataMember]
    public string titleNoFormatting;
    [DataMember]
    public string content;
}

[DataContract]
public class GooglePage {
    [DataMember]
    public string start;
    [DataMember]
    public int label;
}

[DataContract]
public class GoogleCursor {
    [DataMember]
    public GooglePage[] pages;
    [DataMember]
    public string estimatedResultCount;
    [DataMember]
    public int currentPageIndex;
    [DataMember]
    public string moreResultsUrl;
}

[DataContract]
public class GoogleResponseData {
    [DataMember]
    public GoogleResult[] results;
    [DataMember]
    public GoogleCursor cursor;
}

[DataContract]
public class GoogleSearchResponse {
    [DataMember]
    public GoogleResponseData responseData;
    [DataMember]
    public string responseDetails;
    [DataMember]
    public int responseStatus;
}

public partial class GoogleClient : Page 
{
    protected void btnSearch_Click(object sender, EventArgs e) 
    {
        WebClient wc = new WebClient();

        // Google requires that you provide an accurate referer
        wc.Headers.Add(HttpRequestHeader.Referer, Request.Url.ToString());

        String url = String.Format(
          "http://ajax.googleapis.com/ajax/services/search/web?v=1.0&q={0}",
                Server.UrlEncode(txtSearchFor.Text));

        String json = wc.DownloadString(url);

        // Parse the JSON with DataContractJsonSerializer
        GoogleSearchResponse srchResponse = null;
        using (MemoryStream ms = new MemoryStream(Encoding.ASCII.GetBytes(json))) {
            DataContractJsonSerializer jsonSerializer =
                new DataContractJsonSerializer(typeof(GoogleSearchResponse));
            srchResponse = jsonSerializer.ReadObject(ms) as GoogleSearchResponse;
        }

        // create links based on the search results
        StringBuilder sb = new StringBuilder();


        foreach (GoogleResult res in srchResponse.responseData.results) 
        {
            sb.AppendFormat("<a href='{0}'>{1}</a><br />", res.unescapedUrl, res.title);
        }
        lblResults.Text = sb.ToString();
    }
}
