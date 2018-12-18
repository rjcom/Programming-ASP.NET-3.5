<%@ Application Language="VB" %>

<script runat="server">

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        WriteFile("Application Starting")
    End Sub
    
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        WriteFile("Application Ending")
    End Sub
        
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        Dim strError As String
        strError = Server.GetLastError().ToString()

        If Context IsNot Nothing Then
            Context.ClearError()
    
            Response.Write("Application_Error" & "<br/>")
            Response.Write("<b>Error Msg: </b>" & strError & "<br/>" & "<b>End Error Msg</b><br/>")
        End If
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Session_Start" + "<br/>")
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Session_End" + "<br/>")
    End Sub
       
    Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_BeginRequest" & "<br/>")
    End Sub

    Protected Sub Application_EndRequest(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_EndRequest" & "<br/>")
    End Sub

    Protected Sub Application_AcquireRequestState(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_AcquireRequestState" & "<br/>")
    End Sub

    Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_AuthenticateRequest" & "<br/>")
    End Sub

    Protected Sub Application_AuthorizeRequest(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_AuthorizeRequest" & "<br/>")
    End Sub

    Protected Sub Application_PostRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_PostRequestHandlerExecute" & "<br/>")
    End Sub

    Protected Sub Application_PreRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_PreRequestHandlerExecute" & "<br/>")
    End Sub

    Protected Sub Application_PreSendRequestContent(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_PreSendRequestContent" & "<br/>")
    End Sub

    Protected Sub Application_PreSendRequestHeaders(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_PreSendRequestHeaders" & "<br/>")
    End Sub

    Protected Sub Application_ReleaseRequestState(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_ReleaseRequestState" & "<br/>")
    End Sub

    Protected Sub Application_ResolveRequestCache(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_ResolveRequestCache" & "<br/>")
    End Sub


    Protected Sub Application_UpdateRequestCache(ByVal sender As Object, ByVal e As EventArgs)
        Response.Write("Application_UpdateRequestCache" & "<br/>")
    End Sub


    Private Sub WriteFile(ByVal strText As String)
        Using writer As New System.IO.StreamWriter(Server.MapPath("test.txt"), True)
            Dim str As String
            str = (DateTime.Now.ToString() & " ") + strText
            writer.WriteLine(str)
            writer.Close()
        End Using
    End Sub
    
</script>