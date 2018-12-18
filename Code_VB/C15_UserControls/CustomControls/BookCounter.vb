Imports System.ComponentModel 
Imports System.Web.UI 
Imports System.Web.UI.WebControls 

Namespace CustomControls 
    <ToolboxData("<{0}:BookCounter runat=server></{0}:BookCounter>")> _ 
    Public Class BookCounter 
        Inherits WebControl 
        Implements INamingContainer 
        ' initialize the counted button member 
        Private btn As New CountedButton2("inquiries") 
        
        Public Property BookName() As String 
            Get 
                Return DirectCast(ViewState("BookName"), String) 
            End Get 
            
            Set(ByVal value As String) 
                ViewState("BookName") = value 
            End Set 
        End Property 
        
        Public Property Count() As Integer 
            Get 
                Return btn.Count 
            End Get 
            Set(ByVal value As Integer) 
                btn.Count = value 
            End Set 
        End Property 
        
        Public Sub Reset() 
            btn.Count = 0 
        End Sub 
        
        Protected Overloads Overrides Sub CreateChildControls() 
            Controls.Add(btn) 
        End Sub 
    End Class 
End Namespace 
