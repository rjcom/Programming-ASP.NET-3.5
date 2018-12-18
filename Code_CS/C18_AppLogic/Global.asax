<%@ Application Language="C#" %>

<script RunAt="server">

    protected void Application_Start(Object sender, EventArgs e)
    {
        WriteFile("Application Starting");
    }

    protected void Application_End(Object sender, EventArgs e)
    {
        WriteFile("Application Ending");
    }

    protected void Session_Start(Object sender, EventArgs e)
    {
        Response.Write("Session_Start" + "<br/>");
    }

    protected void Session_End(Object sender, EventArgs e)
    {
        Response.Write("Session_End" + "<br/>");
    }

    protected void Application_Disposed(Object sender, EventArgs e)
    {
        Response.Write("Application_Disposed" + "<br/>");
    }

    protected void Application_Error(Object sender, EventArgs e)
    {
        string strError;
        strError = Server.GetLastError().ToString();

        if (Context != null)
        {
            Context.ClearError();

            Response.Write("Application_Error" + "<br/>");
            Response.Write("<b>Error Msg: </b>" + strError + "<br/>" +
                           "<b>End Error Msg</b><br/>");
        }
    }

    protected void Application_BeginRequest(Object sender, EventArgs e)
    {
        Response.Write("Application_BeginRequest" + "<br/>");
    }

    protected void Application_EndRequest(Object sender, EventArgs e)
    {
        Response.Write("Application_EndRequest" + "<br/>");
    }

    protected void Application_AcquireRequestState(
       Object sender, EventArgs e)
    {
        Response.Write("Application_AcquireRequestState" + "<br/>");
    }

    protected void Application_AuthenticateRequest(
       Object sender, EventArgs e)
    {
        Response.Write("Application_AuthenticateRequest" + "<br/>");
    }

    protected void Application_AuthorizeRequest(Object sender, EventArgs e)
    {
        Response.Write("Application_AuthorizeRequest" + "<br/>");
    }

    protected void Application_PostRequestHandlerExecute(
       Object sender, EventArgs e)
    {
        Response.Write("Application_PostRequestHandlerExecute" + "<br/>");
    }

    protected void Application_PreRequestHandlerExecute(
       Object sender, EventArgs e)
    {
        Response.Write("Application_PreRequestHandlerExecute" + "<br/>");
    }

    protected void Application_PreSendRequestContent(
       Object sender, EventArgs e)
    {
        Response.Write("Application_PreSendRequestContent" + "<br/>");
    }

    protected void Application_PreSendRequestHeaders(
       Object sender, EventArgs e)
    {
        Response.Write("Application_PreSendRequestHeaders" + "<br/>");
    }

    protected void Application_ReleaseRequestState(
       Object sender, EventArgs e)
    {
        Response.Write("Application_ReleaseRequestState" + "<br/>");
    }

    protected void Application_ResolveRequestCache(
       Object sender, EventArgs e)
    {
        Response.Write("Application_ResolveRequestCache" + "<br/>");
    }


    protected void Application_UpdateRequestCache(
        Object sender, EventArgs e)
    {
        Response.Write("Application_UpdateRequestCache" + "<br/>");
    }


    void WriteFile(string strText)
    {
        using (System.IO.StreamWriter writer =
            new System.IO.StreamWriter(@"C:\users\public\test.txt", true))
        {
            string str;
            str = DateTime.Now.ToString() + "  " + strText;
            writer.WriteLine(str);
            writer.Close();
        }
    }
</script>

