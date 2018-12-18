Imports System.Web

Public Class TextLogHandler
    Implements IHttpHandler

#Region "IHttpHandler Members"

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        GlobalMembers.StaticWriteFile(".log handler running for " & context.Request.RawUrl)
        'context.Response.ContentType = "text/html"; 
        context.Response.Write("Logged request for " & context.Request.RawUrl & "<br />")

    End Sub

#End Region

End Class
