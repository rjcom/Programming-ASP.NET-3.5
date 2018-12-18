Imports System 
Imports System.ComponentModel 
Imports System.Web.UI 
Imports System.Web.UI.WebControls 

Namespace CustomControls 
    <DefaultProperty("Text")> _ 
    <ToolboxData("<{0}:ServerControl1 runat=server></{0}:ServerControl1>")> _ 
    Public Class ServerControl1 
        Inherits WebControl 
        <Bindable(True)> _ 
        <Category("Appearance")> _ 
        <DefaultValue("")> _ 
        <Localizable(True)> _ 
        Public Property Text() As String 
            Get 
                Dim s As String = DirectCast(ViewState("Text"), String) 
                Return (If((s Is Nothing), "[" & Me.ID & "]", s)) 
            End Get 
            
            Set(ByVal value As String) 
                ViewState("Text") = value 
            End Set 
        End Property 
        
        Protected Overloads Overrides Sub RenderContents(ByVal output As HtmlTextWriter) 
            output.AddStyleAttribute("color", "red") 
            output.RenderBeginTag("p") 
            output.Write(Text) 
            output.RenderEndTag() 
        End Sub 
    End Class 
End Namespace 
