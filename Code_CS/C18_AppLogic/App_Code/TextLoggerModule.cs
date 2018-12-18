using System;
using System.Web;

/// <summary>
/// Summary description for TextLoggerModule
/// </summary>
public class TextLoggerModule : IHttpModule
{
    #region IHttpModule Members

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void Init(HttpApplication context)
    {
        context.PreRequestHandlerExecute += new EventHandler(context_PreRequestHandlerExecute);
    }

    void context_PreRequestHandlerExecute(object sender, EventArgs e)
    {
        GlobalMembers.StaticWriteFile(HttpContext.Current.Request.RawUrl);
    }

    #endregion
}
