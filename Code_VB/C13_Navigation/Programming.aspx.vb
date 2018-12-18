
Partial Class Programming
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            lblCurrentNode.Text = SiteMap.CurrentNode.Title

            If SiteMap.CurrentNode.HasChildNodes Then
                For Each childNode As SiteMapNode In SiteMap.CurrentNode.ChildNodes
                    lblChildNodes.Text += childNode.Title & "<br/>"
                Next
            End If
        Catch generatedExceptionName As System.NullReferenceException
            lblCurrentNode.Text = "The xml file is not in the site map!"

        Catch ex As Exception
            lblCurrentNode.Text = "Exception! " & ex.Message
        End Try

    End Sub
End Class
