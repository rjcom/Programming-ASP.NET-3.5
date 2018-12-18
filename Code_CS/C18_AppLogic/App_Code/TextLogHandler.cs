using System.Web;

public class TextLogHandler : IHttpHandler
{
    #region IHttpHandler Members

    public bool IsReusable
    {
        get { return false; }
    }

    public void ProcessRequest(HttpContext context)
    {
        GlobalMembers.StaticWriteFile(".log handler running for " + context.Request.RawUrl);
        //context.Response.ContentType = "text/html";
        context.Response.Write("Logged request for " + context.Request.RawUrl + "<br />");
    }

    #endregion
}
