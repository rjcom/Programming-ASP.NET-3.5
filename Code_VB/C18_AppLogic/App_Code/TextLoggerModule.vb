Imports System
Imports System.Web

''' <summary> 
''' Summary description for TextLoggerModule 
''' </summary> 
Public Class TextLoggerModule
    Implements IHttpModule

#Region "IHttpModule Members"

    Public Sub Dispose() Implements System.Web.IHttpModule.Dispose
        Throw New NotImplementedException()
    End Sub

    Public Sub Init(ByVal context As HttpApplication) Implements IHttpModule.Init
        AddHandler context.PreRequestHandlerExecute, AddressOf context_PreRequestHandlerExecute
    End Sub

    Private Sub context_PreRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
        GlobalMembers.StaticWriteFile(HttpContext.Current.Request.RawUrl)
    End Sub

#End Region

End Class

