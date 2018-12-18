Imports System 
Imports System.ComponentModel 
Imports System.Web.UI 
Imports System.Web.UI.WebControls 

Namespace CustomControls 
    <DefaultProperty("Text")> _ 
    <ToolboxData("<{0}:ServerControlViewState runat=server></{0}:ServerControlViewState>")> _ 
    Public Class ServerControlViewState 
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
        
        
        Public Property Size() As Integer 
            Get 
                Return Convert.ToInt32(ViewState("Size")) 
            End Get 
            Set(ByVal value As Integer) 
                ViewState("Size") = value 
            End Set 
        End Property 
        
        Public Sub New() 
            ViewState("Size") = 9 
        End Sub 
        
        Protected Overloads Overrides Sub RenderContents(ByVal output As HtmlTextWriter) 
            output.AddStyleAttribute("color", "fuchsia") 
            output.AddStyleAttribute("font-size", [String].Format("{0}pt", Size.ToString())) 
            output.RenderBeginTag("p") 
            output.Write(Text) 
            output.RenderEndTag() 
        End Sub 
    End Class 
End Namespace 
