Imports System 
Imports System.ComponentModel 
Imports System.Web.UI 
Imports System.Web.UI.WebControls 

Namespace CustomControls 
    <DefaultProperty("Text")> _ 
    <ToolboxData("<{0}:CountedButton2 runat=server></{0}:CountedButton2>")> _ 
    Public Class CountedButton2 
        Inherits Button 
        Private displayString As String 
        
        ' default constructor 
        Public Sub New() 
            displayString = "clicks" 
            InitValues() 
        End Sub 
        
        ' overloaded, takes string to display (e.g., 5 books) 
        Public Sub New(ByVal text As String) 
            displayString = text 
            InitValues() 
        End Sub 
        
        ' called by constructors 
        Private Sub InitValues() 
            If ViewState("Count") Is Nothing Then 
                Count = 0 
            End If 
            Text = "Click me" 
        End Sub 
        
        ' count as property maintained in view state 
        Public Property Count() As Integer 
            Get 
                Return CInt(ViewState("Count")) 
            End Get 
            
            Set(ByVal value As Integer) 
                ViewState("Count") = value 
            End Set 
        End Property 
        
        ' override the OnClick to increment the count, 
        ' update the button text and then invoke the base method 
        Protected Overloads Overrides Sub OnClick(ByVal e As EventArgs) 
            Count = Count + 1 
            Text = (Count.ToString() & " ") + displayString 
            MyBase.OnClick(e) 
        End Sub 
    End Class 
End Namespace 
