Imports System 
Imports System.Web.UI 
Imports System.Web.UI.WebControls 
Imports System.Collections 

Namespace CustomControls 
    <ToolboxData("<{0}:BookInquiryList runat=server></{0}:BookInquiryList>")> _ 
    <ControlBuilderAttribute(GetType(BookCounterBuilder)), ParseChildren(False)> _ 
    Public Class BookInquiryList 
        Inherits WebControl 
        Implements INamingContainer 
        Protected Overloads Overrides Sub Render(ByVal output As HtmlTextWriter) 
            Dim totalInquiries As Integer = 0 
            Dim current As BookCounter 
            
            
            ' Write the header 
            output.Write("<Table border='1' width='90%' cellpadding='1'" & "cellspacing='1' align = 'center' >") 
            output.Write("<tr><td colspan = '2' align='center'>") 
            output.Write("<b> Inquiries </b></td></tr>") 
            
            ' if you have no contained controls, write the default msg. 
            If Controls.Count = 0 Then 
                output.Write("<tr><td colspan='2' align='center'>") 
                output.Write("<b> No books listed </b></td></tr>") 
            Else 
                ' otherwise render each of the contained controls 
                ' iterate over the controls colelction and 
                ' display the book name for each 
                ' then tell each contained control to render itself 
                For i As Integer = 0 To Controls.Count - 1 
                    current = TryCast(Controls(i), BookCounter) 
                    
                    If current IsNot Nothing Then 
                        totalInquiries += current.Count 
                        output.Write("<tr><td align='left'>" & current.BookName & "</td>") 
                        output.RenderBeginTag("td") 
                        current.RenderControl(output) 
                        output.RenderEndTag() 
                        ' end td 
                        output.Write("</tr>") 
                    End If 
                Next 
                output.Write(("<tr><td colspan='2' align='center'> " & " Total Inquiries: ") + totalInquiries & "</td></tr>") 
            End If 
            output.Write("</table>") 
        End Sub 
    End Class 
    
    
    
    
    Friend Class BookCounterBuilder 
        Inherits ControlBuilder 
        Public Overloads Overrides Function GetChildControlType(ByVal tagName As String, ByVal attributes As IDictionary) As Type 
            If tagName = "BookCounter" Then 
                Return GetType(BookCounter) 
            Else 
                Return Nothing 
            End If 
        End Function 
        
        Public Overloads Overrides Sub AppendLiteralString(ByVal s As String) 
        End Sub 
    End Class 
End Namespace 
