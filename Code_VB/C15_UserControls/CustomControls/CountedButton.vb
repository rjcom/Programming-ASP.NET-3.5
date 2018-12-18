Imports System 
Imports System.ComponentModel 
Imports System.Web.UI 
Imports System.Web.UI.WebControls 

Namespace CustomControls 
    <DefaultProperty("Text")> _ 
    <ToolboxData("<{0}:CountedButton runat=server></{0}:CountedButton>")> _ 
    Public Class CountedButton 
        Inherits Button 
        Public Sub New() 
            Text = "Click me" 
            ViewState("Count") = 0 
        End Sub 
        
        Public Property Count() As Integer 
            Get 
                Return Convert.ToInt32(ViewState("Count")) 
            End Get 
            Set(ByVal value As Integer) 
                ViewState("Count") = value 
            End Set 
        End Property 
        
        Protected Overloads Overrides Sub OnClick(ByVal e As EventArgs) 
            Count = Count + 1 
            Text = Count.ToString() & " clicks" 
            MyBase.OnClick(e) 
        End Sub 
    End Class 
End Namespace 
