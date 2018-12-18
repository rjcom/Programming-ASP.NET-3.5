Imports System 
Imports System.ComponentModel 
Imports System.Web.UI 
Imports System.Web.UI.WebControls 

Namespace CustomControls 
    <DefaultProperty("Text")> _ 
    <ToolboxData("<{0}:ServerControlControlState runat=server></{0}:ServerControlControlState>")> _ 
    Public Class ServerControlControlState 
        Inherits WebControl 
        #Region "Control State properties" 
        
        <Serializable()> _ 
        Private Structure ControlStateProperties 
            Public fontSize As Integer 
        End Structure 
        
        Private controlState As New ControlStateProperties() 
        
        #End Region 
        
        
        #Region "Public Properties" 
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
                Return controlState.fontSize 
            End Get 
            Set(ByVal value As Integer) 
                controlState.fontSize = value 
                SaveControlState() 
            End Set 
        End Property 
        #End Region 
        
        Public Sub New() 
            controlState.fontSize = 9 
        End Sub 
        
        Protected Overloads Overrides Sub RenderContents(ByVal output As HtmlTextWriter) 
            output.AddStyleAttribute("color", "fuchsia") 
            output.AddStyleAttribute("font-size", [String].Format("{0}pt", Size.ToString())) 
            output.RenderBeginTag("p") 
            output.Write(Text) 
            output.RenderEndTag() 
        End Sub 
        
        Protected Overloads Overrides Sub OnInit(ByVal e As EventArgs) 
            Page.RegisterRequiresControlState(Me) 
            MyBase.OnInit(e) 
        End Sub 
        
        Protected Overloads Overrides Function SaveControlState() As Object 
            Return controlState 
        End Function 
        
        Protected Overloads Overrides Sub LoadControlState(ByVal savedState As Object) 
            controlState = New ControlStateProperties() 
            controlState = DirectCast(savedState, ControlStateProperties) 
        End Sub 
    End Class 
End Namespace 
